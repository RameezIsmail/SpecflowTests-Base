using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.Education
{
    [Binding]
    public class EducationFeatureSteps
    {

        #region Add

        [Given(@"I clicked on the education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            SpecflowPages.Pages.Education.EducationTab();
        }
        
        [When(@"I add new education details")]
        public void WhenIAddNewEducationDetails()
        {
            SpecflowPages.Pages.Education.Add();
        }

        [Then(@"that education details should be displayed on my listings")]
        public void ThenThatEducationDetailsShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Education.AddValidate();
        }

        #endregion


        #region Edit

        [Given(@"I click on the education tab under Profile Page")]
        public void GivenIClickOnTheEducationTabUnderProfilePage()
        {
            SpecflowPages.Pages.Education.EducationTab();
        }

        [When(@"I edit the education details")]
        public void WhenIEditTheEducationDetails()
        {
            SpecflowPages.Pages.Education.Edit();
        }

        [Then(@"That education that been edited should be displayed on my listings")]
        public void ThenThatEducationThatBeenEditedShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Education.EditValidate();
        }

        #endregion


        #region Delete

        [Given(@"I clicked on the education tab under Profile Page")]
        public void GivenIClickedOnEducationTabUnderProfilePage()
        {
            SpecflowPages.Pages.Education.EducationTab();
        }

        [When(@"I click that delete button")]
        public void WhenIClickThatDeleteButton()
        {
            SpecflowPages.Pages.Education.Delete();
        }
                     
        [Then(@"the education that got clicked should not be displayed in my listings")]
        public void ThenTheEducationThatGotClickedShouldNotBeDisplayedInMyListings()
        {
            SpecflowPages.Pages.Education.DeleteValidate();
        }

        #endregion

    }
}
