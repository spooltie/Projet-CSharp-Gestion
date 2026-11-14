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
            btnSeConnecter = new Button();
            btnAdmin = new Button();
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
            carteStats = new Panel();
            lblStats = new Label();
            btnActualiserStats = new Button();
            lblStatsIncidents = new Label();
            lstStatsIncidents = new ListBox();
            lblStatsTechniciens = new Label();
            lstStatsTechniciens = new ListBox();
            lblStatsUtilisateurs = new Label();
            lstStatsUtilisateurs = new ListBox();
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
            carteStats.SuspendLayout();
            SuspendLayout();
            // 
            // panelEntete
            // 
            panelEntete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelEntete.BackColor = Color.FromArgb(12, 68, 124);
            panelEntete.Controls.Add(lblApplication);
            panelEntete.Controls.Add(lblUtilisateur);
            panelEntete.Controls.Add(btnDeconnexion);
            panelEntete.Location = new Point(0, 0);
            panelEntete.Name = "panelEntete";
            panelEntete.Size = new Size(1280, 56);
            panelEntete.TabIndex = 0;
            // 
            // lblApplication
            // 
            lblApplication.AutoSize = true;
            lblApplication.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblApplication.ForeColor = Color.White;
            lblApplication.Location = new Point(20, 15);
            lblApplication.Name = "lblApplication";
            lblApplication.Size = new Size(197, 25);
            lblApplication.TabIndex = 0;
            lblApplication.Text = "Support informatique";
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUtilisateur.Font = new Font("Segoe UI", 10F);
            lblUtilisateur.ForeColor = Color.FromArgb(230, 241, 251);
            lblUtilisateur.Location = new Point(860, 18);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(250, 20);
            lblUtilisateur.TabIndex = 1;
            lblUtilisateur.Text = " ";
            lblUtilisateur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeconnexion.BackColor = Color.FromArgb(12, 68, 124);
            btnDeconnexion.Cursor = Cursors.Hand;
            btnDeconnexion.FlatAppearance.BorderColor = Color.FromArgb(55, 138, 221);
            btnDeconnexion.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnDeconnexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 95, 165);
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.Font = new Font("Segoe UI Semibold", 10F);
            btnDeconnexion.ForeColor = Color.White;
            btnDeconnexion.Location = new Point(1124, 12);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(140, 32);
            btnDeconnexion.TabIndex = 0;
            btnDeconnexion.Text = "Se déconnecter";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // tabMenu
            // 
            tabMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabMenu.Controls.Add(tabConnexion);
            tabMenu.Controls.Add(tabUtilisateur);
            tabMenu.Controls.Add(tabTechnicien);
            tabMenu.Controls.Add(tabResponsable);
            tabMenu.Font = new Font("Segoe UI", 10F);
            tabMenu.Location = new Point(0, 56);
            tabMenu.Name = "tabMenu";
            tabMenu.Padding = new Point(16, 6);
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(1280, 664);
            tabMenu.TabIndex = 1;
            // 
            // tabConnexion
            // 
            tabConnexion.BackColor = Color.FromArgb(238, 242, 247);
            tabConnexion.Controls.Add(carteConnexion);
            tabConnexion.Controls.Add(btnAdmin);
            tabConnexion.Location = new Point(4, 32);
            tabConnexion.Name = "tabConnexion";
            tabConnexion.Padding = new Padding(3);
            tabConnexion.Size = new Size(1272, 628);
            tabConnexion.TabIndex = 2;
            tabConnexion.Text = "Connexion";
            // 
            // carteConnexion
            // 
            carteConnexion.Anchor = AnchorStyles.None;
            carteConnexion.BackColor = Color.White;
            carteConnexion.Controls.Add(lblTitre);
            carteConnexion.Controls.Add(lblSousTitre);
            carteConnexion.Controls.Add(lblLogin);
            carteConnexion.Controls.Add(txtLogin);
            carteConnexion.Controls.Add(lblMotDePasse);
            carteConnexion.Controls.Add(txtMotDePasse);
            carteConnexion.Controls.Add(lblPoste);
            carteConnexion.Controls.Add(cboPoste);
            carteConnexion.Controls.Add(btnSeConnecter);
            carteConnexion.Location = new Point(446, 114);
            carteConnexion.Name = "carteConnexion";
            carteConnexion.Size = new Size(380, 400);
            carteConnexion.TabIndex = 0;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(12, 68, 124);
            lblTitre.Location = new Point(30, 26);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(137, 32);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Connexion";
            // 
            // lblSousTitre
            // 
            lblSousTitre.AutoSize = true;
            lblSousTitre.Font = new Font("Segoe UI", 10F);
            lblSousTitre.ForeColor = Color.FromArgb(90, 107, 128);
            lblSousTitre.Location = new Point(33, 68);
            lblSousTitre.Name = "lblSousTitre";
            lblSousTitre.Size = new Size(291, 19);
            lblSousTitre.TabIndex = 1;
            lblSousTitre.Text = "Connectez-vous pour accéder à votre compte.";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLogin.ForeColor = Color.FromArgb(71, 85, 105);
            lblLogin.Location = new Point(32, 104);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(41, 17);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(245, 248, 251);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 10.5F);
            txtLogin.ForeColor = Color.FromArgb(27, 42, 61);
            txtLogin.Location = new Point(32, 126);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(316, 26);
            txtLogin.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMotDePasse.ForeColor = Color.FromArgb(71, 85, 105);
            lblMotDePasse.Location = new Point(32, 166);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(90, 17);
            lblMotDePasse.TabIndex = 3;
            lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.BackColor = Color.FromArgb(245, 248, 251);
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.Font = new Font("Segoe UI", 10.5F);
            txtMotDePasse.ForeColor = Color.FromArgb(27, 42, 61);
            txtMotDePasse.Location = new Point(32, 188);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(316, 26);
            txtMotDePasse.TabIndex = 1;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // lblPoste
            // 
            lblPoste.AutoSize = true;
            lblPoste.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPoste.ForeColor = Color.FromArgb(71, 85, 105);
            lblPoste.Location = new Point(32, 228);
            lblPoste.Name = "lblPoste";
            lblPoste.Size = new Size(42, 17);
            lblPoste.TabIndex = 4;
            lblPoste.Text = "Poste";
            // 
            // cboPoste
            // 
            cboPoste.BackColor = Color.FromArgb(245, 248, 251);
            cboPoste.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPoste.FlatStyle = FlatStyle.Flat;
            cboPoste.Font = new Font("Segoe UI", 10.5F);
            cboPoste.ForeColor = Color.FromArgb(27, 42, 61);
            cboPoste.Items.AddRange(new object[] { "Utilisateur", "Technicien", "Responsable" });
            cboPoste.Location = new Point(32, 250);
            cboPoste.Name = "cboPoste";
            cboPoste.Size = new Size(316, 27);
            cboPoste.TabIndex = 2;
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.BackColor = Color.FromArgb(24, 95, 165);
            btnSeConnecter.Cursor = Cursors.Hand;
            btnSeConnecter.FlatAppearance.BorderSize = 0;
            btnSeConnecter.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnSeConnecter.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnSeConnecter.FlatStyle = FlatStyle.Flat;
            btnSeConnecter.Font = new Font("Segoe UI Semibold", 10.5F);
            btnSeConnecter.ForeColor = Color.White;
            btnSeConnecter.Location = new Point(32, 330);
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.Size = new Size(316, 40);
            btnSeConnecter.TabIndex = 4;
            btnSeConnecter.Text = "Se connecter";
            btnSeConnecter.UseVisualStyleBackColor = false;
            btnSeConnecter.Click += btnSeConnecter_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdmin.BackColor = Color.White;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI Semibold", 10F);
            btnAdmin.ForeColor = Color.FromArgb(24, 95, 165);
            btnAdmin.Location = new Point(1136, 576);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(120, 36);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // tabUtilisateur
            // 
            tabUtilisateur.BackColor = Color.FromArgb(238, 242, 247);
            tabUtilisateur.Controls.Add(carteNouveau);
            tabUtilisateur.Controls.Add(carteTickets);
            tabUtilisateur.Location = new Point(4, 32);
            tabUtilisateur.Name = "tabUtilisateur";
            tabUtilisateur.Padding = new Padding(3);
            tabUtilisateur.Size = new Size(1272, 628);
            tabUtilisateur.TabIndex = 3;
            tabUtilisateur.Text = "Utilisateur";
            // 
            // carteNouveau
            // 
            carteNouveau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            carteNouveau.BackColor = Color.White;
            carteNouveau.Controls.Add(lblNouveau);
            carteNouveau.Controls.Add(lblMateriel);
            carteNouveau.Controls.Add(cboMateriel);
            carteNouveau.Controls.Add(lblIncident);
            carteNouveau.Controls.Add(txtIncident);
            carteNouveau.Controls.Add(btnEnvoyer);
            carteNouveau.Controls.Add(btnAfficher);
            carteNouveau.Location = new Point(16, 16);
            carteNouveau.Name = "carteNouveau";
            carteNouveau.Size = new Size(480, 596);
            carteNouveau.TabIndex = 0;
            // 
            // lblNouveau
            // 
            lblNouveau.AutoSize = true;
            lblNouveau.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNouveau.ForeColor = Color.FromArgb(12, 68, 124);
            lblNouveau.Location = new Point(22, 18);
            lblNouveau.Name = "lblNouveau";
            lblNouveau.Size = new Size(142, 25);
            lblNouveau.TabIndex = 0;
            lblNouveau.Text = "Nouveau ticket";
            // 
            // lblMateriel
            // 
            lblMateriel.AutoSize = true;
            lblMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMateriel.ForeColor = Color.FromArgb(71, 85, 105);
            lblMateriel.Location = new Point(24, 64);
            lblMateriel.Name = "lblMateriel";
            lblMateriel.Size = new Size(116, 17);
            lblMateriel.TabIndex = 1;
            lblMateriel.Text = "Matériel concerné";
            // 
            // cboMateriel
            // 
            cboMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateriel.FlatStyle = FlatStyle.Flat;
            cboMateriel.Font = new Font("Segoe UI", 10.5F);
            cboMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboMateriel.Location = new Point(24, 86);
            cboMateriel.Name = "cboMateriel";
            cboMateriel.Size = new Size(432, 27);
            cboMateriel.TabIndex = 6;
            // 
            // lblIncident
            // 
            lblIncident.AutoSize = true;
            lblIncident.Font = new Font("Segoe UI Semibold", 9.75F);
            lblIncident.ForeColor = Color.FromArgb(71, 85, 105);
            lblIncident.Location = new Point(24, 128);
            lblIncident.Name = "lblIncident";
            lblIncident.Size = new Size(153, 17);
            lblIncident.TabIndex = 8;
            lblIncident.Text = "Description de l'incident";
            // 
            // txtIncident
            // 
            txtIncident.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtIncident.BackColor = Color.FromArgb(245, 248, 251);
            txtIncident.BorderStyle = BorderStyle.FixedSingle;
            txtIncident.Font = new Font("Segoe UI", 10.5F);
            txtIncident.ForeColor = Color.FromArgb(27, 42, 61);
            txtIncident.Location = new Point(24, 150);
            txtIncident.Multiline = true;
            txtIncident.Name = "txtIncident";
            txtIncident.ScrollBars = ScrollBars.Vertical;
            txtIncident.Size = new Size(432, 370);
            txtIncident.TabIndex = 8;
            // 
            // btnEnvoyer
            // 
            btnEnvoyer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEnvoyer.BackColor = Color.FromArgb(24, 95, 165);
            btnEnvoyer.Cursor = Cursors.Hand;
            btnEnvoyer.FlatAppearance.BorderSize = 0;
            btnEnvoyer.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnEnvoyer.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnEnvoyer.FlatStyle = FlatStyle.Flat;
            btnEnvoyer.Font = new Font("Segoe UI Semibold", 10F);
            btnEnvoyer.ForeColor = Color.White;
            btnEnvoyer.Location = new Point(24, 536);
            btnEnvoyer.Name = "btnEnvoyer";
            btnEnvoyer.Size = new Size(140, 38);
            btnEnvoyer.TabIndex = 9;
            btnEnvoyer.Text = "Envoyer";
            btnEnvoyer.UseVisualStyleBackColor = false;
            btnEnvoyer.Click += btnEnvoyer_Click;
            // 
            // btnAfficher
            // 
            btnAfficher.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAfficher.BackColor = Color.White;
            btnAfficher.Cursor = Cursors.Hand;
            btnAfficher.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnAfficher.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnAfficher.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnAfficher.FlatStyle = FlatStyle.Flat;
            btnAfficher.Font = new Font("Segoe UI Semibold", 10F);
            btnAfficher.ForeColor = Color.FromArgb(24, 95, 165);
            btnAfficher.Location = new Point(176, 536);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(190, 38);
            btnAfficher.TabIndex = 10;
            btnAfficher.Text = "Afficher mes tickets";
            btnAfficher.UseVisualStyleBackColor = false;
            btnAfficher.Click += btnAfficher_Click;
            // 
            // carteTickets
            // 
            carteTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carteTickets.BackColor = Color.White;
            carteTickets.Controls.Add(lblMesTickets);
            carteTickets.Controls.Add(lstTickets);
            carteTickets.Location = new Point(512, 16);
            carteTickets.Name = "carteTickets";
            carteTickets.Size = new Size(744, 596);
            carteTickets.TabIndex = 1;
            // 
            // lblMesTickets
            // 
            lblMesTickets.AutoSize = true;
            lblMesTickets.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblMesTickets.ForeColor = Color.FromArgb(12, 68, 124);
            lblMesTickets.Location = new Point(22, 18);
            lblMesTickets.Name = "lblMesTickets";
            lblMesTickets.Size = new Size(108, 25);
            lblMesTickets.TabIndex = 0;
            lblMesTickets.Text = "Mes tickets";
            // 
            // lstTickets
            // 
            lstTickets.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTickets.BackColor = Color.FromArgb(245, 248, 251);
            lstTickets.BorderStyle = BorderStyle.FixedSingle;
            lstTickets.Font = new Font("Segoe UI", 10.5F);
            lstTickets.ForeColor = Color.FromArgb(27, 42, 61);
            lstTickets.IntegralHeight = false;
            lstTickets.ItemHeight = 19;
            lstTickets.Location = new Point(24, 60);
            lstTickets.Name = "lstTickets";
            lstTickets.Size = new Size(696, 512);
            lstTickets.TabIndex = 11;
            // 
            // tabTechnicien
            // 
            tabTechnicien.AutoScroll = true;
            tabTechnicien.BackColor = Color.FromArgb(238, 242, 247);
            tabTechnicien.Controls.Add(carteMateriel);
            tabTechnicien.Controls.Add(carteIncidents);
            tabTechnicien.Controls.Add(carteTicket);
            tabTechnicien.Location = new Point(4, 32);
            tabTechnicien.Name = "tabTechnicien";
            tabTechnicien.Padding = new Padding(3);
            tabTechnicien.Size = new Size(1272, 628);
            tabTechnicien.TabIndex = 4;
            tabTechnicien.Text = "Technicien";
            // 
            // carteMateriel
            // 
            carteMateriel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carteMateriel.BackColor = Color.White;
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
            carteMateriel.Location = new Point(432, 282);
            carteMateriel.Name = "carteMateriel";
            carteMateriel.Size = new Size(824, 330);
            carteMateriel.TabIndex = 0;
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblGestion.ForeColor = Color.FromArgb(12, 68, 124);
            lblGestion.Location = new Point(22, 18);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(179, 25);
            lblGestion.TabIndex = 0;
            lblGestion.Text = "Gestion du matériel";
            // 
            // lblAjout
            // 
            lblAjout.AutoSize = true;
            lblAjout.Font = new Font("Segoe UI Semibold", 10.5F);
            lblAjout.ForeColor = Color.FromArgb(27, 42, 61);
            lblAjout.Location = new Point(24, 58);
            lblAjout.Name = "lblAjout";
            lblAjout.Size = new Size(187, 19);
            lblAjout.TabIndex = 1;
            lblAjout.Text = "Ajouter un nouveau matériel";
            // 
            // lblProcesseur
            // 
            lblProcesseur.AutoSize = true;
            lblProcesseur.Font = new Font("Segoe UI Semibold", 9.75F);
            lblProcesseur.ForeColor = Color.FromArgb(71, 85, 105);
            lblProcesseur.Location = new Point(24, 90);
            lblProcesseur.Name = "lblProcesseur";
            lblProcesseur.Size = new Size(74, 17);
            lblProcesseur.TabIndex = 2;
            lblProcesseur.Text = "Processeur";
            // 
            // txtProcesseur
            // 
            txtProcesseur.BackColor = Color.FromArgb(245, 248, 251);
            txtProcesseur.BorderStyle = BorderStyle.FixedSingle;
            txtProcesseur.Font = new Font("Segoe UI", 10.5F);
            txtProcesseur.ForeColor = Color.FromArgb(27, 42, 61);
            txtProcesseur.Location = new Point(24, 112);
            txtProcesseur.Name = "txtProcesseur";
            txtProcesseur.Size = new Size(172, 26);
            txtProcesseur.TabIndex = 12;
            // 
            // lblDisque
            // 
            lblDisque.AutoSize = true;
            lblDisque.Font = new Font("Segoe UI Semibold", 9.75F);
            lblDisque.ForeColor = Color.FromArgb(71, 85, 105);
            lblDisque.Location = new Point(212, 90);
            lblDisque.Name = "lblDisque";
            lblDisque.Size = new Size(49, 17);
            lblDisque.TabIndex = 13;
            lblDisque.Text = "Disque";
            // 
            // txtDisque
            // 
            txtDisque.BackColor = Color.FromArgb(245, 248, 251);
            txtDisque.BorderStyle = BorderStyle.FixedSingle;
            txtDisque.Font = new Font("Segoe UI", 10.5F);
            txtDisque.ForeColor = Color.FromArgb(27, 42, 61);
            txtDisque.Location = new Point(212, 112);
            txtDisque.Name = "txtDisque";
            txtDisque.Size = new Size(172, 26);
            txtDisque.TabIndex = 13;
            // 
            // lblLogiciels
            // 
            lblLogiciels.AutoSize = true;
            lblLogiciels.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLogiciels.ForeColor = Color.FromArgb(71, 85, 105);
            lblLogiciels.Location = new Point(24, 148);
            lblLogiciels.Name = "lblLogiciels";
            lblLogiciels.Size = new Size(58, 17);
            lblLogiciels.TabIndex = 14;
            lblLogiciels.Text = "Logiciels";
            // 
            // txtLogiciels
            // 
            txtLogiciels.BackColor = Color.FromArgb(245, 248, 251);
            txtLogiciels.BorderStyle = BorderStyle.FixedSingle;
            txtLogiciels.Font = new Font("Segoe UI", 10.5F);
            txtLogiciels.ForeColor = Color.FromArgb(27, 42, 61);
            txtLogiciels.Location = new Point(24, 170);
            txtLogiciels.Name = "txtLogiciels";
            txtLogiciels.Size = new Size(172, 26);
            txtLogiciels.TabIndex = 14;
            // 
            // lblEtatMateriel
            // 
            lblEtatMateriel.AutoSize = true;
            lblEtatMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEtatMateriel.ForeColor = Color.FromArgb(71, 85, 105);
            lblEtatMateriel.Location = new Point(212, 148);
            lblEtatMateriel.Name = "lblEtatMateriel";
            lblEtatMateriel.Size = new Size(32, 17);
            lblEtatMateriel.TabIndex = 15;
            lblEtatMateriel.Text = "État";
            // 
            // cboEtatMateriel
            // 
            cboEtatMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboEtatMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEtatMateriel.FlatStyle = FlatStyle.Flat;
            cboEtatMateriel.Font = new Font("Segoe UI", 10.5F);
            cboEtatMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboEtatMateriel.Items.AddRange(new object[] { "En service", "En panne", "Hors service" });
            cboEtatMateriel.Location = new Point(212, 170);
            cboEtatMateriel.Name = "cboEtatMateriel";
            cboEtatMateriel.Size = new Size(172, 27);
            cboEtatMateriel.TabIndex = 15;
            // 
            // lblSuiviMateriel
            // 
            lblSuiviMateriel.AutoSize = true;
            lblSuiviMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSuiviMateriel.ForeColor = Color.FromArgb(71, 85, 105);
            lblSuiviMateriel.Location = new Point(24, 206);
            lblSuiviMateriel.Name = "lblSuiviMateriel";
            lblSuiviMateriel.Size = new Size(36, 17);
            lblSuiviMateriel.TabIndex = 16;
            lblSuiviMateriel.Text = "Suivi";
            // 
            // txtSuiviMateriel
            // 
            txtSuiviMateriel.BackColor = Color.FromArgb(245, 248, 251);
            txtSuiviMateriel.BorderStyle = BorderStyle.FixedSingle;
            txtSuiviMateriel.Font = new Font("Segoe UI", 10.5F);
            txtSuiviMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            txtSuiviMateriel.Location = new Point(24, 228);
            txtSuiviMateriel.Name = "txtSuiviMateriel";
            txtSuiviMateriel.Size = new Size(360, 26);
            txtSuiviMateriel.TabIndex = 16;
            // 
            // btnAjouterMateriel
            // 
            btnAjouterMateriel.BackColor = Color.FromArgb(24, 95, 165);
            btnAjouterMateriel.Cursor = Cursors.Hand;
            btnAjouterMateriel.FlatAppearance.BorderSize = 0;
            btnAjouterMateriel.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnAjouterMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnAjouterMateriel.FlatStyle = FlatStyle.Flat;
            btnAjouterMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnAjouterMateriel.ForeColor = Color.White;
            btnAjouterMateriel.Location = new Point(24, 270);
            btnAjouterMateriel.Name = "btnAjouterMateriel";
            btnAjouterMateriel.Size = new Size(140, 38);
            btnAjouterMateriel.TabIndex = 17;
            btnAjouterMateriel.Text = "Ajouter";
            btnAjouterMateriel.UseVisualStyleBackColor = false;
            btnAjouterMateriel.Click += btnAjouterMateriel_Click;
            // 
            // separateurMateriel
            // 
            separateurMateriel.BackColor = Color.FromArgb(214, 224, 236);
            separateurMateriel.Location = new Point(408, 58);
            separateurMateriel.Name = "separateurMateriel";
            separateurMateriel.Size = new Size(1, 252);
            separateurMateriel.TabIndex = 18;
            // 
            // lblConsultation
            // 
            lblConsultation.AutoSize = true;
            lblConsultation.Font = new Font("Segoe UI Semibold", 10.5F);
            lblConsultation.ForeColor = Color.FromArgb(27, 42, 61);
            lblConsultation.Location = new Point(432, 58);
            lblConsultation.Name = "lblConsultation";
            lblConsultation.Size = new Size(176, 19);
            lblConsultation.TabIndex = 19;
            lblConsultation.Text = "Consultation d'un matériel";
            // 
            // cboConsultMateriel
            // 
            cboConsultMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboConsultMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultMateriel.FlatStyle = FlatStyle.Flat;
            cboConsultMateriel.Font = new Font("Segoe UI", 10.5F);
            cboConsultMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboConsultMateriel.Location = new Point(432, 90);
            cboConsultMateriel.Name = "cboConsultMateriel";
            cboConsultMateriel.Size = new Size(250, 27);
            cboConsultMateriel.TabIndex = 18;
            // 
            // btnAfficherMateriel
            // 
            btnAfficherMateriel.BackColor = Color.White;
            btnAfficherMateriel.Cursor = Cursors.Hand;
            btnAfficherMateriel.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnAfficherMateriel.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnAfficherMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnAfficherMateriel.FlatStyle = FlatStyle.Flat;
            btnAfficherMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnAfficherMateriel.ForeColor = Color.FromArgb(24, 95, 165);
            btnAfficherMateriel.Location = new Point(692, 88);
            btnAfficherMateriel.Name = "btnAfficherMateriel";
            btnAfficherMateriel.Size = new Size(108, 30);
            btnAfficherMateriel.TabIndex = 19;
            btnAfficherMateriel.Text = "Afficher";
            btnAfficherMateriel.UseVisualStyleBackColor = false;
            btnAfficherMateriel.Click += btnAfficherMateriel_Click;
            // 
            // panelDetail
            // 
            panelDetail.BackColor = Color.FromArgb(245, 248, 251);
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
            panelDetail.Location = new Point(432, 126);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(368, 64);
            panelDetail.TabIndex = 20;
            // 
            // lblDetailProcesseur
            // 
            lblDetailProcesseur.AutoSize = true;
            lblDetailProcesseur.Font = new Font("Segoe UI", 8.5F);
            lblDetailProcesseur.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailProcesseur.Location = new Point(10, 8);
            lblDetailProcesseur.Name = "lblDetailProcesseur";
            lblDetailProcesseur.Size = new Size(64, 15);
            lblDetailProcesseur.TabIndex = 0;
            lblDetailProcesseur.Text = "Processeur";
            // 
            // lblValeurProcesseur
            // 
            lblValeurProcesseur.AutoSize = true;
            lblValeurProcesseur.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurProcesseur.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurProcesseur.Location = new Point(10, 30);
            lblValeurProcesseur.Name = "lblValeurProcesseur";
            lblValeurProcesseur.Size = new Size(15, 19);
            lblValeurProcesseur.TabIndex = 1;
            lblValeurProcesseur.Text = "-";
            // 
            // lblDetailDisque
            // 
            lblDetailDisque.AutoSize = true;
            lblDetailDisque.Font = new Font("Segoe UI", 8.5F);
            lblDetailDisque.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailDisque.Location = new Point(82, 8);
            lblDetailDisque.Name = "lblDetailDisque";
            lblDetailDisque.Size = new Size(43, 15);
            lblDetailDisque.TabIndex = 2;
            lblDetailDisque.Text = "Disque";
            // 
            // lblValeurDisque
            // 
            lblValeurDisque.AutoSize = true;
            lblValeurDisque.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurDisque.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurDisque.Location = new Point(82, 30);
            lblValeurDisque.Name = "lblValeurDisque";
            lblValeurDisque.Size = new Size(15, 19);
            lblValeurDisque.TabIndex = 3;
            lblValeurDisque.Text = "-";
            // 
            // lblDetailLogiciels
            // 
            lblDetailLogiciels.AutoSize = true;
            lblDetailLogiciels.Font = new Font("Segoe UI", 8.5F);
            lblDetailLogiciels.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailLogiciels.Location = new Point(154, 8);
            lblDetailLogiciels.Name = "lblDetailLogiciels";
            lblDetailLogiciels.Size = new Size(53, 15);
            lblDetailLogiciels.TabIndex = 4;
            lblDetailLogiciels.Text = "Logiciels";
            // 
            // lblValeurLogiciels
            // 
            lblValeurLogiciels.AutoSize = true;
            lblValeurLogiciels.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurLogiciels.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurLogiciels.Location = new Point(154, 30);
            lblValeurLogiciels.Name = "lblValeurLogiciels";
            lblValeurLogiciels.Size = new Size(15, 19);
            lblValeurLogiciels.TabIndex = 5;
            lblValeurLogiciels.Text = "-";
            // 
            // lblDetailEtat
            // 
            lblDetailEtat.AutoSize = true;
            lblDetailEtat.Font = new Font("Segoe UI", 8.5F);
            lblDetailEtat.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailEtat.Location = new Point(226, 8);
            lblDetailEtat.Name = "lblDetailEtat";
            lblDetailEtat.Size = new Size(27, 15);
            lblDetailEtat.TabIndex = 6;
            lblDetailEtat.Text = "État";
            // 
            // lblValeurEtat
            // 
            lblValeurEtat.AutoSize = true;
            lblValeurEtat.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurEtat.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurEtat.Location = new Point(226, 30);
            lblValeurEtat.Name = "lblValeurEtat";
            lblValeurEtat.Size = new Size(15, 19);
            lblValeurEtat.TabIndex = 7;
            lblValeurEtat.Text = "-";
            // 
            // lblDetailSuivi
            // 
            lblDetailSuivi.AutoSize = true;
            lblDetailSuivi.Font = new Font("Segoe UI", 8.5F);
            lblDetailSuivi.ForeColor = Color.FromArgb(90, 107, 128);
            lblDetailSuivi.Location = new Point(298, 8);
            lblDetailSuivi.Name = "lblDetailSuivi";
            lblDetailSuivi.Size = new Size(32, 15);
            lblDetailSuivi.TabIndex = 8;
            lblDetailSuivi.Text = "Suivi";
            // 
            // lblValeurSuivi
            // 
            lblValeurSuivi.AutoSize = true;
            lblValeurSuivi.Font = new Font("Segoe UI Semibold", 10F);
            lblValeurSuivi.ForeColor = Color.FromArgb(27, 42, 61);
            lblValeurSuivi.Location = new Point(298, 30);
            lblValeurSuivi.Name = "lblValeurSuivi";
            lblValeurSuivi.Size = new Size(15, 19);
            lblValeurSuivi.TabIndex = 9;
            lblValeurSuivi.Text = "-";
            // 
            // lblSuppression
            // 
            lblSuppression.AutoSize = true;
            lblSuppression.Font = new Font("Segoe UI Semibold", 10.5F);
            lblSuppression.ForeColor = Color.FromArgb(27, 42, 61);
            lblSuppression.Location = new Point(432, 206);
            lblSuppression.Name = "lblSuppression";
            lblSuppression.Size = new Size(172, 19);
            lblSuppression.TabIndex = 21;
            lblSuppression.Text = "Suppression d'un matériel";
            // 
            // cboSupprMateriel
            // 
            cboSupprMateriel.BackColor = Color.FromArgb(245, 248, 251);
            cboSupprMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupprMateriel.FlatStyle = FlatStyle.Flat;
            cboSupprMateriel.Font = new Font("Segoe UI", 10.5F);
            cboSupprMateriel.ForeColor = Color.FromArgb(27, 42, 61);
            cboSupprMateriel.Location = new Point(432, 236);
            cboSupprMateriel.Name = "cboSupprMateriel";
            cboSupprMateriel.Size = new Size(250, 27);
            cboSupprMateriel.TabIndex = 20;
            // 
            // btnSupprimerMateriel
            // 
            btnSupprimerMateriel.BackColor = Color.White;
            btnSupprimerMateriel.Cursor = Cursors.Hand;
            btnSupprimerMateriel.FlatAppearance.BorderColor = Color.FromArgb(240, 149, 149);
            btnSupprimerMateriel.FlatAppearance.MouseDownBackColor = Color.FromArgb(247, 193, 193);
            btnSupprimerMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 235);
            btnSupprimerMateriel.FlatStyle = FlatStyle.Flat;
            btnSupprimerMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnSupprimerMateriel.ForeColor = Color.FromArgb(163, 45, 45);
            btnSupprimerMateriel.Location = new Point(692, 234);
            btnSupprimerMateriel.Name = "btnSupprimerMateriel";
            btnSupprimerMateriel.Size = new Size(108, 30);
            btnSupprimerMateriel.TabIndex = 21;
            btnSupprimerMateriel.Text = "Supprimer";
            btnSupprimerMateriel.UseVisualStyleBackColor = false;
            btnSupprimerMateriel.Click += btnSupprimerMateriel_Click;
            // 
            // carteIncidents
            // 
            carteIncidents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            carteIncidents.BackColor = Color.White;
            carteIncidents.Controls.Add(lblIncidents);
            carteIncidents.Controls.Add(lstIncidents);
            carteIncidents.Controls.Add(btnPrendreEnCharge);
            carteIncidents.Location = new Point(16, 16);
            carteIncidents.Name = "carteIncidents";
            carteIncidents.Size = new Size(400, 596);
            carteIncidents.TabIndex = 1;
            // 
            // lblIncidents
            // 
            lblIncidents.AutoSize = true;
            lblIncidents.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblIncidents.ForeColor = Color.FromArgb(12, 68, 124);
            lblIncidents.Location = new Point(22, 18);
            lblIncidents.Name = "lblIncidents";
            lblIncidents.Size = new Size(90, 25);
            lblIncidents.TabIndex = 0;
            lblIncidents.Text = "Incidents";
            // 
            // lstIncidents
            // 
            lstIncidents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstIncidents.BackColor = Color.FromArgb(245, 248, 251);
            lstIncidents.BorderStyle = BorderStyle.FixedSingle;
            lstIncidents.Font = new Font("Segoe UI", 10.5F);
            lstIncidents.ForeColor = Color.FromArgb(27, 42, 61);
            lstIncidents.IntegralHeight = false;
            lstIncidents.ItemHeight = 19;
            lstIncidents.Location = new Point(24, 60);
            lstIncidents.Name = "lstIncidents";
            lstIncidents.Size = new Size(352, 470);
            lstIncidents.TabIndex = 22;
            lstIncidents.SelectedIndexChanged += lstIncidents_SelectedIndexChanged;
            // 
            // btnPrendreEnCharge
            // 
            btnPrendreEnCharge.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPrendreEnCharge.BackColor = Color.FromArgb(24, 95, 165);
            btnPrendreEnCharge.Cursor = Cursors.Hand;
            btnPrendreEnCharge.FlatAppearance.BorderSize = 0;
            btnPrendreEnCharge.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnPrendreEnCharge.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnPrendreEnCharge.FlatStyle = FlatStyle.Flat;
            btnPrendreEnCharge.Font = new Font("Segoe UI Semibold", 10F);
            btnPrendreEnCharge.ForeColor = Color.White;
            btnPrendreEnCharge.Location = new Point(24, 544);
            btnPrendreEnCharge.Name = "btnPrendreEnCharge";
            btnPrendreEnCharge.Size = new Size(200, 38);
            btnPrendreEnCharge.TabIndex = 23;
            btnPrendreEnCharge.Text = "Prendre en charge";
            btnPrendreEnCharge.UseVisualStyleBackColor = false;
            btnPrendreEnCharge.Click += btnPrendreEnCharge_Click;
            // 
            // carteTicket
            // 
            carteTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            carteTicket.BackColor = Color.White;
            carteTicket.Controls.Add(lblTicketSelection);
            carteTicket.Controls.Add(lblEtatActuel);
            carteTicket.Controls.Add(lblEtat);
            carteTicket.Controls.Add(panelEtat);
            carteTicket.Controls.Add(lblUrgence);
            carteTicket.Controls.Add(panelUrgence);
            carteTicket.Controls.Add(lblSuivi);
            carteTicket.Controls.Add(txtSuivi);
            carteTicket.Controls.Add(btnEnregistrer);
            carteTicket.Location = new Point(432, 16);
            carteTicket.Name = "carteTicket";
            carteTicket.Size = new Size(824, 250);
            carteTicket.TabIndex = 2;
            // 
            // lblTicketSelection
            // 
            lblTicketSelection.AutoSize = true;
            lblTicketSelection.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTicketSelection.ForeColor = Color.FromArgb(12, 68, 124);
            lblTicketSelection.Location = new Point(22, 18);
            lblTicketSelection.Name = "lblTicketSelection";
            lblTicketSelection.Size = new Size(166, 25);
            lblTicketSelection.TabIndex = 0;
            lblTicketSelection.Text = "Ticket sélectionné";
            // 
            // lblEtatActuel
            // 
            lblEtatActuel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblEtatActuel.Font = new Font("Segoe UI", 10F);
            lblEtatActuel.ForeColor = Color.FromArgb(90, 107, 128);
            lblEtatActuel.Location = new Point(560, 22);
            lblEtatActuel.Name = "lblEtatActuel";
            lblEtatActuel.Size = new Size(240, 22);
            lblEtatActuel.TabIndex = 1;
            lblEtatActuel.Text = "État actuel : -";
            lblEtatActuel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEtat
            // 
            lblEtat.AutoSize = true;
            lblEtat.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEtat.ForeColor = Color.FromArgb(71, 85, 105);
            lblEtat.Location = new Point(24, 62);
            lblEtat.Name = "lblEtat";
            lblEtat.Size = new Size(32, 17);
            lblEtat.TabIndex = 2;
            lblEtat.Text = "État";
            // 
            // panelEtat
            // 
            panelEtat.BackColor = Color.White;
            panelEtat.Controls.Add(rbEnCours);
            panelEtat.Controls.Add(rbResolu);
            panelEtat.Controls.Add(rbCloture);
            panelEtat.Location = new Point(24, 84);
            panelEtat.Name = "panelEtat";
            panelEtat.Size = new Size(400, 30);
            panelEtat.TabIndex = 24;
            // 
            // rbEnCours
            // 
            rbEnCours.AutoSize = true;
            rbEnCours.Checked = true;
            rbEnCours.Font = new Font("Segoe UI", 10F);
            rbEnCours.ForeColor = Color.FromArgb(27, 42, 61);
            rbEnCours.Location = new Point(0, 4);
            rbEnCours.Name = "rbEnCours";
            rbEnCours.Size = new Size(79, 23);
            rbEnCours.TabIndex = 0;
            rbEnCours.TabStop = true;
            rbEnCours.Text = "En cours";
            // 
            // rbResolu
            // 
            rbResolu.AutoSize = true;
            rbResolu.Font = new Font("Segoe UI", 10F);
            rbResolu.ForeColor = Color.FromArgb(27, 42, 61);
            rbResolu.Location = new Point(130, 4);
            rbResolu.Name = "rbResolu";
            rbResolu.Size = new Size(67, 23);
            rbResolu.TabIndex = 1;
            rbResolu.Text = "Résolu";
            // 
            // rbCloture
            // 
            rbCloture.AutoSize = true;
            rbCloture.Font = new Font("Segoe UI", 10F);
            rbCloture.ForeColor = Color.FromArgb(27, 42, 61);
            rbCloture.Location = new Point(260, 4);
            rbCloture.Name = "rbCloture";
            rbCloture.Size = new Size(72, 23);
            rbCloture.TabIndex = 2;
            rbCloture.Text = "Clôturé";
            // 
            // lblUrgence
            // 
            lblUrgence.AutoSize = true;
            lblUrgence.Font = new Font("Segoe UI Semibold", 9.75F);
            lblUrgence.ForeColor = Color.FromArgb(71, 85, 105);
            lblUrgence.Location = new Point(440, 62);
            lblUrgence.Name = "lblUrgence";
            lblUrgence.Size = new Size(114, 17);
            lblUrgence.TabIndex = 25;
            lblUrgence.Text = "Niveau d'urgence";
            // 
            // panelUrgence
            // 
            panelUrgence.BackColor = Color.White;
            panelUrgence.Controls.Add(rbFaible);
            panelUrgence.Controls.Add(rbMoyen);
            panelUrgence.Controls.Add(rbCritique);
            panelUrgence.Location = new Point(440, 84);
            panelUrgence.Name = "panelUrgence";
            panelUrgence.Size = new Size(360, 30);
            panelUrgence.TabIndex = 25;
            // 
            // rbFaible
            // 
            rbFaible.AutoSize = true;
            rbFaible.Checked = true;
            rbFaible.Font = new Font("Segoe UI", 10F);
            rbFaible.ForeColor = Color.FromArgb(27, 42, 61);
            rbFaible.Location = new Point(0, 4);
            rbFaible.Name = "rbFaible";
            rbFaible.Size = new Size(62, 23);
            rbFaible.TabIndex = 0;
            rbFaible.TabStop = true;
            rbFaible.Text = "Faible";
            // 
            // rbMoyen
            // 
            rbMoyen.AutoSize = true;
            rbMoyen.Font = new Font("Segoe UI", 10F);
            rbMoyen.ForeColor = Color.FromArgb(27, 42, 61);
            rbMoyen.Location = new Point(110, 4);
            rbMoyen.Name = "rbMoyen";
            rbMoyen.Size = new Size(70, 23);
            rbMoyen.TabIndex = 1;
            rbMoyen.Text = "Moyen";
            // 
            // rbCritique
            // 
            rbCritique.AutoSize = true;
            rbCritique.Font = new Font("Segoe UI", 10F);
            rbCritique.ForeColor = Color.FromArgb(27, 42, 61);
            rbCritique.Location = new Point(220, 4);
            rbCritique.Name = "rbCritique";
            rbCritique.Size = new Size(75, 23);
            rbCritique.TabIndex = 2;
            rbCritique.Text = "Critique";
            // 
            // lblSuivi
            // 
            lblSuivi.AutoSize = true;
            lblSuivi.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSuivi.ForeColor = Color.FromArgb(71, 85, 105);
            lblSuivi.Location = new Point(24, 124);
            lblSuivi.Name = "lblSuivi";
            lblSuivi.Size = new Size(137, 17);
            lblSuivi.TabIndex = 26;
            lblSuivi.Text = "Suivi (travail effectué)";
            // 
            // txtSuivi
            // 
            txtSuivi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSuivi.BackColor = Color.FromArgb(245, 248, 251);
            txtSuivi.BorderStyle = BorderStyle.FixedSingle;
            txtSuivi.Font = new Font("Segoe UI", 10.5F);
            txtSuivi.ForeColor = Color.FromArgb(27, 42, 61);
            txtSuivi.Location = new Point(24, 146);
            txtSuivi.Multiline = true;
            txtSuivi.Name = "txtSuivi";
            txtSuivi.ScrollBars = ScrollBars.Vertical;
            txtSuivi.Size = new Size(620, 80);
            txtSuivi.TabIndex = 26;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEnregistrer.BackColor = Color.FromArgb(24, 95, 165);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnEnregistrer.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI Semibold", 10F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(660, 188);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(140, 38);
            btnEnregistrer.TabIndex = 27;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // tabResponsable
            // 
            tabResponsable.BackColor = Color.FromArgb(238, 242, 247);
            tabResponsable.Controls.Add(cartePersonnel);
            tabResponsable.Controls.Add(carteStats);
            tabResponsable.Location = new Point(4, 32);
            tabResponsable.Name = "tabResponsable";
            tabResponsable.Padding = new Padding(3);
            tabResponsable.Size = new Size(1272, 628);
            tabResponsable.TabIndex = 5;
            tabResponsable.Text = "Responsable";
            // 
            // cartePersonnel
            // 
            cartePersonnel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cartePersonnel.BackColor = Color.White;
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
            cartePersonnel.Location = new Point(16, 16);
            cartePersonnel.Name = "cartePersonnel";
            cartePersonnel.Size = new Size(1240, 362);
            cartePersonnel.TabIndex = 0;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9.75F);
            lblType.ForeColor = Color.FromArgb(71, 85, 105);
            lblType.Location = new Point(24, 24);
            lblType.Name = "lblType";
            lblType.Size = new Size(105, 17);
            lblType.TabIndex = 0;
            lblType.Text = "Type de compte";
            // 
            // panelType
            // 
            panelType.BackColor = Color.White;
            panelType.Controls.Add(rbTechnicien);
            panelType.Controls.Add(rbUtilisateur);
            panelType.Location = new Point(24, 46);
            panelType.Name = "panelType";
            panelType.Size = new Size(300, 30);
            panelType.TabIndex = 28;
            // 
            // rbTechnicien
            // 
            rbTechnicien.AutoSize = true;
            rbTechnicien.Checked = true;
            rbTechnicien.Font = new Font("Segoe UI", 10F);
            rbTechnicien.ForeColor = Color.FromArgb(27, 42, 61);
            rbTechnicien.Location = new Point(0, 4);
            rbTechnicien.Name = "rbTechnicien";
            rbTechnicien.Size = new Size(89, 23);
            rbTechnicien.TabIndex = 0;
            rbTechnicien.TabStop = true;
            rbTechnicien.Text = "Technicien";
            rbTechnicien.CheckedChanged += rbTechnicien_CheckedChanged;
            // 
            // rbUtilisateur
            // 
            rbUtilisateur.AutoSize = true;
            rbUtilisateur.Font = new Font("Segoe UI", 10F);
            rbUtilisateur.ForeColor = Color.FromArgb(27, 42, 61);
            rbUtilisateur.Location = new Point(130, 4);
            rbUtilisateur.Name = "rbUtilisateur";
            rbUtilisateur.Size = new Size(89, 23);
            rbUtilisateur.TabIndex = 1;
            rbUtilisateur.Text = "Utilisateur";
            rbUtilisateur.CheckedChanged += rbUtilisateur_CheckedChanged;
            // 
            // lblPersonne
            // 
            lblPersonne.AutoSize = true;
            lblPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblPersonne.Location = new Point(24, 92);
            lblPersonne.Name = "lblPersonne";
            lblPersonne.Size = new Size(216, 17);
            lblPersonne.TabIndex = 29;
            lblPersonne.Text = "Personne à modifier ou supprimer";
            // 
            // cboPersonne
            // 
            cboPersonne.BackColor = Color.FromArgb(245, 248, 251);
            cboPersonne.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonne.FlatStyle = FlatStyle.Flat;
            cboPersonne.Font = new Font("Segoe UI", 10.5F);
            cboPersonne.ForeColor = Color.FromArgb(27, 42, 61);
            cboPersonne.Location = new Point(24, 114);
            cboPersonne.Name = "cboPersonne";
            cboPersonne.Size = new Size(300, 27);
            cboPersonne.TabIndex = 29;
            cboPersonne.SelectedIndexChanged += cboPersonne_SelectedIndexChanged;
            // 
            // separateurPersonnel
            // 
            separateurPersonnel.BackColor = Color.FromArgb(214, 224, 236);
            separateurPersonnel.Location = new Point(360, 24);
            separateurPersonnel.Name = "separateurPersonnel";
            separateurPersonnel.Size = new Size(1, 314);
            separateurPersonnel.TabIndex = 30;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI Semibold", 9.75F);
            lblNom.ForeColor = Color.FromArgb(71, 85, 105);
            lblNom.Location = new Point(384, 24);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(38, 17);
            lblNom.TabIndex = 31;
            lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.FromArgb(245, 248, 251);
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Font = new Font("Segoe UI", 10.5F);
            txtNom.ForeColor = Color.FromArgb(27, 42, 61);
            txtNom.Location = new Point(384, 46);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(340, 26);
            txtNom.TabIndex = 30;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPrenom.ForeColor = Color.FromArgb(71, 85, 105);
            lblPrenom.Location = new Point(748, 24);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(56, 17);
            lblPrenom.TabIndex = 32;
            lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.FromArgb(245, 248, 251);
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Font = new Font("Segoe UI", 10.5F);
            txtPrenom.ForeColor = Color.FromArgb(27, 42, 61);
            txtPrenom.Location = new Point(748, 46);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(340, 26);
            txtPrenom.TabIndex = 31;
            // 
            // lblDateEmbauche
            // 
            lblDateEmbauche.AutoSize = true;
            lblDateEmbauche.Font = new Font("Segoe UI Semibold", 9.75F);
            lblDateEmbauche.ForeColor = Color.FromArgb(71, 85, 105);
            lblDateEmbauche.Location = new Point(384, 86);
            lblDateEmbauche.Name = "lblDateEmbauche";
            lblDateEmbauche.Size = new Size(114, 17);
            lblDateEmbauche.TabIndex = 33;
            lblDateEmbauche.Text = "Date d'embauche";
            // 
            // dtpDateEmbauche
            // 
            dtpDateEmbauche.Font = new Font("Segoe UI", 10.5F);
            dtpDateEmbauche.Format = DateTimePickerFormat.Short;
            dtpDateEmbauche.Location = new Point(384, 108);
            dtpDateEmbauche.Name = "dtpDateEmbauche";
            dtpDateEmbauche.Size = new Size(340, 26);
            dtpDateEmbauche.TabIndex = 32;
            // 
            // lblPostePersonne
            // 
            lblPostePersonne.AutoSize = true;
            lblPostePersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPostePersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblPostePersonne.Location = new Point(748, 86);
            lblPostePersonne.Name = "lblPostePersonne";
            lblPostePersonne.Size = new Size(42, 17);
            lblPostePersonne.TabIndex = 34;
            lblPostePersonne.Text = "Poste";
            // 
            // txtPostePersonne
            // 
            txtPostePersonne.BackColor = Color.FromArgb(245, 248, 251);
            txtPostePersonne.BorderStyle = BorderStyle.FixedSingle;
            txtPostePersonne.Font = new Font("Segoe UI", 10.5F);
            txtPostePersonne.ForeColor = Color.FromArgb(27, 42, 61);
            txtPostePersonne.Location = new Point(748, 108);
            txtPostePersonne.Name = "txtPostePersonne";
            txtPostePersonne.Size = new Size(340, 26);
            txtPostePersonne.TabIndex = 33;
            // 
            // lblLoginPersonne
            // 
            lblLoginPersonne.AutoSize = true;
            lblLoginPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLoginPersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblLoginPersonne.Location = new Point(384, 148);
            lblLoginPersonne.Name = "lblLoginPersonne";
            lblLoginPersonne.Size = new Size(41, 17);
            lblLoginPersonne.TabIndex = 35;
            lblLoginPersonne.Text = "Login";
            // 
            // txtLoginPersonne
            // 
            txtLoginPersonne.BackColor = Color.FromArgb(245, 248, 251);
            txtLoginPersonne.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPersonne.Font = new Font("Segoe UI", 10.5F);
            txtLoginPersonne.ForeColor = Color.FromArgb(27, 42, 61);
            txtLoginPersonne.Location = new Point(384, 170);
            txtLoginPersonne.Name = "txtLoginPersonne";
            txtLoginPersonne.Size = new Size(340, 26);
            txtLoginPersonne.TabIndex = 34;
            // 
            // lblMdpPersonne
            // 
            lblMdpPersonne.AutoSize = true;
            lblMdpPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMdpPersonne.ForeColor = Color.FromArgb(71, 85, 105);
            lblMdpPersonne.Location = new Point(748, 148);
            lblMdpPersonne.Name = "lblMdpPersonne";
            lblMdpPersonne.Size = new Size(90, 17);
            lblMdpPersonne.TabIndex = 36;
            lblMdpPersonne.Text = "Mot de passe";
            // 
            // txtMdpPersonne
            // 
            txtMdpPersonne.BackColor = Color.FromArgb(245, 248, 251);
            txtMdpPersonne.BorderStyle = BorderStyle.FixedSingle;
            txtMdpPersonne.Font = new Font("Segoe UI", 10.5F);
            txtMdpPersonne.ForeColor = Color.FromArgb(27, 42, 61);
            txtMdpPersonne.Location = new Point(748, 170);
            txtMdpPersonne.Name = "txtMdpPersonne";
            txtMdpPersonne.Size = new Size(340, 26);
            txtMdpPersonne.TabIndex = 35;
            txtMdpPersonne.UseSystemPasswordChar = true;
            // 
            // panelTechnicien
            // 
            panelTechnicien.BackColor = Color.White;
            panelTechnicien.Controls.Add(lblFormation);
            panelTechnicien.Controls.Add(txtFormation);
            panelTechnicien.Controls.Add(lblCompetence);
            panelTechnicien.Controls.Add(txtCompetence);
            panelTechnicien.Location = new Point(384, 210);
            panelTechnicien.Name = "panelTechnicien";
            panelTechnicien.Size = new Size(704, 70);
            panelTechnicien.TabIndex = 37;
            // 
            // lblFormation
            // 
            lblFormation.AutoSize = true;
            lblFormation.Font = new Font("Segoe UI Semibold", 9.75F);
            lblFormation.ForeColor = Color.FromArgb(71, 85, 105);
            lblFormation.Location = new Point(0, 8);
            lblFormation.Name = "lblFormation";
            lblFormation.Size = new Size(71, 17);
            lblFormation.TabIndex = 0;
            lblFormation.Text = "Formation";
            // 
            // txtFormation
            // 
            txtFormation.BackColor = Color.FromArgb(245, 248, 251);
            txtFormation.BorderStyle = BorderStyle.FixedSingle;
            txtFormation.Font = new Font("Segoe UI", 10.5F);
            txtFormation.ForeColor = Color.FromArgb(27, 42, 61);
            txtFormation.Location = new Point(0, 30);
            txtFormation.Name = "txtFormation";
            txtFormation.Size = new Size(340, 26);
            txtFormation.TabIndex = 36;
            // 
            // lblCompetence
            // 
            lblCompetence.AutoSize = true;
            lblCompetence.Font = new Font("Segoe UI Semibold", 9.75F);
            lblCompetence.ForeColor = Color.FromArgb(71, 85, 105);
            lblCompetence.Location = new Point(364, 8);
            lblCompetence.Name = "lblCompetence";
            lblCompetence.Size = new Size(84, 17);
            lblCompetence.TabIndex = 37;
            lblCompetence.Text = "Compétence";
            // 
            // txtCompetence
            // 
            txtCompetence.BackColor = Color.FromArgb(245, 248, 251);
            txtCompetence.BorderStyle = BorderStyle.FixedSingle;
            txtCompetence.Font = new Font("Segoe UI", 10.5F);
            txtCompetence.ForeColor = Color.FromArgb(27, 42, 61);
            txtCompetence.Location = new Point(364, 30);
            txtCompetence.Name = "txtCompetence";
            txtCompetence.Size = new Size(340, 26);
            txtCompetence.TabIndex = 37;
            // 
            // btnAjouterPersonne
            // 
            btnAjouterPersonne.BackColor = Color.FromArgb(24, 95, 165);
            btnAjouterPersonne.Cursor = Cursors.Hand;
            btnAjouterPersonne.FlatAppearance.BorderSize = 0;
            btnAjouterPersonne.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 44, 83);
            btnAjouterPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(12, 68, 124);
            btnAjouterPersonne.FlatStyle = FlatStyle.Flat;
            btnAjouterPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnAjouterPersonne.ForeColor = Color.White;
            btnAjouterPersonne.Location = new Point(384, 300);
            btnAjouterPersonne.Name = "btnAjouterPersonne";
            btnAjouterPersonne.Size = new Size(120, 38);
            btnAjouterPersonne.TabIndex = 38;
            btnAjouterPersonne.Text = "Ajouter";
            btnAjouterPersonne.UseVisualStyleBackColor = false;
            btnAjouterPersonne.Click += btnAjouterPersonne_Click;
            // 
            // btnModifierPersonne
            // 
            btnModifierPersonne.BackColor = Color.White;
            btnModifierPersonne.Cursor = Cursors.Hand;
            btnModifierPersonne.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnModifierPersonne.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnModifierPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnModifierPersonne.FlatStyle = FlatStyle.Flat;
            btnModifierPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnModifierPersonne.ForeColor = Color.FromArgb(24, 95, 165);
            btnModifierPersonne.Location = new Point(516, 300);
            btnModifierPersonne.Name = "btnModifierPersonne";
            btnModifierPersonne.Size = new Size(120, 38);
            btnModifierPersonne.TabIndex = 39;
            btnModifierPersonne.Text = "Modifier";
            btnModifierPersonne.UseVisualStyleBackColor = false;
            btnModifierPersonne.Click += btnModifierPersonne_Click;
            // 
            // btnSupprimerPersonne
            // 
            btnSupprimerPersonne.BackColor = Color.White;
            btnSupprimerPersonne.Cursor = Cursors.Hand;
            btnSupprimerPersonne.FlatAppearance.BorderColor = Color.FromArgb(240, 149, 149);
            btnSupprimerPersonne.FlatAppearance.MouseDownBackColor = Color.FromArgb(247, 193, 193);
            btnSupprimerPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 235, 235);
            btnSupprimerPersonne.FlatStyle = FlatStyle.Flat;
            btnSupprimerPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnSupprimerPersonne.ForeColor = Color.FromArgb(163, 45, 45);
            btnSupprimerPersonne.Location = new Point(648, 300);
            btnSupprimerPersonne.Name = "btnSupprimerPersonne";
            btnSupprimerPersonne.Size = new Size(120, 38);
            btnSupprimerPersonne.TabIndex = 40;
            btnSupprimerPersonne.Text = "Supprimer";
            btnSupprimerPersonne.UseVisualStyleBackColor = false;
            btnSupprimerPersonne.Click += btnSupprimerPersonne_Click;
            // 
            // carteStats
            // 
            carteStats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            carteStats.BackColor = Color.White;
            carteStats.Controls.Add(lblStats);
            carteStats.Controls.Add(btnActualiserStats);
            carteStats.Controls.Add(lblStatsIncidents);
            carteStats.Controls.Add(lstStatsIncidents);
            carteStats.Controls.Add(lblStatsTechniciens);
            carteStats.Controls.Add(lstStatsTechniciens);
            carteStats.Controls.Add(lblStatsUtilisateurs);
            carteStats.Controls.Add(lstStatsUtilisateurs);
            carteStats.Location = new Point(16, 394);
            carteStats.Name = "carteStats";
            carteStats.Size = new Size(1240, 218);
            carteStats.TabIndex = 1;
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblStats.ForeColor = Color.FromArgb(12, 68, 124);
            lblStats.Location = new Point(22, 18);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(111, 25);
            lblStats.TabIndex = 0;
            lblStats.Text = "Statistiques";
            // 
            // btnActualiserStats
            // 
            btnActualiserStats.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualiserStats.BackColor = Color.White;
            btnActualiserStats.Cursor = Cursors.Hand;
            btnActualiserStats.FlatAppearance.BorderColor = Color.FromArgb(133, 183, 235);
            btnActualiserStats.FlatAppearance.MouseDownBackColor = Color.FromArgb(181, 212, 244);
            btnActualiserStats.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 241, 251);
            btnActualiserStats.FlatStyle = FlatStyle.Flat;
            btnActualiserStats.Font = new Font("Segoe UI Semibold", 10F);
            btnActualiserStats.ForeColor = Color.FromArgb(24, 95, 165);
            btnActualiserStats.Location = new Point(1096, 14);
            btnActualiserStats.Name = "btnActualiserStats";
            btnActualiserStats.Size = new Size(120, 32);
            btnActualiserStats.TabIndex = 1;
            btnActualiserStats.Text = "Actualiser";
            btnActualiserStats.UseVisualStyleBackColor = false;
            btnActualiserStats.Click += btnActualiserStats_Click;
            // 
            // lblStatsIncidents
            // 
            lblStatsIncidents.AutoSize = true;
            lblStatsIncidents.Font = new Font("Segoe UI Semibold", 9.75F);
            lblStatsIncidents.ForeColor = Color.FromArgb(71, 85, 105);
            lblStatsIncidents.Location = new Point(24, 56);
            lblStatsIncidents.Name = "lblStatsIncidents";
            lblStatsIncidents.Size = new Size(115, 17);
            lblStatsIncidents.TabIndex = 2;
            lblStatsIncidents.Text = "Incidents par état";
            // 
            // lstStatsIncidents
            // 
            lstStatsIncidents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstStatsIncidents.BackColor = Color.FromArgb(245, 248, 251);
            lstStatsIncidents.BorderStyle = BorderStyle.FixedSingle;
            lstStatsIncidents.Font = new Font("Segoe UI", 10.5F);
            lstStatsIncidents.ForeColor = Color.FromArgb(27, 42, 61);
            lstStatsIncidents.IntegralHeight = false;
            lstStatsIncidents.ItemHeight = 19;
            lstStatsIncidents.Location = new Point(24, 78);
            lstStatsIncidents.Name = "lstStatsIncidents";
            lstStatsIncidents.Size = new Size(381, 120);
            lstStatsIncidents.TabIndex = 3;
            // 
            // lblStatsTechniciens
            // 
            lblStatsTechniciens.AutoSize = true;
            lblStatsTechniciens.Font = new Font("Segoe UI Semibold", 9.75F);
            lblStatsTechniciens.ForeColor = Color.FromArgb(71, 85, 105);
            lblStatsTechniciens.Location = new Point(429, 56);
            lblStatsTechniciens.Name = "lblStatsTechniciens";
            lblStatsTechniciens.Size = new Size(93, 17);
            lblStatsTechniciens.TabIndex = 4;
            lblStatsTechniciens.Text = "Par technicien";
            // 
            // lstStatsTechniciens
            // 
            lstStatsTechniciens.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstStatsTechniciens.BackColor = Color.FromArgb(245, 248, 251);
            lstStatsTechniciens.BorderStyle = BorderStyle.FixedSingle;
            lstStatsTechniciens.Font = new Font("Segoe UI", 10.5F);
            lstStatsTechniciens.ForeColor = Color.FromArgb(27, 42, 61);
            lstStatsTechniciens.IntegralHeight = false;
            lstStatsTechniciens.ItemHeight = 19;
            lstStatsTechniciens.Location = new Point(429, 78);
            lstStatsTechniciens.Name = "lstStatsTechniciens";
            lstStatsTechniciens.Size = new Size(381, 120);
            lstStatsTechniciens.TabIndex = 5;
            // 
            // lblStatsUtilisateurs
            // 
            lblStatsUtilisateurs.AutoSize = true;
            lblStatsUtilisateurs.Font = new Font("Segoe UI Semibold", 9.75F);
            lblStatsUtilisateurs.ForeColor = Color.FromArgb(71, 85, 105);
            lblStatsUtilisateurs.Location = new Point(834, 56);
            lblStatsUtilisateurs.Name = "lblStatsUtilisateurs";
            lblStatsUtilisateurs.Size = new Size(92, 17);
            lblStatsUtilisateurs.TabIndex = 6;
            lblStatsUtilisateurs.Text = "Par utilisateur";
            // 
            // lstStatsUtilisateurs
            // 
            lstStatsUtilisateurs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstStatsUtilisateurs.BackColor = Color.FromArgb(245, 248, 251);
            lstStatsUtilisateurs.BorderStyle = BorderStyle.FixedSingle;
            lstStatsUtilisateurs.Font = new Font("Segoe UI", 10.5F);
            lstStatsUtilisateurs.ForeColor = Color.FromArgb(27, 42, 61);
            lstStatsUtilisateurs.IntegralHeight = false;
            lstStatsUtilisateurs.ItemHeight = 19;
            lstStatsUtilisateurs.Location = new Point(834, 78);
            lstStatsUtilisateurs.Name = "lstStatsUtilisateurs";
            lstStatsUtilisateurs.Size = new Size(381, 120);
            lstStatsUtilisateurs.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(238, 242, 247);
            ClientSize = new Size(1280, 720);
            Controls.Add(panelEntete);
            Controls.Add(tabMenu);
            Font = new Font("Segoe UI", 9.75F);
            MinimumSize = new Size(1100, 700);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Support informatique";
            WindowState = FormWindowState.Maximized;
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
            carteStats.ResumeLayout(false);
            carteStats.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelEntete;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblUtilisateur;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabConnexion;
        private System.Windows.Forms.Button btnAdmin;
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
        private System.Windows.Forms.Panel carteStats;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Button btnActualiserStats;
        private System.Windows.Forms.Label lblStatsIncidents;
        private System.Windows.Forms.ListBox lstStatsIncidents;
        private System.Windows.Forms.Label lblStatsTechniciens;
        private System.Windows.Forms.ListBox lstStatsTechniciens;
        private System.Windows.Forms.Label lblStatsUtilisateurs;
        private System.Windows.Forms.ListBox lstStatsUtilisateurs;
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