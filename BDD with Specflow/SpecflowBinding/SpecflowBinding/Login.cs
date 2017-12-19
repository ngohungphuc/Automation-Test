using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowBinding
{
    [Binding]
    public sealed class Login
    {
        [Given(@"I have opened the application")]
        public void GivenIHaveOpenedTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I login to application")]
        //restrict in the specific feature
        [Scope(Feature ="User_Login")]
        public void GivenILoginToApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see user portal")]
        public void ThenISeeUserPortal()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I see customer portal")]
        public void ThenISeeCustomerPortal()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
