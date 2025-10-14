## --------------------------------------------------------------------
## GITIGNORE PARA MONOREPO .NET (ASP.NET Core + APIs + IdentityServer)
## --------------------------------------------------------------------

# Diretórios de build
[Bb]in/
[Oo]bj/
build/
artifacts/
publish/
tmp/
temp/

# Configurações do Visual Studio
.vs/
.vscode/
*.user
*.suo
*.userosscache
*.sln.docstates

# Arquivos de log
*.log
*.tlog

# Arquivos de backup e temporários
*.bak
*.tmp
*.swp
*.DS_Store
Thumbs.db

# Arquivos de banco locais
*.db
*.db-shm
*.db-wal
*.sqlite
*.ldf
*.mdf

# Arquivos de configuração sensíveis
appsettings.*.Development.json
appsettings.*.Local.json
secrets.json
.env
credentials.json

# NuGet
*.nupkg
*.snupkg
packages/
.nuget/
project.lock.json

# Publicação e cache
wwwroot/lib/
node_modules/
bundle/
dist/
out/





























# Testes e coverage
TestResults/
coverage/
*.coverage
*.coveragexml

# Arquivos de IDE
.idea/
*.userprefs
*.tsscache

# Rider
*.DotSettings.user

# ReSharper
_ReSharper*/
*.DotSettings

# Arquivos gerados automaticamente para execução local
launchSettings.json

# Ignore obj files under solution-level build folders
**/bin/
*























*/obj/
