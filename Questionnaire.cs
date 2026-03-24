using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BelleTable
{
    public class Questionnaire
    {
        public int QuestionnaireID { get; set; }
        public string QuestionnaireNom { get; set; }
        public string QuestionnaireTheme { get; set; }
        public bool QuestionnairePublie { get; set; }

        public void Delete(DBConnexion DataBaseConnection)
        {
            try
            {
                String sqlString = "DELETE FROM questionnaire WHERE id_questionnaire = ?id_questionnaire";
                sqlString = Tools.PrepareLigne(sqlString, "?id_questionnaire", Tools.PrepareChamp(QuestionnaireID.ToString(), "Nombre"));
                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connexion);
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
        }
        public void AddQuestionnaire(DBConnexion DataBaseConnection)
        {
            try
            {
                String sqlString = "InsertQuestionnaire";

                var cmd = new MySqlCommand(sqlString, DataBaseConnection.Connexion);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_nomQuestionnaire", QuestionnaireNom);
                cmd.Parameters["@p_nomQuestionnaire"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_libelleTheme", QuestionnaireTheme);
                cmd.Parameters["@p_libelleTheme"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_id_collaborateur", 2);
                cmd.Parameters["@p_id_collaborateur"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_publie", QuestionnairePublie);
                cmd.Parameters["@p_publie"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@p_new_id", MySqlDbType.Int32);
                cmd.Parameters["@p_new_id"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                QuestionnaireID = Convert.ToInt32(cmd.Parameters["@p_new_id"].Value);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }
        }
    }
}
