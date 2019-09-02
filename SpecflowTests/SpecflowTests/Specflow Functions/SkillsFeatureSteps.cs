using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.Skills
{
    [Binding]
    public class SkillsFeatureSteps
    {
        #region Add

        [Given(@"I clicked on the skill tab under Profile page")]
        public void GivenIClickedOnTheSkillTabUnderProfilePage()
        {
            SpecflowPages.Pages.Skills.SkillsTab();
        }

        [When(@"I add a new skill")]
        public void WhenIAddANewSkill()
        {
            SpecflowPages.Pages.Skills.Add();
        }

        [Then(@"that skill should be displayed on my listings")]
        public void ThenThatSkillShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Skills.AddValidate();
        }

        #endregion


        #region Edit

        [Given(@"I click on the skill tab under Profile Page")]
        public void GivenIClickOnTheSkillTabUnderProfilePage()
        {
            SpecflowPages.Pages.Skills.SkillsTab();
        }

        [When(@"I edit the skill details")]
        public void WhenIEditTheSkillDetails()
        {
            SpecflowPages.Pages.Skills.Edit();
        }

        [Then(@"That skill that have been edited should be displayed on my listings")]
        public void ThenThatSkillThatHaveBeenEditedShouldBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Skills.EditValidate();
        }

        #endregion


        #region Delete

        [Given(@"I clicked on the skill tab under Profile Page")]
        public void GivenIClickedOnSkillTabUnderProfilePage()
        {
            SpecflowPages.Pages.Skills.SkillsTab();
        }
                
        [When(@"I click delete button")]
        public void WhenIClickDeleteButton()
        {
            SpecflowPages.Pages.Skills.Delete();
        }
        
        [Then(@"the skill that got clicked should not be displayed on my listings")]
        public void ThenTheSkillThatGotClickedShouldNotBeDisplayedOnMyListings()
        {
            SpecflowPages.Pages.Skills.DeleteValidate();
        }

        #endregion
    }
}
