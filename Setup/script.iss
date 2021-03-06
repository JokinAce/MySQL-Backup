; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "MySQL Backup"
#define MyAppVersion "2.0"
#define MyAppPublisher "JokinAce @ AlphaWolf 2021"
#define MyAppExeName "MySQL Backup.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{15F679D8-A10C-46ED-9307-3C16E14CCDB8}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=F:\Programming\C#\MySQL Backup\Setup
OutputBaseFilename=BackupSetup
SetupIconFile=F:\Programming\C#\MySQL Backup\MySQL Backup\icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\BouncyCastle.Crypto.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\K4os.Compression.LZ4.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\K4os.Compression.LZ4.Streams.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\K4os.Hash.xxHash.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\MySQL Backup.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\MySQL Backup.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\MySQL Backup.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\MySQL Backup.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\MySqlBackup.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\Renci.SshNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\SshNet.Security.Cryptography.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\Ubiety.Dns.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\bin\Release\net5.0-windows\publish\Zstandard.Net.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\Programming\C#\MySQL Backup\MySQL Backup\config.json"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

