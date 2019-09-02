using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.Certification
{
    [Binding]
    public class CertificationFeatureSteps
    {
        #region Add

        [Given(@"I clicked on the Certifications tab under Profile Page")]
        public void GivenIClickedOnTheCertificationsTabUnderProfilePage()
        {
            SpecflowPages.Pages.Certifications.CertificationsTab();
        }

        [When(@"I add new certification details")]
        public void WhenIAddNewCertificationDetails()
        {
            SpecflowPages.Pages.Certifications.Add();
        }

        [Then(@"that certification details should be displayed on my listings")]
        public void ThenThatCertificationDetailsShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Certifications.AddValidate();
        }

        #endregion


        #region Edit

        [Given(@"I clicked on the certification tab under Profile Page")]
        public void GivenIClickedOnTheCertificationTabUnderProfilePage()
        {
            SpecflowPages.Pages.Certifications.CertificationsTab();
        }

        [When(@"I edit the certification details")]
        public void WhenIEditTheCertificationDetails()
        {
            SpecflowPages.Pages.Certifications.Edit();
        }

        [Then(@"That certification that been edited should be displayed on my listings")]
        public void ThenThatCertificationThatBeenEditedShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Certifications.EditValidate();
        }

        #endregion


        #region Delete

        [Given(@"I clicked on the certifications tab under Profile Page")]
        public void GivenIClickedOnCertificationsTabUnderProfilePage()
        {
            SpecflowPages.Pages.Certifications.CertificationsTab();
        }
                       
        [When(@"I click the delete button")]
        public void WhenIClickTheDeleteButton()
        {
            SpecflowPages.Pages.Certifications.Delete();
        }
         
        [Then(@"the certification that got clicked should not be displayed on my listings")]
        public void ThenTheCertificationThatGotClickedShouldNotBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Certifications.DeleteValidate();
        }

        #endregion
    }
}
