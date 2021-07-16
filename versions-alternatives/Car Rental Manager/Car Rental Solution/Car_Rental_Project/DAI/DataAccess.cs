using System.Data;
using System.Data.SqlClient;

namespace Car_Rental_Project.DAI
{
    /// <summary>
    /// Représente une couche d'accés aux données permettant 
    /// de recevoir et d'envoyer des données depuis une base de données SQL.
    /// </summary>
    public class DataAccess
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter;
        private SqlCommandBuilder commandBuilder;
        private DataTable table;
        /// <summary>
        /// Obtient la table de données chargées récement.
        /// </summary>
        public DataTable Table
        {
            get { return table; }
        }

        /// <summary>
        /// Initialise une nouvelle instance de la couche d'accés aux données.
        /// </summary>
        public DataAccess()
        {
            connection = new SqlConnection(DataDescription.ConnectionString);
            command = new SqlCommand("", connection);
            dataAdapter = new SqlDataAdapter(command);
            commandBuilder = new SqlCommandBuilder(dataAdapter);
            table = new DataTable();
        }

        /// <summary>
        /// Charge les données d'une table depuis la base de données dans une table de données.
        /// </summary>
        /// <param name="commandText"></param>
        /// <returns>Table de données chargée</returns>
        public DataTable Load(string commandText)
        {
            command.CommandText = commandText;
            dataAdapter.Fill(table);
            return table;
        }

        /// <summary>
        /// Mis à jour les données d'une table de la base de données depuis une table de données.
        /// </summary>
        /// <returns>Nombre de lignes correctement mises à jour à partir de la table de données</returns>
        public int Save()
        {
            return dataAdapter.Update(table);
        }
    }
}
