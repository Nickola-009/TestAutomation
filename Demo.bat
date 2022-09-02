set ProjectPath=C:\Users\Nikhill\eclipse-workspace\TestAutomation
echo %ProjectPath%
set classpath=C:\Users\Nikhill\.p2\pool\plugins
echo %classpath%
java org.testng.TestNG C:\Users\Nikhill\eclipse-workspace\TestAutomation\testng.xml
pause