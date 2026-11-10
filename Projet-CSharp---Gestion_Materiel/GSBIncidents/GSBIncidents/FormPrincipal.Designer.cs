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
            txtPoste = new TextBox();
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
            panelEntete.BackColor = Color.White;
            panelEntete.Controls.Add(lblApplication);
            panelEntete.Controls.Add(lblUtilisateur);
            panelEntete.Controls.Add(btnDeconnexion);
            panelEntete.Location = new Point(0, 0);
            panelEntete.Name = "panelEntete";
            panelEntete.Size = new Size(1100, 56);
            panelEntete.TabIndex = 0;
            // 
            // lblApplication
            // 
            lblApplication.AutoSize = true;
            lblApplication.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblApplication.ForeColor = Color.FromArgb(31, 41, 55);
            lblApplication.Location = new Point(24, 16);
            lblApplication.Name = "lblApplication";
            lblApplication.Size = new Size(348, 45);
            lblApplication.TabIndex = 0;
            lblApplication.Text = "Support informatique";
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.Font = new Font("Segoe UI", 10F);
            lblUtilisateur.ForeColor = Color.FromArgb(107, 114, 128);
            lblUtilisateur.Location = new Point(724, 16);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(200, 24);
            lblUtilisateur.TabIndex = 1;
            lblUtilisateur.Text = "Nom Prénom";
            lblUtilisateur.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnDeconnexion
            // 
            btnDeconnexion.BackColor = Color.White;
            btnDeconnexion.Cursor = Cursors.Hand;
            btnDeconnexion.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnDeconnexion.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.Font = new Font("Segoe UI Semibold", 10F);
            btnDeconnexion.ForeColor = Color.FromArgb(31, 41, 55);
            btnDeconnexion.Location = new Point(936, 12);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(140, 32);
            btnDeconnexion.TabIndex = 0;
            btnDeconnexion.Text = "Se déconnecter";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(tabConnexion);
            tabMenu.Controls.Add(tabUtilisateur);
            tabMenu.Controls.Add(tabTechnicien);
            tabMenu.Controls.Add(tabResponsable);
            tabMenu.Font = new Font("Segoe UI", 10F);
            tabMenu.Location = new Point(16, 72);
            tabMenu.Name = "tabMenu";
            tabMenu.Padding = new Point(16, 6);
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(1068, 572);
            tabMenu.TabIndex = 1;
            // 
            // tabConnexion
            // 
            tabConnexion.BackColor = Color.FromArgb(243, 244, 246);
            tabConnexion.Controls.Add(carteConnexion);
            tabConnexion.Location = new Point(8, 55);
            tabConnexion.Name = "tabConnexion";
            tabConnexion.Padding = new Padding(3);
            tabConnexion.Size = new Size(1052, 509);
            tabConnexion.TabIndex = 2;
            tabConnexion.Text = "Connexion";
            // 
            // carteConnexion
            // 
            carteConnexion.BackColor = Color.White;
            carteConnexion.Controls.Add(lblTitre);
            carteConnexion.Controls.Add(lblSousTitre);
            carteConnexion.Controls.Add(lblLogin);
            carteConnexion.Controls.Add(txtLogin);
            carteConnexion.Controls.Add(lblMotDePasse);
            carteConnexion.Controls.Add(txtMotDePasse);
            carteConnexion.Controls.Add(lblPoste);
            carteConnexion.Controls.Add(txtPoste);
            carteConnexion.Controls.Add(chkResterConnecte);
            carteConnexion.Controls.Add(btnSeConnecter);
            carteConnexion.Location = new Point(350, 55);
            carteConnexion.Name = "carteConnexion";
            carteConnexion.Size = new Size(360, 424);
            carteConnexion.TabIndex = 0;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitre.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitre.Location = new Point(30, 30);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(303, 72);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Connexion";
            // 
            // lblSousTitre
            // 
            lblSousTitre.AutoSize = true;
            lblSousTitre.Font = new Font("Segoe UI", 9.75F);
            lblSousTitre.ForeColor = Color.FromArgb(107, 114, 128);
            lblSousTitre.Location = new Point(33, 74);
            lblSousTitre.Name = "lblSousTitre";
            lblSousTitre.Size = new Size(543, 36);
            lblSousTitre.TabIndex = 1;
            lblSousTitre.Text = "Connectez-vous pour accéder à votre compte.";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLogin.ForeColor = Color.FromArgb(31, 41, 55);
            lblLogin.Location = new Point(32, 120);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(82, 36);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 10.5F);
            txtLogin.Location = new Point(32, 142);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(296, 45);
            txtLogin.TabIndex = 0;
            // 
            // lblMotDePasse
            // 
            lblMotDePasse.AutoSize = true;
            lblMotDePasse.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMotDePasse.ForeColor = Color.FromArgb(31, 41, 55);
            lblMotDePasse.Location = new Point(32, 184);
            lblMotDePasse.Name = "lblMotDePasse";
            lblMotDePasse.Size = new Size(174, 36);
            lblMotDePasse.TabIndex = 3;
            lblMotDePasse.Text = "Mot de passe";
            // 
            // txtMotDePasse
            // 
            txtMotDePasse.BorderStyle = BorderStyle.FixedSingle;
            txtMotDePasse.Font = new Font("Segoe UI", 10.5F);
            txtMotDePasse.Location = new Point(32, 206);
            txtMotDePasse.Name = "txtMotDePasse";
            txtMotDePasse.Size = new Size(296, 45);
            txtMotDePasse.TabIndex = 1;
            txtMotDePasse.UseSystemPasswordChar = true;
            // 
            // lblPoste
            // 
            lblPoste.AutoSize = true;
            lblPoste.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPoste.ForeColor = Color.FromArgb(31, 41, 55);
            lblPoste.Location = new Point(32, 248);
            lblPoste.Name = "lblPoste";
            lblPoste.Size = new Size(79, 36);
            lblPoste.TabIndex = 4;
            lblPoste.Text = "Poste";
            // 
            // txtPoste
            // 
            txtPoste.BorderStyle = BorderStyle.FixedSingle;
            txtPoste.Font = new Font("Segoe UI", 10.5F);
            txtPoste.Location = new Point(32, 270);
            txtPoste.Name = "txtPoste";
            txtPoste.Size = new Size(296, 45);
            txtPoste.TabIndex = 2;
            // 
            // chkResterConnecte
            // 
            chkResterConnecte.AutoSize = true;
            chkResterConnecte.Font = new Font("Segoe UI", 9.75F);
            chkResterConnecte.ForeColor = Color.FromArgb(31, 41, 55);
            chkResterConnecte.Location = new Point(32, 312);
            chkResterConnecte.Name = "chkResterConnecte";
            chkResterConnecte.Size = new Size(232, 40);
            chkResterConnecte.TabIndex = 3;
            chkResterConnecte.Text = "Rester connecté";
            // 
            // btnSeConnecter
            // 
            btnSeConnecter.BackColor = Color.FromArgb(46, 108, 240);
            btnSeConnecter.Cursor = Cursors.Hand;
            btnSeConnecter.FlatAppearance.BorderSize = 0;
            btnSeConnecter.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 74, 184);
            btnSeConnecter.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 88, 214);
            btnSeConnecter.FlatStyle = FlatStyle.Flat;
            btnSeConnecter.Font = new Font("Segoe UI Semibold", 10F);
            btnSeConnecter.ForeColor = Color.White;
            btnSeConnecter.Location = new Point(32, 352);
            btnSeConnecter.Name = "btnSeConnecter";
            btnSeConnecter.Size = new Size(296, 40);
            btnSeConnecter.TabIndex = 4;
            btnSeConnecter.Text = "Se connecter";
            btnSeConnecter.UseVisualStyleBackColor = false;
            btnSeConnecter.Click += btnSeConnecter_Click;
            // 
            // tabUtilisateur
            // 
            tabUtilisateur.BackColor = Color.FromArgb(243, 244, 246);
            tabUtilisateur.Controls.Add(carteNouveau);
            tabUtilisateur.Controls.Add(carteTickets);
            tabUtilisateur.Location = new Point(8, 55);
            tabUtilisateur.Name = "tabUtilisateur";
            tabUtilisateur.Padding = new Padding(3);
            tabUtilisateur.Size = new Size(1052, 509);
            tabUtilisateur.TabIndex = 3;
            tabUtilisateur.Text = "Utilisateur";
            // 
            // carteNouveau
            // 
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
            carteNouveau.Size = new Size(420, 456);
            carteNouveau.TabIndex = 0;
            // 
            // lblNouveau
            // 
            lblNouveau.AutoSize = true;
            lblNouveau.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNouveau.ForeColor = Color.FromArgb(31, 41, 55);
            lblNouveau.Location = new Point(22, 20);
            lblNouveau.Name = "lblNouveau";
            lblNouveau.Size = new Size(293, 51);
            lblNouveau.TabIndex = 0;
            lblNouveau.Text = "Nouveau ticket";
            // 
            // lblMateriel
            // 
            lblMateriel.AutoSize = true;
            lblMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMateriel.ForeColor = Color.FromArgb(31, 41, 55);
            lblMateriel.Location = new Point(24, 68);
            lblMateriel.Name = "lblMateriel";
            lblMateriel.Size = new Size(229, 36);
            lblMateriel.TabIndex = 1;
            lblMateriel.Text = "Matériel concerné";
            // 
            // cboMateriel
            // 
            cboMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateriel.Font = new Font("Segoe UI", 10.5F);
            cboMateriel.Location = new Point(24, 90);
            cboMateriel.Name = "cboMateriel";
            cboMateriel.Size = new Size(372, 46);
            cboMateriel.TabIndex = 6;
            // 
            // lblIncident
            // 
            lblIncident.AutoSize = true;
            lblIncident.Font = new Font("Segoe UI Semibold", 9.75F);
            lblIncident.ForeColor = Color.FromArgb(31, 41, 55);
            lblIncident.Location = new Point(24, 196);
            lblIncident.Name = "lblIncident";
            lblIncident.Size = new Size(304, 36);
            lblIncident.TabIndex = 8;
            lblIncident.Text = "Description de l'incident";
            // 
            // txtIncident
            // 
            txtIncident.BorderStyle = BorderStyle.FixedSingle;
            txtIncident.Font = new Font("Segoe UI", 10.5F);
            txtIncident.Location = new Point(24, 218);
            txtIncident.Multiline = true;
            txtIncident.Name = "txtIncident";
            txtIncident.ScrollBars = ScrollBars.Vertical;
            txtIncident.Size = new Size(372, 150);
            txtIncident.TabIndex = 8;
            // 
            // btnEnvoyer
            // 
            btnEnvoyer.BackColor = Color.FromArgb(46, 108, 240);
            btnEnvoyer.Cursor = Cursors.Hand;
            btnEnvoyer.FlatAppearance.BorderSize = 0;
            btnEnvoyer.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 74, 184);
            btnEnvoyer.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 88, 214);
            btnEnvoyer.FlatStyle = FlatStyle.Flat;
            btnEnvoyer.Font = new Font("Segoe UI Semibold", 10F);
            btnEnvoyer.ForeColor = Color.White;
            btnEnvoyer.Location = new Point(24, 392);
            btnEnvoyer.Name = "btnEnvoyer";
            btnEnvoyer.Size = new Size(140, 38);
            btnEnvoyer.TabIndex = 9;
            btnEnvoyer.Text = "Envoyer";
            btnEnvoyer.UseVisualStyleBackColor = false;
            btnEnvoyer.Click += btnEnvoyer_Click;
            // 
            // btnAfficher
            // 
            btnAfficher.BackColor = Color.White;
            btnAfficher.Cursor = Cursors.Hand;
            btnAfficher.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnAfficher.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnAfficher.FlatStyle = FlatStyle.Flat;
            btnAfficher.Font = new Font("Segoe UI Semibold", 10F);
            btnAfficher.ForeColor = Color.FromArgb(31, 41, 55);
            btnAfficher.Location = new Point(176, 392);
            btnAfficher.Name = "btnAfficher";
            btnAfficher.Size = new Size(180, 38);
            btnAfficher.TabIndex = 10;
            btnAfficher.Text = "Afficher mes tickets";
            btnAfficher.UseVisualStyleBackColor = false;
            btnAfficher.Click += btnAfficher_Click;
            // 
            // carteTickets
            // 
            carteTickets.BackColor = Color.White;
            carteTickets.Controls.Add(lblMesTickets);
            carteTickets.Controls.Add(lstTickets);
            carteTickets.Location = new Point(452, 16);
            carteTickets.Name = "carteTickets";
            carteTickets.Size = new Size(592, 456);
            carteTickets.TabIndex = 1;
            // 
            // lblMesTickets
            // 
            lblMesTickets.AutoSize = true;
            lblMesTickets.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMesTickets.ForeColor = Color.FromArgb(31, 41, 55);
            lblMesTickets.Location = new Point(22, 20);
            lblMesTickets.Name = "lblMesTickets";
            lblMesTickets.Size = new Size(223, 51);
            lblMesTickets.TabIndex = 0;
            lblMesTickets.Text = "Mes tickets";
            // 
            // lstTickets
            // 
            lstTickets.BorderStyle = BorderStyle.FixedSingle;
            lstTickets.Font = new Font("Segoe UI", 10.5F);
            lstTickets.IntegralHeight = false;
            lstTickets.ItemHeight = 38;
            lstTickets.Location = new Point(24, 64);
            lstTickets.Name = "lstTickets";
            lstTickets.Size = new Size(544, 368);
            lstTickets.TabIndex = 11;
            // 
            // tabTechnicien
            // 
            tabTechnicien.AutoScroll = true;
            tabTechnicien.BackColor = Color.FromArgb(243, 244, 246);
            tabTechnicien.Controls.Add(carteMateriel);
            tabTechnicien.Controls.Add(carteIncidents);
            tabTechnicien.Controls.Add(carteTicket);
            tabTechnicien.Location = new Point(8, 55);
            tabTechnicien.Name = "tabTechnicien";
            tabTechnicien.Padding = new Padding(3);
            tabTechnicien.Size = new Size(1052, 509);
            tabTechnicien.TabIndex = 4;
            tabTechnicien.Text = "Technicien";
            // 
            // carteMateriel
            // 
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
            carteMateriel.Location = new Point(16, 16);
            carteMateriel.Name = "carteMateriel";
            carteMateriel.Size = new Size(1012, 340);
            carteMateriel.TabIndex = 0;
            // 
            // lblGestion
            // 
            lblGestion.AutoSize = true;
            lblGestion.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGestion.ForeColor = Color.FromArgb(31, 41, 55);
            lblGestion.Location = new Point(22, 20);
            lblGestion.Name = "lblGestion";
            lblGestion.Size = new Size(375, 51);
            lblGestion.TabIndex = 0;
            lblGestion.Text = "Gestion du matériel";
            // 
            // lblAjout
            // 
            lblAjout.AutoSize = true;
            lblAjout.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAjout.ForeColor = Color.FromArgb(31, 41, 55);
            lblAjout.Location = new Point(24, 64);
            lblAjout.Name = "lblAjout";
            lblAjout.Size = new Size(421, 41);
            lblAjout.TabIndex = 1;
            lblAjout.Text = "Ajouter un nouveau matériel";
            // 
            // lblProcesseur
            // 
            lblProcesseur.AutoSize = true;
            lblProcesseur.Font = new Font("Segoe UI Semibold", 9.75F);
            lblProcesseur.ForeColor = Color.FromArgb(31, 41, 55);
            lblProcesseur.Location = new Point(24, 100);
            lblProcesseur.Name = "lblProcesseur";
            lblProcesseur.Size = new Size(143, 36);
            lblProcesseur.TabIndex = 2;
            lblProcesseur.Text = "Processeur";
            // 
            // txtProcesseur
            // 
            txtProcesseur.BorderStyle = BorderStyle.FixedSingle;
            txtProcesseur.Font = new Font("Segoe UI", 10.5F);
            txtProcesseur.Location = new Point(24, 122);
            txtProcesseur.Name = "txtProcesseur";
            txtProcesseur.Size = new Size(156, 45);
            txtProcesseur.TabIndex = 12;
            // 
            // lblDisque
            // 
            lblDisque.AutoSize = true;
            lblDisque.Font = new Font("Segoe UI Semibold", 9.75F);
            lblDisque.ForeColor = Color.FromArgb(31, 41, 55);
            lblDisque.Location = new Point(196, 100);
            lblDisque.Name = "lblDisque";
            lblDisque.Size = new Size(97, 36);
            lblDisque.TabIndex = 13;
            lblDisque.Text = "Disque";
            // 
            // txtDisque
            // 
            txtDisque.BorderStyle = BorderStyle.FixedSingle;
            txtDisque.Font = new Font("Segoe UI", 10.5F);
            txtDisque.Location = new Point(196, 122);
            txtDisque.Name = "txtDisque";
            txtDisque.Size = new Size(156, 45);
            txtDisque.TabIndex = 13;
            // 
            // lblLogiciels
            // 
            lblLogiciels.AutoSize = true;
            lblLogiciels.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLogiciels.ForeColor = Color.FromArgb(31, 41, 55);
            lblLogiciels.Location = new Point(24, 164);
            lblLogiciels.Name = "lblLogiciels";
            lblLogiciels.Size = new Size(118, 36);
            lblLogiciels.TabIndex = 14;
            lblLogiciels.Text = "Logiciels";
            // 
            // txtLogiciels
            // 
            txtLogiciels.BorderStyle = BorderStyle.FixedSingle;
            txtLogiciels.Font = new Font("Segoe UI", 10.5F);
            txtLogiciels.Location = new Point(24, 186);
            txtLogiciels.Name = "txtLogiciels";
            txtLogiciels.Size = new Size(156, 45);
            txtLogiciels.TabIndex = 14;
            // 
            // lblEtatMateriel
            // 
            lblEtatMateriel.AutoSize = true;
            lblEtatMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEtatMateriel.ForeColor = Color.FromArgb(31, 41, 55);
            lblEtatMateriel.Location = new Point(196, 164);
            lblEtatMateriel.Name = "lblEtatMateriel";
            lblEtatMateriel.Size = new Size(60, 36);
            lblEtatMateriel.TabIndex = 15;
            lblEtatMateriel.Text = "État";
            // 
            // cboEtatMateriel
            // 
            cboEtatMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEtatMateriel.Font = new Font("Segoe UI", 10.5F);
            cboEtatMateriel.Items.AddRange(new object[] { "En service", "En panne", "Hors service" });
            cboEtatMateriel.Location = new Point(196, 186);
            cboEtatMateriel.Name = "cboEtatMateriel";
            cboEtatMateriel.Size = new Size(156, 46);
            cboEtatMateriel.TabIndex = 15;
            // 
            // lblSuiviMateriel
            // 
            lblSuiviMateriel.AutoSize = true;
            lblSuiviMateriel.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSuiviMateriel.ForeColor = Color.FromArgb(31, 41, 55);
            lblSuiviMateriel.Location = new Point(24, 228);
            lblSuiviMateriel.Name = "lblSuiviMateriel";
            lblSuiviMateriel.Size = new Size(71, 36);
            lblSuiviMateriel.TabIndex = 16;
            lblSuiviMateriel.Text = "Suivi";
            // 
            // txtSuiviMateriel
            // 
            txtSuiviMateriel.BorderStyle = BorderStyle.FixedSingle;
            txtSuiviMateriel.Font = new Font("Segoe UI", 10.5F);
            txtSuiviMateriel.Location = new Point(24, 250);
            txtSuiviMateriel.Name = "txtSuiviMateriel";
            txtSuiviMateriel.Size = new Size(328, 45);
            txtSuiviMateriel.TabIndex = 16;
            // 
            // btnAjouterMateriel
            // 
            btnAjouterMateriel.BackColor = Color.FromArgb(46, 108, 240);
            btnAjouterMateriel.Cursor = Cursors.Hand;
            btnAjouterMateriel.FlatAppearance.BorderSize = 0;
            btnAjouterMateriel.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 74, 184);
            btnAjouterMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 88, 214);
            btnAjouterMateriel.FlatStyle = FlatStyle.Flat;
            btnAjouterMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnAjouterMateriel.ForeColor = Color.White;
            btnAjouterMateriel.Location = new Point(24, 290);
            btnAjouterMateriel.Name = "btnAjouterMateriel";
            btnAjouterMateriel.Size = new Size(140, 38);
            btnAjouterMateriel.TabIndex = 17;
            btnAjouterMateriel.Text = "Ajouter";
            btnAjouterMateriel.UseVisualStyleBackColor = false;
            btnAjouterMateriel.Click += btnAjouterMateriel_Click;
            // 
            // separateurMateriel
            // 
            separateurMateriel.BackColor = Color.FromArgb(229, 231, 235);
            separateurMateriel.Location = new Point(376, 64);
            separateurMateriel.Name = "separateurMateriel";
            separateurMateriel.Size = new Size(1, 256);
            separateurMateriel.TabIndex = 18;
            // 
            // lblConsultation
            // 
            lblConsultation.AutoSize = true;
            lblConsultation.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblConsultation.ForeColor = Color.FromArgb(31, 41, 55);
            lblConsultation.Location = new Point(400, 64);
            lblConsultation.Name = "lblConsultation";
            lblConsultation.Size = new Size(395, 41);
            lblConsultation.TabIndex = 19;
            lblConsultation.Text = "Consultation d'un matériel";
            // 
            // cboConsultMateriel
            // 
            cboConsultMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultMateriel.Font = new Font("Segoe UI", 10.5F);
            cboConsultMateriel.Location = new Point(400, 100);
            cboConsultMateriel.Name = "cboConsultMateriel";
            cboConsultMateriel.Size = new Size(460, 46);
            cboConsultMateriel.TabIndex = 18;
            // 
            // btnAfficherMateriel
            // 
            btnAfficherMateriel.BackColor = Color.White;
            btnAfficherMateriel.Cursor = Cursors.Hand;
            btnAfficherMateriel.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnAfficherMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnAfficherMateriel.FlatStyle = FlatStyle.Flat;
            btnAfficherMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnAfficherMateriel.ForeColor = Color.FromArgb(31, 41, 55);
            btnAfficherMateriel.Location = new Point(872, 96);
            btnAfficherMateriel.Name = "btnAfficherMateriel";
            btnAfficherMateriel.Size = new Size(116, 34);
            btnAfficherMateriel.TabIndex = 19;
            btnAfficherMateriel.Text = "Afficher";
            btnAfficherMateriel.UseVisualStyleBackColor = false;
            btnAfficherMateriel.Click += btnAfficherMateriel_Click;
            // 
            // panelDetail
            // 
            panelDetail.BackColor = Color.FromArgb(248, 249, 251);
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
            panelDetail.Location = new Point(400, 142);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(588, 64);
            panelDetail.TabIndex = 20;
            // 
            // lblDetailProcesseur
            // 
            lblDetailProcesseur.AutoSize = true;
            lblDetailProcesseur.Font = new Font("Segoe UI", 9F);
            lblDetailProcesseur.ForeColor = Color.FromArgb(107, 114, 128);
            lblDetailProcesseur.Location = new Point(16, 10);
            lblDetailProcesseur.Name = "lblDetailProcesseur";
            lblDetailProcesseur.Size = new Size(128, 32);
            lblDetailProcesseur.TabIndex = 0;
            lblDetailProcesseur.Text = "Processeur";
            // 
            // lblValeurProcesseur
            // 
            lblValeurProcesseur.AutoSize = true;
            lblValeurProcesseur.Font = new Font("Segoe UI Semibold", 10.5F);
            lblValeurProcesseur.ForeColor = Color.FromArgb(31, 41, 55);
            lblValeurProcesseur.Location = new Point(16, 30);
            lblValeurProcesseur.Name = "lblValeurProcesseur";
            lblValeurProcesseur.Size = new Size(28, 38);
            lblValeurProcesseur.TabIndex = 1;
            lblValeurProcesseur.Text = "-";
            // 
            // lblDetailDisque
            // 
            lblDetailDisque.AutoSize = true;
            lblDetailDisque.Font = new Font("Segoe UI", 9F);
            lblDetailDisque.ForeColor = Color.FromArgb(107, 114, 128);
            lblDetailDisque.Location = new Point(134, 10);
            lblDetailDisque.Name = "lblDetailDisque";
            lblDetailDisque.Size = new Size(88, 32);
            lblDetailDisque.TabIndex = 2;
            lblDetailDisque.Text = "Disque";
            // 
            // lblValeurDisque
            // 
            lblValeurDisque.AutoSize = true;
            lblValeurDisque.Font = new Font("Segoe UI Semibold", 10.5F);
            lblValeurDisque.ForeColor = Color.FromArgb(31, 41, 55);
            lblValeurDisque.Location = new Point(134, 30);
            lblValeurDisque.Name = "lblValeurDisque";
            lblValeurDisque.Size = new Size(28, 38);
            lblValeurDisque.TabIndex = 3;
            lblValeurDisque.Text = "-";
            // 
            // lblDetailLogiciels
            // 
            lblDetailLogiciels.AutoSize = true;
            lblDetailLogiciels.Font = new Font("Segoe UI", 9F);
            lblDetailLogiciels.ForeColor = Color.FromArgb(107, 114, 128);
            lblDetailLogiciels.Location = new Point(252, 10);
            lblDetailLogiciels.Name = "lblDetailLogiciels";
            lblDetailLogiciels.Size = new Size(105, 32);
            lblDetailLogiciels.TabIndex = 4;
            lblDetailLogiciels.Text = "Logiciels";
            // 
            // lblValeurLogiciels
            // 
            lblValeurLogiciels.AutoSize = true;
            lblValeurLogiciels.Font = new Font("Segoe UI Semibold", 10.5F);
            lblValeurLogiciels.ForeColor = Color.FromArgb(31, 41, 55);
            lblValeurLogiciels.Location = new Point(252, 30);
            lblValeurLogiciels.Name = "lblValeurLogiciels";
            lblValeurLogiciels.Size = new Size(28, 38);
            lblValeurLogiciels.TabIndex = 5;
            lblValeurLogiciels.Text = "-";
            // 
            // lblDetailEtat
            // 
            lblDetailEtat.AutoSize = true;
            lblDetailEtat.Font = new Font("Segoe UI", 9F);
            lblDetailEtat.ForeColor = Color.FromArgb(107, 114, 128);
            lblDetailEtat.Location = new Point(370, 10);
            lblDetailEtat.Name = "lblDetailEtat";
            lblDetailEtat.Size = new Size(54, 32);
            lblDetailEtat.TabIndex = 6;
            lblDetailEtat.Text = "État";
            // 
            // lblValeurEtat
            // 
            lblValeurEtat.AutoSize = true;
            lblValeurEtat.Font = new Font("Segoe UI Semibold", 10.5F);
            lblValeurEtat.ForeColor = Color.FromArgb(31, 41, 55);
            lblValeurEtat.Location = new Point(370, 30);
            lblValeurEtat.Name = "lblValeurEtat";
            lblValeurEtat.Size = new Size(28, 38);
            lblValeurEtat.TabIndex = 7;
            lblValeurEtat.Text = "-";
            // 
            // lblDetailSuivi
            // 
            lblDetailSuivi.AutoSize = true;
            lblDetailSuivi.Font = new Font("Segoe UI", 9F);
            lblDetailSuivi.ForeColor = Color.FromArgb(107, 114, 128);
            lblDetailSuivi.Location = new Point(488, 10);
            lblDetailSuivi.Name = "lblDetailSuivi";
            lblDetailSuivi.Size = new Size(65, 32);
            lblDetailSuivi.TabIndex = 8;
            lblDetailSuivi.Text = "Suivi";
            // 
            // lblValeurSuivi
            // 
            lblValeurSuivi.AutoSize = true;
            lblValeurSuivi.Font = new Font("Segoe UI Semibold", 10.5F);
            lblValeurSuivi.ForeColor = Color.FromArgb(31, 41, 55);
            lblValeurSuivi.Location = new Point(488, 30);
            lblValeurSuivi.Name = "lblValeurSuivi";
            lblValeurSuivi.Size = new Size(28, 38);
            lblValeurSuivi.TabIndex = 9;
            lblValeurSuivi.Text = "-";
            // 
            // lblSuppression
            // 
            lblSuppression.AutoSize = true;
            lblSuppression.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSuppression.ForeColor = Color.FromArgb(31, 41, 55);
            lblSuppression.Location = new Point(400, 226);
            lblSuppression.Name = "lblSuppression";
            lblSuppression.Size = new Size(387, 41);
            lblSuppression.TabIndex = 21;
            lblSuppression.Text = "Suppression d'un matériel";
            // 
            // cboSupprMateriel
            // 
            cboSupprMateriel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupprMateriel.Font = new Font("Segoe UI", 10.5F);
            cboSupprMateriel.Location = new Point(400, 262);
            cboSupprMateriel.Name = "cboSupprMateriel";
            cboSupprMateriel.Size = new Size(460, 46);
            cboSupprMateriel.TabIndex = 20;
            // 
            // btnSupprimerMateriel
            // 
            btnSupprimerMateriel.BackColor = Color.White;
            btnSupprimerMateriel.Cursor = Cursors.Hand;
            btnSupprimerMateriel.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            btnSupprimerMateriel.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnSupprimerMateriel.FlatStyle = FlatStyle.Flat;
            btnSupprimerMateriel.Font = new Font("Segoe UI Semibold", 10F);
            btnSupprimerMateriel.ForeColor = Color.FromArgb(185, 28, 28);
            btnSupprimerMateriel.Location = new Point(872, 258);
            btnSupprimerMateriel.Name = "btnSupprimerMateriel";
            btnSupprimerMateriel.Size = new Size(116, 34);
            btnSupprimerMateriel.TabIndex = 21;
            btnSupprimerMateriel.Text = "Supprimer";
            btnSupprimerMateriel.UseVisualStyleBackColor = false;
            btnSupprimerMateriel.Click += btnSupprimerMateriel_Click;
            // 
            // carteIncidents
            // 
            carteIncidents.BackColor = Color.White;
            carteIncidents.Controls.Add(lblIncidents);
            carteIncidents.Controls.Add(lstIncidents);
            carteIncidents.Controls.Add(btnPrendreEnCharge);
            carteIncidents.Location = new Point(16, 372);
            carteIncidents.Name = "carteIncidents";
            carteIncidents.Size = new Size(420, 332);
            carteIncidents.TabIndex = 1;
            // 
            // lblIncidents
            // 
            lblIncidents.AutoSize = true;
            lblIncidents.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblIncidents.ForeColor = Color.FromArgb(31, 41, 55);
            lblIncidents.Location = new Point(22, 20);
            lblIncidents.Name = "lblIncidents";
            lblIncidents.Size = new Size(186, 51);
            lblIncidents.TabIndex = 0;
            lblIncidents.Text = "Incidents";
            // 
            // lstIncidents
            // 
            lstIncidents.BorderStyle = BorderStyle.FixedSingle;
            lstIncidents.Font = new Font("Segoe UI", 10.5F);
            lstIncidents.IntegralHeight = false;
            lstIncidents.ItemHeight = 38;
            lstIncidents.Location = new Point(24, 60);
            lstIncidents.Name = "lstIncidents";
            lstIncidents.Size = new Size(372, 200);
            lstIncidents.TabIndex = 22;
            lstIncidents.SelectedIndexChanged += lstIncidents_SelectedIndexChanged;
            // 
            // btnPrendreEnCharge
            // 
            btnPrendreEnCharge.BackColor = Color.FromArgb(46, 108, 240);
            btnPrendreEnCharge.Cursor = Cursors.Hand;
            btnPrendreEnCharge.FlatAppearance.BorderSize = 0;
            btnPrendreEnCharge.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 74, 184);
            btnPrendreEnCharge.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 88, 214);
            btnPrendreEnCharge.FlatStyle = FlatStyle.Flat;
            btnPrendreEnCharge.Font = new Font("Segoe UI Semibold", 10F);
            btnPrendreEnCharge.ForeColor = Color.White;
            btnPrendreEnCharge.Location = new Point(24, 276);
            btnPrendreEnCharge.Name = "btnPrendreEnCharge";
            btnPrendreEnCharge.Size = new Size(180, 38);
            btnPrendreEnCharge.TabIndex = 23;
            btnPrendreEnCharge.Text = "Prendre en charge";
            btnPrendreEnCharge.UseVisualStyleBackColor = false;
            btnPrendreEnCharge.Click += btnPrendreEnCharge_Click;
            // 
            // carteTicket
            // 
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
            carteTicket.Location = new Point(452, 372);
            carteTicket.Name = "carteTicket";
            carteTicket.Size = new Size(576, 332);
            carteTicket.TabIndex = 2;
            // 
            // lblTicketSelection
            // 
            lblTicketSelection.AutoSize = true;
            lblTicketSelection.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTicketSelection.ForeColor = Color.FromArgb(31, 41, 55);
            lblTicketSelection.Location = new Point(22, 20);
            lblTicketSelection.Name = "lblTicketSelection";
            lblTicketSelection.Size = new Size(317, 47);
            lblTicketSelection.TabIndex = 0;
            lblTicketSelection.Text = "Ticket sélectionné";
            // 
            // lblEtatActuel
            // 
            lblEtatActuel.Font = new Font("Segoe UI", 10F);
            lblEtatActuel.ForeColor = Color.FromArgb(107, 114, 128);
            lblEtatActuel.Location = new Point(328, 22);
            lblEtatActuel.Name = "lblEtatActuel";
            lblEtatActuel.Size = new Size(224, 24);
            lblEtatActuel.TabIndex = 1;
            lblEtatActuel.Text = "État actuel : -";
            lblEtatActuel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblEtat
            // 
            lblEtat.AutoSize = true;
            lblEtat.Font = new Font("Segoe UI Semibold", 9.75F);
            lblEtat.ForeColor = Color.FromArgb(31, 41, 55);
            lblEtat.Location = new Point(24, 64);
            lblEtat.Name = "lblEtat";
            lblEtat.Size = new Size(60, 36);
            lblEtat.TabIndex = 2;
            lblEtat.Text = "État";
            // 
            // panelEtat
            // 
            panelEtat.Controls.Add(rbEnCours);
            panelEtat.Controls.Add(rbResolu);
            panelEtat.Controls.Add(rbCloture);
            panelEtat.Location = new Point(24, 86);
            panelEtat.Name = "panelEtat";
            panelEtat.Size = new Size(528, 28);
            panelEtat.TabIndex = 24;
            // 
            // rbEnCours
            // 
            rbEnCours.AutoSize = true;
            rbEnCours.Checked = true;
            rbEnCours.Font = new Font("Segoe UI", 10F);
            rbEnCours.ForeColor = Color.FromArgb(31, 41, 55);
            rbEnCours.Location = new Point(0, 3);
            rbEnCours.Name = "rbEnCours";
            rbEnCours.Size = new Size(147, 41);
            rbEnCours.TabIndex = 0;
            rbEnCours.TabStop = true;
            rbEnCours.Text = "En cours";
            // 
            // rbResolu
            // 
            rbResolu.AutoSize = true;
            rbResolu.Font = new Font("Segoe UI", 10F);
            rbResolu.ForeColor = Color.FromArgb(31, 41, 55);
            rbResolu.Location = new Point(110, 3);
            rbResolu.Name = "rbResolu";
            rbResolu.Size = new Size(126, 41);
            rbResolu.TabIndex = 1;
            rbResolu.Text = "Résolu";
            // 
            // rbCloture
            // 
            rbCloture.AutoSize = true;
            rbCloture.Font = new Font("Segoe UI", 10F);
            rbCloture.ForeColor = Color.FromArgb(31, 41, 55);
            rbCloture.Location = new Point(220, 3);
            rbCloture.Name = "rbCloture";
            rbCloture.Size = new Size(135, 41);
            rbCloture.TabIndex = 2;
            rbCloture.Text = "Clôturé";
            // 
            // lblUrgence
            // 
            lblUrgence.AutoSize = true;
            lblUrgence.Font = new Font("Segoe UI Semibold", 9.75F);
            lblUrgence.ForeColor = Color.FromArgb(31, 41, 55);
            lblUrgence.Location = new Point(24, 122);
            lblUrgence.Name = "lblUrgence";
            lblUrgence.Size = new Size(224, 36);
            lblUrgence.TabIndex = 25;
            lblUrgence.Text = "Niveau d'urgence";
            // 
            // panelUrgence
            // 
            panelUrgence.Controls.Add(rbFaible);
            panelUrgence.Controls.Add(rbMoyen);
            panelUrgence.Controls.Add(rbCritique);
            panelUrgence.Location = new Point(24, 144);
            panelUrgence.Name = "panelUrgence";
            panelUrgence.Size = new Size(528, 28);
            panelUrgence.TabIndex = 25;
            // 
            // rbFaible
            // 
            rbFaible.AutoSize = true;
            rbFaible.Checked = true;
            rbFaible.Font = new Font("Segoe UI", 10F);
            rbFaible.ForeColor = Color.FromArgb(31, 41, 55);
            rbFaible.Location = new Point(0, 3);
            rbFaible.Name = "rbFaible";
            rbFaible.Size = new Size(118, 41);
            rbFaible.TabIndex = 0;
            rbFaible.TabStop = true;
            rbFaible.Text = "Faible";
            // 
            // rbMoyen
            // 
            rbMoyen.AutoSize = true;
            rbMoyen.Font = new Font("Segoe UI", 10F);
            rbMoyen.ForeColor = Color.FromArgb(31, 41, 55);
            rbMoyen.Location = new Point(110, 3);
            rbMoyen.Name = "rbMoyen";
            rbMoyen.Size = new Size(130, 41);
            rbMoyen.TabIndex = 1;
            rbMoyen.Text = "Moyen";
            // 
            // rbCritique
            // 
            rbCritique.AutoSize = true;
            rbCritique.Font = new Font("Segoe UI", 10F);
            rbCritique.ForeColor = Color.FromArgb(31, 41, 55);
            rbCritique.Location = new Point(220, 3);
            rbCritique.Name = "rbCritique";
            rbCritique.Size = new Size(142, 41);
            rbCritique.TabIndex = 2;
            rbCritique.Text = "Critique";
            // 
            // lblSuivi
            // 
            lblSuivi.AutoSize = true;
            lblSuivi.Font = new Font("Segoe UI Semibold", 9.75F);
            lblSuivi.ForeColor = Color.FromArgb(31, 41, 55);
            lblSuivi.Location = new Point(24, 180);
            lblSuivi.Name = "lblSuivi";
            lblSuivi.Size = new Size(273, 36);
            lblSuivi.TabIndex = 26;
            lblSuivi.Text = "Suivi (travail effectué)";
            // 
            // txtSuivi
            // 
            txtSuivi.BorderStyle = BorderStyle.FixedSingle;
            txtSuivi.Font = new Font("Segoe UI", 10.5F);
            txtSuivi.Location = new Point(24, 202);
            txtSuivi.Multiline = true;
            txtSuivi.Name = "txtSuivi";
            txtSuivi.ScrollBars = ScrollBars.Vertical;
            txtSuivi.Size = new Size(528, 72);
            txtSuivi.TabIndex = 26;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = Color.FromArgb(46, 108, 240);
            btnEnregistrer.Cursor = Cursors.Hand;
            btnEnregistrer.FlatAppearance.BorderSize = 0;
            btnEnregistrer.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 74, 184);
            btnEnregistrer.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 88, 214);
            btnEnregistrer.FlatStyle = FlatStyle.Flat;
            btnEnregistrer.Font = new Font("Segoe UI Semibold", 10F);
            btnEnregistrer.ForeColor = Color.White;
            btnEnregistrer.Location = new Point(24, 286);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(150, 38);
            btnEnregistrer.TabIndex = 27;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // tabResponsable
            // 
            tabResponsable.BackColor = Color.FromArgb(243, 244, 246);
            tabResponsable.Controls.Add(cartePersonnel);
            tabResponsable.Location = new Point(8, 55);
            tabResponsable.Name = "tabResponsable";
            tabResponsable.Padding = new Padding(3);
            tabResponsable.Size = new Size(1052, 509);
            tabResponsable.TabIndex = 5;
            tabResponsable.Text = "Responsable";
            // 
            // cartePersonnel
            // 
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
            cartePersonnel.Size = new Size(772, 492);
            cartePersonnel.TabIndex = 0;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI Semibold", 9.75F);
            lblType.ForeColor = Color.FromArgb(31, 41, 55);
            lblType.Location = new Point(24, 20);
            lblType.Name = "lblType";
            lblType.Size = new Size(205, 36);
            lblType.TabIndex = 0;
            lblType.Text = "Type de compte";
            // 
            // panelType
            // 
            panelType.Controls.Add(rbTechnicien);
            panelType.Controls.Add(rbUtilisateur);
            panelType.Location = new Point(24, 42);
            panelType.Name = "panelType";
            panelType.Size = new Size(260, 28);
            panelType.TabIndex = 28;
            // 
            // rbTechnicien
            // 
            rbTechnicien.AutoSize = true;
            rbTechnicien.Checked = true;
            rbTechnicien.Font = new Font("Segoe UI", 10F);
            rbTechnicien.ForeColor = Color.FromArgb(31, 41, 55);
            rbTechnicien.Location = new Point(0, 3);
            rbTechnicien.Name = "rbTechnicien";
            rbTechnicien.Size = new Size(170, 41);
            rbTechnicien.TabIndex = 0;
            rbTechnicien.TabStop = true;
            rbTechnicien.Text = "Technicien";
            rbTechnicien.CheckedChanged += rbTechnicien_CheckedChanged;
            // 
            // rbUtilisateur
            // 
            rbUtilisateur.AutoSize = true;
            rbUtilisateur.Font = new Font("Segoe UI", 10F);
            rbUtilisateur.ForeColor = Color.FromArgb(31, 41, 55);
            rbUtilisateur.Location = new Point(110, 3);
            rbUtilisateur.Name = "rbUtilisateur";
            rbUtilisateur.Size = new Size(169, 41);
            rbUtilisateur.TabIndex = 1;
            rbUtilisateur.Text = "Utilisateur";
            // 
            // lblPersonne
            // 
            lblPersonne.AutoSize = true;
            lblPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPersonne.ForeColor = Color.FromArgb(31, 41, 55);
            lblPersonne.Location = new Point(300, 20);
            lblPersonne.Name = "lblPersonne";
            lblPersonne.Size = new Size(421, 36);
            lblPersonne.TabIndex = 29;
            lblPersonne.Text = "Personne à modifier ou supprimer";
            // 
            // cboPersonne
            // 
            cboPersonne.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersonne.Font = new Font("Segoe UI", 10.5F);
            cboPersonne.Location = new Point(300, 42);
            cboPersonne.Name = "cboPersonne";
            cboPersonne.Size = new Size(448, 46);
            cboPersonne.TabIndex = 29;
            cboPersonne.SelectedIndexChanged += cboPersonne_SelectedIndexChanged;
            // 
            // separateurPersonnel
            // 
            separateurPersonnel.BackColor = Color.FromArgb(229, 231, 235);
            separateurPersonnel.Location = new Point(24, 88);
            separateurPersonnel.Name = "separateurPersonnel";
            separateurPersonnel.Size = new Size(724, 1);
            separateurPersonnel.TabIndex = 30;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI Semibold", 9.75F);
            lblNom.ForeColor = Color.FromArgb(31, 41, 55);
            lblNom.Location = new Point(24, 108);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(74, 36);
            lblNom.TabIndex = 31;
            lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.Font = new Font("Segoe UI", 10.5F);
            txtNom.Location = new Point(24, 130);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(356, 45);
            txtNom.TabIndex = 30;
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPrenom.ForeColor = Color.FromArgb(31, 41, 55);
            lblPrenom.Location = new Point(392, 108);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(108, 36);
            lblPrenom.TabIndex = 32;
            lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Font = new Font("Segoe UI", 10.5F);
            txtPrenom.Location = new Point(392, 130);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(356, 45);
            txtPrenom.TabIndex = 31;
            // 
            // lblDateEmbauche
            // 
            lblDateEmbauche.AutoSize = true;
            lblDateEmbauche.Font = new Font("Segoe UI Semibold", 9.75F);
            lblDateEmbauche.ForeColor = Color.FromArgb(31, 41, 55);
            lblDateEmbauche.Location = new Point(24, 172);
            lblDateEmbauche.Name = "lblDateEmbauche";
            lblDateEmbauche.Size = new Size(224, 36);
            lblDateEmbauche.TabIndex = 33;
            lblDateEmbauche.Text = "Date d'embauche";
            // 
            // dtpDateEmbauche
            // 
            dtpDateEmbauche.Font = new Font("Segoe UI", 10.5F);
            dtpDateEmbauche.Format = DateTimePickerFormat.Short;
            dtpDateEmbauche.Location = new Point(24, 194);
            dtpDateEmbauche.Name = "dtpDateEmbauche";
            dtpDateEmbauche.Size = new Size(356, 45);
            dtpDateEmbauche.TabIndex = 32;
            // 
            // lblPostePersonne
            // 
            lblPostePersonne.AutoSize = true;
            lblPostePersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblPostePersonne.ForeColor = Color.FromArgb(31, 41, 55);
            lblPostePersonne.Location = new Point(392, 172);
            lblPostePersonne.Name = "lblPostePersonne";
            lblPostePersonne.Size = new Size(79, 36);
            lblPostePersonne.TabIndex = 34;
            lblPostePersonne.Text = "Poste";
            // 
            // txtPostePersonne
            // 
            txtPostePersonne.BorderStyle = BorderStyle.FixedSingle;
            txtPostePersonne.Font = new Font("Segoe UI", 10.5F);
            txtPostePersonne.Location = new Point(392, 194);
            txtPostePersonne.Name = "txtPostePersonne";
            txtPostePersonne.Size = new Size(356, 45);
            txtPostePersonne.TabIndex = 33;
            // 
            // lblLoginPersonne
            // 
            lblLoginPersonne.AutoSize = true;
            lblLoginPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblLoginPersonne.ForeColor = Color.FromArgb(31, 41, 55);
            lblLoginPersonne.Location = new Point(24, 236);
            lblLoginPersonne.Name = "lblLoginPersonne";
            lblLoginPersonne.Size = new Size(82, 36);
            lblLoginPersonne.TabIndex = 35;
            lblLoginPersonne.Text = "Login";
            // 
            // txtLoginPersonne
            // 
            txtLoginPersonne.BorderStyle = BorderStyle.FixedSingle;
            txtLoginPersonne.Font = new Font("Segoe UI", 10.5F);
            txtLoginPersonne.Location = new Point(24, 258);
            txtLoginPersonne.Name = "txtLoginPersonne";
            txtLoginPersonne.Size = new Size(356, 45);
            txtLoginPersonne.TabIndex = 34;
            // 
            // lblMdpPersonne
            // 
            lblMdpPersonne.AutoSize = true;
            lblMdpPersonne.Font = new Font("Segoe UI Semibold", 9.75F);
            lblMdpPersonne.ForeColor = Color.FromArgb(31, 41, 55);
            lblMdpPersonne.Location = new Point(392, 236);
            lblMdpPersonne.Name = "lblMdpPersonne";
            lblMdpPersonne.Size = new Size(174, 36);
            lblMdpPersonne.TabIndex = 36;
            lblMdpPersonne.Text = "Mot de passe";
            // 
            // txtMdpPersonne
            // 
            txtMdpPersonne.BorderStyle = BorderStyle.FixedSingle;
            txtMdpPersonne.Font = new Font("Segoe UI", 10.5F);
            txtMdpPersonne.Location = new Point(392, 258);
            txtMdpPersonne.Name = "txtMdpPersonne";
            txtMdpPersonne.Size = new Size(356, 45);
            txtMdpPersonne.TabIndex = 35;
            txtMdpPersonne.UseSystemPasswordChar = true;
            // 
            // panelTechnicien
            // 
            panelTechnicien.BackColor = Color.FromArgb(248, 249, 251);
            panelTechnicien.Controls.Add(lblFormation);
            panelTechnicien.Controls.Add(txtFormation);
            panelTechnicien.Controls.Add(lblCompetence);
            panelTechnicien.Controls.Add(txtCompetence);
            panelTechnicien.Location = new Point(24, 304);
            panelTechnicien.Name = "panelTechnicien";
            panelTechnicien.Size = new Size(724, 96);
            panelTechnicien.TabIndex = 37;
            // 
            // lblFormation
            // 
            lblFormation.AutoSize = true;
            lblFormation.Font = new Font("Segoe UI Semibold", 9.75F);
            lblFormation.ForeColor = Color.FromArgb(31, 41, 55);
            lblFormation.Location = new Point(16, 12);
            lblFormation.Name = "lblFormation";
            lblFormation.Size = new Size(138, 36);
            lblFormation.TabIndex = 0;
            lblFormation.Text = "Formation";
            // 
            // txtFormation
            // 
            txtFormation.BorderStyle = BorderStyle.FixedSingle;
            txtFormation.Font = new Font("Segoe UI", 10.5F);
            txtFormation.Location = new Point(16, 34);
            txtFormation.Name = "txtFormation";
            txtFormation.Size = new Size(336, 45);
            txtFormation.TabIndex = 36;
            // 
            // lblCompetence
            // 
            lblCompetence.AutoSize = true;
            lblCompetence.Font = new Font("Segoe UI Semibold", 9.75F);
            lblCompetence.ForeColor = Color.FromArgb(31, 41, 55);
            lblCompetence.Location = new Point(372, 12);
            lblCompetence.Name = "lblCompetence";
            lblCompetence.Size = new Size(164, 36);
            lblCompetence.TabIndex = 37;
            lblCompetence.Text = "Compétence";
            // 
            // txtCompetence
            // 
            txtCompetence.BorderStyle = BorderStyle.FixedSingle;
            txtCompetence.Font = new Font("Segoe UI", 10.5F);
            txtCompetence.Location = new Point(372, 34);
            txtCompetence.Name = "txtCompetence";
            txtCompetence.Size = new Size(336, 45);
            txtCompetence.TabIndex = 37;
            // 
            // btnAjouterPersonne
            // 
            btnAjouterPersonne.BackColor = Color.FromArgb(46, 108, 240);
            btnAjouterPersonne.Cursor = Cursors.Hand;
            btnAjouterPersonne.FlatAppearance.BorderSize = 0;
            btnAjouterPersonne.FlatAppearance.MouseDownBackColor = Color.FromArgb(27, 74, 184);
            btnAjouterPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(31, 88, 214);
            btnAjouterPersonne.FlatStyle = FlatStyle.Flat;
            btnAjouterPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnAjouterPersonne.ForeColor = Color.White;
            btnAjouterPersonne.Location = new Point(24, 424);
            btnAjouterPersonne.Name = "btnAjouterPersonne";
            btnAjouterPersonne.Size = new Size(120, 40);
            btnAjouterPersonne.TabIndex = 38;
            btnAjouterPersonne.Text = "Ajouter";
            btnAjouterPersonne.UseVisualStyleBackColor = false;
            btnAjouterPersonne.Click += btnAjouterPersonne_Click;
            // 
            // btnModifierPersonne
            // 
            btnModifierPersonne.BackColor = Color.White;
            btnModifierPersonne.Cursor = Cursors.Hand;
            btnModifierPersonne.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnModifierPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246);
            btnModifierPersonne.FlatStyle = FlatStyle.Flat;
            btnModifierPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnModifierPersonne.ForeColor = Color.FromArgb(31, 41, 55);
            btnModifierPersonne.Location = new Point(156, 424);
            btnModifierPersonne.Name = "btnModifierPersonne";
            btnModifierPersonne.Size = new Size(120, 40);
            btnModifierPersonne.TabIndex = 39;
            btnModifierPersonne.Text = "Modifier";
            btnModifierPersonne.UseVisualStyleBackColor = false;
            btnModifierPersonne.Click += btnModifierPersonne_Click;
            // 
            // btnSupprimerPersonne
            // 
            btnSupprimerPersonne.BackColor = Color.White;
            btnSupprimerPersonne.Cursor = Cursors.Hand;
            btnSupprimerPersonne.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            btnSupprimerPersonne.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnSupprimerPersonne.FlatStyle = FlatStyle.Flat;
            btnSupprimerPersonne.Font = new Font("Segoe UI Semibold", 10F);
            btnSupprimerPersonne.ForeColor = Color.FromArgb(185, 28, 28);
            btnSupprimerPersonne.Location = new Point(288, 424);
            btnSupprimerPersonne.Name = "btnSupprimerPersonne";
            btnSupprimerPersonne.Size = new Size(120, 40);
            btnSupprimerPersonne.TabIndex = 40;
            btnSupprimerPersonne.Text = "Supprimer";
            btnSupprimerPersonne.UseVisualStyleBackColor = false;
            btnSupprimerPersonne.Click += btnSupprimerPersonne_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1248, 834);
            Controls.Add(panelEntete);
            Controls.Add(tabMenu);
            Font = new Font("Segoe UI", 9.75F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
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
        private System.Windows.Forms.TextBox txtPoste;
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
