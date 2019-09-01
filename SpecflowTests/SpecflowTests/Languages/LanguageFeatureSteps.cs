using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.Languages
{
    [Binding]
    public class LanguageFeatureSteps :Utils.Start
    {

        #region Add

        [Given(@"I clicked on the Language tab under Profile page")]
        public void GivenIClickedOnTheLanguageTabUnderProfilePage()
        {
            SpecflowPages.Pages.Languages.LanguageTab();
        }

        [When(@"I add a new language")]
        public void WhenIAddANewLanguage()
        {
            SpecflowPages.Pages.Languages.Add();
        }

        [Then(@"that language should be displayed on my listings")]
        public void ThenThatLanguageShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Languages.AddValidate();
        }

        #endregion


        #region Edit

        [Given(@"I click on the language tab under Profile Page")]
        public void GivenIClickOnTheLanguageTabUnderProfilePage()
        {
            SpecflowPages.Pages.Languages.LanguageTab();
        }

        [When(@"I edit the language details")]
        public void WhenIEditTheLanguageDetails()
        {
            SpecflowPages.Pages.Languages.Edit();
        }

        [Then(@"that language that been edited should be displayed on my listings")]
        public void ThenThatLanguageThatBeenEditedShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Languages.EditValidate();
        }

        #endregion


        #region Delete

        [Given(@"I clicked on the Languages tab under Profile Page")]
        public void GivenIClickedOnTheLanguagesTabUnderProfilePage()
        {
            SpecflowPages.Pages.Languages.LanguageTab();
        }
        
        [When(@"I click on the delete button")]
        public void WhenIClickOnTheDeleteButton()
        {
            SpecflowPages.Pages.Languages.Delete();
        }
               
        [Then(@"the language that got clicked should not be displayed on my listings")]
        public void ThenTheLanguageThatGotClickedShouldNotBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Languages.DeleteValidate();
        }

        #endregion
    }
}
