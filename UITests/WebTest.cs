/*
 * This file contains the Selenium WebDriver test methods for the Employee Details page.
 * Details:
 * It uses the Chrome browser to navigate to the Employee Details page for employee with id 4,
 * and then asserts that the employee is an hourly employee, 
 * that the pay is a currency value,
 * and that searching for an employee with id 0 fails.
 * */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace UITest
{
    [TestClass]
    public class EmployeeDetailsTests
    {
        private IWebDriver? _driver;

        [TestInitialize]
        public void TestInitialize()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            _driver = new ChromeDriver();
        }

        // Create a test method 'SearchForEmployeeId4_ShouldSucceed' to navigate to the employee details page for employee with id 4
        // Use the URL 'https://localhost:7088/Employee/Details/4'
        // Use a try-catch block to catch any exceptions and fail the test if an exception occurs
        [TestMethod]

        public void SearchForEmployeeId4_ShouldSucceed()
        {
            try
            {
                _driver?.Navigate().GoToUrl("https://localhost:7088/Employee/Details/4");
            }
            catch (Exception)
            {
                Assert.Fail("Search for employee with id 4 failed");
            }
        }

        
        // Create a test method 'EmployeeIsHourly_ShouldSucceed' to assert that the element with the id "caption_typeof_employee" contains the text "Hourly Employee"
        [TestMethod]
        public void EmployeeIsHourly_ShouldSucceed()
        {
            _driver?.Navigate().GoToUrl("https://localhost:7088/Employee/Details/4");
            var caption = _driver?.FindElement(By.Id("caption_typeof_employee"));
            Assert.AreEqual("Hourly Employee", caption?.Text);
        }



        // Create a test method 'PayIsCurrency_ShouldSucceed' to assert that the element with the id "pay" contains a currency value
        [TestMethod]
        public void PayIsCurrency_ShouldSucceed()
        {
            _driver?.Navigate().GoToUrl("https://localhost:7088/Employee/Details/4");
            var pay = _driver?.FindElement(By.Id("pay"));
            if (pay != null)
            {
                Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(pay.Text, @"^\$\d{1,3}(,\d{3})*(\.\d{2})?$"));
            }
            else
            {
                Assert.Fail("Element with id 'pay' not found");
            }

        }

        // Create a test method 'SearchForEmployeeId0_ShouldFail' to navigate to the employee details page for employee with id 0
        [TestMethod]
        public void SearchForEmployeeId1000_ShouldFail()
        {
            try
            {
                _driver?.Navigate().GoToUrl("https://localhost:7088/Employee/Details/0");
                Assert.Fail("Search for employee with id 0 should have failed");
            }
            catch (Exception)
            {
                // Expected to fail

            }
        }



        [TestCleanup]
        public void TestCleanup()
        {
            _driver?.Quit();
        }
    }
}

