namespace BelleTable
{
    partial class FormQuestion
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
            tbLibelle = new RichTextBox();
            lbLibelle = new Label();
            btPlus = new Button();
            btMoins = new Button();
            dataGridView1 = new DataGridView();
            lbType = new Label();
            rbOuverte = new RadioButton();
            panel1 = new Panel();
            rbListe = new RadioButton();
            rbFerme = new RadioButton();
            panel2 = new Panel();
            panelOuiNon = new Panel();
            rbNon = new RadioButton();
            rbOui = new RadioButton();
            dgvListe = new DataGridView();
            label1 = new Label();
            lbQuestionnaire = new Label();
            btPlusListe = new Button();
            btMoinsListe = new Button();
            panelListe = new Panel();
            lbNum = new Label();
            numquestion = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panelOuiNon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListe).BeginInit();
            panelListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numquestion).BeginInit();
            SuspendLayout();
            // 
            // tbLibelle
            // 
            tbLibelle.Font = new Font("Segoe UI", 10F);
            tbLibelle.Location = new Point(495, 79);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(249, 36);
            tbLibelle.TabIndex = 21;
            tbLibelle.Text = "";
            // 
            // lbLibelle
            // 
            lbLibelle.AutoSize = true;
            lbLibelle.Font = new Font("Segoe UI", 15F);
            lbLibelle.Location = new Point(430, 79);
            lbLibelle.Name = "lbLibelle";
            lbLibelle.Size = new Size(68, 28);
            lbLibelle.TabIndex = 17;
            lbLibelle.Text = "Libellé";
            // 
            // btPlus
            // 
            btPlus.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btPlus.Location = new Point(439, 13);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(45, 50);
            btPlus.TabIndex = 15;
            btPlus.Text = "+";
            btPlus.TextAlign = ContentAlignment.TopRight;
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // btMoins
            // 
            btMoins.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btMoins.Location = new Point(501, 13);
            btMoins.Name = "btMoins";
            btMoins.Size = new Size(45, 50);
            btMoins.TabIndex = 14;
            btMoins.Text = "−";
            btMoins.TextAlign = ContentAlignment.TopRight;
            btMoins.UseVisualStyleBackColor = true;
            btMoins.Click += btMoins_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(405, 426);
            dataGridView1.TabIndex = 13;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Segoe UI", 15F);
            lbType.Location = new Point(430, 167);
            lbType.Name = "lbType";
            lbType.Size = new Size(53, 28);
            lbType.TabIndex = 22;
            lbType.Text = "Type";
            // 
            // rbOuverte
            // 
            rbOuverte.AutoSize = true;
            rbOuverte.Font = new Font("Segoe UI", 20F);
            rbOuverte.Location = new Point(3, 3);
            rbOuverte.Name = "rbOuverte";
            rbOuverte.Size = new Size(129, 41);
            rbOuverte.TabIndex = 23;
            rbOuverte.TabStop = true;
            rbOuverte.Text = "Ouverte";
            rbOuverte.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbListe);
            panel1.Controls.Add(rbFerme);
            panel1.Controls.Add(rbOuverte);
            panel1.Font = new Font("Segoe UI", 15F);
            panel1.Location = new Point(495, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 272);
            panel1.TabIndex = 24;
            // 
            // rbListe
            // 
            rbListe.AutoSize = true;
            rbListe.Font = new Font("Segoe UI", 20F);
            rbListe.Location = new Point(3, 168);
            rbListe.Name = "rbListe";
            rbListe.Size = new Size(216, 41);
            rbListe.TabIndex = 25;
            rbListe.TabStop = true;
            rbListe.Text = "Liste de valeurs";
            rbListe.UseVisualStyleBackColor = true;
            rbListe.CheckedChanged += rbListe_CheckedChanged;
            // 
            // rbFerme
            // 
            rbFerme.AutoSize = true;
            rbFerme.Font = new Font("Segoe UI", 20F);
            rbFerme.Location = new Point(3, 82);
            rbFerme.Name = "rbFerme";
            rbFerme.Size = new Size(146, 41);
            rbFerme.TabIndex = 24;
            rbFerme.TabStop = true;
            rbFerme.Text = "Oui/ Non";
            rbFerme.UseVisualStyleBackColor = true;
            rbFerme.CheckedChanged += rbFerme_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(801, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 361);
            panel2.TabIndex = 25;
            // 
            // panelOuiNon
            // 
            panelOuiNon.Controls.Add(rbNon);
            panelOuiNon.Controls.Add(rbOui);
            panelOuiNon.Font = new Font("Segoe UI", 15F);
            panelOuiNon.Location = new Point(840, 251);
            panelOuiNon.Name = "panelOuiNon";
            panelOuiNon.Size = new Size(277, 41);
            panelOuiNon.TabIndex = 26;
            panelOuiNon.Visible = false;
            // 
            // rbNon
            // 
            rbNon.AutoSize = true;
            rbNon.Location = new Point(156, 7);
            rbNon.Name = "rbNon";
            rbNon.Size = new Size(75, 32);
            rbNon.TabIndex = 1;
            rbNon.TabStop = true;
            rbNon.Text = "NON";
            rbNon.UseVisualStyleBackColor = true;
            // 
            // rbOui
            // 
            rbOui.AutoSize = true;
            rbOui.Location = new Point(49, 7);
            rbOui.Name = "rbOui";
            rbOui.Size = new Size(64, 32);
            rbOui.TabIndex = 0;
            rbOui.TabStop = true;
            rbOui.Text = "OUI";
            rbOui.UseVisualStyleBackColor = true;
            // 
            // dgvListe
            // 
            dgvListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListe.Location = new Point(3, 37);
            dgvListe.Name = "dgvListe";
            dgvListe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListe.Size = new Size(271, 102);
            dgvListe.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(840, 167);
            label1.Name = "label1";
            label1.Size = new Size(86, 28);
            label1.TabIndex = 27;
            label1.Text = "Réponse";
            // 
            // lbQuestionnaire
            // 
            lbQuestionnaire.AutoSize = true;
            lbQuestionnaire.Location = new Point(595, 35);
            lbQuestionnaire.Name = "lbQuestionnaire";
            lbQuestionnaire.Size = new Size(81, 15);
            lbQuestionnaire.TabIndex = 28;
            lbQuestionnaire.Text = "Questionnaire";
            // 
            // btPlusListe
            // 
            btPlusListe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btPlusListe.Location = new Point(196, 3);
            btPlusListe.Name = "btPlusListe";
            btPlusListe.Size = new Size(35, 41);
            btPlusListe.TabIndex = 16;
            btPlusListe.Text = "+";
            btPlusListe.TextAlign = ContentAlignment.TopRight;
            btPlusListe.UseVisualStyleBackColor = true;
            btPlusListe.Click += btPlusListe_Click;
            // 
            // btMoinsListe
            // 
            btMoinsListe.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btMoinsListe.Location = new Point(237, 3);
            btMoinsListe.Name = "btMoinsListe";
            btMoinsListe.Size = new Size(37, 41);
            btMoinsListe.TabIndex = 29;
            btMoinsListe.Text = "−";
            btMoinsListe.TextAlign = ContentAlignment.TopRight;
            btMoinsListe.UseVisualStyleBackColor = true;
            btMoinsListe.Click += btMoinsListe_Click;
            // 
            // panelListe
            // 
            panelListe.Controls.Add(dgvListe);
            panelListe.Controls.Add(btMoinsListe);
            panelListe.Controls.Add(btPlusListe);
            panelListe.Location = new Point(840, 298);
            panelListe.Name = "panelListe";
            panelListe.Size = new Size(277, 142);
            panelListe.TabIndex = 30;
            panelListe.Visible = false;
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Font = new Font("Segoe UI", 15F);
            lbNum.Location = new Point(430, 127);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(55, 28);
            lbNum.TabIndex = 31;
            lbNum.Text = "Num";
            // 
            // numquestion
            // 
            numquestion.Font = new Font("Segoe UI", 20F);
            numquestion.Location = new Point(495, 121);
            numquestion.Name = "numquestion";
            numquestion.Size = new Size(120, 43);
            numquestion.TabIndex = 32;
            // 
            // FormQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1148, 452);
            Controls.Add(numquestion);
            Controls.Add(lbNum);
            Controls.Add(panelListe);
            Controls.Add(lbQuestionnaire);
            Controls.Add(label1);
            Controls.Add(panelOuiNon);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbType);
            Controls.Add(tbLibelle);
            Controls.Add(lbLibelle);
            Controls.Add(btPlus);
            Controls.Add(btMoins);
            Controls.Add(dataGridView1);
            Name = "FormQuestion";
            Text = "Questions";
            Load += FormQuestion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelOuiNon.ResumeLayout(false);
            panelOuiNon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListe).EndInit();
            panelListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numquestion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox tbLibelle;
        private Label lbLibelle;
        private Button btPlus;
        private Button btMoins;
        private DataGridView dataGridView1;
        private Label lbType;
        private RadioButton rbOuverte;
        private Panel panel1;
        private Panel panel2;
        private RadioButton rbListe;
        private RadioButton rbFerme;
        private Panel panelOuiNon;
        private RadioButton rbNon;
        private RadioButton rbOui;
        private Label label1;
        private Label lbQuestionnaire;
        private DataGridView dgvListe;
        private Button btPlusListe;
        private Button btMoinsListe;
        private Panel panelListe;
        private Label lbNum;
        private NumericUpDown numquestion;
    }
}