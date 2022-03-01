using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commande
{
    class Class3
    {
        public void Update(Commande commande)
        {
            //1 - Définir la ConnectionString
            String connectionString = "Server=localhost;Database=commande;Uid=root;Pwd=root;";

            //2 - création de la Connection
            MySqlConnection sqlConnection = new MySqlConnection(connectionString);

            //3 - Ouvrir la connection
            sqlConnection.Open();

            //4 - Ecrire la requête
            String query = $@"UPDATE EntetCommande
                              ModifiedDate = @Date
                              WHERE Identifiant = @IdentifiantCommande ;";

            //5 - Créer la commande
            MySqlCommand cmd = new MySqlCommand(query, sqlConnection);
            cmd.Parameters.AddWithValue("IdentifiantCommande", commande.Identifiant);
            cmd.Parameters.AddWithValue("Date", DateTime.Now);

            //6 - Executer la commande
            cmd.ExecuteNonQuery();

            //7 - Fermer la connection
            sqlConnection.Close();
        }
    }
}
