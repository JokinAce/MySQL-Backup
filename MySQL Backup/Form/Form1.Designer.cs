
using System.ComponentModel;

namespace MySQL_Backup {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PasswortLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.TimerLable = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PortTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DatabaseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UsernameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.PasswortTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TimerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.LoadConfigButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.ForceBackupButton = new System.Windows.Forms.Button();
            this.BackupLabel = new System.Windows.Forms.Label();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.MinimizedBox = new System.Windows.Forms.NotifyIcon(this.components);
            this.BackupWorker = new System.ComponentModel.BackgroundWorker();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ConsoleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ConsoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleTextBox.ForeColor = System.Drawing.Color.Silver;
            this.ConsoleTextBox.Location = new System.Drawing.Point(12, 271);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.ReadOnly = true;
            this.ConsoleTextBox.Size = new System.Drawing.Size(559, 160);
            this.ConsoleTextBox.TabIndex = 0;
            this.ConsoleTextBox.Text = "";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatabaseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.DatabaseLabel.Location = new System.Drawing.Point(10, 81);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(69, 19);
            this.DatabaseLabel.TabIndex = 3;
            this.DatabaseLabel.Text = "Database:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 111);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(74, 19);
            this.UsernameLabel.TabIndex = 4;
            this.UsernameLabel.Text = "Username:";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.PortLabel.Location = new System.Drawing.Point(12, 52);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(37, 19);
            this.PortLabel.TabIndex = 2;
            this.PortLabel.Text = "Port:";
            // 
            // PasswortLabel
            // 
            this.PasswortLabel.AutoSize = true;
            this.PasswortLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.PasswortLabel.Location = new System.Drawing.Point(12, 145);
            this.PasswortLabel.Name = "PasswortLabel";
            this.PasswortLabel.Size = new System.Drawing.Size(67, 19);
            this.PasswortLabel.TabIndex = 5;
            this.PasswortLabel.Text = "Passwort:";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.IPLabel.Location = new System.Drawing.Point(12, 21);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(24, 19);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP:";
            // 
            // TimerLable
            // 
            this.TimerLable.AutoSize = true;
            this.TimerLable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimerLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.TimerLable.Location = new System.Drawing.Point(12, 176);
            this.TimerLable.Name = "TimerLable";
            this.TimerLable.Size = new System.Drawing.Size(110, 19);
            this.TimerLable.TabIndex = 6;
            this.TimerLable.Text = "Timer (Minuten):";
            // 
            // IPTextBox
            // 
            this.IPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.IPTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IPTextBox.ForeColor = System.Drawing.Color.Silver;
            this.IPTextBox.Location = new System.Drawing.Point(128, 24);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(100, 16);
            this.IPTextBox.TabIndex = 7;
            // 
            // PortTextBox
            // 
            this.PortTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PortTextBox.ForeColor = System.Drawing.Color.Silver;
            this.PortTextBox.Location = new System.Drawing.Point(128, 52);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(100, 16);
            this.PortTextBox.TabIndex = 8;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.DatabaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DatabaseTextBox.ForeColor = System.Drawing.Color.Silver;
            this.DatabaseTextBox.Location = new System.Drawing.Point(128, 81);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(100, 16);
            this.DatabaseTextBox.TabIndex = 9;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.UsernameTextBox.Location = new System.Drawing.Point(128, 114);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 16);
            this.UsernameTextBox.TabIndex = 10;
            // 
            // PasswortTextBox
            // 
            this.PasswortTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PasswortTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswortTextBox.ForeColor = System.Drawing.Color.Silver;
            this.PasswortTextBox.Location = new System.Drawing.Point(128, 148);
            this.PasswortTextBox.Name = "PasswortTextBox";
            this.PasswortTextBox.Size = new System.Drawing.Size(100, 16);
            this.PasswortTextBox.TabIndex = 11;
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.TimerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimerTextBox.ForeColor = System.Drawing.Color.Silver;
            this.TimerTextBox.Location = new System.Drawing.Point(128, 179);
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.Size = new System.Drawing.Size(100, 16);
            this.TimerTextBox.TabIndex = 12;
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.SaveConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.SaveConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveConfigButton.Location = new System.Drawing.Point(12, 226);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(75, 23);
            this.SaveConfigButton.TabIndex = 13;
            this.SaveConfigButton.Text = "Save";
            this.SaveConfigButton.UseVisualStyleBackColor = false;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_ClickAsync);
            // 
            // LoadConfigButton
            // 
            this.LoadConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.LoadConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.LoadConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadConfigButton.Location = new System.Drawing.Point(153, 226);
            this.LoadConfigButton.Name = "LoadConfigButton";
            this.LoadConfigButton.Size = new System.Drawing.Size(75, 23);
            this.LoadConfigButton.TabIndex = 14;
            this.LoadConfigButton.Text = "Load";
            this.LoadConfigButton.UseVisualStyleBackColor = false;
            this.LoadConfigButton.Click += new System.EventHandler(this.LoadConfigButton_ClickAsync);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.StopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.StopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopButton.Location = new System.Drawing.Point(476, 45);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 15;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(322, 45);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 16;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ForceBackupButton
            // 
            this.ForceBackupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ForceBackupButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.ForceBackupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceBackupButton.Location = new System.Drawing.Point(476, 107);
            this.ForceBackupButton.Name = "ForceBackupButton";
            this.ForceBackupButton.Size = new System.Drawing.Size(75, 23);
            this.ForceBackupButton.TabIndex = 17;
            this.ForceBackupButton.Text = "FBackup";
            this.ForceBackupButton.UseVisualStyleBackColor = false;
            this.ForceBackupButton.Click += new System.EventHandler(this.ForceBackupButton_Click);
            // 
            // BackupLabel
            // 
            this.BackupLabel.AutoSize = true;
            this.BackupLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(0)))), ((int)(((byte)(14)))));
            this.BackupLabel.Location = new System.Drawing.Point(458, 225);
            this.BackupLabel.Name = "BackupLabel";
            this.BackupLabel.Size = new System.Drawing.Size(93, 21);
            this.BackupLabel.TabIndex = 18;
            this.BackupLabel.Text = "Backup: Aus";
            // 
            // RestoreButton
            // 
            this.RestoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.RestoreButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(28)))), ((int)(((byte)(37)))));
            this.RestoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestoreButton.Location = new System.Drawing.Point(322, 107);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(75, 23);
            this.RestoreButton.TabIndex = 19;
            this.RestoreButton.Text = "Restore";
            this.RestoreButton.UseVisualStyleBackColor = false;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // MinimizedBox
            // 
            this.MinimizedBox.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MinimizedBox.BalloonTipText = "Bin im Hintergrund";
            this.MinimizedBox.BalloonTipTitle = "RED-V.cc";
            this.MinimizedBox.Icon = ((System.Drawing.Icon)(resources.GetObject("MinimizedBox.Icon")));
            this.MinimizedBox.Text = "RED-V.cc";
            this.MinimizedBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MinimizedBox_MouseDoubleClick);
            // 
            // BackupWorker
            // 
            this.BackupWorker.WorkerSupportsCancellation = true;
            this.BackupWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackupWorker_DoWork);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "FileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(583, 443);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.BackupLabel);
            this.Controls.Add(this.ForceBackupButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.LoadConfigButton);
            this.Controls.Add(this.SaveConfigButton);
            this.Controls.Add(this.TimerTextBox);
            this.Controls.Add(this.PasswortTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.TimerLable);
            this.Controls.Add(this.ConsoleTextBox);
            this.Controls.Add(this.PasswortLabel);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.DatabaseLabel);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(599, 482);
            this.MinimumSize = new System.Drawing.Size(599, 482);
            this.Name = "MainForm";
            this.Text = "MySQL Backup | RED-V.cc";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label PasswortLabel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label TimerLable;
        private System.Windows.Forms.MaskedTextBox IPTextBox;
        private System.Windows.Forms.MaskedTextBox PortTextBox;
        private System.Windows.Forms.MaskedTextBox DatabaseTextBox;
        private System.Windows.Forms.MaskedTextBox UsernameTextBox;
        private System.Windows.Forms.MaskedTextBox PasswortTextBox;
        private System.Windows.Forms.MaskedTextBox TimerTextBox;
        private System.Windows.Forms.Button SaveConfigButton;
        private System.Windows.Forms.Button LoadConfigButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ForceBackupButton;
        private System.Windows.Forms.Label BackupLabel;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.NotifyIcon MinimizedBox;
        private BackgroundWorker BackupWorker;
        private System.Windows.Forms.OpenFileDialog FileDialog;
    }
}

