using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BelleTable
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionLibelle {  get; set; }

        public void Delete(DBConnexion DataBaseConnection)
        {
            try
            {
                String sqlString = "DELETE FROM question WHERE id_question = ?id_question";
                sqlString = Tools.PrepareLigne(sqlString, "?id_question", Tools.PrepareChamp(QuestionId.ToString(), "Nombre"));
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connexion);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
        }
    }
}
