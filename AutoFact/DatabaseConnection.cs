using MySqlConnector;
using System.IO;
using System.Windows.Forms;

public class DatabaseConnection
{
    private static DatabaseConnection instance;
    private MySqlConnection connection;
    private static readonly string iniPath = "config.ini";

    // Constructeur privé
    private DatabaseConnection()
    {
        try
        {
            var config = LoadDatabaseConfig();

            string connectionString = $"Server={config.Server};Database={config.Database};User ID={config.User};Password={config.Password};";

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

    private (string Server, string Database, string User, string Password) LoadDatabaseConfig()
    {
        if (!File.Exists(iniPath))
        {
            throw new FileNotFoundException("Fichier de configuration config.ini non trouvé.");
        }

        string server = "", database = "", user = "", password = "";
        foreach (var line in File.ReadAllLines(iniPath))
        {
            if (line.StartsWith("Server=")) server = line.Substring("Server=".Length).Trim();
            else if (line.StartsWith("Database=")) database = line.Substring("Database=".Length).Trim();
            else if (line.StartsWith("User=")) user = line.Substring("User=".Length).Trim();
            else if (line.StartsWith("Password=")) password = line.Substring("Password=".Length).Trim();
        }

        if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database) || string.IsNullOrEmpty(user))
        {
            throw new InvalidDataException("Informations de connexion incomplètes dans config.ini.");
        }

        return (server, database, user, password);
    }
}
