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
    public class Collaborateur
    {
        public int CollaborateurID { get; set; }
        public string CollaborateurNom { get; set; }
        public string CollaborateurPrenom { get; set; }
        public string CollaborateurMail { get; set; }
        public string CollaborateurMdp { get; set; }
        public void Save(DBConnexion DataBaseConnection)
        {
            if (CollaborateurID > 0)
                UpdateCollaborateur(DataBaseConnection);
            else
                AddCollaborateur(DataBaseConnection);
        }
        private void AddCollaborateur(DBConnexion DataBaseConnection)
        {
            try
            {
                String InsertUtilisateur = "InsertUtilisateur";
                var cmd = new MySqlCommand(InsertUtilisateur, DataBaseConnection.Connexion);
                cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                cmd.Parameters.AddWithValue("@nomCollaborateur", CollaborateurNom);
                cmd.Parameters["@nomCollaborateur"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@prenomCollaborateur", CollaborateurPrenom);
                cmd.Parameters["@prenomCollaborateur"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@mailCollaborateur", CollaborateurMail);
                cmd.Parameters["@mailCollaborateur"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@mdpCollaborateur", CollaborateurMdp);
                cmd.Parameters["@mdpCollaborateur"].Direction = ParameterDirection.Input;

                cmd.Parameters.Add("@nouvel_id", MySqlDbType.Int32);
                cmd.Parameters["@nouvel_id"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                CollaborateurID = Convert.ToInt32(cmd.Parameters["@nouvel_id"].Value);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }

        private void UpdateCollaborateur(DBConnexion DataBaseConnection)
        {
            try
            {
                String UpdateUtilisateur = "UpdateUtilisateur";
                var cmd = new MySqlCommand(UpdateUtilisateur, DataBaseConnection.Connexion);
                cmd.CommandType = CommandType.StoredProcedure; //Il faut System.Data pour cette ligne

                cmd.Parameters.AddWithValue("@p_id", CollaborateurID);
                cmd.Parameters["@p_id"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_nom", CollaborateurNom);
                cmd.Parameters["@p_nom"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_prenom", CollaborateurPrenom);
                cmd.Parameters["@p_prenom"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_mail", CollaborateurMail);
                cmd.Parameters["@p_mail"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("@p_mdp", CollaborateurMdp);
                cmd.Parameters["@p_mdp"].Direction = ParameterDirection.Input;

                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.Write("Erreur N° " + ex.Number + " : " + ex.Message);
            }

        }
    }
}
