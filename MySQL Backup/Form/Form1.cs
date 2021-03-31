using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQL_Backup {

    public partial class MainForm : Form {
        private readonly ConfigSystem Config = new();
        private bool ShouldBackup;

        public MainForm() {
            InitializeComponent();
            Log("Program gestartet");

            if (File.Exists("config.json")) {
                Config.LoadConfig().ConfigureAwait(false).GetAwaiter().GetResult();
                IPTextBox.Text = Config.IP;
                PortTextBox.Text = Config.Port;
                DatabaseTextBox.Text = Config.Database;
                UsernameTextBox.Text = Config.Username;
                PasswortTextBox.Text = Config.Passwort;
                TimerTextBox.Text = Config.Timer.ToString();

                Log("Config geladen");
            }

            if (!Directory.Exists("./backups/")) {
                Directory.CreateDirectory("./backups/");
            }
        }

        private void Backup() {
            _ = Task.Run(() => {
                try {

                    using MySqlConnection conn = new($"Server={Config.IP}; Port={Config.Port}; database={Config.Database}; UID={Config.Username}; password={Config.Passwort};charset=utf8;convertzerodatetime=true;");
                    using MySqlCommand cmd = new();
                    using MySqlBackup mb = new(cmd); cmd.Connection = conn;
                    conn.Open();
                    mb.ExportToFile($"./backups/db-{DateTime.Now:d/M/yyyy}-{DateTime.Now:HH,mm}-{Config.Database}.sql");
                    conn.Close();
                    Log("Backup erfolgreich.");
                } catch (Exception Error) {
                    Log($"Backup fehlgeschlagen. {Error}");
                }
            });
        }

        private void BackupWorker_DoWork(object sender, DoWorkEventArgs e) {
            while (ShouldBackup) {
                Backup();
                Thread.Sleep((int)TimeSpan.FromMinutes(Config.Timer).TotalMilliseconds);
            }
        }

        private void Log(string Message) => ConsoleTextBox.AppendText($"[{DateTime.Now}] " + Message + "\n");

        private void ForceBackupButton_Click(object sender, EventArgs e) => Backup();

        private async void SaveConfigButton_ClickAsync(object sender, EventArgs e) {
            Config.IP = IPTextBox.Text;
            Config.Port = PortTextBox.Text;
            Config.Database = DatabaseTextBox.Text;
            Config.Username = UsernameTextBox.Text;
            Config.Passwort = PasswortTextBox.Text;
            Config.Timer = Convert.ToDouble(TimerTextBox.Text);

            await Config.SaveConfig().ConfigureAwait(false);
        }

        private async void LoadConfigButton_ClickAsync(object sender, EventArgs e) {
            if (!File.Exists("config.json")) {
                Log("Konfigurations konnte nicht gefunden werden. (config.json)");
                return;
            }

            await Config.LoadConfig().ConfigureAwait(false);

            IPTextBox.Text = Config.IP;
            PortTextBox.Text = Config.Port;
            DatabaseTextBox.Text = Config.Database;
            UsernameTextBox.Text = Config.Username;
            PasswortTextBox.Text = Config.Passwort;
            TimerTextBox.Text = Config.Timer.ToString();
        }

        private void StartButton_Click(object sender, EventArgs e) {
            ShouldBackup = true;
            BackupLabel.Text = "Backup: An";
            BackupWorker.RunWorkerAsync();
        }

        private void StopButton_Click(object sender, EventArgs e) {
            ShouldBackup = false;
            BackupLabel.Text = "Backup: Aus";
            BackupWorker.CancelAsync();
        }

        private void RestoreButton_Click(object sender, EventArgs e) {
            try {
                FileDialog.ShowDialog();

                using MySqlConnection conn = new($"Server={Config.IP}; Port={Config.Port}; database={Config.Database}; UID={Config.Username}; password={Config.Passwort};charset=utf8;convertzerodatetime=true;");
                using MySqlCommand cmd = new();
                using MySqlBackup mb = new(cmd); cmd.Connection = conn;
                conn.Open();

                if (FileDialog.CheckFileExists && FileDialog.CheckPathExists) {
                    mb.ImportFromStream(FileDialog.OpenFile());
                    Log("Datei gefunden und importiert.");
                } else {
                    Log("Datei nicht gefunden.");
                }

                conn.Close();
            } catch (Exception Error) {
                Log($"Backup fehlgeschlagen. {Error}");
            }
        }

        private void MinimizedBox_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
            MinimizedBox.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
                MinimizedBox.Visible = true;
                MinimizedBox.ShowBalloonTip(2000);
            }
        }
    }
}