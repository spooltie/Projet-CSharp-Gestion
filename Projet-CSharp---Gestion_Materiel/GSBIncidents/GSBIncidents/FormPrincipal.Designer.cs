namespace GSBIncidents
{
    partial class FormPrincipal
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
            this.panelEntete = new System.Windows.Forms.Panel();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblUtilisateur = new System.Windows.Forms.Label();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabConnexion = new System.Windows.Forms.TabPage();
            this.tabUtilisateur = new System.Windows.Forms.TabPage();
            this.tabTechnicien = new System.Windows.Forms.TabPage();
            this.tabResponsable = new System.Windows.Forms.TabPage();
            this.carteConnexion = new System.Windows.Forms.Panel();
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
            this.carteNouveau = new System.Windows.Forms.Panel();
            this.lblNouveau = new System.Windows.Forms.Label();
            this.lblMateriel = new System.Windows.Forms.Label();
            this.cboMateriel = new System.Windows.Forms.ComboBox();
            this.lblDeclUrgence = new System.Windows.Forms.Label();
            this.panelDeclUrgence = new System.Windows.Forms.Panel();
            this.rbDeclFaible = new System.Windows.Forms.RadioButton();
            this.rbDeclMoyen = new System.Windows.Forms.RadioButton();
            this.rbDeclCritique = new System.Windows.Forms.RadioButton();
            this.lblIncident = new System.Windows.Forms.Label();
            this.txtIncident = new System.Windows.Forms.TextBox();
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.carteTickets = new System.Windows.Forms.Panel();
            this.lblMesTickets = new System.Windows.Forms.Label();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.carteMateriel = new System.Windows.Forms.Panel();
            this.lblGestion = new System.Windows.Forms.Label();
            this.lblAjout = new System.Windows.Forms.Label();
            this.lblProcesseur = new System.Windows.Forms.Label();
            this.txtProcesseur = new System.Windows.Forms.TextBox();
            this.lblDisque = new System.Windows.Forms.Label();
            this.txtDisque = new System.Windows.Forms.TextBox();
            this.lblLogiciels = new System.Windows.Forms.Label();
            this.txtLogiciels = new System.Windows.Forms.TextBox();
            this.lblEtatMateriel = new System.Windows.Forms.Label();
            this.cboEtatMateriel = new System.Windows.Forms.ComboBox();
            this.lblSuiviMateriel = new System.Windows.Forms.Label();
            this.txtSuiviMateriel = new System.Windows.Forms.TextBox();
            this.btnAjouterMateriel = new System.Windows.Forms.Button();
            this.separateurMateriel = new System.Windows.Forms.Panel();
            this.lblConsultation = new System.Windows.Forms.Label();
            this.cboConsultMateriel = new System.Windows.Forms.ComboBox();
            this.btnAfficherMateriel = new System.Windows.Forms.Button();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.lblDetailProcesseur = new System.Windows.Forms.Label();
            this.lblValeurProcesseur = new System.Windows.Forms.Label();
            this.lblDetailDisque = new System.Windows.Forms.Label();
            this.lblValeurDisque = new System.Windows.Forms.Label();
            this.lblDetailLogiciels = new System.Windows.Forms.Label();
            this.lblValeurLogiciels = new System.Windows.Forms.Label();
            this.lblDetailEtat = new System.Windows.Forms.Label();
            this.lblValeurEtat = new System.Windows.Forms.Label();
            this.lblDetailSuivi = new System.Windows.Forms.Label();
            this.lblValeurSuivi = new System.Windows.Forms.Label();
            this.lblSuppression = new System.Windows.Forms.Label();
            this.cboSupprMateriel = new System.Windows.Forms.ComboBox();
            this.btnSupprimerMateriel = new System.Windows.Forms.Button();
            this.carteIncidents = new System.Windows.Forms.Panel();
            this.lblIncidents = new System.Windows.Forms.Label();
            this.lstIncidents = new System.Windows.Forms.ListBox();
            this.btnPrendreEnCharge = new System.Windows.Forms.Button();
            this.carteTicket = new System.Windows.Forms.Panel();
            this.lblTicketSelection = new System.Windows.Forms.Label();
            this.lblEtatActuel = new System.Windows.Forms.Label();
            this.lblEtat = new System.Windows.Forms.Label();
            this.panelEtat = new System.Windows.Forms.Panel();
            this.rbEnCours = new System.Windows.Forms.RadioButton();
            this.rbResolu = new System.Windows.Forms.RadioButton();
            this.rbCloture = new System.Windows.Forms.RadioButton();
            this.lblUrgence = new System.Windows.Forms.Label();
            this.panelUrgence = new System.Windows.Forms.Panel();
            this.rbFaible = new System.Windows.Forms.RadioButton();
            this.rbMoyen = new System.Windows.Forms.RadioButton();
            this.rbCritique = new System.Windows.Forms.RadioButton();
            this.lblSuivi = new System.Windows.Forms.Label();
            this.txtSuivi = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.cartePersonnel = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.panelType = new System.Windows.Forms.Panel();
            this.rbTechnicien = new System.Windows.Forms.RadioButton();
            this.rbUtilisateur = new System.Windows.Forms.RadioButton();
            this.lblPersonne = new System.Windows.Forms.Label();
            this.cboPersonne = new System.Windows.Forms.ComboBox();
            this.separateurPersonnel = new System.Windows.Forms.Panel();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.dtpDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.lblPostePersonne = new System.Windows.Forms.Label();
            this.txtPostePersonne = new System.Windows.Forms.TextBox();
            this.lblLoginPersonne = new System.Windows.Forms.Label();
            this.txtLoginPersonne = new System.Windows.Forms.TextBox();
            this.lblMdpPersonne = new System.Windows.Forms.Label();
            this.txtMdpPersonne = new System.Windows.Forms.TextBox();
            this.panelTechnicien = new System.Windows.Forms.Panel();
            this.lblFormation = new System.Windows.Forms.Label();
            this.txtFormation = new System.Windows.Forms.TextBox();
            this.lblCompetence = new System.Windows.Forms.Label();
            this.txtCompetence = new System.Windows.Forms.TextBox();
            this.btnAjouterPersonne = new System.Windows.Forms.Button();
            this.btnModifierPersonne = new System.Windows.Forms.Button();
            this.btnSupprimerPersonne = new System.Windows.Forms.Button();
            this.panelEntete.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tabConnexion.SuspendLayout();
            this.tabUtilisateur.SuspendLayout();
            this.tabTechnicien.SuspendLayout();
            this.tabResponsable.SuspendLayout();
            this.carteConnexion.SuspendLayout();
            this.carteNouveau.SuspendLayout();
            this.panelDeclUrgence.SuspendLayout();
            this.carteTickets.SuspendLayout();
            this.carteMateriel.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.carteIncidents.SuspendLayout();
            this.carteTicket.SuspendLayout();
            this.panelEtat.SuspendLayout();
            this.panelUrgence.SuspendLayout();
            this.cartePersonnel.SuspendLayout();
            this.panelType.SuspendLayout();
            this.panelTechnicien.SuspendLayout();
            this.SuspendLayout();
            //
            // panelEntete
            //
            this.panelEntete.Controls.Add(this.lblApplication);
            this.panelEntete.Controls.Add(this.lblUtilisateur);
            this.panelEntete.Controls.Add(this.btnDeconnexion);
            this.panelEntete.BackColor = System.Drawing.Color.White;
            this.panelEntete.Location = new System.Drawing.Point(0, 0);
            this.panelEntete.Name = "panelEntete";
            this.panelEntete.Size = new System.Drawing.Size(1100, 56);
            //
            // lblApplication
            //
            this.lblApplication.AutoSize = true;
            this.lblApplication.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblApplication.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblApplication.Location = new System.Drawing.Point(24, 16);
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Text = "Support informatique";
            //
            // lblUtilisateur
            //
            this.lblUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUtilisateur.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblUtilisateur.Location = new System.Drawing.Point(724, 16);
            this.lblUtilisateur.Name = "lblUtilisateur";
            this.lblUtilisateur.Size = new System.Drawing.Size(200, 24);
            this.lblUtilisateur.Text = "Nom Prénom";
            this.lblUtilisateur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // btnDeconnexion
            //
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnDeconnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.btnDeconnexion.BackColor = System.Drawing.Color.White;
            this.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeconnexion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDeconnexion.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnDeconnexion.Location = new System.Drawing.Point(936, 12);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(140, 32);
            this.btnDeconnexion.TabIndex = 0;
            this.btnDeconnexion.Text = "Se déconnecter";
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            //
            // tabMenu
            //
            this.tabMenu.Controls.Add(this.tabConnexion);
            this.tabMenu.Controls.Add(this.tabUtilisateur);
            this.tabMenu.Controls.Add(this.tabTechnicien);
            this.tabMenu.Controls.Add(this.tabResponsable);
            this.tabMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabMenu.Location = new System.Drawing.Point(16, 72);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Drawing.Point(16, 6);
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1068, 572);
            this.tabMenu.TabIndex = 1;
            //
            // tabConnexion
            //
            this.tabConnexion.Controls.Add(this.carteConnexion);
            this.tabConnexion.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabConnexion.Location = new System.Drawing.Point(4, 34);
            this.tabConnexion.Name = "tabConnexion";
            this.tabConnexion.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnexion.Size = new System.Drawing.Size(1060, 534);
            this.tabConnexion.TabIndex = 2;
            this.tabConnexion.Text = "Connexion";
            this.tabConnexion.UseVisualStyleBackColor = false;
            //
            // tabUtilisateur
            //
            this.tabUtilisateur.Controls.Add(this.carteNouveau);
            this.tabUtilisateur.Controls.Add(this.carteTickets);
            this.tabUtilisateur.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabUtilisateur.Location = new System.Drawing.Point(4, 34);
            this.tabUtilisateur.Name = "tabUtilisateur";
            this.tabUtilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.tabUtilisateur.Size = new System.Drawing.Size(1060, 534);
            this.tabUtilisateur.TabIndex = 3;
            this.tabUtilisateur.Text = "Utilisateur";
            this.tabUtilisateur.UseVisualStyleBackColor = false;
            //
            // tabTechnicien
            //
            this.tabTechnicien.Controls.Add(this.carteMateriel);
            this.tabTechnicien.Controls.Add(this.carteIncidents);
            this.tabTechnicien.Controls.Add(this.carteTicket);
            this.tabTechnicien.AutoScroll = true;
            this.tabTechnicien.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabTechnicien.Location = new System.Drawing.Point(4, 34);
            this.tabTechnicien.Name = "tabTechnicien";
            this.tabTechnicien.Padding = new System.Windows.Forms.Padding(3);
            this.tabTechnicien.Size = new System.Drawing.Size(1060, 534);
            this.tabTechnicien.TabIndex = 4;
            this.tabTechnicien.Text = "Technicien";
            this.tabTechnicien.UseVisualStyleBackColor = false;
            //
            // tabResponsable
            //
            this.tabResponsable.Controls.Add(this.cartePersonnel);
            this.tabResponsable.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.tabResponsable.Location = new System.Drawing.Point(4, 34);
            this.tabResponsable.Name = "tabResponsable";
            this.tabResponsable.Padding = new System.Windows.Forms.Padding(3);
            this.tabResponsable.Size = new System.Drawing.Size(1060, 534);
            this.tabResponsable.TabIndex = 5;
            this.tabResponsable.Text = "Responsable";
            this.tabResponsable.UseVisualStyleBackColor = false;
            //
            // carteConnexion
            //
            this.carteConnexion.Controls.Add(this.lblTitre);
            this.carteConnexion.Controls.Add(this.lblSousTitre);
            this.carteConnexion.Controls.Add(this.lblLogin);
            this.carteConnexion.Controls.Add(this.txtLogin);
            this.carteConnexion.Controls.Add(this.lblMotDePasse);
            this.carteConnexion.Controls.Add(this.txtMotDePasse);
            this.carteConnexion.Controls.Add(this.lblPoste);
            this.carteConnexion.Controls.Add(this.txtPoste);
            this.carteConnexion.Controls.Add(this.chkResterConnecte);
            this.carteConnexion.Controls.Add(this.btnSeConnecter);
            this.carteConnexion.BackColor = System.Drawing.Color.White;
            this.carteConnexion.Location = new System.Drawing.Point(350, 55);
            this.carteConnexion.Name = "carteConnexion";
            this.carteConnexion.Size = new System.Drawing.Size(360, 424);
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
            // carteNouveau
            //
            this.carteNouveau.Controls.Add(this.lblNouveau);
            this.carteNouveau.Controls.Add(this.lblMateriel);
            this.carteNouveau.Controls.Add(this.cboMateriel);
            this.carteNouveau.Controls.Add(this.lblDeclUrgence);
            this.carteNouveau.Controls.Add(this.panelDeclUrgence);
            this.carteNouveau.Controls.Add(this.lblIncident);
            this.carteNouveau.Controls.Add(this.txtIncident);
            this.carteNouveau.Controls.Add(this.btnEnvoyer);
            this.carteNouveau.Controls.Add(this.btnAfficher);
            this.carteNouveau.BackColor = System.Drawing.Color.White;
            this.carteNouveau.Location = new System.Drawing.Point(16, 16);
            this.carteNouveau.Name = "carteNouveau";
            this.carteNouveau.Size = new System.Drawing.Size(420, 456);
            //
            // lblNouveau
            //
            this.lblNouveau.AutoSize = true;
            this.lblNouveau.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNouveau.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblNouveau.Location = new System.Drawing.Point(22, 20);
            this.lblNouveau.Name = "lblNouveau";
            this.lblNouveau.Text = "Nouveau ticket";
            //
            // lblMateriel
            //
            this.lblMateriel.AutoSize = true;
            this.lblMateriel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblMateriel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMateriel.Location = new System.Drawing.Point(24, 68);
            this.lblMateriel.Name = "lblMateriel";
            this.lblMateriel.Text = "Matériel concerné";
            //
            // cboMateriel
            //
            this.cboMateriel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateriel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboMateriel.Location = new System.Drawing.Point(24, 90);
            this.cboMateriel.Name = "cboMateriel";
            this.cboMateriel.Size = new System.Drawing.Size(372, 27);
            this.cboMateriel.TabIndex = 6;
            //
            // lblDeclUrgence
            //
            this.lblDeclUrgence.AutoSize = true;
            this.lblDeclUrgence.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblDeclUrgence.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDeclUrgence.Location = new System.Drawing.Point(24, 132);
            this.lblDeclUrgence.Name = "lblDeclUrgence";
            this.lblDeclUrgence.Text = "Niveau d'urgence";
            //
            // panelDeclUrgence
            //
            this.panelDeclUrgence.Controls.Add(this.rbDeclFaible);
            this.panelDeclUrgence.Controls.Add(this.rbDeclMoyen);
            this.panelDeclUrgence.Controls.Add(this.rbDeclCritique);
            this.panelDeclUrgence.Location = new System.Drawing.Point(24, 154);
            this.panelDeclUrgence.Name = "panelDeclUrgence";
            this.panelDeclUrgence.Size = new System.Drawing.Size(372, 28);
            this.panelDeclUrgence.TabIndex = 7;
            //
            // rbDeclFaible
            //
            this.rbDeclFaible.AutoSize = true;
            this.rbDeclFaible.Checked = true;
            this.rbDeclFaible.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbDeclFaible.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbDeclFaible.Location = new System.Drawing.Point(0, 3);
            this.rbDeclFaible.Name = "rbDeclFaible";
            this.rbDeclFaible.TabStop = true;
            this.rbDeclFaible.Text = "Faible";
            //
            // rbDeclMoyen
            //
            this.rbDeclMoyen.AutoSize = true;
            this.rbDeclMoyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbDeclMoyen.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbDeclMoyen.Location = new System.Drawing.Point(110, 3);
            this.rbDeclMoyen.Name = "rbDeclMoyen";
            this.rbDeclMoyen.Text = "Moyen";
            //
            // rbDeclCritique
            //
            this.rbDeclCritique.AutoSize = true;
            this.rbDeclCritique.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbDeclCritique.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbDeclCritique.Location = new System.Drawing.Point(220, 3);
            this.rbDeclCritique.Name = "rbDeclCritique";
            this.rbDeclCritique.Text = "Critique";
            //
            // lblIncident
            //
            this.lblIncident.AutoSize = true;
            this.lblIncident.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblIncident.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblIncident.Location = new System.Drawing.Point(24, 196);
            this.lblIncident.Name = "lblIncident";
            this.lblIncident.Text = "Description de l'incident";
            //
            // txtIncident
            //
            this.txtIncident.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIncident.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtIncident.Location = new System.Drawing.Point(24, 218);
            this.txtIncident.Multiline = true;
            this.txtIncident.Name = "txtIncident";
            this.txtIncident.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIncident.Size = new System.Drawing.Size(372, 150);
            this.txtIncident.TabIndex = 8;
            //
            // btnEnvoyer
            //
            this.btnEnvoyer.FlatAppearance.BorderSize = 0;
            this.btnEnvoyer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(27, 74, 184);
            this.btnEnvoyer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 88, 214);
            this.btnEnvoyer.BackColor = System.Drawing.Color.FromArgb(46, 108, 240);
            this.btnEnvoyer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoyer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnEnvoyer.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyer.Location = new System.Drawing.Point(24, 392);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(140, 38);
            this.btnEnvoyer.TabIndex = 9;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            //
            // btnAfficher
            //
            this.btnAfficher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnAfficher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.btnAfficher.BackColor = System.Drawing.Color.White;
            this.btnAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAfficher.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnAfficher.Location = new System.Drawing.Point(176, 392);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(180, 38);
            this.btnAfficher.TabIndex = 10;
            this.btnAfficher.Text = "Afficher mes tickets";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            //
            // carteTickets
            //
            this.carteTickets.Controls.Add(this.lblMesTickets);
            this.carteTickets.Controls.Add(this.lstTickets);
            this.carteTickets.BackColor = System.Drawing.Color.White;
            this.carteTickets.Location = new System.Drawing.Point(452, 16);
            this.carteTickets.Name = "carteTickets";
            this.carteTickets.Size = new System.Drawing.Size(592, 456);
            //
            // lblMesTickets
            //
            this.lblMesTickets.AutoSize = true;
            this.lblMesTickets.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMesTickets.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMesTickets.Location = new System.Drawing.Point(22, 20);
            this.lblMesTickets.Name = "lblMesTickets";
            this.lblMesTickets.Text = "Mes tickets";
            //
            // lstTickets
            //
            this.lstTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTickets.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lstTickets.IntegralHeight = false;
            this.lstTickets.Location = new System.Drawing.Point(24, 64);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(544, 368);
            this.lstTickets.TabIndex = 11;
            //
            // carteMateriel
            //
            this.carteMateriel.Controls.Add(this.lblGestion);
            this.carteMateriel.Controls.Add(this.lblAjout);
            this.carteMateriel.Controls.Add(this.lblProcesseur);
            this.carteMateriel.Controls.Add(this.txtProcesseur);
            this.carteMateriel.Controls.Add(this.lblDisque);
            this.carteMateriel.Controls.Add(this.txtDisque);
            this.carteMateriel.Controls.Add(this.lblLogiciels);
            this.carteMateriel.Controls.Add(this.txtLogiciels);
            this.carteMateriel.Controls.Add(this.lblEtatMateriel);
            this.carteMateriel.Controls.Add(this.cboEtatMateriel);
            this.carteMateriel.Controls.Add(this.lblSuiviMateriel);
            this.carteMateriel.Controls.Add(this.txtSuiviMateriel);
            this.carteMateriel.Controls.Add(this.btnAjouterMateriel);
            this.carteMateriel.Controls.Add(this.separateurMateriel);
            this.carteMateriel.Controls.Add(this.lblConsultation);
            this.carteMateriel.Controls.Add(this.cboConsultMateriel);
            this.carteMateriel.Controls.Add(this.btnAfficherMateriel);
            this.carteMateriel.Controls.Add(this.panelDetail);
            this.carteMateriel.Controls.Add(this.lblSuppression);
            this.carteMateriel.Controls.Add(this.cboSupprMateriel);
            this.carteMateriel.Controls.Add(this.btnSupprimerMateriel);
            this.carteMateriel.BackColor = System.Drawing.Color.White;
            this.carteMateriel.Location = new System.Drawing.Point(16, 16);
            this.carteMateriel.Name = "carteMateriel";
            this.carteMateriel.Size = new System.Drawing.Size(1012, 340);
            //
            // lblGestion
            //
            this.lblGestion.AutoSize = true;
            this.lblGestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGestion.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblGestion.Location = new System.Drawing.Point(22, 20);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Text = "Gestion du matériel";
            //
            // lblAjout
            //
            this.lblAjout.AutoSize = true;
            this.lblAjout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblAjout.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblAjout.Location = new System.Drawing.Point(24, 64);
            this.lblAjout.Name = "lblAjout";
            this.lblAjout.Text = "Ajouter un nouveau matériel";
            //
            // lblProcesseur
            //
            this.lblProcesseur.AutoSize = true;
            this.lblProcesseur.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblProcesseur.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblProcesseur.Location = new System.Drawing.Point(24, 100);
            this.lblProcesseur.Name = "lblProcesseur";
            this.lblProcesseur.Text = "Processeur";
            //
            // txtProcesseur
            //
            this.txtProcesseur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProcesseur.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtProcesseur.Location = new System.Drawing.Point(24, 122);
            this.txtProcesseur.Name = "txtProcesseur";
            this.txtProcesseur.Size = new System.Drawing.Size(156, 26);
            this.txtProcesseur.TabIndex = 12;
            //
            // lblDisque
            //
            this.lblDisque.AutoSize = true;
            this.lblDisque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblDisque.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDisque.Location = new System.Drawing.Point(196, 100);
            this.lblDisque.Name = "lblDisque";
            this.lblDisque.Text = "Disque";
            //
            // txtDisque
            //
            this.txtDisque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisque.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtDisque.Location = new System.Drawing.Point(196, 122);
            this.txtDisque.Name = "txtDisque";
            this.txtDisque.Size = new System.Drawing.Size(156, 26);
            this.txtDisque.TabIndex = 13;
            //
            // lblLogiciels
            //
            this.lblLogiciels.AutoSize = true;
            this.lblLogiciels.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblLogiciels.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblLogiciels.Location = new System.Drawing.Point(24, 164);
            this.lblLogiciels.Name = "lblLogiciels";
            this.lblLogiciels.Text = "Logiciels";
            //
            // txtLogiciels
            //
            this.txtLogiciels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogiciels.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLogiciels.Location = new System.Drawing.Point(24, 186);
            this.txtLogiciels.Name = "txtLogiciels";
            this.txtLogiciels.Size = new System.Drawing.Size(156, 26);
            this.txtLogiciels.TabIndex = 14;
            //
            // lblEtatMateriel
            //
            this.lblEtatMateriel.AutoSize = true;
            this.lblEtatMateriel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblEtatMateriel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblEtatMateriel.Location = new System.Drawing.Point(196, 164);
            this.lblEtatMateriel.Name = "lblEtatMateriel";
            this.lblEtatMateriel.Text = "État";
            //
            // cboEtatMateriel
            //
            this.cboEtatMateriel.Items.AddRange(new object[] {
            "En service",
            "En panne",
            "Hors service"});
            this.cboEtatMateriel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtatMateriel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboEtatMateriel.Location = new System.Drawing.Point(196, 186);
            this.cboEtatMateriel.Name = "cboEtatMateriel";
            this.cboEtatMateriel.Size = new System.Drawing.Size(156, 27);
            this.cboEtatMateriel.TabIndex = 15;
            //
            // lblSuiviMateriel
            //
            this.lblSuiviMateriel.AutoSize = true;
            this.lblSuiviMateriel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblSuiviMateriel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSuiviMateriel.Location = new System.Drawing.Point(24, 228);
            this.lblSuiviMateriel.Name = "lblSuiviMateriel";
            this.lblSuiviMateriel.Text = "Suivi";
            //
            // txtSuiviMateriel
            //
            this.txtSuiviMateriel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuiviMateriel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSuiviMateriel.Location = new System.Drawing.Point(24, 250);
            this.txtSuiviMateriel.Name = "txtSuiviMateriel";
            this.txtSuiviMateriel.Size = new System.Drawing.Size(328, 26);
            this.txtSuiviMateriel.TabIndex = 16;
            //
            // btnAjouterMateriel
            //
            this.btnAjouterMateriel.FlatAppearance.BorderSize = 0;
            this.btnAjouterMateriel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(27, 74, 184);
            this.btnAjouterMateriel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 88, 214);
            this.btnAjouterMateriel.BackColor = System.Drawing.Color.FromArgb(46, 108, 240);
            this.btnAjouterMateriel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterMateriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterMateriel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAjouterMateriel.ForeColor = System.Drawing.Color.White;
            this.btnAjouterMateriel.Location = new System.Drawing.Point(24, 290);
            this.btnAjouterMateriel.Name = "btnAjouterMateriel";
            this.btnAjouterMateriel.Size = new System.Drawing.Size(140, 38);
            this.btnAjouterMateriel.TabIndex = 17;
            this.btnAjouterMateriel.Text = "Ajouter";
            this.btnAjouterMateriel.UseVisualStyleBackColor = false;
            this.btnAjouterMateriel.Click += new System.EventHandler(this.btnAjouterMateriel_Click);
            //
            // separateurMateriel
            //
            this.separateurMateriel.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.separateurMateriel.Location = new System.Drawing.Point(376, 64);
            this.separateurMateriel.Name = "separateurMateriel";
            this.separateurMateriel.Size = new System.Drawing.Size(1, 256);
            //
            // lblConsultation
            //
            this.lblConsultation.AutoSize = true;
            this.lblConsultation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblConsultation.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblConsultation.Location = new System.Drawing.Point(400, 64);
            this.lblConsultation.Name = "lblConsultation";
            this.lblConsultation.Text = "Consultation d'un matériel";
            //
            // cboConsultMateriel
            //
            this.cboConsultMateriel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsultMateriel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboConsultMateriel.Location = new System.Drawing.Point(400, 100);
            this.cboConsultMateriel.Name = "cboConsultMateriel";
            this.cboConsultMateriel.Size = new System.Drawing.Size(460, 27);
            this.cboConsultMateriel.TabIndex = 18;
            //
            // btnAfficherMateriel
            //
            this.btnAfficherMateriel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnAfficherMateriel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.btnAfficherMateriel.BackColor = System.Drawing.Color.White;
            this.btnAfficherMateriel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficherMateriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherMateriel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAfficherMateriel.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnAfficherMateriel.Location = new System.Drawing.Point(872, 96);
            this.btnAfficherMateriel.Name = "btnAfficherMateriel";
            this.btnAfficherMateriel.Size = new System.Drawing.Size(116, 34);
            this.btnAfficherMateriel.TabIndex = 19;
            this.btnAfficherMateriel.Text = "Afficher";
            this.btnAfficherMateriel.UseVisualStyleBackColor = false;
            this.btnAfficherMateriel.Click += new System.EventHandler(this.btnAfficherMateriel_Click);
            //
            // panelDetail
            //
            this.panelDetail.Controls.Add(this.lblDetailProcesseur);
            this.panelDetail.Controls.Add(this.lblValeurProcesseur);
            this.panelDetail.Controls.Add(this.lblDetailDisque);
            this.panelDetail.Controls.Add(this.lblValeurDisque);
            this.panelDetail.Controls.Add(this.lblDetailLogiciels);
            this.panelDetail.Controls.Add(this.lblValeurLogiciels);
            this.panelDetail.Controls.Add(this.lblDetailEtat);
            this.panelDetail.Controls.Add(this.lblValeurEtat);
            this.panelDetail.Controls.Add(this.lblDetailSuivi);
            this.panelDetail.Controls.Add(this.lblValeurSuivi);
            this.panelDetail.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            this.panelDetail.Location = new System.Drawing.Point(400, 142);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(588, 64);
            //
            // lblDetailProcesseur
            //
            this.lblDetailProcesseur.AutoSize = true;
            this.lblDetailProcesseur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetailProcesseur.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDetailProcesseur.Location = new System.Drawing.Point(16, 10);
            this.lblDetailProcesseur.Name = "lblDetailProcesseur";
            this.lblDetailProcesseur.Text = "Processeur";
            //
            // lblValeurProcesseur
            //
            this.lblValeurProcesseur.AutoSize = true;
            this.lblValeurProcesseur.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblValeurProcesseur.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValeurProcesseur.Location = new System.Drawing.Point(16, 30);
            this.lblValeurProcesseur.Name = "lblValeurProcesseur";
            this.lblValeurProcesseur.Text = "-";
            //
            // lblDetailDisque
            //
            this.lblDetailDisque.AutoSize = true;
            this.lblDetailDisque.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetailDisque.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDetailDisque.Location = new System.Drawing.Point(134, 10);
            this.lblDetailDisque.Name = "lblDetailDisque";
            this.lblDetailDisque.Text = "Disque";
            //
            // lblValeurDisque
            //
            this.lblValeurDisque.AutoSize = true;
            this.lblValeurDisque.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblValeurDisque.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValeurDisque.Location = new System.Drawing.Point(134, 30);
            this.lblValeurDisque.Name = "lblValeurDisque";
            this.lblValeurDisque.Text = "-";
            //
            // lblDetailLogiciels
            //
            this.lblDetailLogiciels.AutoSize = true;
            this.lblDetailLogiciels.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetailLogiciels.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDetailLogiciels.Location = new System.Drawing.Point(252, 10);
            this.lblDetailLogiciels.Name = "lblDetailLogiciels";
            this.lblDetailLogiciels.Text = "Logiciels";
            //
            // lblValeurLogiciels
            //
            this.lblValeurLogiciels.AutoSize = true;
            this.lblValeurLogiciels.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblValeurLogiciels.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValeurLogiciels.Location = new System.Drawing.Point(252, 30);
            this.lblValeurLogiciels.Name = "lblValeurLogiciels";
            this.lblValeurLogiciels.Text = "-";
            //
            // lblDetailEtat
            //
            this.lblDetailEtat.AutoSize = true;
            this.lblDetailEtat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetailEtat.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDetailEtat.Location = new System.Drawing.Point(370, 10);
            this.lblDetailEtat.Name = "lblDetailEtat";
            this.lblDetailEtat.Text = "État";
            //
            // lblValeurEtat
            //
            this.lblValeurEtat.AutoSize = true;
            this.lblValeurEtat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblValeurEtat.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValeurEtat.Location = new System.Drawing.Point(370, 30);
            this.lblValeurEtat.Name = "lblValeurEtat";
            this.lblValeurEtat.Text = "-";
            //
            // lblDetailSuivi
            //
            this.lblDetailSuivi.AutoSize = true;
            this.lblDetailSuivi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDetailSuivi.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblDetailSuivi.Location = new System.Drawing.Point(488, 10);
            this.lblDetailSuivi.Name = "lblDetailSuivi";
            this.lblDetailSuivi.Text = "Suivi";
            //
            // lblValeurSuivi
            //
            this.lblValeurSuivi.AutoSize = true;
            this.lblValeurSuivi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblValeurSuivi.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblValeurSuivi.Location = new System.Drawing.Point(488, 30);
            this.lblValeurSuivi.Name = "lblValeurSuivi";
            this.lblValeurSuivi.Text = "-";
            //
            // lblSuppression
            //
            this.lblSuppression.AutoSize = true;
            this.lblSuppression.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSuppression.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSuppression.Location = new System.Drawing.Point(400, 226);
            this.lblSuppression.Name = "lblSuppression";
            this.lblSuppression.Text = "Suppression d'un matériel";
            //
            // cboSupprMateriel
            //
            this.cboSupprMateriel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupprMateriel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboSupprMateriel.Location = new System.Drawing.Point(400, 262);
            this.cboSupprMateriel.Name = "cboSupprMateriel";
            this.cboSupprMateriel.Size = new System.Drawing.Size(460, 27);
            this.cboSupprMateriel.TabIndex = 20;
            //
            // btnSupprimerMateriel
            //
            this.btnSupprimerMateriel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnSupprimerMateriel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnSupprimerMateriel.BackColor = System.Drawing.Color.White;
            this.btnSupprimerMateriel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerMateriel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerMateriel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSupprimerMateriel.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnSupprimerMateriel.Location = new System.Drawing.Point(872, 258);
            this.btnSupprimerMateriel.Name = "btnSupprimerMateriel";
            this.btnSupprimerMateriel.Size = new System.Drawing.Size(116, 34);
            this.btnSupprimerMateriel.TabIndex = 21;
            this.btnSupprimerMateriel.Text = "Supprimer";
            this.btnSupprimerMateriel.UseVisualStyleBackColor = false;
            this.btnSupprimerMateriel.Click += new System.EventHandler(this.btnSupprimerMateriel_Click);
            //
            // carteIncidents
            //
            this.carteIncidents.Controls.Add(this.lblIncidents);
            this.carteIncidents.Controls.Add(this.lstIncidents);
            this.carteIncidents.Controls.Add(this.btnPrendreEnCharge);
            this.carteIncidents.BackColor = System.Drawing.Color.White;
            this.carteIncidents.Location = new System.Drawing.Point(16, 372);
            this.carteIncidents.Name = "carteIncidents";
            this.carteIncidents.Size = new System.Drawing.Size(420, 332);
            //
            // lblIncidents
            //
            this.lblIncidents.AutoSize = true;
            this.lblIncidents.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblIncidents.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblIncidents.Location = new System.Drawing.Point(22, 20);
            this.lblIncidents.Name = "lblIncidents";
            this.lblIncidents.Text = "Incidents";
            //
            // lstIncidents
            //
            this.lstIncidents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstIncidents.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lstIncidents.IntegralHeight = false;
            this.lstIncidents.Location = new System.Drawing.Point(24, 60);
            this.lstIncidents.Name = "lstIncidents";
            this.lstIncidents.Size = new System.Drawing.Size(372, 200);
            this.lstIncidents.TabIndex = 22;
            this.lstIncidents.SelectedIndexChanged += new System.EventHandler(this.lstIncidents_SelectedIndexChanged);
            //
            // btnPrendreEnCharge
            //
            this.btnPrendreEnCharge.FlatAppearance.BorderSize = 0;
            this.btnPrendreEnCharge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(27, 74, 184);
            this.btnPrendreEnCharge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 88, 214);
            this.btnPrendreEnCharge.BackColor = System.Drawing.Color.FromArgb(46, 108, 240);
            this.btnPrendreEnCharge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrendreEnCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrendreEnCharge.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnPrendreEnCharge.ForeColor = System.Drawing.Color.White;
            this.btnPrendreEnCharge.Location = new System.Drawing.Point(24, 276);
            this.btnPrendreEnCharge.Name = "btnPrendreEnCharge";
            this.btnPrendreEnCharge.Size = new System.Drawing.Size(180, 38);
            this.btnPrendreEnCharge.TabIndex = 23;
            this.btnPrendreEnCharge.Text = "Prendre en charge";
            this.btnPrendreEnCharge.UseVisualStyleBackColor = false;
            this.btnPrendreEnCharge.Click += new System.EventHandler(this.btnPrendreEnCharge_Click);
            //
            // carteTicket
            //
            this.carteTicket.Controls.Add(this.lblTicketSelection);
            this.carteTicket.Controls.Add(this.lblEtatActuel);
            this.carteTicket.Controls.Add(this.lblEtat);
            this.carteTicket.Controls.Add(this.panelEtat);
            this.carteTicket.Controls.Add(this.lblUrgence);
            this.carteTicket.Controls.Add(this.panelUrgence);
            this.carteTicket.Controls.Add(this.lblSuivi);
            this.carteTicket.Controls.Add(this.txtSuivi);
            this.carteTicket.Controls.Add(this.btnEnregistrer);
            this.carteTicket.BackColor = System.Drawing.Color.White;
            this.carteTicket.Location = new System.Drawing.Point(452, 372);
            this.carteTicket.Name = "carteTicket";
            this.carteTicket.Size = new System.Drawing.Size(576, 332);
            //
            // lblTicketSelection
            //
            this.lblTicketSelection.AutoSize = true;
            this.lblTicketSelection.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTicketSelection.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblTicketSelection.Location = new System.Drawing.Point(22, 20);
            this.lblTicketSelection.Name = "lblTicketSelection";
            this.lblTicketSelection.Text = "Ticket sélectionné";
            //
            // lblEtatActuel
            //
            this.lblEtatActuel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEtatActuel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128);
            this.lblEtatActuel.Location = new System.Drawing.Point(328, 22);
            this.lblEtatActuel.Name = "lblEtatActuel";
            this.lblEtatActuel.Size = new System.Drawing.Size(224, 24);
            this.lblEtatActuel.Text = "État actuel : -";
            this.lblEtatActuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblEtat
            //
            this.lblEtat.AutoSize = true;
            this.lblEtat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblEtat.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblEtat.Location = new System.Drawing.Point(24, 64);
            this.lblEtat.Name = "lblEtat";
            this.lblEtat.Text = "État";
            //
            // panelEtat
            //
            this.panelEtat.Controls.Add(this.rbEnCours);
            this.panelEtat.Controls.Add(this.rbResolu);
            this.panelEtat.Controls.Add(this.rbCloture);
            this.panelEtat.Location = new System.Drawing.Point(24, 86);
            this.panelEtat.Name = "panelEtat";
            this.panelEtat.Size = new System.Drawing.Size(528, 28);
            this.panelEtat.TabIndex = 24;
            //
            // rbEnCours
            //
            this.rbEnCours.AutoSize = true;
            this.rbEnCours.Checked = true;
            this.rbEnCours.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbEnCours.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbEnCours.Location = new System.Drawing.Point(0, 3);
            this.rbEnCours.Name = "rbEnCours";
            this.rbEnCours.TabStop = true;
            this.rbEnCours.Text = "En cours";
            //
            // rbResolu
            //
            this.rbResolu.AutoSize = true;
            this.rbResolu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbResolu.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbResolu.Location = new System.Drawing.Point(110, 3);
            this.rbResolu.Name = "rbResolu";
            this.rbResolu.Text = "Résolu";
            //
            // rbCloture
            //
            this.rbCloture.AutoSize = true;
            this.rbCloture.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCloture.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbCloture.Location = new System.Drawing.Point(220, 3);
            this.rbCloture.Name = "rbCloture";
            this.rbCloture.Text = "Clôturé";
            //
            // lblUrgence
            //
            this.lblUrgence.AutoSize = true;
            this.lblUrgence.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblUrgence.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblUrgence.Location = new System.Drawing.Point(24, 122);
            this.lblUrgence.Name = "lblUrgence";
            this.lblUrgence.Text = "Niveau d'urgence";
            //
            // panelUrgence
            //
            this.panelUrgence.Controls.Add(this.rbFaible);
            this.panelUrgence.Controls.Add(this.rbMoyen);
            this.panelUrgence.Controls.Add(this.rbCritique);
            this.panelUrgence.Location = new System.Drawing.Point(24, 144);
            this.panelUrgence.Name = "panelUrgence";
            this.panelUrgence.Size = new System.Drawing.Size(528, 28);
            this.panelUrgence.TabIndex = 25;
            //
            // rbFaible
            //
            this.rbFaible.AutoSize = true;
            this.rbFaible.Checked = true;
            this.rbFaible.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbFaible.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbFaible.Location = new System.Drawing.Point(0, 3);
            this.rbFaible.Name = "rbFaible";
            this.rbFaible.TabStop = true;
            this.rbFaible.Text = "Faible";
            //
            // rbMoyen
            //
            this.rbMoyen.AutoSize = true;
            this.rbMoyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbMoyen.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbMoyen.Location = new System.Drawing.Point(110, 3);
            this.rbMoyen.Name = "rbMoyen";
            this.rbMoyen.Text = "Moyen";
            //
            // rbCritique
            //
            this.rbCritique.AutoSize = true;
            this.rbCritique.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCritique.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbCritique.Location = new System.Drawing.Point(220, 3);
            this.rbCritique.Name = "rbCritique";
            this.rbCritique.Text = "Critique";
            //
            // lblSuivi
            //
            this.lblSuivi.AutoSize = true;
            this.lblSuivi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblSuivi.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblSuivi.Location = new System.Drawing.Point(24, 180);
            this.lblSuivi.Name = "lblSuivi";
            this.lblSuivi.Text = "Suivi (travail effectué)";
            //
            // txtSuivi
            //
            this.txtSuivi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuivi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSuivi.Location = new System.Drawing.Point(24, 202);
            this.txtSuivi.Multiline = true;
            this.txtSuivi.Name = "txtSuivi";
            this.txtSuivi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSuivi.Size = new System.Drawing.Size(528, 72);
            this.txtSuivi.TabIndex = 26;
            //
            // btnEnregistrer
            //
            this.btnEnregistrer.FlatAppearance.BorderSize = 0;
            this.btnEnregistrer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(27, 74, 184);
            this.btnEnregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 88, 214);
            this.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(46, 108, 240);
            this.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrer.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnEnregistrer.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrer.Location = new System.Drawing.Point(24, 286);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(150, 38);
            this.btnEnregistrer.TabIndex = 27;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = false;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            //
            // cartePersonnel
            //
            this.cartePersonnel.Controls.Add(this.lblType);
            this.cartePersonnel.Controls.Add(this.panelType);
            this.cartePersonnel.Controls.Add(this.lblPersonne);
            this.cartePersonnel.Controls.Add(this.cboPersonne);
            this.cartePersonnel.Controls.Add(this.separateurPersonnel);
            this.cartePersonnel.Controls.Add(this.lblNom);
            this.cartePersonnel.Controls.Add(this.txtNom);
            this.cartePersonnel.Controls.Add(this.lblPrenom);
            this.cartePersonnel.Controls.Add(this.txtPrenom);
            this.cartePersonnel.Controls.Add(this.lblDateEmbauche);
            this.cartePersonnel.Controls.Add(this.dtpDateEmbauche);
            this.cartePersonnel.Controls.Add(this.lblPostePersonne);
            this.cartePersonnel.Controls.Add(this.txtPostePersonne);
            this.cartePersonnel.Controls.Add(this.lblLoginPersonne);
            this.cartePersonnel.Controls.Add(this.txtLoginPersonne);
            this.cartePersonnel.Controls.Add(this.lblMdpPersonne);
            this.cartePersonnel.Controls.Add(this.txtMdpPersonne);
            this.cartePersonnel.Controls.Add(this.panelTechnicien);
            this.cartePersonnel.Controls.Add(this.btnAjouterPersonne);
            this.cartePersonnel.Controls.Add(this.btnModifierPersonne);
            this.cartePersonnel.Controls.Add(this.btnSupprimerPersonne);
            this.cartePersonnel.BackColor = System.Drawing.Color.White;
            this.cartePersonnel.Location = new System.Drawing.Point(16, 16);
            this.cartePersonnel.Name = "cartePersonnel";
            this.cartePersonnel.Size = new System.Drawing.Size(772, 492);
            //
            // lblType
            //
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblType.Location = new System.Drawing.Point(24, 20);
            this.lblType.Name = "lblType";
            this.lblType.Text = "Type de compte";
            //
            // panelType
            //
            this.panelType.Controls.Add(this.rbTechnicien);
            this.panelType.Controls.Add(this.rbUtilisateur);
            this.panelType.Location = new System.Drawing.Point(24, 42);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(260, 28);
            this.panelType.TabIndex = 28;
            //
            // rbTechnicien
            //
            this.rbTechnicien.AutoSize = true;
            this.rbTechnicien.Checked = true;
            this.rbTechnicien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbTechnicien.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbTechnicien.Location = new System.Drawing.Point(0, 3);
            this.rbTechnicien.Name = "rbTechnicien";
            this.rbTechnicien.TabStop = true;
            this.rbTechnicien.Text = "Technicien";
            this.rbTechnicien.CheckedChanged += new System.EventHandler(this.rbTechnicien_CheckedChanged);
            //
            // rbUtilisateur
            //
            this.rbUtilisateur.AutoSize = true;
            this.rbUtilisateur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbUtilisateur.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.rbUtilisateur.Location = new System.Drawing.Point(110, 3);
            this.rbUtilisateur.Name = "rbUtilisateur";
            this.rbUtilisateur.Text = "Utilisateur";
            //
            // lblPersonne
            //
            this.lblPersonne.AutoSize = true;
            this.lblPersonne.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblPersonne.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPersonne.Location = new System.Drawing.Point(300, 20);
            this.lblPersonne.Name = "lblPersonne";
            this.lblPersonne.Text = "Personne à modifier ou supprimer";
            //
            // cboPersonne
            //
            this.cboPersonne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonne.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboPersonne.Location = new System.Drawing.Point(300, 42);
            this.cboPersonne.Name = "cboPersonne";
            this.cboPersonne.Size = new System.Drawing.Size(448, 27);
            this.cboPersonne.TabIndex = 29;
            this.cboPersonne.SelectedIndexChanged += new System.EventHandler(this.cboPersonne_SelectedIndexChanged);
            //
            // separateurPersonnel
            //
            this.separateurPersonnel.BackColor = System.Drawing.Color.FromArgb(229, 231, 235);
            this.separateurPersonnel.Location = new System.Drawing.Point(24, 88);
            this.separateurPersonnel.Name = "separateurPersonnel";
            this.separateurPersonnel.Size = new System.Drawing.Size(724, 1);
            //
            // lblNom
            //
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblNom.Location = new System.Drawing.Point(24, 108);
            this.lblNom.Name = "lblNom";
            this.lblNom.Text = "Nom";
            //
            // txtNom
            //
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtNom.Location = new System.Drawing.Point(24, 130);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(356, 26);
            this.txtNom.TabIndex = 30;
            //
            // lblPrenom
            //
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblPrenom.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPrenom.Location = new System.Drawing.Point(392, 108);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Text = "Prénom";
            //
            // txtPrenom
            //
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPrenom.Location = new System.Drawing.Point(392, 130);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(356, 26);
            this.txtPrenom.TabIndex = 31;
            //
            // lblDateEmbauche
            //
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblDateEmbauche.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblDateEmbauche.Location = new System.Drawing.Point(24, 172);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Text = "Date d'embauche";
            //
            // dtpDateEmbauche
            //
            this.dtpDateEmbauche.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtpDateEmbauche.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEmbauche.Location = new System.Drawing.Point(24, 194);
            this.dtpDateEmbauche.Name = "dtpDateEmbauche";
            this.dtpDateEmbauche.Size = new System.Drawing.Size(356, 26);
            this.dtpDateEmbauche.TabIndex = 32;
            //
            // lblPostePersonne
            //
            this.lblPostePersonne.AutoSize = true;
            this.lblPostePersonne.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblPostePersonne.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblPostePersonne.Location = new System.Drawing.Point(392, 172);
            this.lblPostePersonne.Name = "lblPostePersonne";
            this.lblPostePersonne.Text = "Poste";
            //
            // txtPostePersonne
            //
            this.txtPostePersonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostePersonne.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtPostePersonne.Location = new System.Drawing.Point(392, 194);
            this.txtPostePersonne.Name = "txtPostePersonne";
            this.txtPostePersonne.Size = new System.Drawing.Size(356, 26);
            this.txtPostePersonne.TabIndex = 33;
            //
            // lblLoginPersonne
            //
            this.lblLoginPersonne.AutoSize = true;
            this.lblLoginPersonne.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblLoginPersonne.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblLoginPersonne.Location = new System.Drawing.Point(24, 236);
            this.lblLoginPersonne.Name = "lblLoginPersonne";
            this.lblLoginPersonne.Text = "Login";
            //
            // txtLoginPersonne
            //
            this.txtLoginPersonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPersonne.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtLoginPersonne.Location = new System.Drawing.Point(24, 258);
            this.txtLoginPersonne.Name = "txtLoginPersonne";
            this.txtLoginPersonne.Size = new System.Drawing.Size(356, 26);
            this.txtLoginPersonne.TabIndex = 34;
            //
            // lblMdpPersonne
            //
            this.lblMdpPersonne.AutoSize = true;
            this.lblMdpPersonne.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblMdpPersonne.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblMdpPersonne.Location = new System.Drawing.Point(392, 236);
            this.lblMdpPersonne.Name = "lblMdpPersonne";
            this.lblMdpPersonne.Text = "Mot de passe";
            //
            // txtMdpPersonne
            //
            this.txtMdpPersonne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMdpPersonne.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMdpPersonne.Location = new System.Drawing.Point(392, 258);
            this.txtMdpPersonne.Name = "txtMdpPersonne";
            this.txtMdpPersonne.Size = new System.Drawing.Size(356, 26);
            this.txtMdpPersonne.TabIndex = 35;
            this.txtMdpPersonne.UseSystemPasswordChar = true;
            //
            // panelTechnicien
            //
            this.panelTechnicien.Controls.Add(this.lblFormation);
            this.panelTechnicien.Controls.Add(this.txtFormation);
            this.panelTechnicien.Controls.Add(this.lblCompetence);
            this.panelTechnicien.Controls.Add(this.txtCompetence);
            this.panelTechnicien.BackColor = System.Drawing.Color.FromArgb(248, 249, 251);
            this.panelTechnicien.Location = new System.Drawing.Point(24, 304);
            this.panelTechnicien.Name = "panelTechnicien";
            this.panelTechnicien.Size = new System.Drawing.Size(724, 96);
            //
            // lblFormation
            //
            this.lblFormation.AutoSize = true;
            this.lblFormation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblFormation.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblFormation.Location = new System.Drawing.Point(16, 12);
            this.lblFormation.Name = "lblFormation";
            this.lblFormation.Text = "Formation";
            //
            // txtFormation
            //
            this.txtFormation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFormation.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtFormation.Location = new System.Drawing.Point(16, 34);
            this.txtFormation.Name = "txtFormation";
            this.txtFormation.Size = new System.Drawing.Size(336, 26);
            this.txtFormation.TabIndex = 36;
            //
            // lblCompetence
            //
            this.lblCompetence.AutoSize = true;
            this.lblCompetence.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.lblCompetence.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.lblCompetence.Location = new System.Drawing.Point(372, 12);
            this.lblCompetence.Name = "lblCompetence";
            this.lblCompetence.Text = "Compétence";
            //
            // txtCompetence
            //
            this.txtCompetence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompetence.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtCompetence.Location = new System.Drawing.Point(372, 34);
            this.txtCompetence.Name = "txtCompetence";
            this.txtCompetence.Size = new System.Drawing.Size(336, 26);
            this.txtCompetence.TabIndex = 37;
            //
            // btnAjouterPersonne
            //
            this.btnAjouterPersonne.FlatAppearance.BorderSize = 0;
            this.btnAjouterPersonne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(27, 74, 184);
            this.btnAjouterPersonne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(31, 88, 214);
            this.btnAjouterPersonne.BackColor = System.Drawing.Color.FromArgb(46, 108, 240);
            this.btnAjouterPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjouterPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPersonne.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAjouterPersonne.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPersonne.Location = new System.Drawing.Point(24, 424);
            this.btnAjouterPersonne.Name = "btnAjouterPersonne";
            this.btnAjouterPersonne.Size = new System.Drawing.Size(120, 40);
            this.btnAjouterPersonne.TabIndex = 38;
            this.btnAjouterPersonne.Text = "Ajouter";
            this.btnAjouterPersonne.UseVisualStyleBackColor = false;
            this.btnAjouterPersonne.Click += new System.EventHandler(this.btnAjouterPersonne_Click);
            //
            // btnModifierPersonne
            //
            this.btnModifierPersonne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(209, 213, 219);
            this.btnModifierPersonne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.btnModifierPersonne.BackColor = System.Drawing.Color.White;
            this.btnModifierPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModifierPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifierPersonne.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnModifierPersonne.ForeColor = System.Drawing.Color.FromArgb(31, 41, 55);
            this.btnModifierPersonne.Location = new System.Drawing.Point(156, 424);
            this.btnModifierPersonne.Name = "btnModifierPersonne";
            this.btnModifierPersonne.Size = new System.Drawing.Size(120, 40);
            this.btnModifierPersonne.TabIndex = 39;
            this.btnModifierPersonne.Text = "Modifier";
            this.btnModifierPersonne.UseVisualStyleBackColor = false;
            this.btnModifierPersonne.Click += new System.EventHandler(this.btnModifierPersonne_Click);
            //
            // btnSupprimerPersonne
            //
            this.btnSupprimerPersonne.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnSupprimerPersonne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnSupprimerPersonne.BackColor = System.Drawing.Color.White;
            this.btnSupprimerPersonne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerPersonne.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSupprimerPersonne.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnSupprimerPersonne.Location = new System.Drawing.Point(288, 424);
            this.btnSupprimerPersonne.Name = "btnSupprimerPersonne";
            this.btnSupprimerPersonne.Size = new System.Drawing.Size(120, 40);
            this.btnSupprimerPersonne.TabIndex = 40;
            this.btnSupprimerPersonne.Text = "Supprimer";
            this.btnSupprimerPersonne.UseVisualStyleBackColor = false;
            this.btnSupprimerPersonne.Click += new System.EventHandler(this.btnSupprimerPersonne_Click);
            //
            // FormPrincipal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(243, 244, 246);
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.panelEntete);
            this.Controls.Add(this.tabMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Support informatique";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelTechnicien.ResumeLayout(false);
            this.panelTechnicien.PerformLayout();
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            this.cartePersonnel.ResumeLayout(false);
            this.cartePersonnel.PerformLayout();
            this.panelUrgence.ResumeLayout(false);
            this.panelUrgence.PerformLayout();
            this.panelEtat.ResumeLayout(false);
            this.panelEtat.PerformLayout();
            this.carteTicket.ResumeLayout(false);
            this.carteTicket.PerformLayout();
            this.carteIncidents.ResumeLayout(false);
            this.carteIncidents.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.carteMateriel.ResumeLayout(false);
            this.carteMateriel.PerformLayout();
            this.carteTickets.ResumeLayout(false);
            this.carteTickets.PerformLayout();
            this.panelDeclUrgence.ResumeLayout(false);
            this.panelDeclUrgence.PerformLayout();
            this.carteNouveau.ResumeLayout(false);
            this.carteNouveau.PerformLayout();
            this.carteConnexion.ResumeLayout(false);
            this.carteConnexion.PerformLayout();
            this.tabResponsable.ResumeLayout(false);
            this.tabTechnicien.ResumeLayout(false);
            this.tabUtilisateur.ResumeLayout(false);
            this.tabConnexion.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.panelEntete.ResumeLayout(false);
            this.panelEntete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabConnexion;
        private System.Windows.Forms.TabPage tabUtilisateur;
        private System.Windows.Forms.TabPage tabTechnicien;
        private System.Windows.Forms.TabPage tabResponsable;
        private System.Windows.Forms.Panel carteConnexion;
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
        private System.Windows.Forms.Panel carteNouveau;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.Label lblMateriel;
        private System.Windows.Forms.ComboBox cboMateriel;
        private System.Windows.Forms.Label lblDeclUrgence;
        private System.Windows.Forms.Panel panelDeclUrgence;
        private System.Windows.Forms.RadioButton rbDeclFaible;
        private System.Windows.Forms.RadioButton rbDeclMoyen;
        private System.Windows.Forms.RadioButton rbDeclCritique;
        private System.Windows.Forms.Label lblIncident;
        private System.Windows.Forms.TextBox txtIncident;
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Panel carteTickets;
        private System.Windows.Forms.Label lblMesTickets;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Panel carteMateriel;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.Label lblAjout;
        private System.Windows.Forms.Label lblProcesseur;
        private System.Windows.Forms.TextBox txtProcesseur;
        private System.Windows.Forms.Label lblDisque;
        private System.Windows.Forms.TextBox txtDisque;
        private System.Windows.Forms.Label lblLogiciels;
        private System.Windows.Forms.TextBox txtLogiciels;
        private System.Windows.Forms.Label lblEtatMateriel;
        private System.Windows.Forms.ComboBox cboEtatMateriel;
        private System.Windows.Forms.Label lblSuiviMateriel;
        private System.Windows.Forms.TextBox txtSuiviMateriel;
        private System.Windows.Forms.Button btnAjouterMateriel;
        private System.Windows.Forms.Panel separateurMateriel;
        private System.Windows.Forms.Label lblConsultation;
        private System.Windows.Forms.ComboBox cboConsultMateriel;
        private System.Windows.Forms.Button btnAfficherMateriel;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label lblDetailProcesseur;
        private System.Windows.Forms.Label lblValeurProcesseur;
        private System.Windows.Forms.Label lblDetailDisque;
        private System.Windows.Forms.Label lblValeurDisque;
        private System.Windows.Forms.Label lblDetailLogiciels;
        private System.Windows.Forms.Label lblValeurLogiciels;
        private System.Windows.Forms.Label lblDetailEtat;
        private System.Windows.Forms.Label lblValeurEtat;
        private System.Windows.Forms.Label lblDetailSuivi;
        private System.Windows.Forms.Label lblValeurSuivi;
        private System.Windows.Forms.Label lblSuppression;
        private System.Windows.Forms.ComboBox cboSupprMateriel;
        private System.Windows.Forms.Button btnSupprimerMateriel;
        private System.Windows.Forms.Panel carteIncidents;
        private System.Windows.Forms.Label lblIncidents;
        private System.Windows.Forms.ListBox lstIncidents;
        private System.Windows.Forms.Button btnPrendreEnCharge;
        private System.Windows.Forms.Panel carteTicket;
        private System.Windows.Forms.Label lblTicketSelection;
        private System.Windows.Forms.Label lblEtatActuel;
        private System.Windows.Forms.Label lblEtat;
        private System.Windows.Forms.Panel panelEtat;
        private System.Windows.Forms.RadioButton rbEnCours;
        private System.Windows.Forms.RadioButton rbResolu;
        private System.Windows.Forms.RadioButton rbCloture;
        private System.Windows.Forms.Label lblUrgence;
        private System.Windows.Forms.Panel panelUrgence;
        private System.Windows.Forms.RadioButton rbFaible;
        private System.Windows.Forms.RadioButton rbMoyen;
        private System.Windows.Forms.RadioButton rbCritique;
        private System.Windows.Forms.Label lblSuivi;
        private System.Windows.Forms.TextBox txtSuivi;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Panel cartePersonnel;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.RadioButton rbTechnicien;
        private System.Windows.Forms.RadioButton rbUtilisateur;
        private System.Windows.Forms.Label lblPersonne;
        private System.Windows.Forms.ComboBox cboPersonne;
        private System.Windows.Forms.Panel separateurPersonnel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.DateTimePicker dtpDateEmbauche;
        private System.Windows.Forms.Label lblPostePersonne;
        private System.Windows.Forms.TextBox txtPostePersonne;
        private System.Windows.Forms.Label lblLoginPersonne;
        private System.Windows.Forms.TextBox txtLoginPersonne;
        private System.Windows.Forms.Label lblMdpPersonne;
        private System.Windows.Forms.TextBox txtMdpPersonne;
        private System.Windows.Forms.Panel panelTechnicien;
        private System.Windows.Forms.Label lblFormation;
        private System.Windows.Forms.TextBox txtFormation;
        private System.Windows.Forms.Label lblCompetence;
        private System.Windows.Forms.TextBox txtCompetence;
        private System.Windows.Forms.Button btnAjouterPersonne;
        private System.Windows.Forms.Button btnModifierPersonne;
        private System.Windows.Forms.Button btnSupprimerPersonne;
    }
}
