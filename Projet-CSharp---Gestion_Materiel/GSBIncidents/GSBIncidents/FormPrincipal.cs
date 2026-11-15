using System.Reflection.Metadata.Ecma335;

namespace GSBIncidents
{
    public partial class FormPrincipal : Form
    {

        private Personnel personneConnecte;
        private Technicien technicienConnecte;

        public FormPrincipal()
        {

            InitializeComponent();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            //L'utilisateur qui se connecte n'a accès qu'à la page de connexion, les autres sont masqué via les lignes ci-dessous.
            tabMenu.TabPages.Remove(tabUtilisateur);
            tabMenu.TabPages.Remove(tabResponsable);
            tabMenu.TabPages.Remove(tabTechnicien);
            btnDeconnexion.Hide();

        }

        #region Entête

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            tabMenu.TabPages.Remove(tabResponsable);
            tabMenu.TabPages.Remove(tabUtilisateur);
            tabMenu.TabPages.Remove(tabTechnicien);
            tabMenu.TabPages.Add(tabConnexion);
            tabMenu.SelectedTab = tabConnexion;
            btnDeconnexion.Hide();
            lblUtilisateur.Hide();



        }

        #endregion

        #region Onglet Connexion

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtMotDePasse.Text;
            btnDeconnexion.Show();
            lblUtilisateur.Show();

            // Cacher la groupe box avec les formations et compétence dans l'onglet responsable

            panelTechnicien.Hide();

            //

            // Clear des comboBox, listBox...

            cboPersonne.Items.Clear();
            cboConsultMateriel.Items.Clear();
            cboSupprMateriel.Items.Clear();
            lstIncidents.Items.Clear();

            //

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez remplir tout les champs !");
                return;
            }

            if (cboPoste.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un poste !");
                return;
            }

            personneConnecte = BD.SeConnecter(login, password);
            if (personneConnecte == null)
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect !");
                return;
            }

            string poste = cboPoste.Text.ToLower();

            if (personneConnecte.poste.Trim().ToLower() != poste)
            {
                MessageBox.Show("Ce poste ne correspond pas à votre compte !");
                personneConnecte = null;
                return;
            }

            if (poste == "technicien")
            {
                tabMenu.TabPages.Add(tabTechnicien);
                tabMenu.SelectedTab = tabTechnicien;
                foreach (Ticket t in BD.GetTicket())
                {
                    lstIncidents.Items.Add(t);
                }
                foreach (Materiel m in BD.GetMateriels())
                {
                    cboConsultMateriel.Items.Add(m);
                    cboSupprMateriel.Items.Add(m);
                }
                technicienConnecte = BD.GetTechnicien(personneConnecte.id_Personnel);
                carteTicket.Enabled = false;
            }
            else if (poste == "utilisateur")
            {
                tabMenu.TabPages.Add(tabUtilisateur);
                tabMenu.SelectedTab = tabUtilisateur;
                cboMateriel.Items.Clear();
                foreach (Materiel m in BD.GetMateriels())
                {
                    cboMateriel.Items.Add(m);
                }


            }
            else if (poste == "responsable")
            {
                tabMenu.TabPages.Add(tabResponsable);
                tabMenu.SelectedTab = tabResponsable;

                rbTechnicien.Checked = true;
                rbTechnicien_CheckedChanged(sender, e);
                btnActualiserStats_Click(sender, e);


            }
            else
            {
                MessageBox.Show("Fonction non reconnue !" + personneConnecte.poste);
                personneConnecte = null;
                return;

            }
            lblUtilisateur.Text = "Connecté :" + personneConnecte.prenom + " " + personneConnecte.nom;
            txtLogin.Clear();
            txtMotDePasse.Clear();
            cboPoste.SelectedIndex = -1;
            tabMenu.TabPages.Remove(tabConnexion);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnDeconnexion.Show();
            lblUtilisateur.Show();
            cboPersonne.Items.Clear();
            cboConsultMateriel.Items.Clear();
            cboSupprMateriel.Items.Clear();
            lstIncidents.Items.Clear();

            tabMenu.TabPages.Add(tabUtilisateur);
            tabMenu.TabPages.Add(tabResponsable);
            tabMenu.TabPages.Add(tabTechnicien);
            tabMenu.TabPages.Remove(tabConnexion);
            tabMenu.SelectedTab = tabUtilisateur;


        }


        #endregion

        #region Onglet Utilisateur

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            if (cboMateriel.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un matériel !");
                return;
            }

            Materiel leMateriel = (Materiel)cboMateriel.SelectedItem;

            Ticket unTicket = new Ticket(0, txtIncident.Text, "En attente", "Non définie", "");
            unTicket.id_Materiel = leMateriel.id_Materiel;
            unTicket.id_Personnel = personneConnecte.id_Personnel;

            BD.AjouteTicket(unTicket);

            MessageBox.Show("Ticket envoyé");
            cboMateriel.SelectedIndex = -1;
            txtIncident.Clear();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            lstTickets.Items.Clear();
            foreach (Ticket t in BD.GetTicketsUtilisateur(personneConnecte.id_Personnel))
            {
                lstTickets.Items.Add(t);
            }
        }

        #endregion

        #region Onglet Technicien

        private void btnAjouterMateriel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProcesseur.Text) || string.IsNullOrWhiteSpace(txtDisque.Text)
                || string.IsNullOrWhiteSpace(txtLogiciels.Text) || cboEtatMateriel.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs et choisir un état");
                return;
            }

            Materiel unMateriel = new Materiel(0, txtProcesseur.Text, txtDisque.Text, txtLogiciels.Text,
                                   DateTime.Today, cboEtatMateriel.Text);
            BD.AjouteMateriel(unMateriel);

            MessageBox.Show("Matériel ajouté");
            txtProcesseur.Clear();
            txtDisque.Clear();
            txtLogiciels.Clear();
            cboEtatMateriel.SelectedIndex = -1;
            RemplirComboSuppression();

        }

        private void btnAfficherMateriel_Click(object sender, EventArgs e)
        {
            if (cboConsultMateriel.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un matériel !");
                return;
            }
            if (cboConsultMateriel.SelectedItem is Materiel m)
            {
                lblValeurProcesseur.Text = m.processus;
                lblValeurDisque.Text = m.disque;
                lblValeurLogiciels.Text = m.logiciel;
                lblValeurEtat.Text = m.etat;
                lblValeurDateAjout.Text = m.date_Ajout.ToShortDateString();
            }

        }

        private void btnSupprimerMateriel_Click(object sender, EventArgs e)
        {
            if (cboSupprMateriel.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez choisir un matériel !");
                return;
            }
            Materiel m = (Materiel)cboSupprMateriel.SelectedItem;
            DialogResult rep = MessageBox.Show("Supprimer " + m + " et tous ses tickets ?", "Confirmation", MessageBoxButtons.YesNo);
            if (rep == DialogResult.Yes)
            {
                BD.DeleteMateriel(m);
                MessageBox.Show("Matériel supprimé");

                RemplirComboSuppression();
                btnAffichIncident_Click(sender, e);
            }

        }



        private void RemplirComboSuppression()
        {
            cboSupprMateriel.Items.Clear();
            cboConsultMateriel.Items.Clear();
            cboSupprMateriel.Text = "";
            foreach (Materiel m in BD.GetMateriels())
            {
                cboSupprMateriel.Items.Add(m);
                cboConsultMateriel.Items.Add(m);

            }

        }

        private void lstIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIncidents.SelectedItem is Ticket t)
            {

                carteTicket.Enabled = t.etat != "En attente";
                lblEtatActuel.Text = "État actuel : " + t.etat;
                txtSuivi.Text = t.suivi;

                rbEnCours.Checked = t.etat == "En cours";
                rbCloture.Checked = t.etat == "Clôturé";

                rbFaible.Checked = t.niveau_Urgence == "Faible";
                rbMoyen.Checked = t.niveau_Urgence == "Moyen";
                rbCritique.Checked = t.niveau_Urgence == "Critique";
            }
            else
            {
                carteTicket.Enabled = false;
            }

        }

        private void btnPrendreEnCharge_Click(object sender, EventArgs e)
        {
            if (lstIncidents.SelectedItem is Ticket t)
            {
                if (t.etat != "En attente")
                {
                    MessageBox.Show("Cet incident est déjà pris en charge");
                    return;
                }

                BD.PriseEnChargeIncident(t, technicienConnecte);
                t.etat = "En cours";
                BD.ModificationEtatIncident(t);
                MessageBox.Show("Incident pris en charge");

                int idTicket = t.id_Ticket;
                btnAffichIncident_Click(sender, e);

                Ticket aSelectionner = null;
                foreach (Ticket ticket in lstIncidents.Items)
                {
                    if (ticket.id_Ticket == idTicket)
                    {
                        aSelectionner = ticket;
                    }
                }
                lstIncidents.SelectedItem = aSelectionner;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un incident");
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!(lstIncidents.SelectedItem is Ticket t))
            {
                MessageBox.Show("Veuillez sélectionner un incident");
                return;
            }

            t.etat = rbCloture.Checked ? "Clôturé" : "En cours";
            t.niveau_Urgence = rbCritique.Checked ? "Critique" : rbMoyen.Checked ? "Moyen" : "Faible";

            BD.ModificationTicket(t);
            MessageBox.Show("Ticket enregistré");
            btnAffichIncident_Click(sender, e);
        }

        private void btnAffichIncident_Click(object sender, EventArgs e)
        {
            lstIncidents.Items.Clear();
            foreach (Ticket t in BD.GetTicket())
            {
                lstIncidents.Items.Add(t);
            }

        }

        #endregion

        #region Onglet Responsable
        // Sur les boutons radios il faudra ajouter une méthode pour afficher ou non les textBox Formation et Compétence

        private List<Personnel> lesPersonnels = new List<Personnel>();

        private void rbTechnicien_CheckedChanged(object sender, EventArgs e)
        {
            panelTechnicien.Show();
            lesPersonnels = BD.GetPersonnelParPoste("Technicien");
            cboPersonne.Items.Clear();

            foreach (Personnel p in lesPersonnels)
            {
                cboPersonne.Items.Add(p.nom + " " + p.prenom);
            }

            txtNom.Clear();
            txtPrenom.Clear();
            txtPostePersonne.Clear();
            txtLoginPersonne.Clear();
            txtMdpPersonne.Clear();
            txtFormation.Clear();
            txtCompetence.Clear();
            dtpDateEmbauche.Value = DateTime.Today;
        }
        private void rbUtilisateur_CheckedChanged(object sender, EventArgs e)
        {
            panelTechnicien.Hide();
            lesPersonnels = BD.GetPersonnelParPoste("Utilisateur");

            cboPersonne.Items.Clear();

            foreach (Personnel p in lesPersonnels)
            {
                cboPersonne.Items.Add(p.nom + " " + p.prenom);
            }

            txtNom.Clear();
            txtPrenom.Clear();
            txtPostePersonne.Clear();
            txtLoginPersonne.Clear();
            txtMdpPersonne.Clear();
            txtFormation.Clear();
            txtCompetence.Clear();
            dtpDateEmbauche.Value = DateTime.Today;
        }
        private void cboPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPersonne.SelectedIndex == -1) return;

            Personnel p = lesPersonnels[cboPersonne.SelectedIndex];
            txtNom.Text = p.nom;
            txtPrenom.Text = p.prenom;
            dtpDateEmbauche.Value = p.date_Embauche;
            txtPostePersonne.Text = p.fonction;
            txtLoginPersonne.Text = p.login;
            txtMdpPersonne.Text = p.MDP;

            if (rbTechnicien.Checked)
            {
                Technicien t = BD.GetTechnicien(p.id_Personnel);
                if (t != null)
                {
                    txtFormation.Text = t.formation;
                    txtCompetence.Text = t.competence;
                }
            }
        }

        private void btnAjouterPersonne_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text)
                || string.IsNullOrWhiteSpace(txtPostePersonne.Text) || string.IsNullOrWhiteSpace(txtLoginPersonne.Text)
                || string.IsNullOrWhiteSpace(txtMdpPersonne.Text)
                || (rbTechnicien.Checked && (string.IsNullOrWhiteSpace(txtFormation.Text) || string.IsNullOrWhiteSpace(txtCompetence.Text))))
            {
                MessageBox.Show("Veillez remplir tous les champs !");
                return;
            }
            string poste = rbTechnicien.Checked ? "Technicien" : "Utilisateur";
            Personnel p = new Personnel(0, txtNom.Text.Trim(), txtPrenom.Text.Trim(), dtpDateEmbauche.Value.Date,
                                        txtPostePersonne.Text.Trim(), txtLoginPersonne.Text.Trim(), txtMdpPersonne.Text, poste);
            try
            {
                BD.AjoutePersonnel(p);

                foreach (Personnel x in BD.GetPersonnelParPoste(poste))
                {
                    if (x.login == p.login) p.id_Personnel = x.id_Personnel;
                }

                if (rbTechnicien.Checked)
                    BD.AjouteTechnicien(new Technicien(0, 1, txtFormation.Text.Trim(), txtCompetence.Text.Trim(), p));
                else
                    BD.AjouteUtilisateur(new Utilisateur(0, p));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ajout impossible : " + ex.Message);
                return;
            }

            MessageBox.Show(poste + " ajouté");
            if (rbTechnicien.Checked) rbTechnicien_CheckedChanged(sender, e);
            else rbUtilisateur_CheckedChanged(sender, e);
        }


        private void btnModifierPersonne_Click(object sender, EventArgs e)
        {
            if (cboPersonne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une personne !");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenom.Text)
                || string.IsNullOrWhiteSpace(txtPostePersonne.Text) || string.IsNullOrWhiteSpace(txtLoginPersonne.Text)
                || string.IsNullOrWhiteSpace(txtMdpPersonne.Text)
                || (rbTechnicien.Checked && (string.IsNullOrWhiteSpace(txtFormation.Text) || string.IsNullOrWhiteSpace(txtCompetence.Text))))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            Personnel p = lesPersonnels[cboPersonne.SelectedIndex];
            p.nom = txtNom.Text.Trim();
            p.prenom = txtPrenom.Text.Trim();
            p.date_Embauche = dtpDateEmbauche.Value.Date;
            p.fonction = txtPostePersonne.Text.Trim();
            p.login = txtLoginPersonne.Text.Trim();
            p.MDP = txtMdpPersonne.Text;

            try
            {
                if (rbTechnicien.Checked)
                    BD.UpdateTechnicien(new Technicien(0, 1, txtFormation.Text.Trim(), txtCompetence.Text.Trim(), p));
                else
                    BD.UpdateUtilisateur(new Utilisateur(0, p));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modification impossible : " + ex.Message);
                return;
            }

            MessageBox.Show("Modification enregistrée");
            if (rbTechnicien.Checked) rbTechnicien_CheckedChanged(sender, e);
            else rbUtilisateur_CheckedChanged(sender, e);
        }

        private void btnSupprimerPersonne_Click(object sender, EventArgs e)
        {
            if (cboPersonne.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une personne !");
                return;
            }

            Personnel p = lesPersonnels[cboPersonne.SelectedIndex];
            try
            {
                if (rbTechnicien.Checked)
                    BD.DeleteTechnicien(new Technicien(0, 1, "", "", p));
                else
                    BD.DeleteUtlisateur(new Utilisateur(0, p));
            }
            catch (Exception)
            {
                MessageBox.Show("Suppression impossible : des incidents sont liés à cette personne.");
                return;
            }

            MessageBox.Show("Personne supprimée");
            if (rbTechnicien.Checked) rbTechnicien_CheckedChanged(sender, e);
            else rbUtilisateur_CheckedChanged(sender, e);
        }

        private void btnActualiserStats_Click(object sender, EventArgs e)
        {
            lstStatsIncidents.Items.Clear();
            lstStatsTechniciens.Items.Clear();
            lstStatsUtilisateurs.Items.Clear();

            StatsIncidents si = BD.GetStatsIncidents();
            lstStatsIncidents.Items.Add("Total : " + si.total);
            lstStatsIncidents.Items.Add("Déclarés : " + si.declares + " (" + si.pourcentageDeclares.ToString("0.0") + " %)");
            lstStatsIncidents.Items.Add("En charge : " + si.enCharge + " (" + si.pourcentageEnCharge.ToString("0.0") + " %)");
            lstStatsIncidents.Items.Add("Résolus : " + si.resolus + " (" + si.pourcentageResolus.ToString("0.0") + " %)");
            lstStatsIncidents.Items.Add("Délai moyen d'intervention : " + si.joursMoyensIntervention.ToString("0.0") + " jour(s)");

            foreach (StatsTechnicien st in BD.GetStatsTechniciens())
            {
                lstStatsTechniciens.Items.Add(st.nom + " " + st.prenom + " : " + st.enCharge + " en charge, " + st.resolus + " résolus");
            }

            foreach (StatsUtilisateur su in BD.GetStatsUtilisateurs())
            {
                lstStatsUtilisateurs.Items.Add(su.nom + " " + su.prenom + " : " + su.declares + " déclarés, ");
            }
        }
        #endregion

    }
}