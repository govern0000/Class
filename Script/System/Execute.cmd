@echo off

set InfraFold=C:\Users\aaabb\Package\Class\Out\Class\Infra

pushd Out\Class\Module
set "PATH=%InfraFold%;%PATH%" & set "QT_PLUGIN_PATH=%InfraFold%" & ..\Library\System-SystemDemo-96207.08.47.exe "-"
echo Status: %errorlevel%
popd