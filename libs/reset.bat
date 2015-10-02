del /s /F /Q  %USERPROFILE%\Desktop\MakerDen\*.*
rd /s /q %USERPROFILE%\Desktop\MakerDen
for /f %%f in ('dir /ad /b %USERPROFILE%\Desktop\MakerDen\') do rd /s /q %USERPROFILE%\Desktop\MakerDen\%%f
git clone https://github.com/tanchunsiong/MakerDenWindows.git  %USERPROFILE%\Desktop\MakerDen
