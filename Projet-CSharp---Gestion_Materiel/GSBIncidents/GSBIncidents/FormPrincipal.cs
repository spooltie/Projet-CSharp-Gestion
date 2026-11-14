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

            Ticket unTicket = new Ticket(0, txtIncident.Text, "En Attente", "Non définie", "");
            unTicket.id_Materiel = leMateriel.id_Materiel;
            unTicket.id_Personnel = personneConnecte.id_Personnel;

            BD.AjouteTicket(unTicket);

            MessageBox.Show("Ticket envoyé");
            cboMateriel.SelectedIndex = -1;
            txtIncident.Clear();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {

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
                                               txtSuiviMateriel.Text, cboEtatMateriel.Text);
            technicienConnecte.AjouterMateriel(unMateriel);

            MessageBox.Show("Matériel ajouté");
            txtProcesseur.Clear();
            txtDisque.Clear();
            txtLogiciels.Clear();
            txtSuiviMateriel.Clear();
            cboEtatMateriel.SelectedIndex = -1;
            RemplirComboSuppression();

        }

        private void btnAfficherMateriel_Click(object sender, EventArgs e)
        {
            {
                cboConsultMateriel.Items.Clear();
                foreach (Materiel m in technicienConnecte.ConsulterMateriels())
                {
                    cboConsultMateriel.Items.Add(m);
                }
            }
        }
        private void cboConsultMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboConsultMateriel.SelectedItem is Materiel m)
            {
                lblValeurProcesseur.Text = m.processus;
                lblValeurDisque.Text = m.disque;
                lblValeurLogiciels.Text = m.logiciel;
                lblValeurEtat.Text = m.etat;
                lblValeurSuivi.Text = m.suivis;
            }

        }

        private void btnSupprimerMateriel_Click(object sender, EventArgs e)
        {
            if (cboSupprMateriel.SelectedItem is Materiel m)
            {
                DialogResult rep = MessageBox.Show("Supprimer " + m + " ?", "Confirmation", MessageBoxButtons.YesNo);
                if (rep == DialogResult.Yes)
                {
                    technicienConnecte.SupprimerMateriel(m);
                    MessageBox.Show("Matériel supprimé");
                }
            }

            RemplirComboSuppression();
        }

        private void RemplirComboSuppression()
        {
            cboSupprMateriel.Items.Clear();
            cboSupprMateriel.Text = "";
            foreach (Materiel m in technicienConnecte.ConsulterMateriels())
            {
                cboSupprMateriel.Items.Add(m);
            }

        }

        private void lstIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstIncidents.SelectedItem is Ticket t)
            {
                lblEtatActuel.Text = "État actuel : " + t.etat;
                txtSuivi.Text = t.suivi;

                rbEnCours.Checked = t.etat == "En cours";
                rbResolu.Checked = t.etat == "Résolu";
                rbCloture.Checked = t.etat == "Clôturé";

                rbFaible.Checked = t.niveau_Urgence == "Faible";
                rbMoyen.Checked = t.niveau_Urgence == "Moyen";
                rbCritique.Checked = t.niveau_Urgence == "Critique";
            }

        }

        private void btnPrendreEnCharge_Click(object sender, EventArgs e)
        {
            if (lstIncidents.SelectedItem is Ticket t)
            {
                technicienConnecte.PrendreEnCharge(t);
                MessageBox.Show("Incident pris en charge");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un incident");
            }

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            {
                if (!(lstIncidents.SelectedItem is Ticket t))
                {
                    MessageBox.Show("Veuillez sélectionner un incident");
                    return;
                }

                t.etat = rbResolu.Checked ? "Résolu" : rbCloture.Checked ? "Clôturé" : "En cours";
                t.niveau_Urgence = rbCritique.Checked ? "Critique" : rbMoyen.Checked ? "Moyen" : "Faible";

                technicienConnecte.ConsignerSuivis(t, txtSuivi.Text);
                MessageBox.Show("Ticket enregistré");
                btnAffichIncident_Click(sender, e);

            }
        }

        private void btnAffichIncident_Click(object sender, EventArgs e)
        {
            lstIncidents.Items.Clear();
            foreach (Ticket t in technicienConnecte.ConsulterTickets())
            {
                lstIncidents.Items.Add(t);
            }

        }

        #endregion

        #region Onglet Responsable
        // Sur les boutons radios il faudra ajouter une méthode pour afficher ou non les textBox Formation et Compétence

        private void rbTechnicien_CheckedChanged(object sender, EventArgs e)
        {
            panelTechnicien.Show();
            cboPersonne.Items.Add(lblNom);
        }
        private void rbUtilisateur_CheckedChanged(object sender, EventArgs e)
        {
            panelTechnicien.Hide();
            //cboPersonne.Items.Add(La liste des utilisateur - leurs id et nom ?);
        }
        private void cboPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterPersonne_Click(object sender, EventArgs e)
        {
            if (rbTechnicien.Checked)
            {

            }
            if (rbUtilisateur.Checked)
            {
                panelTechnicien.Hide();
            }



        }

        private void btnModifierPersonne_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerPersonne_Click(object sender, EventArgs e)
        {

        }

        #endregion



    }
}