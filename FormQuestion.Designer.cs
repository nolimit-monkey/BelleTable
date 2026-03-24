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
            panel2 = new Panel();
            rbFerme = new RadioButton();
            rbListe = new RadioButton();
            panel3 = new Panel();
            rbOui = new RadioButton();
            rbNon = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tbLibelle
            // 
            tbLibelle.Location = new Point(504, 94);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(249, 36);
            tbLibelle.TabIndex = 21;
            tbLibelle.Text = "";
            // 
            // lbLibelle
            // 
            lbLibelle.AutoSize = true;
            lbLibelle.Font = new Font("Segoe UI", 15F);
            lbLibelle.Location = new Point(430, 102);
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
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(405, 426);
            dataGridView1.TabIndex = 13;
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
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Location = new Point(809, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(2, 426);
            panel2.TabIndex = 25;
            // 
            // rbFerme
            // 
            rbFerme.AutoSize = true;
            rbFerme.Font = new Font("Segoe UI", 20F);
            rbFerme.Location = new Point(3, 125);
            rbFerme.Name = "rbFerme";
            rbFerme.Size = new Size(146, 41);
            rbFerme.TabIndex = 24;
            rbFerme.TabStop = true;
            rbFerme.Text = "Oui/ Non";
            rbFerme.UseVisualStyleBackColor = true;
            // 
            // rbListe
            // 
            rbListe.AutoSize = true;
            rbListe.Font = new Font("Segoe UI", 20F);
            rbListe.Location = new Point(0, 228);
            rbListe.Name = "rbListe";
            rbListe.Size = new Size(216, 41);
            rbListe.TabIndex = 25;
            rbListe.TabStop = true;
            rbListe.Text = "Liste de valeurs";
            rbListe.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(rbNon);
            panel3.Controls.Add(rbOui);
            panel3.Font = new Font("Segoe UI", 15F);
            panel3.Location = new Point(840, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(277, 272);
            panel3.TabIndex = 26;
            // 
            // rbOui
            // 
            rbOui.AutoSize = true;
            rbOui.Location = new Point(38, 132);
            rbOui.Name = "rbOui";
            rbOui.Size = new Size(61, 32);
            rbOui.TabIndex = 0;
            rbOui.TabStop = true;
            rbOui.Text = "Oui";
            rbOui.UseVisualStyleBackColor = true;
            // 
            // rbNon
            // 
            rbNon.AutoSize = true;
            rbNon.Location = new Point(163, 132);
            rbNon.Name = "rbNon";
            rbNon.Size = new Size(68, 32);
            rbNon.TabIndex = 1;
            rbNon.TabStop = true;
            rbNon.Text = "Non";
            rbNon.UseVisualStyleBackColor = true;
            // 
            // FormQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1148, 452);
            Controls.Add(panel3);
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private Panel panel3;
        private RadioButton rbNon;
        private RadioButton rbOui;
    }
}