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
        private string logFilePath = "C:\\setupLog.txt";
        private string connectionString = "Data Source={{servername}};Network Library=DBMSSOCN;Initial Catalog={{dbname}};Integrated Security=False;User ID={{username}};Password={{password}}";
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

        private void ExecuteSql(string serverName, string dbName, string username, string password, string Sql) {
            Log("Executing Sql");
            Log(serverName);
            Log(dbName);
            Log(username);
            Log(password);

            string connStr = connectionString
                .Replace("{{servername}}", serverName)
                .Replace("{{dbname}}", dbName)
                .Replace("{{username}}", username)
                .Replace("{{password}}", password);

            using (SqlConnection conn = new SqlConnection(Sql))
            {
                try {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(Sql)) {
                        command.ExecuteNonQuery();
                    }
                    conn.Close();
                } catch (Exception ex) {
                    Log(ex.Message);
                    Log(ex.StackTrace);
                }
            }
        }

        private void EditConnFile() {
            try
            {
                Log("Edit config file.");
                string text = File.ReadAllText(this.Context.Parameters["targetdir"] + "TimeBank.exe.config");
                int start = text.IndexOf("connection string=&quot;");
                int end = text.IndexOf(";MultipleActiveResultSets=True;App=EntityFramework");
                string result = text.Substring(start + 1, end - start - 1);
                text = text.Replace(result, connectionString);
                File.WriteAllText(this.Context.Parameters["targetdir"] + "TimeBank.exe.config", text);
            }
            catch (Exception e) {
                Log(e.Message);
            }
        }

        protected void AddDBTable(string serverName, string dbname, string username, string password) {
            try
            {
                string strScript = GetSql("sql.txt");
                ExecuteSql(serverName, dbname, username, password, strScript);
            }
            catch {
            
            }
        }

        public override void Install(System.Collections.IDictionary stateSaver) {
            base.Install(stateSaver);
            Log("Setup started");
            
            AddDBTable(
                this.Context.Parameters["servername"],
                this.Context.Parameters["dbname"],
                this.Context.Parameters["username"],
                this.Context.Parameters["password"]
            );

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
