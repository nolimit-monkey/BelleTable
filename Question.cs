using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BelleTable
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuestionnaireId { get; set; }
        public int NumeroQuestion { get; set; }
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
        public void AddQuestion(DBConnexion DataBaseConnection)
        {
            try
            {
                String sqlString = "InsertQuestion";

                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_id_questionnaire", QuestionnaireId);
                cmd.Parameters["@p_id_questionnaire"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_libelleQuestion", QuestionLibelle);
                cmd.Parameters["@p_libelleQuestion"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_numQuestion", NumeroQuestion);
                cmd.Parameters["@p_numQuestion"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@p_new_id_question", MySqlDbType.Int32);
                cmd.Parameters["@p_new_id_question"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                QuestionId = Convert.ToInt32(cmd.Parameters["@p_new_id_question"].Value);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
        }
    }
}
