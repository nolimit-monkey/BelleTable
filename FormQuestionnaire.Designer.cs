namespace BelleTable
{
    partial class FormQuestionnaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btMoins = new Button();
            btPlus = new Button();
            lbTheme = new Label();
            btOuvrir = new Button();
            tbTheme = new RichTextBox();
            lbPublie = new Label();
            cbPublie = new CheckBox();
            tbTitre = new RichTextBox();
            lbTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(405, 426);
            dataGridView1.TabIndex = 2;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // btMoins
            // 
            btMoins.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btMoins.Location = new Point(501, 12);
            btMoins.Name = "btMoins";
            btMoins.Size = new Size(45, 50);
            btMoins.TabIndex = 4;
            btMoins.Text = "−";
            btMoins.TextAlign = ContentAlignment.TopRight;
            btMoins.UseVisualStyleBackColor = true;
            btMoins.Click += btMoins_Click;
            // 
            // btPlus
            // 
            btPlus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btPlus.Location = new Point(439, 12);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(45, 50);
            btPlus.TabIndex = 5;
            btPlus.Text = "+";
            btPlus.TextAlign = ContentAlignment.TopRight;
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // lbTheme
            // 
            lbTheme.AutoSize = true;
            lbTheme.Font = new Font("Segoe UI", 15F);
            lbTheme.Location = new Point(439, 222);
            lbTheme.Name = "lbTheme";
            lbTheme.Size = new Size(70, 28);
            lbTheme.TabIndex = 7;
            lbTheme.Text = "Thème";
            // 
            // btOuvrir
            // 
            btOuvrir.Font = new Font("Segoe UI", 15F);
            btOuvrir.Location = new Point(646, 396);
            btOuvrir.Name = "btOuvrir";
            btOuvrir.Size = new Size(121, 42);
            btOuvrir.TabIndex = 9;
            btOuvrir.Text = "Ouvrir";
            btOuvrir.UseVisualStyleBackColor = true;
            btOuvrir.Click += btOuvrir_Click;
            // 
            // tbTheme
            // 
            tbTheme.Font = new Font("Segoe UI", 15F);
            tbTheme.Location = new Point(518, 214);
            tbTheme.Name = "tbTheme";
            tbTheme.Size = new Size(249, 36);
            tbTheme.TabIndex = 11;
            tbTheme.Text = "";
            // 
            // lbPublie
            // 
            lbPublie.AutoSize = true;
            lbPublie.Font = new Font("Segoe UI", 15F);
            lbPublie.Location = new Point(439, 285);
            lbPublie.Name = "lbPublie";
            lbPublie.Size = new Size(66, 28);
            lbPublie.TabIndex = 8;
            lbPublie.Text = "Publié";
            // 
            // cbPublie
            // 
            cbPublie.AutoSize = true;
            cbPublie.Font = new Font("Segoe UI", 15F);
            cbPublie.Location = new Point(531, 297);
            cbPublie.Name = "cbPublie";
            cbPublie.Size = new Size(15, 14);
            cbPublie.TabIndex = 12;
            cbPublie.UseVisualStyleBackColor = true;
            // 
            // tbTitre
            // 
            tbTitre.Font = new Font("Segoe UI", 15F);
            tbTitre.Location = new Point(518, 152);
            tbTitre.Name = "tbTitre";
            tbTitre.Size = new Size(249, 36);
            tbTitre.TabIndex = 10;
            tbTitre.Text = "";
            // 
            // lbTitre
            // 
            lbTitre.AutoSize = true;
            lbTitre.Font = new Font("Segoe UI", 15F);
            lbTitre.Location = new Point(439, 160);
            lbTitre.Name = "lbTitre";
            lbTitre.Size = new Size(51, 28);
            lbTitre.TabIndex = 6;
            lbTitre.Text = "Titre";
            // 
            // FormQuestionnaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 452);
            Controls.Add(cbPublie);
            Controls.Add(tbTheme);
            Controls.Add(tbTitre);
            Controls.Add(btOuvrir);
            Controls.Add(lbPublie);
            Controls.Add(lbTheme);
            Controls.Add(lbTitre);
            Controls.Add(btPlus);
            Controls.Add(btMoins);
            Controls.Add(dataGridView1);
            Name = "FormQuestionnaire";
            Text = "Questionnaires";
            Load += FormQuestionnaire_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button btMoins;
        private Button btPlus;
        private Label lbTheme;
        private Button btOuvrir;
        private RichTextBox tbTheme;
        private Label lbPublie;
        private CheckBox cbPublie;
        private RichTextBox tbTitre;
        private Label lbTitre;
    }
}