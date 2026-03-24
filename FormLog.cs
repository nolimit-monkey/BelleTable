using System.Data.Common;
using MySqlX.XDevAPI;

namespace BelleTable
{
    public partial class FormLog : Form
    {
        private string _nomUtilisateurConnecte;
        public FormLog()
        {
            InitializeComponent();
        }
        private void bt_connexion_Click(object sender, EventArgs e)
        {
            // Connexion
            DBConnexion _dbCon = new DBConnexion
            {
                Server = "127.0.0.1",
                DatabaseName = "belletable",
                UserName = "devuser",
                Password = "MotDePasse3889"
            };

            if (!_dbCon.IsConnect())
            {
                lb_status.Text = "Erreur : impossible de se connecter à la base.";
                return;
            }

            // Validation des champs
            string nom = tbconnexion_nom.Text?.Trim();
            string mdpClair = tbconnexion_mdp.Text?.Trim();

            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(mdpClair))
            {
                lb_status.Text = "Erreur : nom ou mot de passe vide.";
                return;
            }

            // Hashage
            Hashage hashage = new Hashage();
            string mdpHash = hashage.MakeMD5Hash(mdpClair);
            string mdpHashSale = hashage.Salting(mdpHash);

            // Requête match utilisateur
            string query = @"
                SELECT nomCollaborateur
                FROM collaborateur
                WHERE nomCollaborateur = @nom AND mdpCollaborateur = @mdpHash
                LIMIT 1;";

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, _dbCon.Connexion);
            cmd.Parameters.AddWithValue("@nom", nom);
            cmd.Parameters.AddWithValue("@mdpHash", mdpHashSale);

            using var reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                _nomUtilisateurConnecte = reader.GetString(0);
                lb_status.Text = $"Connecté : {_nomUtilisateurConnecte}";
                FormQuestionnaire dashboard = new FormQuestionnaire();
                dashboard.Show();
            }
            else
            {
                lb_status.Text = "Erreur : identifiants incorrects.";
            }
        }

        private void bt_Inscription_Click(object sender, EventArgs e)
        {
            // Connexion
            DBConnexion _dbCon = new DBConnexion
            {
                Server = "127.0.0.1",
                DatabaseName = "belletable",
                UserName = "devuser",
                Password = "MotDePasse3889"
            };

            if (!_dbCon.IsConnect())
            {
                MessageBox.Show("Connexion à la base échouée. Cliquez d'abord sur Connexion ou vérifiez vos paramètres.");
                return;
            }

            // Validation des champs
            string nom = tb_nom.Text?.Trim();
            string prenom = tb_prenom.Text?.Trim();
            string mail = tb_mail.Text?.Trim();
            string mdpClair = tb_mdp.Text?.Trim();

            if (string.IsNullOrWhiteSpace(nom) ||
                string.IsNullOrWhiteSpace(prenom) ||
                string.IsNullOrWhiteSpace(mail) ||
                string.IsNullOrWhiteSpace(mdpClair))
            {
                MessageBox.Show("Veuillez remplir tous les champs (nom, adresse, ville, téléphone, mot de passe).");
                return;
            }

            // Hashage du mot de passe
            Hashage hashage = new Hashage();

            string mdpHash = hashage.MakeMD5Hash(mdpClair);

            // Salage
            string mdpHashSale = hashage.Salting(mdpHash);

            // Création du collaborateur
            var nouveauCollaborateur = new Collaborateur
            {
                CollaborateurNom = nom,
                CollaborateurPrenom = prenom,
                CollaborateurMail = mail,
                CollaborateurMdp = mdpHashSale
            };

            MySql.Data.MySqlClient.MySqlDataReader reader = null;

            nouveauCollaborateur.Save(_dbCon);

            // Confirmation que créé
            if (nouveauCollaborateur.CollaborateurID > 0)
            {
                MessageBox.Show($"Client ajouté avec succès. Nouvel ID : {nouveauCollaborateur.CollaborateurID}");

                // On nettoie les champs pour une nouvelle saisie
                tb_nom.Text = "";
                tb_prenom.Text = "";
                tb_mail.Text = "";
                tb_mdp.Text = "";
                tb_nom.Focus();
            }
            else
            {
                MessageBox.Show("L'ajout semble avoir été exécuté, mais aucun ID n'a été renvoyé. Vérifiez la procédure InsertUtilisateur (paramètre OUTPUT @nouvel_id).");
            }
        }

        private void bt_sinscrire_Click(object sender, EventArgs e)
        {
            if (this.Width > 500)
                this.Width = 456;
            else
                this.Width = 949;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            this.Width = 456;
        }
    }
}
