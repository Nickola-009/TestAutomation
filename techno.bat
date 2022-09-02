set ProjectPath=C:\Users\Nikhill\eclipse-workspace\TestAutomation
echo %ProjectPath%
set classpath=C:\Users\Nikhill\eclipse-workspace\TestAutomation\.classpath
echo %classpath%
java org.testng.TestNG testng.xml
pause