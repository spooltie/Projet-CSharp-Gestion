using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GSBIncidents
{
    internal class BD
    {
        private static MySqlConnection Connexion()
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=projetgestion;Uid=root;Password=;");

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

            reqSql = "INSERT INTO Materiel (Processus, Disque, Logiciel, Date_Ajout, Etat) "
       + "VALUES (@processus, @disque, @logiciel, CURDATE(), @etat)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@processus", unMateriel.processus);
            cmd.Parameters.AddWithValue("@disque", unMateriel.disque);
            cmd.Parameters.AddWithValue("@logiciel", unMateriel.logiciel);
            cmd.Parameters.AddWithValue("@etat", unMateriel.etat);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static void AjouteTicket(Ticket unTicket)
        {
            MySqlConnection conn = Connexion();

            string reqSql;

            reqSql = "INSERT INTO Ticket (Incident, Etat, Niveau_Urgence, Suivi, id_materiel, Id_Utilisateur, Id_Tech) "
                   + "VALUES (@incident, @etat, @niveau_Urgence, @suivi, @id_materiel, (SELECT Id_Utilisateur FROM Utilisateurs WHERE Id_personnel = @idPersonnel), NULL)";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@incident", unTicket.incident);
            cmd.Parameters.AddWithValue("@etat", unTicket.etat);
            cmd.Parameters.AddWithValue("@niveau_Urgence", unTicket.niveau_Urgence);
            cmd.Parameters.AddWithValue("@suivi", unTicket.suivi);
            cmd.Parameters.AddWithValue("@id_materiel", unTicket.id_Materiel);
            cmd.Parameters.AddWithValue("@idPersonnel", unTicket.id_Personnel);

            cmd.ExecuteNonQuery();

            // Le matériel du ticket passe "En panne"
            MySqlCommand cmdPanne = new MySqlCommand("UPDATE Materiel SET Etat = 'En panne' WHERE id_materiel = @id", conn);
            cmdPanne.Parameters.AddWithValue("@id", unTicket.id_Materiel);
            cmdPanne.ExecuteNonQuery();

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

            // 1. Supprimer les tickets liés à ce matériel
            MySqlCommand cmdTickets = new MySqlCommand("DELETE FROM Ticket WHERE id_materiel = @id", conn);
            cmdTickets.Parameters.AddWithValue("@id", unMateriel.id_Materiel);
            cmdTickets.ExecuteNonQuery();

            // 2. Supprimer le matériel
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Materiel WHERE Id_Materiel = @id", conn);
            cmd.Parameters.AddWithValue("@id", unMateriel.id_Materiel);
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
            List<Materiel> lesMateriels = new List<Materiel>();
            MySqlConnection conn = Connexion();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Materiel", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_Materiel"]);
                string processus = reader["Processus"].ToString();
                string disque = reader["Disque"].ToString();
                string logiciel = reader["Logiciel"].ToString();
                DateTime dateAjout = Convert.ToDateTime(reader["Date_Ajout"]);
                string etat = reader["Etat"].ToString();
                Materiel materiel = new Materiel(id, processus, disque, logiciel, dateAjout, etat);
                lesMateriels.Add(materiel);
            }

            reader.Close();
            conn.Close();

            return lesMateriels;
        }

        internal static List<Ticket> GetTicket()
        {
            List<Ticket> lesTickets = new List<Ticket>();
            MySqlConnection conn = Connexion();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM TICKET", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_Ticket"]);
                string incident = reader["Incident"].ToString();
                string etat = reader["Etat"].ToString();
                string niveau_urgence = reader["Niveau_urgence"].ToString();
                string suivi = reader["Suivi"].ToString();


                Ticket ticket = new Ticket(id, incident, etat, niveau_urgence, suivi);
                lesTickets.Add(ticket);
            }
            reader.Close();
            conn.Close();

            return lesTickets;


        }

        internal static List<Ticket> GetTicketsUtilisateur(int idPersonel)
        {
            List<Ticket> LesTickets = new List<Ticket>();
            MySqlConnection conn = Connexion();
            string reqSql = "SELECT t.* FROM Ticket t "
                  + "JOIN Utilisateurs u ON t.Id_Utilisateur = u.Id_Utilisateur "
                  + "WHERE u.Id_personnel = @idPersonnel";
            MySqlCommand cmd = new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@idPersonnel", idPersonel);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int idTicket = Convert.ToInt32(reader["Id_Ticket"]);
                string incident = reader["Incident"].ToString();
                string etat = reader["Etat"].ToString();
                string niveauUrgence = reader["Niveau_Urgence"].ToString();
                string suivi = reader["Suivi"].ToString();
                Ticket ticket = new Ticket(idTicket, incident, etat, niveauUrgence, suivi);
                LesTickets.Add(ticket);
            }
            reader.Close();
            conn.Close();

            return LesTickets;
        }

        internal static List<Personnel> GetPersonnelParPoste(string poste)
        {
            List<Personnel> LePersonnel=new List<Personnel>();
            MySqlConnection conn = Connexion();

            string reqSql = "SELECT * FROM personnel WHERE Poste=@poste";
            MySqlCommand cmd= new MySqlCommand(reqSql, conn);
            cmd.Parameters.AddWithValue("@poste", poste);

            MySqlDataReader reader=cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_Personnel"]);
                string nom = reader["Nom"].ToString();
                string prenom = reader["Prenom"].ToString();
                DateTime dateEmbauche = Convert.ToDateTime(reader["Date_Embauche"]);
                string fonction = reader["Fonction"].ToString();
                string loginBD = reader["Login"].ToString();
                string mdpBD = reader["MDP"].ToString();
                string posteBD = reader["Poste"].ToString();

                LePersonnel.Add(new Personnel(id, nom, prenom, dateEmbauche, fonction, loginBD, mdpBD, posteBD));

            }

            reader.Close();
            conn.Close();
            return LePersonnel;
        }

        internal static Technicien GetTechnicien (int id_Personnel)
        {
            Technicien leTechnicien = null;
            MySqlConnection conn = Connexion();

            string reqSql = "SELECT p.*, t.Id_Tech, t.Formation, t.Competence FROM technicien t JOIN personnel p ON t.Id_personnel = p.Id_personnel "
                          + "WHERE p.Id_personnel = @id_Personnel"; 
            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@id_Personnel", id_Personnel);

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
                int idTech = Convert.ToInt32(reader["Id_Tech"]);
                string formation = reader["Formation"].ToString();
                string competence = reader["Competence"].ToString();

                Personnel p = new Personnel(id, nom, prenom, dateEmbauche, fonction, loginBD, mdpBD, poste);

                leTechnicien = new Technicien(idTech, 1, formation, competence, p);
            }

            reader.Close();
            conn.Close();
            return leTechnicien;
        }

        internal static StatsIncidents GetStatsIncidents()
        {
            StatsIncidents stats = new StatsIncidents();
            MySqlConnection conn = Connexion();

            string reqSql = "SELECT COUNT(*) AS Total, IFNULL(SUM(Etat = 'En attente'), 0) AS Declares, IFNULL(SUM(Etat = 'En cours'), 0) AS EnCharge, "
              + "IFNULL(SUM(Etat IN ('Résolu', 'Clôturé')), 0) AS Resolus, "
              + "AVG(CASE WHEN Etat IN ('Résolu', 'Clôturé') "
              + "THEN DATEDIFF(Date_Resolution, Date_Declaration) END) AS JoursMoyens "
              + "FROM ticket";
            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                stats.total = Convert.ToInt32(reader["Total"]);
                stats.declares = Convert.ToInt32(reader["Declares"]);
                stats.enCharge = Convert.ToInt32(reader["EnCharge"]);
                stats.resolus = Convert.ToInt32(reader["Resolus"]);

                if (reader["JoursMoyens"] != DBNull.Value)
                {

                    stats.joursMoyensIntervention = Convert.ToDouble(reader["JoursMoyens"]);
                }

                if (stats.total > 0)
                {
                    stats.pourcentageDeclares = 100.0 * stats.declares / stats.total;
                    stats.pourcentageEnCharge = 100.0 * stats.enCharge / stats.total;
                    stats.pourcentageResolus = 100.0 * stats.resolus / stats.total;
                }
            }

            reader.Close();
            conn.Close();
            return stats;
        }

        internal static List<StatsTechnicien> GetStatsTechniciens()
        {
            List<StatsTechnicien> lesStats = new List<StatsTechnicien>();
            MySqlConnection conn = Connexion();

            string reqSql = "SELECT t.Id_Tech, p.Nom, p.Prenom, IFNULL(SUM(k.Etat = 'En cours'), 0) AS EnCharge, IFNULL(SUM(k.Etat IN ('Résolu', 'Clôturé')), 0) AS Resolus "
              + "FROM technicien t "
              + "JOIN personnel p ON t.Id_personnel = p.Id_personnel "
              + "LEFT JOIN ticket k ON k.Id_Tech = t.Id_Tech "
              + "GROUP BY t.Id_Tech, p.Nom, p.Prenom";

            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StatsTechnicien s = new StatsTechnicien();
                s.id_Tech = Convert.ToInt32(reader["Id_Tech"]);
                s.nom = reader["Nom"].ToString();
                s.prenom = reader["Prenom"].ToString();
                s.enCharge = Convert.ToInt32(reader["EnCharge"]);
                s.resolus = Convert.ToInt32(reader["Resolus"]);
                lesStats.Add(s);
            }

            reader.Close();
            conn.Close();
            return lesStats;
        }

        internal static List<StatsUtilisateur> GetStatsUtilisateurs()
        {
            List<StatsUtilisateur> lesStats = new List<StatsUtilisateur>();
            MySqlConnection conn = Connexion();

            string reqSql = "SELECT u.Id_Utilisateur, p.Nom, p.Prenom, COUNT(k.Id_ticket) AS Declares, IFNULL(SUM(k.Etat IN ('Résolu', 'Clôturé')), 0) AS Resolus "
              + "FROM utilisateurs u "
              + "JOIN personnel p ON u.Id_personnel = p.Id_personnel "
              + "LEFT JOIN ticket k ON k.id_Utilisateur = u.Id_Utilisateur "
              + "GROUP BY u.Id_Utilisateur, p.Nom, p.Prenom";
            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StatsUtilisateur s = new StatsUtilisateur();
                s.id_User = Convert.ToInt32(reader["Id_Utilisateur"]);
                s.nom = reader["Nom"].ToString();
                s.prenom = reader["Prenom"].ToString();
                s.declares = Convert.ToInt32(reader["Declares"]);
                s.resolus = Convert.ToInt32(reader["Resolus"]);
                lesStats.Add(s);
            }

            reader.Close();
            conn.Close();
            return lesStats;
        }

        internal static void ModificationTicket(Ticket unTicket)
        {
            MySqlConnection conn = Connexion();
            string reqSql;
            reqSql = "UPDATE Ticket SET Etat = @etat, Niveau_urgence = @urgence, Suivi = @suivi WHERE Id_ticket = @id_Ticket";
            MySqlCommand cmd = new MySqlCommand(reqSql, conn);

            cmd.Parameters.AddWithValue("@etat", unTicket.etat);
            cmd.Parameters.AddWithValue("@urgence", unTicket.niveau_Urgence);
            cmd.Parameters.AddWithValue("@suivi", unTicket.suivi);
            cmd.Parameters.AddWithValue("@id_Ticket", unTicket.id_Ticket);

            cmd.ExecuteNonQuery();
            if (unTicket.etat == "Clôturé")
            {
                MySqlCommand cmdService = new MySqlCommand(
                    "UPDATE Materiel SET Etat = 'En service' "
                  + "WHERE id_materiel = (SELECT id_materiel FROM Ticket WHERE Id_ticket = @idTicket) "
                  + "AND NOT EXISTS (SELECT 1 FROM Ticket WHERE id_materiel = Materiel.id_materiel AND Etat <> 'Clôturé')", conn);
                cmdService.Parameters.AddWithValue("@idTicket", unTicket.id_Ticket);
                cmdService.ExecuteNonQuery();
            }
            conn.Close();

        }

        internal static List<Ticket> GetTicketsNonClotures()
        {
            throw new NotImplementedException();
        }

    }
}