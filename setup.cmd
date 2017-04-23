set PATH=%PATH%;c:\Windows\Microsoft.NET\Framework\v3.5\
call setupDb.cmd
msbuild /P:Configuration=Release && call Retail.Main\bin\Release\Retail.Main.exe
