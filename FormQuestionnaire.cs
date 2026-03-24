using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelleTable
{
    public partial class FormQuestionnaire : Form
    {
        public FormQuestionnaire()
        {
            InitializeComponent();
        }

        private void FormQuestionnaire_Load(object sender, EventArgs e)
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
                MessageBox.Show("Impossible de se connecter à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<Questionnaire> questionnaires = new List<Questionnaire>();

            // Requête
            string query = @"
                SELECT 
                    q.id_questionnaire,
                    q.nomQuestionnaire,
                    t.libelleTheme AS theme,
                    q.publie
                FROM questionnaire q
                JOIN theme t ON t.id_theme = q.id_theme;";

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, _dbCon.Connexion);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    questionnaires.Add(new Questionnaire
                    {
                        QuestionnaireID = reader.GetInt32("id_questionnaire"),
                        QuestionnaireNom = reader.GetString("nomQuestionnaire"),
                        QuestionnaireTheme = reader.GetString("theme"),
                        QuestionnairePublie = reader.GetBoolean("publie")
                    });
                }
            }

            dataGridView1.DataSource = questionnaires;
            dataGridView1.Columns["QuestionnaireId"].Visible = false;
        }

        private void btPlus_Click(object sender, EventArgs e)
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
                MessageBox.Show("Impossible de se connecter à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tbTitre.Text) || string.IsNullOrWhiteSpace(tbTheme.Text))
            {
                MessageBox.Show("Le titre et le thème sont obligatoires.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            Questionnaire q = new Questionnaire();

            q.QuestionnaireNom = tbTitre.Text;
            q.QuestionnaireTheme = tbTheme.Text;
            q.QuestionnairePublie = cbPublie.Checked;

            q.AddQuestionnaire(_dbCon);

            FormQuestionnaire_Load(sender, e);
        }

        private void btMoins_Click(object sender, EventArgs e)
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
                MessageBox.Show("Impossible de se connecter à la base de données.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridView1.CurrentRow == null)
                return;

            Questionnaire q = (Questionnaire)dataGridView1.CurrentRow.DataBoundItem;

            q.Delete(_dbCon);

            FormQuestionnaire_Load(sender, e);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            Questionnaire q = (Questionnaire)dataGridView1.CurrentRow.DataBoundItem;

            tbTitre.Text = q.QuestionnaireNom;
            tbTheme.Text = q.QuestionnaireTheme;
            cbPublie.Checked = q.QuestionnairePublie;
        }

        private void btOuvrir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un questionnaire.");

                return;
            }

            Questionnaire q = (Questionnaire)dataGridView1.CurrentRow.DataBoundItem;
            
            FormQuestion dashboard = new FormQuestion(q.QuestionnaireID);
            dashboard.Show();
        }
    }
}
