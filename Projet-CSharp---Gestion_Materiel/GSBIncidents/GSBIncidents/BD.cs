using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mysql.Data.MySqlClient;

namespace GSBIncidents
{
    internal class BD
    {
        /// AJOUTER UN PERSONNEL 
        /// <summary>
        /// <param name="unPersonnel"></param>
        public static void AjoutePersonnel(Personnel unPersonnel)
        {
            MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database= babe5484_projetgestion;Uid=babe5484_admin;Password=ZVAx0hLGr");
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
    }
}
