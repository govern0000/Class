@echo off

pushd Out\Class\Module
..\Library\Alan-SystemDemo-96207.08.47.exe "-" "-"
echo Status: %errorlevel%
popd