using System.Reflection.Metadata.Ecma335;

namespace GSBIncidents
{
    public partial class FormPrincipal : Form
    {

        private Personnel personneConnecte;
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

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Onglet Technicien

        private void btnAjouterMateriel_Click(object sender, EventArgs e)
        {

        }

        private void btnAfficherMateriel_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerMateriel_Click(object sender, EventArgs e)
        {

        }

        private void lstIncidents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrendreEnCharge_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

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