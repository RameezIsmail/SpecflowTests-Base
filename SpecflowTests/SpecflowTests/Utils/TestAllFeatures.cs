using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.Utils
{
    
    [Binding]
    public class TestAllFeatures :Driver
    {
        
        [SetUp]
        public void SetUp()
        {
            //Launch the browser
            Initialize();
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //Call the Login Class            
            SpecflowPages.Utils.LoginPage.LoginStep();
        }

        [Test, Order(1)]
        public void AddLanguages()
        {
            SpecflowPages.Pages.Languages.LanguageTab();
            SpecflowPages.Pages.Languages.Add();
            SpecflowPages.Pages.Languages.AddValidate();
            
        }

        [Test, Order(2)]
        public void EditLanguages()
        {
            SpecflowPages.Pages.Languages.LanguageTab();
            SpecflowPages.Pages.Languages.Edit();
            SpecflowPages.Pages.Languages.EditValidate();
        }

        [Test, Order(3)]
        public void DeleteLanguages()
        {
            SpecflowPages.Pages.Languages.LanguageTab();
            SpecflowPages.Pages.Languages.Delete();
            SpecflowPages.Pages.Languages.DeleteValidate();
        }

        [Test, Order(4)]
        public void AddSkills()
        {
            SpecflowPages.Pages.Skills.SkillsTab();
            SpecflowPages.Pages.Skills.Add();
            SpecflowPages.Pages.Skills.AddValidate();
            
        }

        [Test, Order(5)]
        public void EditSkills()
        {
            SpecflowPages.Pages.Skills.SkillsTab();
            SpecflowPages.Pages.Skills.Edit();
            SpecflowPages.Pages.Skills.EditValidate();
        }

        [Test, Order(6)]
        public void DeleteSkills()
        {
            SpecflowPages.Pages.Skills.SkillsTab();
            SpecflowPages.Pages.Skills.Delete();
            SpecflowPages.Pages.Skills.DeleteValidate();
        }

        [Test, Order(7)]
        public void AddEducation()
        {
            SpecflowPages.Pages.Education.EducationTab();
            SpecflowPages.Pages.Education.Add();
            SpecflowPages.Pages.Education.AddValidate();
        }

        [Test, Order(8)]
        public void EditEducation()
        {
            SpecflowPages.Pages.Education.EducationTab();
            SpecflowPages.Pages.Education.Edit();
            SpecflowPages.Pages.Education.EditValidate();
        }

        [Test, Order(9)]
        public void DeleteEducation()
        {
            SpecflowPages.Pages.Education.EducationTab();
            SpecflowPages.Pages.Education.Delete();
            SpecflowPages.Pages.Education.DeleteValidate();
        }

        [Test, Order(10)]
        public void AddCertification()
        {
            SpecflowPages.Pages.Certifications.CertificationsTab();
            SpecflowPages.Pages.Certifications.Add();
            SpecflowPages.Pages.Certifications.AddValidate();
        }


        [Test, Order(11)]
        public void EditCertification()
        {
            SpecflowPages.Pages.Certifications.CertificationsTab();
            SpecflowPages.Pages.Certifications.Edit();
            SpecflowPages.Pages.Certifications.EditValidate();
        }

        [Test, Order(12)]
        public void DeleteCertification()
        {
            SpecflowPages.Pages.Certifications.CertificationsTab();
            SpecflowPages.Pages.Certifications.Delete();
            SpecflowPages.Pages.Certifications.DeleteValidate();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            CommonMethods.extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            CommonMethods.extent.Flush();

            //Close the browser
            Close();
        }
    }
}
