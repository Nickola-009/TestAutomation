using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomation
{
    public class activity
    {
        public static WebDriverWait CreatWait(TimeSpan  timetowait)
        {
            WebDriverWait wait = new WebDriverWait(Global.chrome_driver, timetowait);
            return wait;
        }
    }
}
