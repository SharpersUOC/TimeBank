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

        private Session() { }
        public static Session GetCurrentSession()
        {
            if (instance == null)
            {
                instance = new Session();
            }

            return instance;
        }

        public Usuarios getCurrentUser() {
            return usuario;
        }

        public void setUser(Usuarios usuario) {
            this.usuario = usuario;
        }

        public Boolean hasUser() {
            return this.usuario != null;
        }
    }
}
