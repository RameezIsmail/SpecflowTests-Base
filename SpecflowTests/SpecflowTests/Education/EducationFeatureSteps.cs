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
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I add new education details")]
        public void WhenIAddNewEducationDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"that education details should be displayed on my listings")]
        public void ThenThatEducationDetailsShouldBeDisplayedOnMyListings()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion


        #region Edit

        [Given(@"I click on the education tab under Profile Page")]
        public void GivenIClickOnTheEducationTabUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit the education details")]
        public void WhenIEditTheEducationDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"That education that been edited should be displayed on my listings")]
        public void ThenThatEducationThatBeenEditedShouldBeDisplayedOnMyListings()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion


        #region Delete

        [Given(@"I clicked on the education tab under Profile Page")]
        public void GivenIClickedOnEducationTabUnderProfilePage()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click that delete button")]
        public void WhenIClickThatDeleteButton()
        {
            ScenarioContext.Current.Pending();
        }
                     
        [Then(@"the education that got clicked should not be displayed in my listings")]
        public void ThenTheEducationThatGotClickedShouldNotBeDisplayedInMyListings()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion

    }
}
