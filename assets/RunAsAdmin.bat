@echo off
cd /d "%~dp0"
powershell -Command "Start-Process '%~dp0L2Setup.exe' -Verb RunAs"

