using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BelleTable
{
    public partial class FormQuestion : Form
    {
        private int _idQuestionnaire;

        public FormQuestion(int idQuestionnaire)
        {
            InitializeComponent();
            _idQuestionnaire = idQuestionnaire;
        }

        private void FormQuestion_Load(object sender, EventArgs e)
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

            // AFFICHAGE DU NOM DU QUESTIONNAIRE
            string queryNom = @"
                SELECT nomQuestionnaire
                FROM questionnaire
                WHERE id_questionnaire = @idQuestionnaire;";

            using (var cmdNom = new MySqlCommand(queryNom, _dbCon.Connexion))
            {
                cmdNom.Parameters.AddWithValue("@idQuestionnaire", _idQuestionnaire);

                var result = cmdNom.ExecuteScalar();

                if (result != null)
                {
                    lbQuestionnaire.Text = "Questionnaire : " + result.ToString();
                }
            }

            List<Question> questions = new List<Question>();

            // Requête
            string query = @"
                SELECT 
                    q.id_question,
                    c.numQuestion,
                    q.libelleQuestion
                FROM contient c
                JOIN question q ON q.id_question = c.id_question
                WHERE c.id_questionnaire = @idQuestionnaire
                ORDER BY c.numQuestion;";

            using var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, _dbCon.Connexion);
            cmd.Parameters.AddWithValue("@idQuestionnaire", _idQuestionnaire);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    questions.Add(new Question
                    {
                        QuestionId = reader.GetInt32("id_question"),
                        QuestionnaireId = _idQuestionnaire,
                        NumeroQuestion = reader.GetInt32("numQuestion"),
                        QuestionLibelle = reader.GetString("libelleQuestion")
                    });
                }
            }

            dataGridView1.DataSource = questions;
            dataGridView1.Columns["QuestionId"].Visible = false;
            dataGridView1.Columns["QuestionnaireId"].Visible = false;
            dataGridView1.Columns["NumeroQuestion"].HeaderText = "N°";
            dataGridView1.Columns["QuestionLibelle"].HeaderText = "Question";

            // CONFIGURATION DU DATAGRIDVIEW POUR LES QUESTIONS À RÉPONSE MULTIPLE
            dgvListe.Columns.Add("Valeur", "Valeur");
            dgvListe.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Bonne",
                HeaderText = "Bonne"
            });

            dgvListe.AllowUserToAddRows = false;
            dgvListe.AllowUserToDeleteRows = false;
        }

        private void rbFerme_CheckedChanged(object sender, EventArgs e)
        {
            if (panelOuiNon.Visible)
            {
                panelOuiNon.Visible = false;
            }
            else
            {
                panelOuiNon.Visible = true;
            }
        }

        private void rbListe_CheckedChanged(object sender, EventArgs e)
        {
            if (panelListe.Visible)
            {
                panelListe.Visible = false;
            }
            else
            {
                panelListe.Visible = true;
            }
        }

        private void btPlusListe_Click(object sender, EventArgs e)
        {
            dgvListe.Rows.Add("", false);
        }

        private void btMoinsListe_Click(object sender, EventArgs e)
        {
            if (dgvListe.CurrentRow != null)
            {
                dgvListe.Rows.Remove(dgvListe.CurrentRow);
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
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

            if (string.IsNullOrWhiteSpace(tbLibelle.Text) || string.IsNullOrWhiteSpace(numquestion.Text))
            {
                MessageBox.Show("Le numéro et le libellé sont obligatoires.");
                return;
            }

            Question q = new Question
            {
                QuestionnaireId = _idQuestionnaire,
                QuestionLibelle = tbLibelle.Text.Trim(),
                NumeroQuestion = Convert.ToInt32(numquestion.Text)
            };

            q.AddQuestion(_dbCon);

            FormQuestion_Load(sender, e);
        }

        private void btMoins_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            Question q = (Question)dataGridView1.CurrentRow.DataBoundItem;

            tbLibelle.Text = q.QuestionLibelle;

            numquestion.Text = q.NumeroQuestion.ToString();
        }
    }
}
