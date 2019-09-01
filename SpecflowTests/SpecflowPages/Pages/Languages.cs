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
    
    public class Languages
    {
        
        public static void LanguageTab()
        {
            //Wait
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // Click on Language tab
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")).Click();

        }

        public static void Add()
        {
            //Click on Add New button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")).Click();

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Add Language
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")).SendKeys("English");

            //Click on Language Level
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();

            //Choose the language level
            IWebElement Lang = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option"))[2];
            Lang.Click();

            //Click on Add button
            Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")).Click();

        }

        public static void AddValidate()
        {
            try
            {
                //Start the Reports
                CommonMethods.ExtentReports();
                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                CommonMethods.test = CommonMethods.extent.StartTest("Add a Language");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "English";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageAdded");
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
                    var textcode = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(textcode);
                    if (textcode == "English")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //Click the edit button
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[1]/i")).Click();

                        //Clear the text and then write Konglish
                        IWebElement LangText = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[1]/input"));
                        LangText.Clear();
                        LangText.SendKeys("Konglish");

                        //Click on the dropdown menu
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select")).Click();

                        //Select the level
                        IWebElement LangLevel = Driver.driver.FindElements(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/div[2]/select/option"))[4];
                        LangLevel.Click();

                        //Click update
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td/div/span/input[1]")).Click();

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

                CommonMethods.test = CommonMethods.extent.StartTest("Edit a Language");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "Konglish";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (ExpectedValue == ActualValue)
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Edited a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageEdited");
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
                    var textcode = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[1]")).Text;
                    Console.WriteLine(textcode);
                    if (textcode == "Konglish")
                    {
                        //Wait
                        Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                        //Click the Delete button
                        Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[" + i + "]/tr/td[3]/span[2]/i")).Click();

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

                CommonMethods.test = CommonMethods.extent.StartTest("Delete a Language");

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                string ExpectedValue = "Konglish";
                string ActualValue = Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;

                Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                if (!(ExpectedValue == ActualValue))
                {
                    CommonMethods.test.Log(LogStatus.Pass, "Test Passed, Deleted a Language Successfully");
                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "LanguageDelete");
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
