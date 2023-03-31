@echo off

REM Delete BIN and OBJ folders from current directory and all subdirectories
for /d /r %%d in (*bin *obj) do (
    echo Deleting "%%d"
    rmdir "%%d" /s /q
)

pause
