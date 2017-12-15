using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowIntro.StepDefinations
{
    [Binding]
    class SampleFeatureSteps
    {
        public readonly EmployeeDetails _employee;

        public SampleFeatureSteps(EmployeeDetails employee)
        {
            _employee = employee;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Press Add button");
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 120)
                Console.WriteLine("Pass");
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
            ////var details = table.CreateSet<EmployeeDetails>();
            //var details = table.CreateDynamicSet();
            //foreach (var detail in details)
            //{
            //    Console.WriteLine(detail.Name);
            //    Console.WriteLine(detail.Email);
            //    Console.WriteLine(detail.Phone);
            //    Console.WriteLine(detail.Age);
            //}

            var data = table.CreateDynamicSet();
            foreach (var item in data)
            {
                _employee.Name = item.Name;
                _employee.Email = item.Email;
                _employee.Phone = item.Phone;
                _employee.Age = item.Age;
            }
        }

        [When(@"I fill all the mandatory details in form (.*), (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormTonyAnd(string name, string age, string phone)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(phone);
            ScenarioContext.Current["InfoForNextStep"] = "Step 1 pass";

            List<EmployeeDetails> list = new List<EmployeeDetails>
            {
                new EmployeeDetails()
                {
                    Name = "tony",
                    Age = "23",
                    Email ="123123",
                     Phone="123"
                }
            };

            //save the value in ScenarioContext
            ScenarioContext.Current.Add("empDetails", list);

            var details = ScenarioContext.Current.Get<IEnumerable<EmployeeDetails>>("empDetails");

            foreach (var detail in details)
            {
                Console.WriteLine(detail.Name);
                Console.WriteLine(detail.Email);
                Console.WriteLine(detail.Phone);
                Console.WriteLine(detail.Age);
            }
        }
    }
}
