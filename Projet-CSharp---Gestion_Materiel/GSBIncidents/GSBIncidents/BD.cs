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

            cmd.Parameters.AddWithValue("@Id_Personnel", unPersonnel.id_Personnel);
            cmd.Parameters.AddWithValue("@nom", unPersonnel.nom);
            cmd.Parameters.AddWithValue("@Prenom", unPersonnel.prenom);
            cmd.Parameters.AddWithValue("@Date_Embauche", unPersonnel.date_Embauche);
            cmd.Parameters.AddWithValue("@Login", unPersonnel.login);
            cmd.Parameters.AddWithValue("@MDP", unPersonnel.MDP);
            cmd.Parameters.AddWithValue("@Poste", unPersonnel.poste);

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

            cmd.Parameters.AddWithValue("@Id_Responsable", unResponsable.id_Responsable);


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

            cmd.Parameters.AddWithValue("@Id_Materiel", unMateriel.Id_materiel);
            cmd.Parameters.AddWithValue("@Processus", unMateriel.Processus);
            cmd.Parameters.AddWithValue("@Disque", unMateriel.Disque);
            cmd.Parameters.AddWithValue("@Logiciel", unMateriel.Logiciel);
            cmd.Parameters.AddWithValue("@Suivis", unMateriel.Suivis);
            cmd.Parameters.AddWithValue("@Etat", unMateriel.Etat);

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

            cmd.Parameters.AddWithValue("@Id_Ticket", unTicket.id_Ticket);
            cmd.Parameters.AddWithValue("@Incident", unTicket.incident);
            cmd.Parameters.AddWithValue("@Etat", unTicket.etat);
            cmd.Parameters.AddWithValue("@Suivi", unTicket.suivi);
            cmd.Parameters.AddWithValue("@Niveau_urgence", unTicket.niveau_Urgence);

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

        public static void UpdateUtilisateur(Utilisateur unUtilisateur)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "UPDATE Utilisateur SET nom_user WHERE id_user = @id_user";

            cmd.CommandText = reqSql;
            cmd.Parameters.AddWithValue("@id_user", unUtilisateur.Id_user);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void UpdateTechnicien(Technicien unTechnicien)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            string reqSql;

            reqSql = "UPDATE Technicien SET nom_tech WHERE id_tech = @id_tech";

            cmd.CommandText = reqSql;
            cmd.Parameters.AddWithValue("@id_tech", unTechnicien.id_tech);

            cmd.ExecuteNonQuery();
            conn.Close();
        }



    }

}