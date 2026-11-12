using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GSBIncidents
{
    internal class BD
    {
        private static MySqlConnection Connexion()
        {
            MySqlConnection conn = new MySqlConnection("Server=192.168.1.10;Port=8889;Database=projetgestion;Uid=admin;Password=1234");
            conn.Open();
            return conn;
        }

        public static void AjoutePersonnel(Personnel unPersonnel)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "INSERT INTO Personnel (Id_Personnel, Nom, Prenom, Date_Embauche, Fonction, Login, MDP, Poste) "
                   + "VALUES (@id_Personnel, @nom, @prenom, @date_Embauche, @fonction, @login, @MDP, @poste)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@id_Personnel", unPersonnel.id_Personnel);
            cmd.Parameters.AddWithValue("@nom", unPersonnel.nom);
            cmd.Parameters.AddWithValue("@prenom", unPersonnel.prenom);
            cmd.Parameters.AddWithValue("@date_Embauche", unPersonnel.date_Embauche);
            cmd.Parameters.AddWithValue("@fonction", unPersonnel.fonction);
            cmd.Parameters.AddWithValue("@login", unPersonnel.login);
            cmd.Parameters.AddWithValue("@MDP", unPersonnel.MDP);
            cmd.Parameters.AddWithValue("@poste", unPersonnel.poste);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void AjouteResponsable(Responsable unResponsable)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "INSERT INTO Responsable (Id_Responsable) "
                   + "VALUES (@id_Responsable)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@id_Responsable", unResponsable.id_Responsable);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void AjouteMateriel(Materiel unMateriel)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "INSERT INTO Materiel (Id_Materiel, Processus, Disque, Logiciel, Suivis, Etat) "
                   + "VALUES (@id_Materiel, @processus, @disque, @logiciel, @suivis, @etat)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@id_Materiel", unMateriel.id_Materiel);
            cmd.Parameters.AddWithValue("@processus", unMateriel.processus);
            cmd.Parameters.AddWithValue("@disque", unMateriel.disque);
            cmd.Parameters.AddWithValue("@logiciel", unMateriel.logiciel);
            cmd.Parameters.AddWithValue("@suivis", unMateriel.suivis);
            cmd.Parameters.AddWithValue("@etat", unMateriel.etat);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void AjouteTicket(Ticket unTicket)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "INSERT INTO Ticket (Id_Ticket, Incident, Etat, Niveau_Urgence, Suivi) "
                   + "VALUES (@id_Ticket, @incident, @etat, @niveau_Urgence, @suivi)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@id_Ticket", unTicket.id_Ticket);
            cmd.Parameters.AddWithValue("@incident", unTicket.incident);
            cmd.Parameters.AddWithValue("@etat", unTicket.etat);
            cmd.Parameters.AddWithValue("@niveau_Urgence", unTicket.niveau_Urgence);
            cmd.Parameters.AddWithValue("@suivi", unTicket.suivi);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void AjouteUtilisateur(Utilisateur unUtilisateur)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "INSERT INTO Utilisateur (Id_User) "
                   + "VALUES (@id_User)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@id_User", unUtilisateur.id_User);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void AjouteTechnicien(Technicien unTechnicien)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "INSERT INTO Technicien (Id_Tech, Formation, Competence) "
                   + "VALUES (@id_Tech, @formation, @competence)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@id_Tech", unTechnicien.id_Tech);
            cmd.Parameters.AddWithValue("@formation", unTechnicien.formation);
            cmd.Parameters.AddWithValue("@competence", unTechnicien.competence);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void DeleteMateriel(Materiel unMateriel)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "DELETE FROM Materiel WHERE Id_Materiel = @id_Materiel";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@id_Materiel", unMateriel.id_Materiel);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void DeleteUtlisateur(Utilisateur unUtilisateur)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "DELETE FROM Utilisateur WHERE Id_User = @id_User";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@id_User", unUtilisateur.id_User);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void DeleteTechnicien(Technicien unTechnicien)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "DELETE FROM Technicien WHERE Id_Tech = @id_Tech";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@id_Tech", unTechnicien.id_Tech);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void UpdateUtilisateur(Utilisateur unUtilisateur)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "UPDATE Utilisateur SET nom_user WHERE Id_User = @id_User";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@id_User", unUtilisateur.id_User);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateTechnicien(Technicien unTechnicien)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "UPDATE Technicien SET nom_tech WHERE Id_Tech = @id_Tech";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@id_Tech", unTechnicien.id_Tech);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static Personnel SeConnecter(string login, string MDP)
        {
            Personnel personne = null;
            MySqlConnection conn = Connexion();

            string reqSql = "SELECT * FROM Personnel WHERE Login = @login AND MDP = @mdp";
            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@mdp", MDP);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_Personnel"]);
                string nom = reader["Nom"].ToString();
                string prenom = reader["Prenom"].ToString();
                DateTime dateEmbauche = Convert.ToDateTime(reader["Date_Embauche"]);
                string fonction = reader["Fonction"].ToString();
                string loginBD = reader["Login"].ToString();
                string mdpBD = reader["MDP"].ToString();
                string poste = reader["Poste"].ToString();

                personne = new Personnel(id, nom, prenom, dateEmbauche, fonction, loginBD, mdpBD, poste);
            }

            reader.Close();
            conn.Close();

            return personne;
        }

        public static void PriseEnChargeIncident(Ticket unTicket, Technicien unTechnicien)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "UPDATE Ticket SET Id_Tech = @id_Tech WHERE Id_Ticket = @id_Ticket";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@id_Tech", unTechnicien.id_Tech);
            cmd.Parameters.AddWithValue("@id_Ticket", unTicket.id_Ticket);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void ModificationEtatIncident(Ticket unTicket)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "UPDATE Ticket SET Etat = @etat WHERE Id_Ticket = @id_Ticket";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@etat", unTicket.etat);
            cmd.Parameters.AddWithValue("@id_Ticket", unTicket.id_Ticket);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        internal static List<Materiel> GetMateriels()
        {
            throw new NotImplementedException();
        }

        internal static void ModificationTicket(Ticket unTicket)
        {
            throw new NotImplementedException();
        }

        internal static List<Ticket> GetTicketsNonClotures()
        {
            throw new NotImplementedException();
        }
    }

}