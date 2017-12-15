using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowIntro.StepDefinations
{
    [Binding]
    public class ExtendedStep
    {
        public readonly EmployeeDetails _employee;

        public ExtendedStep(EmployeeDetails employee)
        {
            _employee = employee;
        }

        [Then(@"I should get the same value from Extended steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
           Console.WriteLine(_employee.Age);
        }

    }
}
