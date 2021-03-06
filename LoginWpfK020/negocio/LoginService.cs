using LoginWpfK020.datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfK020.negocio
{
    internal class LoginService
    {
        string usernameValido = "admin";
        string passwordValido = "nimda";

        public bool check(string username, string password)
        {
            if (usernameValido == username && passwordValido == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkArchivoTexto(string username, string password)
        {
            LoginDao loginDao = new LoginDao();
            Usuario usuario = loginDao.readFile();
            if (usuario != null)
            {
                if(usuario.Username == username && usuario.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool checkContraBaseDatos(string username, string password)
        {
            UsuariosDao usuariosDao = new UsuariosDao();
            Usuario user = usuariosDao.buscarUsuarioPorUsername(username, password);
            if (user != null)
            {
                Console.WriteLine("usuario" + user.Username + "existe en la base de datos");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario no existente en la base de datos");

                return false;
            }
        }
    }
}
