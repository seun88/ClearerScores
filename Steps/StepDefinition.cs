using ClearerScores.Helper;
using ClearerScores.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ClearerScores.Steps
{
    [Binding]
    public sealed class StepDefinition 
    {
        private ClearScoreHomePage hp;


        [Given(@"i navigate to web")]
        public void GivenINavigateToWeb()
        {
            hp = BaseClass.AndNavigateClearScoreHomePage();
        }

        [When(@"i input email")]
        public void WhenIInputEmail()
        {
            hp.AndinputE();
        }

    }
}
