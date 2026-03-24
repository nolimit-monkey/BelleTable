namespace BelleTable
{
    partial class FormLog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbconnexion_mdp = new TextBox();
            lbconnexion_mdp = new Label();
            tbconnexion_nom = new TextBox();
            lbconnexion_nom = new Label();
            lb_connexion = new Label();
            lb_inscription = new Label();
            lb_mdp = new Label();
            tb_mdp = new TextBox();
            tb_mail = new TextBox();
            tb_prenom = new TextBox();
            tb_nom = new TextBox();
            lb_mail = new Label();
            lb_prenom = new Label();
            lb_nom = new Label();
            bt_Inscription = new Button();
            bt_connexion = new Button();
            panel1 = new Panel();
            bt_sinscrire = new Button();
            lb_status = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbconnexion_mdp
            // 
            tbconnexion_mdp.Location = new Point(31, 157);
            tbconnexion_mdp.Name = "tbconnexion_mdp";
            tbconnexion_mdp.Size = new Size(363, 23);
            tbconnexion_mdp.TabIndex = 39;
            tbconnexion_mdp.UseSystemPasswordChar = true;
            // 
            // lbconnexion_mdp
            // 
            lbconnexion_mdp.AutoSize = true;
            lbconnexion_mdp.Location = new Point(31, 139);
            lbconnexion_mdp.Name = "lbconnexion_mdp";
            lbconnexion_mdp.Size = new Size(77, 15);
            lbconnexion_mdp.TabIndex = 38;
            lbconnexion_mdp.Text = "Mot de passe";
            // 
            // tbconnexion_nom
            // 
            tbconnexion_nom.Location = new Point(31, 87);
            tbconnexion_nom.Name = "tbconnexion_nom";
            tbconnexion_nom.Size = new Size(363, 23);
            tbconnexion_nom.TabIndex = 37;
            // 
            // lbconnexion_nom
            // 
            lbconnexion_nom.AutoSize = true;
            lbconnexion_nom.Location = new Point(31, 69);
            lbconnexion_nom.Name = "lbconnexion_nom";
            lbconnexion_nom.Size = new Size(34, 15);
            lbconnexion_nom.TabIndex = 36;
            lbconnexion_nom.Text = "Nom";
            // 
            // lb_connexion
            // 
            lb_connexion.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lb_connexion.Location = new Point(163, 25);
            lb_connexion.Name = "lb_connexion";
            lb_connexion.Size = new Size(102, 24);
            lb_connexion.TabIndex = 35;
            lb_connexion.Text = "Connexion";
            // 
            // lb_inscription
            // 
            lb_inscription.AutoSize = true;
            lb_inscription.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lb_inscription.Location = new Point(161, 25);
            lb_inscription.Name = "lb_inscription";
            lb_inscription.Size = new Size(99, 24);
            lb_inscription.TabIndex = 34;
            lb_inscription.Text = "Inscription";
            // 
            // lb_mdp
            // 
            lb_mdp.AutoSize = true;
            lb_mdp.Location = new Point(27, 282);
            lb_mdp.Name = "lb_mdp";
            lb_mdp.Size = new Size(77, 15);
            lb_mdp.TabIndex = 33;
            lb_mdp.Text = "Mot de passe";
            // 
            // tb_mdp
            // 
            tb_mdp.Location = new Point(27, 300);
            tb_mdp.Name = "tb_mdp";
            tb_mdp.Size = new Size(363, 23);
            tb_mdp.TabIndex = 32;
            tb_mdp.UseSystemPasswordChar = true;
            // 
            // tb_mail
            // 
            tb_mail.Location = new Point(27, 227);
            tb_mail.Name = "tb_mail";
            tb_mail.Size = new Size(363, 23);
            tb_mail.TabIndex = 30;
            // 
            // tb_prenom
            // 
            tb_prenom.Location = new Point(27, 157);
            tb_prenom.Name = "tb_prenom";
            tb_prenom.Size = new Size(363, 23);
            tb_prenom.TabIndex = 29;
            // 
            // tb_nom
            // 
            tb_nom.Location = new Point(27, 87);
            tb_nom.Name = "tb_nom";
            tb_nom.Size = new Size(363, 23);
            tb_nom.TabIndex = 28;
            // 
            // lb_mail
            // 
            lb_mail.AutoSize = true;
            lb_mail.Location = new Point(27, 209);
            lb_mail.Name = "lb_mail";
            lb_mail.Size = new Size(30, 15);
            lb_mail.TabIndex = 26;
            lb_mail.Text = "Mail";
            // 
            // lb_prenom
            // 
            lb_prenom.AutoSize = true;
            lb_prenom.Location = new Point(27, 139);
            lb_prenom.Name = "lb_prenom";
            lb_prenom.Size = new Size(49, 15);
            lb_prenom.TabIndex = 25;
            lb_prenom.Text = "Prénom";
            // 
            // lb_nom
            // 
            lb_nom.AutoSize = true;
            lb_nom.Location = new Point(27, 69);
            lb_nom.Name = "lb_nom";
            lb_nom.Size = new Size(34, 15);
            lb_nom.TabIndex = 24;
            lb_nom.Text = "Nom";
            // 
            // bt_Inscription
            // 
            bt_Inscription.Location = new Point(304, 443);
            bt_Inscription.Name = "bt_Inscription";
            bt_Inscription.Size = new Size(109, 65);
            bt_Inscription.TabIndex = 23;
            bt_Inscription.Text = "Inscription";
            bt_Inscription.UseVisualStyleBackColor = true;
            bt_Inscription.Click += bt_Inscription_Click;
            // 
            // bt_connexion
            // 
            bt_connexion.Location = new Point(3, 443);
            bt_connexion.Name = "bt_connexion";
            bt_connexion.Size = new Size(109, 65);
            bt_connexion.TabIndex = 22;
            bt_connexion.Text = "Connexion";
            bt_connexion.UseVisualStyleBackColor = true;
            bt_connexion.Click += bt_connexion_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(bt_sinscrire);
            panel1.Controls.Add(lb_status);
            panel1.Controls.Add(lb_connexion);
            panel1.Controls.Add(tbconnexion_mdp);
            panel1.Controls.Add(lbconnexion_nom);
            panel1.Controls.Add(lbconnexion_mdp);
            panel1.Controls.Add(tbconnexion_nom);
            panel1.Controls.Add(bt_connexion);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 511);
            panel1.TabIndex = 40;
            // 
            // bt_sinscrire
            // 
            bt_sinscrire.Location = new Point(240, 465);
            bt_sinscrire.Name = "bt_sinscrire";
            bt_sinscrire.Size = new Size(173, 43);
            bt_sinscrire.TabIndex = 41;
            bt_sinscrire.Text = "S'inscrire";
            bt_sinscrire.UseVisualStyleBackColor = true;
            bt_sinscrire.Click += bt_sinscrire_Click;
            // 
            // lb_status
            // 
            lb_status.AutoSize = true;
            lb_status.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lb_status.Location = new Point(31, 273);
            lb_status.Name = "lb_status";
            lb_status.Size = new Size(69, 28);
            lb_status.TabIndex = 40;
            lb_status.Text = "status";
            // 
            // panel2
            // 
            panel2.Controls.Add(tb_prenom);
            panel2.Controls.Add(lb_inscription);
            panel2.Controls.Add(bt_Inscription);
            panel2.Controls.Add(lb_mdp);
            panel2.Controls.Add(lb_nom);
            panel2.Controls.Add(tb_mdp);
            panel2.Controls.Add(lb_prenom);
            panel2.Controls.Add(tb_mail);
            panel2.Controls.Add(lb_mail);
            panel2.Controls.Add(tb_nom);
            panel2.Location = new Point(499, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 511);
            panel2.TabIndex = 41;
            // 
            // FormLog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormLog";
            Text = "Login et Signup";
            Load += FormLog_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbconnexion_mdp;
        private Label lbconnexion_mdp;
        private TextBox tbconnexion_nom;
        private Label lbconnexion_nom;
        private Label lb_connexion;
        private Label lb_inscription;
        private Label lb_mdp;
        private TextBox tb_mdp;
        private TextBox tb_mail;
        private TextBox tb_prenom;
        private TextBox tb_nom;
        private Label lb_mail;
        private Label lb_prenom;
        private Label lb_nom;
        private Button bt_Inscription;
        private Button bt_connexion;
        private Panel panel1;
        private Panel panel2;
        private Label lb_status;
        private Button bt_sinscrire;
    }
}
