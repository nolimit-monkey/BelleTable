using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BelleTable
{
    public class DBConnexion
    {
        public DBConnexion()
        {
        }

        public string Server { get; set; }
        public string DatabaseName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public MySqlConnection Connexion { get; set; }

        private static DBConnexion _instance = null;
        public static DBConnexion Instance()
        {
            if (_instance == null)
                _instance = new DBConnexion();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connexion == null)
            {
                if (String.IsNullOrEmpty(DatabaseName))
                    return false;
                string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, UserName, Password);
                Connexion = new MySqlConnection(connstring);
                Connexion.Open();
            }
            return true;
        }

        public void Close()
        {
            Connexion.Close();
        }
    }
}
