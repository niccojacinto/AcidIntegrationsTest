@echo off
start http://localhost:27017

cd Part C - Unity
cd build
start AcidDBTest.exe

cd ..
cd Part A
node app.js
cmd /k