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
        /// AJOUTER UN PERSONNEL 
        /// <summary>
        /// <param name="unPersonnel"></param>
        public static void AjoutePersonnel(Personnel unPersonnel)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "INSERT INTO Personnel (Id_Personnel, nom, Prenom, Date_Embauche, Login, MDP, Poste ) "
                   + "VALUES (@id_Personnel, @nom, @Prenom, @Date_Embauche, @Login, @MDP, @Poste )";

            cmd.CommandText = reqSql;

            cmd.Parameters.AddWithValue("@Id_Personnel", unPersonnel.Id_personnel);
            cmd.Parameters.AddWithValue("@nom", unPersonnel.Nom);
            cmd.Parameters.AddWithValue("@Prenom", unPersonnel.Prenom);
            cmd.Parameters.AddWithValue("@Date_Embauche", unPersonnel.Date_Embauche);
            cmd.Parameters.AddWithValue("@Login", unPersonnel.Login);
            cmd.Parameters.AddWithValue("@MDP", unPersonnel.MDP);
            cmd.Parameters.AddWithValue("@Poste", unPersonnel.Poste);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// AJOUTER UN RESPONSABLE 
        /// <summary>
        /// <param name="unResponsable"></param>
        public static void AjouteResponsable(Responsable unResponsable)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "INSERT INTO Responsable (Id_Responsable) "
                   + "VALUES (@Id_Responsable)";

            cmd.CommandText = reqSql;

            cmd.Parameters.AddWithValue("@Id_Responsable", unResponsable.id_responsable);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// AJOUTER UN MATERIEL 
        /// <summary>
        /// <param name="unResponsable"></param>
        public static void AjouteMateriel(Materiel unMateriel)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "INSERT INTO Materiel (Id_Materiel, Processus, Disque, Logiciel, Suivis, Etat) "
                   + "VALUES (@Id_Materiel, @Processus, @Disque, @Logiciel, @Suivis, @Etat)";

            cmd.CommandText = reqSql;

            cmd.Parameters.AddWithValue("@Id_Materiel", unMateriel.id_materiel);
            cmd.Parameters.AddWithValue("@Processus", unMateriel.processus);
            cmd.Parameters.AddWithValue("@Disque", unMateriel.disque);
            cmd.Parameters.AddWithValue("@Logiciel", unMateriel.logiciel);
            cmd.Parameters.AddWithValue("@Suivis", unMateriel.suivis);
            cmd.Parameters.AddWithValue("@Etat", unMateriel.etat);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// AJOUTER UN TICKET 
        /// <summary>
        /// <param name="unTicket"></param>
        public static void AjouteTicket(Ticket unTicket)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "INSERT INTO Ticket (Id_Ticket, Incident, Etat, Niveau_urgence, Suivi) "
                   + "VALUES (@Id_Ticket, @Incident, @Etat, @Suivi, @Niveau_urgence)";

            cmd.CommandText = reqSql;

            cmd.Parameters.AddWithValue("@Id_Ticket", unTicket.ID_ticket);
            cmd.Parameters.AddWithValue("@Incident", unTicket.Incident);
            cmd.Parameters.AddWithValue("@Etat", unTicket.Etat);
            cmd.Parameters.AddWithValue("@Suivi", unTicket.Suivi);
            cmd.Parameters.AddWithValue("@Niveau_urgence", unTicket.Niveau_urgence);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// AJOUTER UN UTILISATEUR 
        /// <summary>
        /// <param name="unUtilisateur"></param>
        public static void AjouteUtilisateur(Utilisateur unUtilisateur)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "INSERT INTO Utilisateur (Id_user)"
                   + "VALUES (@Id_user)";

            cmd.CommandText = reqSql;

            cmd.Parameters.AddWithValue("@Id_Responsable", unUtilisateur.Id_user);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// AJOUTER UN TECHNICIEN 
        /// <summary>
        /// <param name="unTechnicien"></param>
        public static void AjouteTechnicien(Technicien unTechnicien)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "INSERT INTO Technicien (id_tech, formation, competence)"
                   + "VALUES (@id_tech, @formation, @competence)";

            cmd.CommandText = reqSql;

            cmd.Parameters.AddWithValue("@id_tech", unTechnicien.id_tech);
            cmd.Parameters.AddWithValue("@formation", unTechnicien.formation);
            cmd.Parameters.AddWithValue("@competence", unTechnicien.competence);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// SUPPRESSION MATERIEL 
        /// <summary>
        /// <param name="unMateriel"></param>
        public static void DeleteMateriel(Materiel unMateriel)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "DELETE FROM MATERIEL WHERE id_materiel = @id_materiel";

            cmd.CommandText = reqSql;
            cmd.Parameters.AddWithValue("@id_materiel", unMateriel.id_materiel);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// SUPPRESSION UTILISATEUR 
        /// <summary>
        /// <param name="unUtilsateur"></param>
        public static void DeleteUtlisateur(Utilisateur unUtilisateur)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "DELETE FROM Utilisateur WHERE id_user = @id_user";

            cmd.CommandText = reqSql;
            cmd.Parameters.AddWithValue("@id_user", unUtilisateur.Id_user);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        /// SUPPRESSION TECHNICIEN 
        /// <summary>
        /// <param name="unTechnicien"></param>
        public static void DeleteTechnicien(Technicien unTechnicien)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "DELETE FROM Technicien WHERE id_tech = @id_tech";

            cmd.CommandText = reqSql;
            cmd.Parameters.AddWithValue("@id_tech", unTechnicien.id_tech);

            cmd.ExecuteNonQuery();
            conn.Close();

        }





    }

}