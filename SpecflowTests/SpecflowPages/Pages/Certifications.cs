using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Pages
{
    public class Certifications
    {
        public static void CertificationsTab()
        {
            //Wait
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Click on Certifications Tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")).Click();

        }

        public static void Add()
        {
            //Click on Add new Button 
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")).Click();

            //Wait 
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Add Certificate or Award
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input")).SendKeys("Gold Medal");

            //Add Certified From
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input")).SendKeys("Olympic");

            //Click on Year
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select")).Click();

            //Choose Year
            IWebElement ChooseYear = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option"))[6];
            ChooseYear.Click();

            //Click on Add Button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")).Click();

        }

        public static void AddValidate()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                CommonMethods.test = CommonMethods.extent.StartTest("Add a Certification");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "Gold Medal";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Certification Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationAdded");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        public static void Edit()
        {
            try
            {
                for (var i = 1; i <= 10; i++)
                {

                    var textcode = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(textcode);
                    if (textcode == "Gold Medal")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);

                        //Click the edit button 
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[1]/i")).Click();

                        //Clear the text and then write new text under Certifcation/Award
                        IWebElement CertAward = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[1]/input"));
                        CertAward.Clear();
                        CertAward.SendKeys("Silver Medal");

                        //Clear the text and then write new text under Certified From
                        IWebElement CertFrom = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[2]/input"));
                        CertFrom.Clear();
                        CertFrom.SendKeys("Disney Land");

                        //Click on the dropdown menu
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[3]/select")).Click();

                        //Select the year
                        IWebElement LangLevel = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/div/div[3]/select/option"))[2];
                        LangLevel.Click();

                        //Click update
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();

                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }

        public static void EditValidate()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                CommonMethods.test = CommonMethods.extent.StartTest("Edit Certification");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "Silver Medal";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited a Certifaction Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertifactionEdited");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }

        public static void Delete()
        {
            try
            {
                for (var i = 1; i <= 10; i++)
                {

                    var textcode = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(textcode);
                    if (textcode == "Silver Medal")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //Click the Delete button
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[" + i + "]/tr/td[4]/span[2]/i")).Click();

                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }

        public static void DeleteValidate()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Certification");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "Silver Medal";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[1]/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (!(ExpectedValue == ActualValue))
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Certification Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "CertificationsDelete");
                }

                else
                    CommonMethods.test.Log(LogStatus.Fail, "Test Failed");

            }
            catch (Exception e)
            {
                CommonMethods.test.Log(LogStatus.Fail, "Test Failed", e.Message);
            }
        }
    }
}
