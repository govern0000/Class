@echo off

set ClassFold=C:\Users\aaabb\Package\Class\Out\Class

pushd Out\Class\Module
set "PATH=%ClassFold%;%PATH%" & set "QT_PLUGIN_PATH=%ClassFold%" & ..\Library\SystemDemo-96207.08.47.exe
echo Status: %errorlevel%
popd