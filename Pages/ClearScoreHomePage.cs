using ClearerScores.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearerScores.Pages
{
    public class ClearScoreHomePage : BaseClass 
    {
        IWebElement email = driver.FindElement(By.Id("email"));


        public void AndinputE()
        {
            email.SendKeys("light@gmail.com");
        }
    }
}
