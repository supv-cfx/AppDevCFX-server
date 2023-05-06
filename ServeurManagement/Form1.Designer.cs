using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Text.Json;
using System.Xml.Linq;

namespace ServeurManagement
{
    public partial class Form1 : Form
    {
        private string applicationPath = @"C:\MonApplication\MonApplication.exe";
        private string filePath = @"C:\Users\cormi\Documents\supv_template_esx";

        private const string SettingsFileName = "settings.json";

        private readonly string _settingsFilePath;

        private class AppSettings
        {
            public string ApplicationPath { get; set; }
            public string FilePath { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            // Récupérer le chemin d'accès au fichier de configuration
            _settingsFilePath = Path.Combine(Application.StartupPath, "settings.json");
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Vérifier si le fichier de configuration existe
            if (File.Exists(_settingsFilePath))
            {
                // Charger les paramètres à partir du fichier de configuration
                string json = File.ReadAllText(_settingsFilePath);
                dynamic settings = JsonConvert.DeserializeObject(json);

                // Mettre à jour les valeurs des variables de chemin d'accès
                applicationPath = settings.applicationPath;
                filePath = settings.filePath;
            }
        }

        private void SaveSettings()
        {
            // Créer un objet JSON contenant les paramètres de configuration
            dynamic settings = new Newtonsoft.Json.Linq.JObject();
            settings.applicationPath = applicationPath;
            settings.filePath = filePath;

            // Écrire les paramètres dans le fichier de configuration
            File.WriteAllText(_settingsFilePath, settings.ToString());
        }

        private void btnLancerServeur_Click(object sender, EventArgs e)
        {
            // Lancer l'application
            Process.Start(filePath + "\\start.bat");
        }

        private void btnSupprimerCache_Click(object sender, EventArgs e)
        {
            string directoryPath = filePath + "\\cache";

            // Vérifier si le dossier de cache existe
            if (Directory.Exists(directoryPath))
            {
                try
                {
                    // Récupérer les autorisations de sécurité actuelles du dossier
                    DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
                    DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

                    directorySecurity.AddAccessRule(new FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Allow));
                    directoryInfo.SetAccessControl(directorySecurity);

                    Directory.Delete(directoryPath, true);
                }
                catch (Exception ex)
                {
                    // Gérer l'exception
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le dossier de cache n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLancerFivem_Click(object sender, EventArgs e)
        {
            // Définir le chemin d'accès à l'application Fivem
            string fivemPath = @"C:\Users\cormi\AppData\Local\FiveM\FiveM.exe";

            // Lancer Fivem avec la console visible
            Process fivemProcess = new Process();
            fivemProcess.StartInfo.FileName = fivemPath;
            fivemProcess.StartInfo.Arguments = "--console";
            fivemProcess.Start();
        }
    }
}
