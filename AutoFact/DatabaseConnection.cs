using MySqlConnector;
using System;
using System.Windows.Forms;

public class DatabaseConnection
{
    private static DatabaseConnection instance;
    private MySqlConnection connection;

    private readonly string connectionString = "Server=172.16.119.9;Database=db_AutoFact;User ID=admin;Password=admin;";

    // Constructeur privé
    private DatabaseConnection()
    {
        try
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connexion à la base de données réussie !");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erreur de connexion à la base de données : {ex.Message}", "Erreur");
        }
    }

    // Méthode statique pour récupérer l’instance unique
    public static DatabaseConnection GetInstance()
    {
        if (instance == null)
        {
            instance = new DatabaseConnection();
        }
        return instance;
    }

    // Accès à la connexion
    public MySqlConnection GetConnection()
    {
        return connection;
    }

    // Méthode pour fermer proprement la connexion
    public void CloseConnection()
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
            Console.WriteLine("Connexion fermée.");
        }
    }
}