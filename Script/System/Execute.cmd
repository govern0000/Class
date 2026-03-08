@echo off

set InfraLibraryFold=C:\Users\aaabb\Package\Class\Out\Class\Infra

pushd Out\Class\Module
set "PATH=%InfraLibraryFold%;%PATH%" && ..\Library\Alan-SystemDemo-96207.08.47.exe "-" "-"
echo Status: %errorlevel%
popd