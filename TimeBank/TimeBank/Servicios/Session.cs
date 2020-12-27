using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeBank.Modelos;

namespace TimeBank.Servicios
{
    class Session
    {
        private static Session instance = null;
        Usuarios usuario = null;

        public Session() { }
        public Session(Usuarios usuario) {
            this.usuario = usuario;
        }
        public static Session Instance
        {
            get
            {

                if (instance == null)
                {
                    instance = new Session();
                }

                return instance;
            }
        }

        public Usuarios getCurrentUser() {
            return usuario;
        }
    }
}
