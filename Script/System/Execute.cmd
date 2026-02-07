@echo off

set InfraFold=C:\Users\aaabb\Package\Class\Out\Class\Infra

pushd Out\Class\Module
set "QT_PLUGIN_PATH=%InfraFold%" & ..\Library\Alan-SystemDemo-96207.08.47.exe "-"
echo Status: %errorlevel%
popd