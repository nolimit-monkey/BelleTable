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


            List<Question> questions = new List<Question>();

            // Requête
            string query = @"
                SELECT 
                    q.id_question,
                    q.libelleQuestion
                FROM contient c
                INNER JOIN question q ON q.id_question = c.id_question
                WHERE c.id_questionnaire = @idQuestionnaire;";

            using var cmd = new MySqlCommand(query, _dbCon.Connexion);
            cmd.Parameters.AddWithValue("@idQuestionnaire", _idQuestionnaire); 
            
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    questions.Add(new Question
                    {
                        QuestionId = reader.GetInt32("id_question"),
                        QuestionLibelle = reader.GetString("libelleQuestion"),
                    });
                }
            }

            dataGridView1.DataSource = questions;
            dataGridView1.Columns["QuestionId"].Visible = false;
        }
    }
}
