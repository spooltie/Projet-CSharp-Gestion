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
            carteNouveau.Enabled= false;
            carteTickets.Enabled = false;
            carteMateriel.Enabled = false;
            carteIncidents.Enabled = false;
            carteTicket.Enabled = false;
            cartePersonnel.Enabled = false;
   
        }

        #region Entête

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Onglet Connexion

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtMotDePasse.Text;

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
                carteNouveau.Enabled = false;
                carteTickets.Enabled = false;
                carteMateriel.Enabled = true;
                carteIncidents.Enabled = true;
                carteTicket.Enabled = true;
                tabMenu.SelectedTab = tabTechnicien;

            }
            else if (poste == "utilisateur")
            {
                carteNouveau.Enabled = true;
                carteTickets.Enabled = true;
                carteMateriel.Enabled = false;
                carteIncidents.Enabled = false;
                carteTicket.Enabled = false;
                cartePersonnel.Enabled = false;
                tabMenu.SelectedTab = tabUtilisateur;
            }
            else if (poste == "responsable")
            {
                carteNouveau.Enabled = false;
                carteTickets.Enabled = false;
                carteMateriel.Enabled = false;
                carteIncidents.Enabled = false;
                carteTicket.Enabled = false;
                cartePersonnel.Enabled = true;
                tabMenu.SelectedTab = tabResponsable;
            }
            else
            {
                MessageBox.Show("Fonction non reconnue !"+ personneConnecte.poste);
                personneConnecte = null;
                return;

            }
            lblUtilisateur.Text = "Connecté :" + personneConnecte.prenom + " " + personneConnecte.nom;
            txtLogin.Clear();
            txtMotDePasse.Clear();
            cboPoste.SelectedIndex = -1;
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

        }

        private void cboPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouterPersonne_Click(object sender, EventArgs e)
        {

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