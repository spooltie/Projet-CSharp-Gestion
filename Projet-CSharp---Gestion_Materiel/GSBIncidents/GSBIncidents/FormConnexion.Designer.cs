namespace GSBIncidents
{
    partial class FormConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.carte = new System.Windows.Forms.Panel();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.lblPoste = new System.Windows.Forms.Label();
            this.txtPoste = new System.Windows.Forms.TextBox();
            this.chkResterConnecte = new System.Windows.Forms.CheckBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.carte.SuspendLayout();
            this.SuspendLayout();
            //
            // carte
            //
            this.carte.Controls.Add(this.lblTitre);
            this.carte.Controls.Add(this.lblSousTitre);
            this.carte.Controls.Add(this.lblLogin);
            this.carte.Controls.Add(this.txtLogin);
            this.carte.Controls.Add(this.lblMotDePasse);
            this.carte.Controls.Add(this.txtMotDePasse);
            this.carte.Controls.Add(this.lblPoste);
            this.carte.Controls.Add(this.txtPoste);
            this.carte.Controls.Add(this.chkResterConnecte);
            this.carte.Controls.Add(this.btnSeConnecter);
            this.carte.BackColor = System.Drawing.Color.White;
            this.carte.Location = new System.Drawing.Point(40, 40);
            this.carte.Name = "carte";
            this.carte.Size = new System.Drawing.Size(360, 424);
            //
            // lblTitre
            //
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTitre.Location = new System.Drawing.Point(30, 30);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Text = "Connexion";
            //
            // lblSousTitre
            //
            this.lblSousTitre.AutoSize = true;
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblSousTitre.Location = new System.Drawing.Point(33, 74);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Text = "Connectez-vous pour accéder à votre compte.";
            //
            // lblLogin
            //
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblLogin.Location = new System.Drawing.Point(32, 120);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Text = "Login";
            //
            // txtLogin
            //
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLogin.Location = new System.Drawing.Point(32, 142);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(296, 26);
            this.txtLogin.TabIndex = 0;
            //
            // lblMotDePasse
            //
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblMotDePasse.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMotDePasse.Location = new System.Drawing.Point(32, 184);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Text = "Mot de passe";
            //
            // txtMotDePasse
            //
            this.txtMotDePasse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotDePasse.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMotDePasse.Location = new System.Drawing.Point(32, 206);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(296, 26);
            this.txtMotDePasse.TabIndex = 1;
            this.txtMotDePasse.UseSystemPasswordChar = true;
            //
            // lblPoste
            //
            this.lblPoste.AutoSize = true;
            this.lblPoste.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblPoste.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPoste.Location = new System.Drawing.Point(32, 248);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Text = "Poste";
            //
            // txtPoste
            //
            this.txtPoste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoste.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPoste.Location = new System.Drawing.Point(32, 270);
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.Size = new System.Drawing.Size(296, 26);
            this.txtPoste.TabIndex = 2;
            //
            // chkResterConnecte
            //
            this.chkResterConnecte.AutoSize = true;
            this.chkResterConnecte.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chkResterConnecte.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.chkResterConnecte.Location = new System.Drawing.Point(32, 312);
            this.chkResterConnecte.Name = "chkResterConnecte";
            this.chkResterConnecte.TabIndex = 3;
            this.chkResterConnecte.Text = "Rester connecté";
            //
            // btnSeConnecter
            //
            this.btnSeConnecter.FlatAppearance.BorderSize = 0;
            this.btnSeConnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(27, 74, 184);
            this.btnSeConnecter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 88, 214);
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(46, 108, 240);
            this.btnSeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.White;
            this.btnSeConnecter.Location = new System.Drawing.Point(32, 352);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(296, 40);
            this.btnSeConnecter.TabIndex = 4;
            this.btnSeConnecter.Text = "Se connecter";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            //
            // FormConnexion
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(35, 35, 35);
            this.ClientSize = new System.Drawing.Size(440, 504);
            this.Controls.Add(this.carte);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FormConnexion_Load);
            this.carte.ResumeLayout(false);
            this.carte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel carte;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.TextBox txtPoste;
        private System.Windows.Forms.CheckBox chkResterConnecte;
        private System.Windows.Forms.Button btnSeConnecter;
    }
}
