using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace MySQL_Backup {

    public class ConfigSystem {
        public string IP { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Passwort { get; set; }
        public double Timer { get; set; }

        public async Task SaveConfig() {
            await File.WriteAllTextAsync("config.json", JsonSerializer.Serialize(this)).ConfigureAwait(false);
        }

        public async Task LoadConfig() {
            using var stream = File.OpenRead("config.json");
            var DConfig = await JsonSerializer.DeserializeAsync<ConfigSystem>(stream).ConfigureAwait(false);

            IP = DConfig.IP;
            Port = DConfig.Port;
            Database = DConfig.Database;
            Username = DConfig.Username;
            Passwort = DConfig.Passwort;
            Timer = DConfig.Timer;
        }
    }
}