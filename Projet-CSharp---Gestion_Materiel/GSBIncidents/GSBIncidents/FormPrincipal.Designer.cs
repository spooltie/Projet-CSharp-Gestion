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
            panelEntete = new Panel();
            lblApplication = new Label();
            lblUtilisateur = new Label();
            btnDeconnexion = new Button();
            tabMenu = new TabControl();
            tabConnexion = new TabPage();
            carteConnexion = new Panel();
            lblTitre = new Label();
            lblSousTitre = new Label();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblMotDePasse = new Label();
            txtMotDePasse = new TextBox();
            lblPoste = new Label();
            cboPoste = new ComboBox();
            chkResterConnecte = new CheckBox();
            btnSeConnecter = new Button();
            tabUtilisateur = new TabPage();
            carteNouveau = new Panel();
            lblNouveau = new Label();
            lblMateriel = new Label();
            cboMateriel = new ComboBox();
            lblIncident = new Label();
            txtIncident = new TextBox();
            btnEnvoyer = new Button();
            btnAfficher = new Button();
            carteTickets = new Panel();
            lblMesTickets = new Label();
            lstTickets = new ListBox();
            tabTechnicien = new TabPage();
            carteMateriel = new Panel();
            lblGestion = new Label();
            lblAjout = new Label();
            lblProcesseur = new Label();
            txtProcesseur = new TextBox();
            lblDisque = new Label();
            txtDisque = new TextBox();
            lblLogiciels = new Label();
            txtLogiciels = new TextBox();
            lblEtatMateriel = new Label();
            cboEtatMateriel = new ComboBox();
            lblSuiviMateriel = new Label();
            txtSuiviMateriel = new TextBox();
            btnAjouterMateriel = new Button();
            separateurMateriel = new Panel();
            lblConsultation = new Label();
            cboConsultMateriel = new ComboBox();
            btnAfficherMateriel = new Button();
            panelDetail = new Panel();
            lblDetailProcesseur = new Label();
            lblValeurProcesseur = new Label();
            lblDetailDisque = new Label();
            lblValeurDisque = new Label();
            lblDetailLogiciels = new Label();
            lblValeurLogiciels = new Label();
            lblDetailEtat = new Label();
            lblValeurEtat = new Label();
            lblDetailSuivi = new Label();
            lblValeurSuivi = new Label();
            lblSuppression = new Label();
            cboSupprMateriel = new ComboBox();
            btnSupprimerMateriel = new Button();
            carteIncidents = new Panel();
            lblIncidents = new Label();
            lstIncidents = new ListBox();
            btnPrendreEnCharge = new Button();
            carteTicket = new Panel();
            lblTicketSelection = new Label();
            lblEtatActuel = new Label();
            lblEtat = new Label();
            panelEtat = new Panel();
            rbEnCours = new RadioButton();
            rbResolu = new RadioButton();
            rbCloture = new RadioButton();
            lblUrgence = new Label();
            panelUrgence = new Panel();
            rbFaible = new RadioButton();
            rbMoyen = new RadioButton();
            rbCritique = new RadioButton();
            lblSuivi = new Label();
            txtSuivi = new TextBox();
            btnEnregistrer = new Button();
            tabResponsable = new TabPage();
            cartePersonnel = new Panel();
            lblType = new Label();
            panelType = new Panel();
            rbTechnicien = new RadioButton();
            rbUtilisateur = new RadioButton();
            lblPersonne = new Label();
            cboPersonne = new ComboBox();
            separateurPersonnel = new Panel();
            lblNom = new Label();
            txtNom = new TextBox();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblDateEmbauche = new Label();
            dtpDateEmbauche = new DateTimePicker();
            lblPostePersonne = new Label();
            txtPostePersonne = new TextBox();
            lblLoginPersonne = new Label();
            txtLoginPersonne = new TextBox();
            lblMdpPersonne = new Label();
            txtMdpPersonne = new TextBox();
            panelTechnicien = new Panel();
            lblFormation = new Label();
            txtFormation = new TextBox();
            lblCompetence = new Label();
            txtCompetence = new TextBox();
            btnAjouterPersonne = new Button();
            btnModifierPersonne = new Button();
            btnSupprimerPersonne = new Button();
            panelEntete.SuspendLayout();
            tabMenu.SuspendLayout();
            tabConnexion.SuspendLayout();
            carteConnexion.SuspendLayout();
            tabUtilisateur.SuspendLayout();
            carteNouveau.SuspendLayout();
            carteTickets.SuspendLayout();
            tabTechnicien.SuspendLayout();
            carteMateriel.SuspendLayout();
            panelDetail.SuspendLayout();
            carteIncidents.SuspendLayout();
            carteTicket.SuspendLayout();
            panelEtat.SuspendLayout();
            panelUrgence.SuspendLayout();
            tabResponsable.SuspendLayout();
            cartePersonnel.SuspendLayout();
            panelType.SuspendLayout();
            panelTechnicien.SuspendLayout();
            SuspendLayout();
            // 
            // panelEntete
            // 
            panelEntete.Controls.Add(lblApplication);
            panelEntete.Controls.Add(lblUtilisateur);
            panelEntete.Controls.Add(btnDeconnexion);
            panelEntete.Name = "panelEntete";
            panelEntete.Location = new Point(0, 0);
            panelEntete.Size = new Size(1280, 56);
            panelEntete.BackColor = Color.FromArgb(12, 68, 124);
            panelEntete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEntete.TabIndex = 0;
            // 
            // lblApplication
            // 
            lblApplication.Name = "lblApplication";
            lblApplication.Location = new Point(20, 15);
            lblApplication.AutoSize = true;
            lblApplication.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblApplication.ForeColor = Color.White;
            lblApplication.TabIndex = 0;
            lblApplication.Text = "Support informatique";
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Location = new Point(860, 18);
            lblUtilisateur.Size = new Size(250, 20);
            lblUtilisateur.Font = new Font("Segoe UI", 10F);
            lblUtilisateur.ForeColor = Color.FromArgb(230, 241, 251);
            lblUtilisateur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUtilisateur.TabIndex = 1;
            lblUtilisateur.Text = "Nom Prénom";
            lblUtilisateur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Location = new Point(1124, 12);
            btnDeconnexion.Size = new Size(140, 32);
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.Cursor = Cursors.Hand;
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Font = new Font("Segoe UI Semibold", 10F);
            btnDeconnexion.BackColor = Color.FromArgb(12, 68, 124);
            btnDeconnexion.ForeColor = Color.White;
            btnDeconnexion.FlatAppearance.BorderColor = Color.FromArgb(55, 138, 221);
            btnDeconnexion.FlatAppearance.BorderSize = 1;
            btnDeconnexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 95, 165);
            btnDeconnexion.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnDeconnexion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeconnexion.TabIndex = 0;
            btnDeconnexion.Text = "Se déconnecter";
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(tabConnexion);
            tabMenu.Controls.Add(tabUtilisateur);
            tabMenu.Controls.Add(tabTechnicien);
            tabMenu.Controls.Add(tabResponsable);
            tabMenu.Name = "tabMenu";
            tabMenu.Location = new Point(0, 56);
            tabMenu.Size = new Size(1280, 664);
            tabMenu.Font = new Font("Segoe UI", 10F);
            tabMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabMenu.Padding = new Point(16, 6);
            tabMenu.SelectedIndex = 0;
            tabMenu.TabIndex = 1;
            // 
            // tabConnexion
            // 
            tabConnexion.Controls.Add(carteConnexion);
            tabConnexion.Name = "tabConnexion";
            tabConnexion.Location = new Point(4, 32);
            tabConnexion.Size = new Size(1272, 628);
            tabConnexion.BackColor = Color.FromArgb(238, 242, 247);
            tabConnexion.Padding = new Padding(3);
            tabConnexion.TabIndex = 2;
            tabConnexion.Text = "Connexion";
            // 
            // carteConnexion
            // 
            carteConnexion.Controls.Add(lblTitre);
            carteConnexion.Controls.Add(lblSousTitre);
            carteConnexion.Controls.Add(lblLogin);
            carteConnexion.Controls.Add(txtLogin);
            carteConnexion.Controls.Add(lblMotDePasse);
            carteConnexion.Controls.Add(txtMotDePasse);
            carteConnexion.Controls.Add(lblPoste);
            carteConnexion.Controls.Add(cboPoste);
            carteConnexion.Controls.Add(chkResterConnecte);
            carteConnexion.Controls.Add(btnSeConnecter);
            carteConnexion.Name = "carteConnexion";
            carteConnexion.Location = new Point(446, 114);
            carteConnexion.Size = new Size(380, 400);
            carteConnexion.BackColor = Color.White;
            carteConnexion.Anchor = AnchorStyles.None;
            carteConnexion.TabIndex = 0;
            // 
            // lblTitre
            // 
            lblTitre.Name = "lblTitre";
            lblTitre.Location = new Point(30, 26);
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(12, 68, 124);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Connexion";
            // 
            // lblSousTitre
            // 
            lblSousTitre.Name = "lblSousTitre";
            lblSousTitre.Location = new Point(33, 68);
            lblSousTitre.AutoSize = true;
            lblSousTitre.Font = new Font("Segoe UI", 10F);
            lblSousTitre.ForeColor = Color.FromArgb(90, 107, 128);
            lblSousTitre.TabIndex = 1;
            lblSousTitre.Text = "Connectez-vous pour accéder à votre compte.";
            // 
            // lblLogin
            // 
            lblLogin.Name = "lblLogin";
            lblLogin.Location = new Point(32, 104);
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLogin.ForeColor = Color.FromArgb(71, 85, 105);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.Name = "txtLogin";
            txtLogin.Location = new Point(32, 126);
            txtLogin.Size = new Size(316, 26);
            txtLogin.Font = new Font("Segoe UI", 10.5F);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.BackColor = Color.FromArgb(245, 248, 251);
            txtLogin.ForeColor = Color.FromArgb(27, 42, 61);
            txtLogin.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Location = new Point(32, 166);
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMotDePasse.ForeColor = Color.FromArgb(71, 85, 105);
            lblMotDePasse.TabIndex = 3;
            lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Location = new Point(32, 188);
            txtMotDePasse.Size = new Size(316, 26);
            txtMotDePasse.Font = new Font("Segoe UI", 10.5F);
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.BackColor = Color.FromArgb(245, 248, 251);
            txtMotDePasse.ForeColor = Color.FromArgb(27, 42, 61);
            txtMotDePasse.TabIndex = 1;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // lblPoste
            // 
            lblPoste.Name = "lblPoste";
            lblPoste.Location = new Point(32, 228);
            lblPoste.AutoSize = true;
            lblPoste.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPoste.ForeColor = Color.FromArgb(71, 85, 105);
            lblPoste.TabIndex = 4;
            lblPoste.Text = "Poste";
            // 
            // cboPoste
            // 
            cboPoste.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPoste.Items.AddRange(new object[] { "Utilisateur", "Technicien", "Responsable" });
            cboPoste.Name = "cboPoste";
            cboPoste.Location = new Point(32, 250);
            cboPoste.Size = new Size(316, 26);
            cboPoste.Font = new Font("Segoe UI", 10.5F);
            cboPoste.FlatStyle = FlatStyle.Flat;
            cboPoste.BackColor = Color.FromArgb(245, 248, 251);
            cboPoste.ForeColor = Color.FromArgb(27, 42, 61);
            cboPoste.TabIndex = 2;
            // 
            // chkResterConnecte
            // 
            chkResterConnecte.Name = "chkResterConnecte";
            chkResterConnecte.Location = new Point(32, 292);
            chkResterConnecte.AutoSize = true;
            chkResterConnecte.Font = new Font("Segoe UI", 9.75F);
            chkResterConnecte.ForeColor = Color.FromArgb(90, 107, 128);
            chkResterConnecte.TabIndex = 3;
            chkResterConnecte.Text = "Rester connecté";
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.Location = new Point(32, 330);
            btnSeConnecter.Size = new Size(316, 40);
            btnSeConnecter.FlatStyle = FlatStyle.Flat;
            btnSeConnecter.Cursor = Cursors.Hand;
            btnSeConnecter.UseVisualStyleBackColor = false;
            btnSeConnecter.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSeConnecter.BackColor = Color.FromArgb(24, 95, 165);
            btnSeConnecter.ForeColor = Color.White;
            btnSeConnecter.FlatAppearance.BorderSize = 0;
            btnSeConnecter.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnSeConnecter.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnSeConnecter.TabIndex = 4;
            btnSeConnecter.Text = "Se connecter";
            btnSeConnecter.Click += btnSeConnecter_Click;
            // 
            // tabUtilisateur
            // 
            tabUtilisateur.Controls.Add(carteNouveau);
            tabUtilisateur.Controls.Add(carteTickets);
            tabUtilisateur.Name = "tabUtilisateur";
            tabUtilisateur.Location = new Point(4, 32);
            tabUtilisateur.Size = new Size(1272, 628);
            tabUtilisateur.BackColor = Color.FromArgb(238, 242, 247);
            tabUtilisateur.Padding = new Padding(3);
            tabUtilisateur.TabIndex = 3;
            tabUtilisateur.Text = "Utilisateur";
            // 
            // carteNouveau
            // 
            carteNouveau.Controls.Add(lblNouveau);
            carteNouveau.Controls.Add(lblMateriel);
            carteNouveau.Controls.Add(cboMateriel);
            carteNouveau.Controls.Add(lblIncident);
            carteNouveau.Controls.Add(txtIncident);
            carteNouveau.Controls.Add(btnEnvoyer);
            carteNouveau.Controls.Add(btnAfficher);
            carteNouveau.Name = "carteNouveau";
            carteNouveau.Location = new Point(16, 16);
            carteNouveau.Size = new Size(480, 596);
            carteNouveau.BackColor = Color.White;
            carteNouveau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            carteNouveau.TabIndex = 0;
            // 
            // lblNouveau
            // 
            lblNouveau.Name = "lblNouveau";
            lblNouveau.Location = new Point(22, 18);
            lblNouveau.AutoSize = true;
            lblNouveau.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNouveau.ForeColor = Color.FromArgb(12, 68, 124);
            lblNouveau.TabIndex = 0;
            lblNouveau.Text = "Nouveau ticket";
            // 
            // lblMateriel
            // 
            lblMateriel.Name = "lblMateriel";
            lblMateriel.Location = new Point(24, 64);
            lblMateriel.AutoSize = true;
            lblMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMateriel.ForeColor = Color.FromArgb(71, 85, 105);
            lblMateriel.TabIndex = 1;
            lblMateriel.Text = "Matériel concerné";
            // 
            // cboMateriel
            // 
            cboMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateriel.Name = "cboMateriel";
            cboMateriel.Location = new Point(24, 86);
            cboMateriel.Size = new Size(432, 26);
            cboMateriel.Font = new Font("Segoe UI", 10.5F);
            cboMateriel.FlatStyle = FlatStyle.Flat;
            cboMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboMateriel.TabIndex = 6;
            // 
            // lblIncident
            // 
            lblIncident.Name = "lblIncident";
            lblIncident.Location = new Point(24, 128);
            lblIncident.AutoSize = true;
            lblIncident.Font = new Font("Segoe UI Semibold", 9.75F);
            lblIncident.ForeColor = Color.FromArgb(71, 85, 105);
            lblIncident.TabIndex = 8;
            lblIncident.Text = "Description de l'incident";
            // 
            // txtIncident
            // 
            txtIncident.Multiline = true;
            txtIncident.Name = "txtIncident";
            txtIncident.Location = new Point(24, 150);
            txtIncident.Size = new Size(432, 370);
            txtIncident.Font = new Font("Segoe UI", 10.5F);
            txtIncident.BorderStyle = BorderStyle.FixedSingle;
            txtIncident.BackColor = Color.FromArgb(245, 248, 251);
            txtIncident.ForeColor = Color.FromArgb(27, 42, 61);
            txtIncident.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIncident.ScrollBars = ScrollBars.Vertical;
            txtIncident.TabIndex = 8;
            // 
            // btnEnvoyer
            // 
            btnEnvoyer.Name = "btnEnvoyer";
            btnEnvoyer.Location = new Point(24, 536);
            btnEnvoyer.Size = new Size(140, 38);
            btnEnvoyer.FlatStyle = FlatStyle.Flat;
            btnEnvoyer.Cursor = Cursors.Hand;
            btnEnvoyer.UseVisualStyleBackColor = false;
            btnEnvoyer.Font = new Font("Segoe UI Semibold", 10F);
            btnEnvoyer.BackColor = Color.FromArgb(24, 95, 165);
            btnEnvoyer.ForeColor = Color.White;
            btnEnvoyer.FlatAppearance.BorderSize = 0;
            btnEnvoyer.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnEnvoyer.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnEnvoyer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnvoyer.TabIndex = 9;
            btnEnvoyer.Text = "Envoyer";
            btnEnvoyer.Click += btnEnvoyer_Click;
            // 
            // btnAfficher
            // 
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Location = new Point(176, 536);
            btnAfficher.Size = new Size(190, 38);
            btnAfficher.FlatStyle = FlatStyle.Flat;
            btnAfficher.Cursor = Cursors.Hand;
            btnAfficher.UseVisualStyleBackColor = false;
            btnAfficher.Font = new Font("Segoe UI Semibold", 10F);
            btnAfficher.BackColor = Color.White;
            btnAfficher.ForeColor = Color.FromArgb(24, 95, 165);
            btnAfficher.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnAfficher.FlatAppearance.BorderSize = 1;
            btnAfficher.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnAfficher.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnAfficher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAfficher.TabIndex = 10;
            btnAfficher.Text = "Afficher mes tickets";
            btnAfficher.Click += btnAfficher_Click;
            // 
            // carteTickets
            // 
            carteTickets.Controls.Add(lblMesTickets);
            carteTickets.Controls.Add(lstTickets);
            carteTickets.Name = "carteTickets";
            carteTickets.Location = new Point(512, 16);
            carteTickets.Size = new Size(744, 596);
            carteTickets.BackColor = Color.White;
            carteTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carteTickets.TabIndex = 1;
            // 
            // lblMesTickets
            // 
            lblMesTickets.Name = "lblMesTickets";
            lblMesTickets.Location = new Point(22, 18);
            lblMesTickets.AutoSize = true;
            lblMesTickets.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMesTickets.ForeColor = Color.FromArgb(12, 68, 124);
            lblMesTickets.TabIndex = 0;
            lblMesTickets.Text = "Mes tickets";
            // 
            // lstTickets
            // 
            lstTickets.Name = "lstTickets";
            lstTickets.Location = new Point(24, 60);
            lstTickets.Size = new Size(696, 512);
            lstTickets.Font = new Font("Segoe UI", 10.5F);
            lstTickets.BorderStyle = BorderStyle.FixedSingle;
            lstTickets.BackColor = Color.FromArgb(245, 248, 251);
            lstTickets.ForeColor = Color.FromArgb(27, 42, 61);
            lstTickets.IntegralHeight = false;
            lstTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTickets.TabIndex = 11;
            // 
            // tabTechnicien
            // 
            tabTechnicien.AutoScroll = true;
            tabTechnicien.Controls.Add(carteMateriel);
            tabTechnicien.Controls.Add(carteIncidents);
            tabTechnicien.Controls.Add(carteTicket);
            tabTechnicien.Name = "tabTechnicien";
            tabTechnicien.Location = new Point(4, 32);
            tabTechnicien.Size = new Size(1272, 628);
            tabTechnicien.BackColor = Color.FromArgb(238, 242, 247);
            tabTechnicien.Padding = new Padding(3);
            tabTechnicien.TabIndex = 4;
            tabTechnicien.Text = "Technicien";
            // 
            // carteMateriel
            // 
            carteMateriel.Controls.Add(lblGestion);
            carteMateriel.Controls.Add(lblAjout);
            carteMateriel.Controls.Add(lblProcesseur);
            carteMateriel.Controls.Add(txtProcesseur);
            carteMateriel.Controls.Add(lblDisque);
            carteMateriel.Controls.Add(txtDisque);
            carteMateriel.Controls.Add(lblLogiciels);
            carteMateriel.Controls.Add(txtLogiciels);
            carteMateriel.Controls.Add(lblEtatMateriel);
            carteMateriel.Controls.Add(cboEtatMateriel);
            carteMateriel.Controls.Add(lblSuiviMateriel);
            carteMateriel.Controls.Add(txtSuiviMateriel);
            carteMateriel.Controls.Add(btnAjouterMateriel);
            carteMateriel.Controls.Add(separateurMateriel);
            carteMateriel.Controls.Add(lblConsultation);
            carteMateriel.Controls.Add(cboConsultMateriel);
            carteMateriel.Controls.Add(btnAfficherMateriel);
            carteMateriel.Controls.Add(panelDetail);
            carteMateriel.Controls.Add(lblSuppression);
            carteMateriel.Controls.Add(cboSupprMateriel);
            carteMateriel.Controls.Add(btnSupprimerMateriel);
            carteMateriel.Name = "carteMateriel";
            carteMateriel.Location = new Point(432, 282);
            carteMateriel.Size = new Size(824, 330);
            carteMateriel.BackColor = Color.White;
            carteMateriel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carteMateriel.TabIndex = 0;
            // 
            // lblGestion
            // 
            lblGestion.Name = "lblGestion";
            lblGestion.Location = new Point(22, 18);
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblGestion.ForeColor = Color.FromArgb(12, 68, 124);
            lblGestion.TabIndex = 0;
            lblGestion.Text = "Gestion du matériel";
            // 
            // lblAjout
            // 
            lblAjout.Name = "lblAjout";
            lblAjout.Location = new Point(24, 58);
            lblAjout.AutoSize = true;
            lblAjout.Font = new Font("Segoe UI Semibold", 10.5F);
            lblAjout.ForeColor = Color.FromArgb(27, 42, 61);
            lblAjout.TabIndex = 1;
            lblAjout.Text = "Ajouter un nouveau matériel";
            // 
            // lblProcesseur
            // 
            lblProcesseur.Name = "lblProcesseur";
            lblProcesseur.Location = new Point(24, 90);
            lblProcesseur.AutoSize = true;
            lblProcesseur.Font = new Font("Segoe UI Semibold", 9.75F);
            lblProcesseur.ForeColor = Color.FromArgb(71, 85, 105);
            lblProcesseur.TabIndex = 2;
            lblProcesseur.Text = "Processeur";
            // 
            // txtProcesseur
            // 
            txtProcesseur.Name = "txtProcesseur";
            txtProcesseur.Location = new Point(24, 112);
            txtProcesseur.Size = new Size(172, 26);
            txtProcesseur.Font = new Font("Segoe UI", 10.5F);
            txtProcesseur.BorderStyle = BorderStyle.FixedSingle;
            txtProcesseur.BackColor = Color.FromArgb(245, 248, 251);
            txtProcesseur.ForeColor = Color.FromArgb(27, 42, 61);
            txtProcesseur.TabIndex = 12;
            // 
            // lblDisque
            // 
            lblDisque.Name = "lblDisque";
            lblDisque.Location = new Point(212, 90);
            lblDisque.AutoSize = true;
            lblDisque.Font = new Font("Segoe UI Semibold", 9.75F);
            lblDisque.ForeColor = Color.FromArgb(71, 85, 105);
            lblDisque.TabIndex = 13;
            lblDisque.Text = "Disque";
            // 
            // txtDisque
            // 
            txtDisque.Name = "txtDisque";
            txtDisque.Location = new Point(212, 112);
            txtDisque.Size = new Size(172, 26);
            txtDisque.Font = new Font("Segoe UI", 10.5F);
            txtDisque.BorderStyle = BorderStyle.FixedSingle;
            txtDisque.BackColor = Color.FromArgb(245, 248, 251);
            txtDisque.ForeColor = Color.FromArgb(27, 42, 61);
            txtDisque.TabIndex = 13;
            // 
            // lblLogiciels
            // 
            lblLogiciels.Name = "lblLogiciels";
            lblLogiciels.Location = new Point(24, 148);
            lblLogiciels.AutoSize = true;
            lblLogiciels.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLogiciels.ForeColor = Color.FromArgb(71, 85, 105);
            lblLogiciels.TabIndex = 14;
            lblLogiciels.Text = "Logiciels";
            // 
            // txtLogiciels
            // 
            txtLogiciels.Name = "txtLogiciels";
            txtLogiciels.Location = new Point(24, 170);
            txtLogiciels.Size = new Size(172, 26);
            txtLogiciels.Font = new Font("Segoe UI", 10.5F);
            txtLogiciels.BorderStyle = BorderStyle.FixedSingle;
            txtLogiciels.BackColor = Color.FromArgb(245, 248, 251);
            txtLogiciels.ForeColor = Color.FromArgb(27, 42, 61);
            txtLogiciels.TabIndex = 14;
            // 
            // lblEtatMateriel
            // 
            lblEtatMateriel.Name = "lblEtatMateriel";
            lblEtatMateriel.Location = new Point(212, 148);
            lblEtatMateriel.AutoSize = true;
            lblEtatMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEtatMateriel.ForeColor = Color.FromArgb(71, 85, 105);
            lblEtatMateriel.TabIndex = 15;
            lblEtatMateriel.Text = "État";
            // 
            // cboEtatMateriel
            // 
            cboEtatMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEtatMateriel.Items.AddRange(new object[] { "En service", "En panne", "Hors service" });
            cboEtatMateriel.Name = "cboEtatMateriel";
            cboEtatMateriel.Location = new Point(212, 170);
            cboEtatMateriel.Size = new Size(172, 26);
            cboEtatMateriel.Font = new Font("Segoe UI", 10.5F);
            cboEtatMateriel.FlatStyle = FlatStyle.Flat;
            cboEtatMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboEtatMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboEtatMateriel.TabIndex = 15;
            // 
            // lblSuiviMateriel
            // 
            lblSuiviMateriel.Name = "lblSuiviMateriel";
            lblSuiviMateriel.Location = new Point(24, 206);
            lblSuiviMateriel.AutoSize = true;
            lblSuiviMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSuiviMateriel.ForeColor = Color.FromArgb(71, 85, 105);
            lblSuiviMateriel.TabIndex = 16;
            lblSuiviMateriel.Text = "Suivi";
            // 
            // txtSuiviMateriel
            // 
            txtSuiviMateriel.Name = "txtSuiviMateriel";
            txtSuiviMateriel.Location = new Point(24, 228);
            txtSuiviMateriel.Size = new Size(360, 26);
            txtSuiviMateriel.Font = new Font("Segoe UI", 10.5F);
            txtSuiviMateriel.BorderStyle = BorderStyle.FixedSingle;
            txtSuiviMateriel.BackColor = Color.FromArgb(245, 248, 251);
            txtSuiviMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            txtSuiviMateriel.TabIndex = 16;
            // 
            // btnAjouterMateriel
            // 
            btnAjouterMateriel.Name = "btnAjouterMateriel";
            btnAjouterMateriel.Location = new Point(24, 270);
            btnAjouterMateriel.Size = new Size(140, 38);
            btnAjouterMateriel.FlatStyle = FlatStyle.Flat;
            btnAjouterMateriel.Cursor = Cursors.Hand;
            btnAjouterMateriel.UseVisualStyleBackColor = false;
            btnAjouterMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnAjouterMateriel.BackColor = Color.FromArgb(24, 95, 165);
            btnAjouterMateriel.ForeColor = Color.White;
            btnAjouterMateriel.FlatAppearance.BorderSize = 0;
            btnAjouterMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnAjouterMateriel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnAjouterMateriel.TabIndex = 17;
            btnAjouterMateriel.Text = "Ajouter";
            btnAjouterMateriel.Click += btnAjouterMateriel_Click;
            // 
            // separateurMateriel
            // 
            separateurMateriel.Name = "separateurMateriel";
            separateurMateriel.Location = new Point(408, 58);
            separateurMateriel.Size = new Size(1, 252);
            separateurMateriel.BackColor = Color.FromArgb(214, 224, 236);
            separateurMateriel.TabIndex = 18;
            // 
            // lblConsultation
            // 
            lblConsultation.Name = "lblConsultation";
            lblConsultation.Location = new Point(432, 58);
            lblConsultation.AutoSize = true;
            lblConsultation.Font = new Font("Segoe UI Semibold", 10.5F);
            lblConsultation.ForeColor = Color.FromArgb(27, 42, 61);
            lblConsultation.TabIndex = 19;
            lblConsultation.Text = "Consultation d'un matériel";
            // 
            // cboConsultMateriel
            // 
            cboConsultMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultMateriel.Name = "cboConsultMateriel";
            cboConsultMateriel.Location = new Point(432, 90);
            cboConsultMateriel.Size = new Size(250, 26);
            cboConsultMateriel.Font = new Font("Segoe UI", 10.5F);
            cboConsultMateriel.FlatStyle = FlatStyle.Flat;
            cboConsultMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboConsultMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboConsultMateriel.TabIndex = 18;
            // 
            // btnAfficherMateriel
            // 
            btnAfficherMateriel.Name = "btnAfficherMateriel";
            btnAfficherMateriel.Location = new Point(692, 88);
            btnAfficherMateriel.Size = new Size(108, 30);
            btnAfficherMateriel.FlatStyle = FlatStyle.Flat;
            btnAfficherMateriel.Cursor = Cursors.Hand;
            btnAfficherMateriel.UseVisualStyleBackColor = false;
            btnAfficherMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnAfficherMateriel.BackColor = Color.White;
            btnAfficherMateriel.ForeColor = Color.FromArgb(24, 95, 165);
            btnAfficherMateriel.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnAfficherMateriel.FlatAppearance.BorderSize = 1;
            btnAfficherMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnAfficherMateriel.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnAfficherMateriel.TabIndex = 19;
            btnAfficherMateriel.Text = "Afficher";
            btnAfficherMateriel.Click += btnAfficherMateriel_Click;
            // 
            // panelDetail
            // 
            panelDetail.Controls.Add(lblDetailProcesseur);
            panelDetail.Controls.Add(lblValeurProcesseur);
            panelDetail.Controls.Add(lblDetailDisque);
            panelDetail.Controls.Add(lblValeurDisque);
            panelDetail.Controls.Add(lblDetailLogiciels);
            panelDetail.Controls.Add(lblValeurLogiciels);
            panelDetail.Controls.Add(lblDetailEtat);
            panelDetail.Controls.Add(lblValeurEtat);
            panelDetail.Controls.Add(lblDetailSuivi);
            panelDetail.Controls.Add(lblValeurSuivi);
            panelDetail.Name = "panelDetail";
            panelDetail.Location = new Point(432, 126);
            panelDetail.Size = new Size(368, 64);
            panelDetail.BackColor = Color.FromArgb(245, 248, 251);
            panelDetail.TabIndex = 20;
            // 
            // lblDetailProcesseur
            // 
            lblDetailProcesseur.Name = "lblDetailProcesseur";
            lblDetailProcesseur.Location = new Point(10, 8);
            lblDetailProcesseur.AutoSize = true;
            lblDetailProcesseur.Font = new Font("Segoe UI", 8.5F);
            lblDetailProcesseur.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailProcesseur.TabIndex = 0;
            lblDetailProcesseur.Text = "Processeur";
            // 
            // lblValeurProcesseur
            // 
            lblValeurProcesseur.Name = "lblValeurProcesseur";
            lblValeurProcesseur.Location = new Point(10, 30);
            lblValeurProcesseur.AutoSize = true;
            lblValeurProcesseur.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurProcesseur.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurProcesseur.TabIndex = 1;
            lblValeurProcesseur.Text = "-";
            // 
            // lblDetailDisque
            // 
            lblDetailDisque.Name = "lblDetailDisque";
            lblDetailDisque.Location = new Point(82, 8);
            lblDetailDisque.AutoSize = true;
            lblDetailDisque.Font = new Font("Segoe UI", 8.5F);
            lblDetailDisque.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailDisque.TabIndex = 2;
            lblDetailDisque.Text = "Disque";
            // 
            // lblValeurDisque
            // 
            lblValeurDisque.Name = "lblValeurDisque";
            lblValeurDisque.Location = new Point(82, 30);
            lblValeurDisque.AutoSize = true;
            lblValeurDisque.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurDisque.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurDisque.TabIndex = 3;
            lblValeurDisque.Text = "-";
            // 
            // lblDetailLogiciels
            // 
            lblDetailLogiciels.Name = "lblDetailLogiciels";
            lblDetailLogiciels.Location = new Point(154, 8);
            lblDetailLogiciels.AutoSize = true;
            lblDetailLogiciels.Font = new Font("Segoe UI", 8.5F);
            lblDetailLogiciels.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailLogiciels.TabIndex = 4;
            lblDetailLogiciels.Text = "Logiciels";
            // 
            // lblValeurLogiciels
            // 
            lblValeurLogiciels.Name = "lblValeurLogiciels";
            lblValeurLogiciels.Location = new Point(154, 30);
            lblValeurLogiciels.AutoSize = true;
            lblValeurLogiciels.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurLogiciels.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurLogiciels.TabIndex = 5;
            lblValeurLogiciels.Text = "-";
            // 
            // lblDetailEtat
            // 
            lblDetailEtat.Name = "lblDetailEtat";
            lblDetailEtat.Location = new Point(226, 8);
            lblDetailEtat.AutoSize = true;
            lblDetailEtat.Font = new Font("Segoe UI", 8.5F);
            lblDetailEtat.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailEtat.TabIndex = 6;
            lblDetailEtat.Text = "État";
            // 
            // lblValeurEtat
            // 
            lblValeurEtat.Name = "lblValeurEtat";
            lblValeurEtat.Location = new Point(226, 30);
            lblValeurEtat.AutoSize = true;
            lblValeurEtat.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurEtat.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurEtat.TabIndex = 7;
            lblValeurEtat.Text = "-";
            // 
            // lblDetailSuivi
            // 
            lblDetailSuivi.Name = "lblDetailSuivi";
            lblDetailSuivi.Location = new Point(298, 8);
            lblDetailSuivi.AutoSize = true;
            lblDetailSuivi.Font = new Font("Segoe UI", 8.5F);
            lblDetailSuivi.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailSuivi.TabIndex = 8;
            lblDetailSuivi.Text = "Suivi";
            // 
            // lblValeurSuivi
            // 
            lblValeurSuivi.Name = "lblValeurSuivi";
            lblValeurSuivi.Location = new Point(298, 30);
            lblValeurSuivi.AutoSize = true;
            lblValeurSuivi.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurSuivi.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurSuivi.TabIndex = 9;
            lblValeurSuivi.Text = "-";
            // 
            // lblSuppression
            // 
            lblSuppression.Name = "lblSuppression";
            lblSuppression.Location = new Point(432, 206);
            lblSuppression.AutoSize = true;
            lblSuppression.Font = new Font("Segoe UI Semibold", 10.5F);
            lblSuppression.ForeColor = Color.FromArgb(27, 42, 61);
            lblSuppression.TabIndex = 21;
            lblSuppression.Text = "Suppression d'un matériel";
            // 
            // cboSupprMateriel
            // 
            cboSupprMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupprMateriel.Name = "cboSupprMateriel";
            cboSupprMateriel.Location = new Point(432, 236);
            cboSupprMateriel.Size = new Size(250, 26);
            cboSupprMateriel.Font = new Font("Segoe UI", 10.5F);
            cboSupprMateriel.FlatStyle = FlatStyle.Flat;
            cboSupprMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboSupprMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboSupprMateriel.TabIndex = 20;
            // 
            // btnSupprimerMateriel
            // 
            btnSupprimerMateriel.Name = "btnSupprimerMateriel";
            btnSupprimerMateriel.Location = new Point(692, 234);
            btnSupprimerMateriel.Size = new Size(108, 30);
            btnSupprimerMateriel.FlatStyle = FlatStyle.Flat;
            btnSupprimerMateriel.Cursor = Cursors.Hand;
            btnSupprimerMateriel.UseVisualStyleBackColor = false;
            btnSupprimerMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnSupprimerMateriel.BackColor = Color.White;
            btnSupprimerMateriel.ForeColor = Color.FromArgb(163, 45, 45);
            btnSupprimerMateriel.FlatAppearance.BorderColor = Color.FromArgb(240, 149, 149);
            btnSupprimerMateriel.FlatAppearance.BorderSize = 1;
            btnSupprimerMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 235);
            btnSupprimerMateriel.FlatAppearance.MouseDownBackColor = Color.FromArgb(247, 193, 193);
            btnSupprimerMateriel.TabIndex = 21;
            btnSupprimerMateriel.Text = "Supprimer";
            btnSupprimerMateriel.Click += btnSupprimerMateriel_Click;
            // 
            // carteIncidents
            // 
            carteIncidents.Controls.Add(lblIncidents);
            carteIncidents.Controls.Add(lstIncidents);
            carteIncidents.Controls.Add(btnPrendreEnCharge);
            carteIncidents.Name = "carteIncidents";
            carteIncidents.Location = new Point(16, 16);
            carteIncidents.Size = new Size(400, 596);
            carteIncidents.BackColor = Color.White;
            carteIncidents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            carteIncidents.TabIndex = 1;
            // 
            // lblIncidents
            // 
            lblIncidents.Name = "lblIncidents";
            lblIncidents.Location = new Point(22, 18);
            lblIncidents.AutoSize = true;
            lblIncidents.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblIncidents.ForeColor = Color.FromArgb(12, 68, 124);
            lblIncidents.TabIndex = 0;
            lblIncidents.Text = "Incidents";
            // 
            // lstIncidents
            // 
            lstIncidents.Name = "lstIncidents";
            lstIncidents.Location = new Point(24, 60);
            lstIncidents.Size = new Size(352, 470);
            lstIncidents.Font = new Font("Segoe UI", 10.5F);
            lstIncidents.BorderStyle = BorderStyle.FixedSingle;
            lstIncidents.BackColor = Color.FromArgb(245, 248, 251);
            lstIncidents.ForeColor = Color.FromArgb(27, 42, 61);
            lstIncidents.IntegralHeight = false;
            lstIncidents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstIncidents.TabIndex = 22;
            lstIncidents.SelectedIndexChanged += lstIncidents_SelectedIndexChanged;
            // 
            // btnPrendreEnCharge
            // 
            btnPrendreEnCharge.Name = "btnPrendreEnCharge";
            btnPrendreEnCharge.Location = new Point(24, 544);
            btnPrendreEnCharge.Size = new Size(200, 38);
            btnPrendreEnCharge.FlatStyle = FlatStyle.Flat;
            btnPrendreEnCharge.Cursor = Cursors.Hand;
            btnPrendreEnCharge.UseVisualStyleBackColor = false;
            btnPrendreEnCharge.Font = new Font("Segoe UI Semibold", 10F);
            btnPrendreEnCharge.BackColor = Color.FromArgb(24, 95, 165);
            btnPrendreEnCharge.ForeColor = Color.White;
            btnPrendreEnCharge.FlatAppearance.BorderSize = 0;
            btnPrendreEnCharge.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnPrendreEnCharge.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnPrendreEnCharge.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrendreEnCharge.TabIndex = 23;
            btnPrendreEnCharge.Text = "Prendre en charge";
            btnPrendreEnCharge.Click += btnPrendreEnCharge_Click;
            // 
            // carteTicket
            // 
            carteTicket.Controls.Add(lblTicketSelection);
            carteTicket.Controls.Add(lblEtatActuel);
            carteTicket.Controls.Add(lblEtat);
            carteTicket.Controls.Add(panelEtat);
            carteTicket.Controls.Add(lblUrgence);
            carteTicket.Controls.Add(panelUrgence);
            carteTicket.Controls.Add(lblSuivi);
            carteTicket.Controls.Add(txtSuivi);
            carteTicket.Controls.Add(btnEnregistrer);
            carteTicket.Name = "carteTicket";
            carteTicket.Location = new Point(432, 16);
            carteTicket.Size = new Size(824, 250);
            carteTicket.BackColor = Color.White;
            carteTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            carteTicket.TabIndex = 2;
            // 
            // lblTicketSelection
            // 
            lblTicketSelection.Name = "lblTicketSelection";
            lblTicketSelection.Location = new Point(22, 18);
            lblTicketSelection.AutoSize = true;
            lblTicketSelection.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTicketSelection.ForeColor = Color.FromArgb(12, 68, 124);
            lblTicketSelection.TabIndex = 0;
            lblTicketSelection.Text = "Ticket sélectionné";
            // 
            // lblEtatActuel
            // 
            lblEtatActuel.Name = "lblEtatActuel";
            lblEtatActuel.Location = new Point(560, 22);
            lblEtatActuel.Size = new Size(240, 22);
            lblEtatActuel.Font = new Font("Segoe UI", 10F);
            lblEtatActuel.ForeColor = Color.FromArgb(90, 107, 128);
            lblEtatActuel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEtatActuel.TabIndex = 1;
            lblEtatActuel.Text = "État actuel : -";
            lblEtatActuel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEtat
            // 
            lblEtat.Name = "lblEtat";
            lblEtat.Location = new Point(24, 62);
            lblEtat.AutoSize = true;
            lblEtat.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEtat.ForeColor = Color.FromArgb(71, 85, 105);
            lblEtat.TabIndex = 2;
            lblEtat.Text = "État";
            // 
            // panelEtat
            // 
            panelEtat.Controls.Add(rbEnCours);
            panelEtat.Controls.Add(rbResolu);
            panelEtat.Controls.Add(rbCloture);
            panelEtat.Name = "panelEtat";
            panelEtat.Location = new Point(24, 84);
            panelEtat.Size = new Size(400, 30);
            panelEtat.BackColor = Color.White;
            panelEtat.TabIndex = 24;
            // 
            // rbEnCours
            // 
            rbEnCours.Checked = true;
            rbEnCours.Name = "rbEnCours";
            rbEnCours.Location = new Point(0, 4);
            rbEnCours.AutoSize = true;
            rbEnCours.Font = new Font("Segoe UI", 10F);
            rbEnCours.ForeColor = Color.FromArgb(27, 42, 61);
            rbEnCours.TabIndex = 0;
            rbEnCours.TabStop = true;
            rbEnCours.Text = "En cours";
            // 
            // rbResolu
            // 
            rbResolu.Name = "rbResolu";
            rbResolu.Location = new Point(130, 4);
            rbResolu.AutoSize = true;
            rbResolu.Font = new Font("Segoe UI", 10F);
            rbResolu.ForeColor = Color.FromArgb(27, 42, 61);
            rbResolu.TabIndex = 1;
            rbResolu.Text = "Résolu";
            // 
            // rbCloture
            // 
            rbCloture.Name = "rbCloture";
            rbCloture.Location = new Point(260, 4);
            rbCloture.AutoSize = true;
            rbCloture.Font = new Font("Segoe UI", 10F);
            rbCloture.ForeColor = Color.FromArgb(27, 42, 61);
            rbCloture.TabIndex = 2;
            rbCloture.Text = "Clôturé";
            // 
            // lblUrgence
            // 
            lblUrgence.Name = "lblUrgence";
            lblUrgence.Location = new Point(440, 62);
            lblUrgence.AutoSize = true;
            lblUrgence.Font = new Font("Segoe UI Semibold", 9.75F);
            lblUrgence.ForeColor = Color.FromArgb(71, 85, 105);
            lblUrgence.TabIndex = 25;
            lblUrgence.Text = "Niveau d'urgence";
            // 
            // panelUrgence
            // 
            panelUrgence.Controls.Add(rbFaible);
            panelUrgence.Controls.Add(rbMoyen);
            panelUrgence.Controls.Add(rbCritique);
            panelUrgence.Name = "panelUrgence";
            panelUrgence.Location = new Point(440, 84);
            panelUrgence.Size = new Size(360, 30);
            panelUrgence.BackColor = Color.White;
            panelUrgence.TabIndex = 25;
            // 
            // rbFaible
            // 
            rbFaible.Checked = true;
            rbFaible.Name = "rbFaible";
            rbFaible.Location = new Point(0, 4);
            rbFaible.AutoSize = true;
            rbFaible.Font = new Font("Segoe UI", 10F);
            rbFaible.ForeColor = Color.FromArgb(27, 42, 61);
            rbFaible.TabIndex = 0;
            rbFaible.TabStop = true;
            rbFaible.Text = "Faible";
            // 
            // rbMoyen
            // 
            rbMoyen.Name = "rbMoyen";
            rbMoyen.Location = new Point(110, 4);
            rbMoyen.AutoSize = true;
            rbMoyen.Font = new Font("Segoe UI", 10F);
            rbMoyen.ForeColor = Color.FromArgb(27, 42, 61);
            rbMoyen.TabIndex = 1;
            rbMoyen.Text = "Moyen";
            // 
            // rbCritique
            // 
            rbCritique.Name = "rbCritique";
            rbCritique.Location = new Point(220, 4);
            rbCritique.AutoSize = true;
            rbCritique.Font = new Font("Segoe UI", 10F);
            rbCritique.ForeColor = Color.FromArgb(27, 42, 61);
            rbCritique.TabIndex = 2;
            rbCritique.Text = "Critique";
            // 
            // lblSuivi
            // 
            lblSuivi.Name = "lblSuivi";
            lblSuivi.Location = new Point(24, 124);
            lblSuivi.AutoSize = true;
            lblSuivi.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSuivi.ForeColor = Color.FromArgb(71, 85, 105);
            lblSuivi.TabIndex = 26;
            lblSuivi.Text = "Suivi (travail effectué)";
            // 
            // txtSuivi
            // 
            txtSuivi.Multiline = true;
            txtSuivi.Name = "txtSuivi";
            txtSuivi.Location = new Point(24, 146);
            txtSuivi.Size = new Size(620, 80);
            txtSuivi.Font = new Font("Segoe UI", 10.5F);
            txtSuivi.BorderStyle = BorderStyle.FixedSingle;
            txtSuivi.BackColor = Color.FromArgb(245, 248, 251);
            txtSuivi.ForeColor = Color.FromArgb(27, 42, 61);
            txtSuivi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSuivi.ScrollBars = ScrollBars.Vertical;
            txtSuivi.TabIndex = 26;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Location = new Point(660, 188);
            btnEnregistrer.Size = new Size(140, 38);
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Font = new Font("Segoe UI Semibold", 10F);
            btnEnregistrer.BackColor = Color.FromArgb(24, 95, 165);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnEnregistrer.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnEnregistrer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnregistrer.TabIndex = 27;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // tabResponsable
            // 
            tabResponsable.Controls.Add(cartePersonnel);
            tabResponsable.Name = "tabResponsable";
            tabResponsable.Location = new Point(4, 32);
            tabResponsable.Size = new Size(1272, 628);
            tabResponsable.BackColor = Color.FromArgb(238, 242, 247);
            tabResponsable.Padding = new Padding(3);
            tabResponsable.TabIndex = 5;
            tabResponsable.Text = "Responsable";
            // 
            // cartePersonnel
            // 
            cartePersonnel.Controls.Add(lblType);
            cartePersonnel.Controls.Add(panelType);
            cartePersonnel.Controls.Add(lblPersonne);
            cartePersonnel.Controls.Add(cboPersonne);
            cartePersonnel.Controls.Add(separateurPersonnel);
            cartePersonnel.Controls.Add(lblNom);
            cartePersonnel.Controls.Add(txtNom);
            cartePersonnel.Controls.Add(lblPrenom);
            cartePersonnel.Controls.Add(txtPrenom);
            cartePersonnel.Controls.Add(lblDateEmbauche);
            cartePersonnel.Controls.Add(dtpDateEmbauche);
            cartePersonnel.Controls.Add(lblPostePersonne);
            cartePersonnel.Controls.Add(txtPostePersonne);
            cartePersonnel.Controls.Add(lblLoginPersonne);
            cartePersonnel.Controls.Add(txtLoginPersonne);
            cartePersonnel.Controls.Add(lblMdpPersonne);
            cartePersonnel.Controls.Add(txtMdpPersonne);
            cartePersonnel.Controls.Add(panelTechnicien);
            cartePersonnel.Controls.Add(btnAjouterPersonne);
            cartePersonnel.Controls.Add(btnModifierPersonne);
            cartePersonnel.Controls.Add(btnSupprimerPersonne);
            cartePersonnel.Name = "cartePersonnel";
            cartePersonnel.Location = new Point(16, 16);
            cartePersonnel.Size = new Size(1240, 596);
            cartePersonnel.BackColor = Color.White;
            cartePersonnel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cartePersonnel.TabIndex = 0;
            // 
            // lblType
            // 
            lblType.Name = "lblType";
            lblType.Location = new Point(24, 24);
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9.75F);
            lblType.ForeColor = Color.FromArgb(71, 85, 105);
            lblType.TabIndex = 0;
            lblType.Text = "Type de compte";
            // 
            // panelType
            // 
            panelType.Controls.Add(rbTechnicien);
            panelType.Controls.Add(rbUtilisateur);
            panelType.Name = "panelType";
            panelType.Location = new Point(24, 46);
            panelType.Size = new Size(300, 30);
            panelType.BackColor = Color.White;
            panelType.TabIndex = 28;
            // 
            // rbTechnicien
            // 
            rbTechnicien.Checked = true;
            rbTechnicien.Name = "rbTechnicien";
            rbTechnicien.Location = new Point(0, 4);
            rbTechnicien.AutoSize = true;
            rbTechnicien.Font = new Font("Segoe UI", 10F);
            rbTechnicien.ForeColor = Color.FromArgb(27, 42, 61);
            rbTechnicien.TabIndex = 0;
            rbTechnicien.TabStop = true;
            rbTechnicien.Text = "Technicien";
            rbTechnicien.CheckedChanged += rbTechnicien_CheckedChanged;
            // 
            // rbUtilisateur
            // 
            rbUtilisateur.Name = "rbUtilisateur";
            rbUtilisateur.Location = new Point(130, 4);
            rbUtilisateur.AutoSize = true;
            rbUtilisateur.Font = new Font("Segoe UI", 10F);
            rbUtilisateur.ForeColor = Color.FromArgb(27, 42, 61);
            rbUtilisateur.TabIndex = 1;
            rbUtilisateur.Text = "Utilisateur";
            // 
            // lblPersonne
            // 
            lblPersonne.Name = "lblPersonne";
            lblPersonne.Location = new Point(24, 92);
            lblPersonne.AutoSize = true;
            lblPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblPersonne.TabIndex = 29;
            lblPersonne.Text = "Personne à modifier ou supprimer";
            // 
            // cboPersonne
            // 
            cboPersonne.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonne.Name = "cboPersonne";
            cboPersonne.Location = new Point(24, 114);
            cboPersonne.Size = new Size(300, 26);
            cboPersonne.Font = new Font("Segoe UI", 10.5F);
            cboPersonne.FlatStyle = FlatStyle.Flat;
            cboPersonne.BackColor = Color.FromArgb(245, 248, 251);
            cboPersonne.ForeColor = Color.FromArgb(27, 42, 61);
            cboPersonne.TabIndex = 29;
            cboPersonne.SelectedIndexChanged += cboPersonne_SelectedIndexChanged;
            // 
            // separateurPersonnel
            // 
            separateurPersonnel.Name = "separateurPersonnel";
            separateurPersonnel.Location = new Point(360, 24);
            separateurPersonnel.Size = new Size(1, 548);
            separateurPersonnel.BackColor = Color.FromArgb(214, 224, 236);
            separateurPersonnel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            separateurPersonnel.TabIndex = 30;
            // 
            // lblNom
            // 
            lblNom.Name = "lblNom";
            lblNom.Location = new Point(384, 24);
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI Semibold", 9.75F);
            lblNom.ForeColor = Color.FromArgb(71, 85, 105);
            lblNom.TabIndex = 31;
            lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.Name = "txtNom";
            txtNom.Location = new Point(384, 46);
            txtNom.Size = new Size(340, 26);
            txtNom.Font = new Font("Segoe UI", 10.5F);
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.BackColor = Color.FromArgb(245, 248, 251);
            txtNom.ForeColor = Color.FromArgb(27, 42, 61);
            txtNom.TabIndex = 30;
            // 
            // lblPrenom
            // 
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Location = new Point(748, 24);
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPrenom.ForeColor = Color.FromArgb(71, 85, 105);
            lblPrenom.TabIndex = 32;
            lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Location = new Point(748, 46);
            txtPrenom.Size = new Size(340, 26);
            txtPrenom.Font = new Font("Segoe UI", 10.5F);
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.BackColor = Color.FromArgb(245, 248, 251);
            txtPrenom.ForeColor = Color.FromArgb(27, 42, 61);
            txtPrenom.TabIndex = 31;
            // 
            // lblDateEmbauche
            // 
            lblDateEmbauche.Name = "lblDateEmbauche";
            lblDateEmbauche.Location = new Point(384, 86);
            lblDateEmbauche.AutoSize = true;
            lblDateEmbauche.Font = new Font("Segoe UI Semibold", 9.75F);
            lblDateEmbauche.ForeColor = Color.FromArgb(71, 85, 105);
            lblDateEmbauche.TabIndex = 33;
            lblDateEmbauche.Text = "Date d'embauche";
            // 
            // dtpDateEmbauche
            // 
            dtpDateEmbauche.Format = DateTimePickerFormat.Short;
            dtpDateEmbauche.Name = "dtpDateEmbauche";
            dtpDateEmbauche.Location = new Point(384, 108);
            dtpDateEmbauche.Size = new Size(340, 26);
            dtpDateEmbauche.Font = new Font("Segoe UI", 10.5F);
            dtpDateEmbauche.TabIndex = 32;
            // 
            // lblPostePersonne
            // 
            lblPostePersonne.Name = "lblPostePersonne";
            lblPostePersonne.Location = new Point(748, 86);
            lblPostePersonne.AutoSize = true;
            lblPostePersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPostePersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblPostePersonne.TabIndex = 34;
            lblPostePersonne.Text = "Poste";
            // 
            // txtPostePersonne
            // 
            txtPostePersonne.Name = "txtPostePersonne";
            txtPostePersonne.Location = new Point(748, 108);
            txtPostePersonne.Size = new Size(340, 26);
            txtPostePersonne.Font = new Font("Segoe UI", 10.5F);
            txtPostePersonne.BorderStyle = BorderStyle.FixedSingle;
            txtPostePersonne.BackColor = Color.FromArgb(245, 248, 251);
            txtPostePersonne.ForeColor = Color.FromArgb(27, 42, 61);
            txtPostePersonne.TabIndex = 33;
            // 
            // lblLoginPersonne
            // 
            lblLoginPersonne.Name = "lblLoginPersonne";
            lblLoginPersonne.Location = new Point(384, 148);
            lblLoginPersonne.AutoSize = true;
            lblLoginPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLoginPersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblLoginPersonne.TabIndex = 35;
            lblLoginPersonne.Text = "Login";
            // 
            // txtLoginPersonne
            // 
            txtLoginPersonne.Name = "txtLoginPersonne";
            txtLoginPersonne.Location = new Point(384, 170);
            txtLoginPersonne.Size = new Size(340, 26);
            txtLoginPersonne.Font = new Font("Segoe UI", 10.5F);
            txtLoginPersonne.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPersonne.BackColor = Color.FromArgb(245, 248, 251);
            txtLoginPersonne.ForeColor = Color.FromArgb(27, 42, 61);
            txtLoginPersonne.TabIndex = 34;
            // 
            // lblMdpPersonne
            // 
            lblMdpPersonne.Name = "lblMdpPersonne";
            lblMdpPersonne.Location = new Point(748, 148);
            lblMdpPersonne.AutoSize = true;
            lblMdpPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMdpPersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblMdpPersonne.TabIndex = 36;
            lblMdpPersonne.Text = "Mot de passe";
            // 
            // txtMdpPersonne
            // 
            txtMdpPersonne.Name = "txtMdpPersonne";
            txtMdpPersonne.Location = new Point(748, 170);
            txtMdpPersonne.Size = new Size(340, 26);
            txtMdpPersonne.Font = new Font("Segoe UI", 10.5F);
            txtMdpPersonne.BorderStyle = BorderStyle.FixedSingle;
            txtMdpPersonne.BackColor = Color.FromArgb(245, 248, 251);
            txtMdpPersonne.ForeColor = Color.FromArgb(27, 42, 61);
            txtMdpPersonne.TabIndex = 35;
            txtMdpPersonne.UseSystemPasswordChar = true;
            // 
            // panelTechnicien
            // 
            panelTechnicien.Controls.Add(lblFormation);
            panelTechnicien.Controls.Add(txtFormation);
            panelTechnicien.Controls.Add(lblCompetence);
            panelTechnicien.Controls.Add(txtCompetence);
            panelTechnicien.Name = "panelTechnicien";
            panelTechnicien.Location = new Point(384, 210);
            panelTechnicien.Size = new Size(704, 70);
            panelTechnicien.BackColor = Color.White;
            panelTechnicien.TabIndex = 37;
            // 
            // lblFormation
            // 
            lblFormation.Name = "lblFormation";
            lblFormation.Location = new Point(0, 8);
            lblFormation.AutoSize = true;
            lblFormation.Font = new Font("Segoe UI Semibold", 9.75F);
            lblFormation.ForeColor = Color.FromArgb(71, 85, 105);
            lblFormation.TabIndex = 0;
            lblFormation.Text = "Formation";
            // 
            // txtFormation
            // 
            txtFormation.Name = "txtFormation";
            txtFormation.Location = new Point(0, 30);
            txtFormation.Size = new Size(340, 26);
            txtFormation.Font = new Font("Segoe UI", 10.5F);
            txtFormation.BorderStyle = BorderStyle.FixedSingle;
            txtFormation.BackColor = Color.FromArgb(245, 248, 251);
            txtFormation.ForeColor = Color.FromArgb(27, 42, 61);
            txtFormation.TabIndex = 36;
            // 
            // lblCompetence
            // 
            lblCompetence.Name = "lblCompetence";
            lblCompetence.Location = new Point(364, 8);
            lblCompetence.AutoSize = true;
            lblCompetence.Font = new Font("Segoe UI Semibold", 9.75F);
            lblCompetence.ForeColor = Color.FromArgb(71, 85, 105);
            lblCompetence.TabIndex = 37;
            lblCompetence.Text = "Compétence";
            // 
            // txtCompetence
            // 
            txtCompetence.Name = "txtCompetence";
            txtCompetence.Location = new Point(364, 30);
            txtCompetence.Size = new Size(340, 26);
            txtCompetence.Font = new Font("Segoe UI", 10.5F);
            txtCompetence.BorderStyle = BorderStyle.FixedSingle;
            txtCompetence.BackColor = Color.FromArgb(245, 248, 251);
            txtCompetence.ForeColor = Color.FromArgb(27, 42, 61);
            txtCompetence.TabIndex = 37;
            // 
            // btnAjouterPersonne
            // 
            btnAjouterPersonne.Name = "btnAjouterPersonne";
            btnAjouterPersonne.Location = new Point(384, 300);
            btnAjouterPersonne.Size = new Size(120, 38);
            btnAjouterPersonne.FlatStyle = FlatStyle.Flat;
            btnAjouterPersonne.Cursor = Cursors.Hand;
            btnAjouterPersonne.UseVisualStyleBackColor = false;
            btnAjouterPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnAjouterPersonne.BackColor = Color.FromArgb(24, 95, 165);
            btnAjouterPersonne.ForeColor = Color.White;
            btnAjouterPersonne.FlatAppearance.BorderSize = 0;
            btnAjouterPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnAjouterPersonne.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnAjouterPersonne.TabIndex = 38;
            btnAjouterPersonne.Text = "Ajouter";
            btnAjouterPersonne.Click += btnAjouterPersonne_Click;
            // 
            // btnModifierPersonne
            // 
            btnModifierPersonne.Name = "btnModifierPersonne";
            btnModifierPersonne.Location = new Point(516, 300);
            btnModifierPersonne.Size = new Size(120, 38);
            btnModifierPersonne.FlatStyle = FlatStyle.Flat;
            btnModifierPersonne.Cursor = Cursors.Hand;
            btnModifierPersonne.UseVisualStyleBackColor = false;
            btnModifierPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnModifierPersonne.BackColor = Color.White;
            btnModifierPersonne.ForeColor = Color.FromArgb(24, 95, 165);
            btnModifierPersonne.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnModifierPersonne.FlatAppearance.BorderSize = 1;
            btnModifierPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnModifierPersonne.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnModifierPersonne.TabIndex = 39;
            btnModifierPersonne.Text = "Modifier";
            btnModifierPersonne.Click += btnModifierPersonne_Click;
            // 
            // btnSupprimerPersonne
            // 
            btnSupprimerPersonne.Name = "btnSupprimerPersonne";
            btnSupprimerPersonne.Location = new Point(648, 300);
            btnSupprimerPersonne.Size = new Size(120, 38);
            btnSupprimerPersonne.FlatStyle = FlatStyle.Flat;
            btnSupprimerPersonne.Cursor = Cursors.Hand;
            btnSupprimerPersonne.UseVisualStyleBackColor = false;
            btnSupprimerPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnSupprimerPersonne.BackColor = Color.White;
            btnSupprimerPersonne.ForeColor = Color.FromArgb(163, 45, 45);
            btnSupprimerPersonne.FlatAppearance.BorderColor = Color.FromArgb(240, 149, 149);
            btnSupprimerPersonne.FlatAppearance.BorderSize = 1;
            btnSupprimerPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 235);
            btnSupprimerPersonne.FlatAppearance.MouseDownBackColor = Color.FromArgb(247, 193, 193);
            btnSupprimerPersonne.TabIndex = 40;
            btnSupprimerPersonne.Text = "Supprimer";
            btnSupprimerPersonne.Click += btnSupprimerPersonne_Click;
            // 
            // FormPrincipal
            // 
            Controls.Add(panelEntete);
            Controls.Add(tabMenu);
            Name = "FormPrincipal";
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(238, 242, 247);
            ClientSize = new Size(1280, 720);
            Font = new Font("Segoe UI", 9.75F);
            MinimumSize = new Size(1100, 700);
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Support informatique";
            Load += FormPrincipal_Load;
            panelEntete.ResumeLayout(false);
            panelEntete.PerformLayout();
            tabMenu.ResumeLayout(false);
            tabConnexion.ResumeLayout(false);
            carteConnexion.ResumeLayout(false);
            carteConnexion.PerformLayout();
            tabUtilisateur.ResumeLayout(false);
            carteNouveau.ResumeLayout(false);
            carteNouveau.PerformLayout();
            carteTickets.ResumeLayout(false);
            carteTickets.PerformLayout();
            tabTechnicien.ResumeLayout(false);
            carteMateriel.ResumeLayout(false);
            carteMateriel.PerformLayout();
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            carteIncidents.ResumeLayout(false);
            carteIncidents.PerformLayout();
            carteTicket.ResumeLayout(false);
            carteTicket.PerformLayout();
            panelEtat.ResumeLayout(false);
            panelEtat.PerformLayout();
            panelUrgence.ResumeLayout(false);
            panelUrgence.PerformLayout();
            tabResponsable.ResumeLayout(false);
            cartePersonnel.ResumeLayout(false);
            cartePersonnel.PerformLayout();
            panelType.ResumeLayout(false);
            panelType.PerformLayout();
            panelTechnicien.ResumeLayout(false);
            panelTechnicien.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox cboPoste;
        private System.Windows.Forms.CheckBox chkResterConnecte;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.Panel carteNouveau;
        private System.Windows.Forms.Label lblNouveau;
        private System.Windows.Forms.Label lblMateriel;
        private System.Windows.Forms.ComboBox cboMateriel;
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