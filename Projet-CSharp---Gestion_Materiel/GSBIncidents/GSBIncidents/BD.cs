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

            cmd.Parameters.AddWithValue("@Id_Materiel", unMateriel.id_Materiel);
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

            cmd.Parameters.AddWithValue("@Id_Ticket", unTicket.id_Ticket);
            cmd.Parameters.AddWithValue("@Incident", unTicket.incident);
            cmd.Parameters.AddWithValue("@Etat", unTicket.etat);
            cmd.Parameters.AddWithValue("@Suivi", unTicket.suivi);
            cmd.Parameters.AddWithValue("@Niveau_urgence", unTicket.niveau_Urgence);


            cmd.ExecuteNonQuery();
            conn.Close();
        }



    }
}
