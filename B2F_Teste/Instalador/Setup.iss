#define MyAppName "B2F_Teste"
#define MyAppVersion "1.0.0.0"
#define MyAppPublisher "B2F_Teste"
#define MyAppURL ""
#define MyServiceName "B2F_Teste"  
#define MyServiceDisplayName "b2finance [B2F_Teste]"

[Setup]
AppId={{1D8022AE-8F9E-4BA0-AEB1-AB34700F6119}
AppName={#MyServiceDisplayName}
AppVersion={#MyAppVersion}
AppVerName={#MyServiceDisplayName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\Serviço\{#MyServiceDisplayName}
DefaultGroupName={#MyServiceDisplayName}
DisableProgramGroupPage=yes
OutputBaseFilename={#MyAppName} v{#MyAppVersion}
Compression=lzma
SolidCompression=yes

[Languages]
Name: en; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

[Files]
Source: "..\bin\Debug\net8.0\*.*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

[Run]
Filename: {sys}\sc.exe; Parameters: "create ""{#MyServiceName}"" displayname= ""{#MyServiceDisplayName}"" start= auto binPath= ""{app}\B2F_Teste.exe"""; Flags: runhidden

[UninstallRun]
Filename: {sys}\sc.exe; Parameters: "stop ""{#MyServiceName}"""; Flags: runhidden
Filename: {sys}\sc.exe; Parameters: "delete ""{#MyServiceName}"""; Flags: runhidden
