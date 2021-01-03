using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data.SqlClient;
using System.Reflection;

namespace TimeBank
{
    [RunInstaller(true)]
    public partial class SQLInstaller : System.Configuration.Install.Installer
    {
        private string servername = "";
        private string dbname = "";
        private string username = "";
        private string password = "";

        private string logFilePath = "C:\\setupLog.txt";
        private string connectionString = "Server={{servername}};Database={{dbname}};Integrated Security=False;User ID={{username}};Password={{password}}";
        public SQLInstaller()
        {
            InitializeComponent();
        }

        private string GetSql(string Name)
        {
            Log("Getting sql");
            try
            {
                Assembly Asm = Assembly.GetExecutingAssembly();
                Stream strm = Asm.GetManifestResourceStream(Asm.GetName().Name + "." + Name);
                StreamReader reader = new StreamReader(strm);

                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                throw ex;
            }
        }

        private string addData(string str) {
            return str.Replace("{{servername}}", servername)
                .Replace("{{dbname}}", dbname)
                .Replace("{{username}}", username)
                .Replace("{{password}}", password);
        }

        private void ExecuteSql(string Sql) {
            Log("Executing Sql");
            Log(servername);
            Log(dbname);
            Log(username);
            Log(password);

            string connStr = addData(connectionString); 

            
            string[] splitter = new string[] { "\r\nGO\r\n" };
            var commandText = Sql.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                foreach (string commandLine in commandText) {

                    using (SqlConnection conn = new SqlConnection(connStr))
                    {

                        conn.Open();
                        using (SqlCommand command = new SqlCommand(commandLine, conn))
                        {
                            command.ExecuteNonQuery();
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Log(ex.Message);
                Log(ex.StackTrace);
            }
        }

        private void EditConnFile() {
            try
            {
                Log("Edit config file.");
                Log("In " + this.Context.Parameters["targetdir"] + "TimeBank.exe.config");
                string text = File.ReadAllText(this.Context.Parameters["targetdir"] + "TimeBank.exe.config");
                int start = text.IndexOf("connection string=&quot;");
                int end = text.IndexOf(";MultipleActiveResultSets=True;App=EntityFramework");
                string result = text.Substring(start, end - start);
                text = text.Replace(result, "connection string = &quot;"  + addData(connectionString));
                File.WriteAllText(this.Context.Parameters["targetdir"] + "TimeBank.exe.config", text);
            }
            catch (Exception e) {
                Log(e.Message);
            }
        }

        protected void AddDBTable() {
            try
            {
                string strScript = GetSql("sql.txt");
                ExecuteSql(strScript);
            }
            catch {
            
            }
        }

        public override void Install(System.Collections.IDictionary stateSaver) {
            base.Install(stateSaver);
            Log("Setup started");

            this.servername = this.Context.Parameters["servername"];
            this.dbname = this.Context.Parameters["dbname"];
            this.username = this.Context.Parameters["username"];
            this.password = this.Context.Parameters["password"];


            AddDBTable();

            EditConnFile();
        }

        public void Log(string str) {
            StreamWriter Tex;

            try
            {
                Tex = File.AppendText(this.logFilePath);
                Tex.WriteLine(DateTime.Now.ToString() + " " + str);
                Tex.Close();
            }
            catch {
                
            }
        }
    }
}
