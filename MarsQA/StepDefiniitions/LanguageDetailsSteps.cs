using MarsQA.Helpers;
using MarsQA.PageObjects;
using MarsQA.StepDefiniitions;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefiniitions
{
    [Binding]
    public class LanguageDetailsSteps
    {
        [Given(@"Add Language Details")]
        public void GivenAddLanguageDetails()
        {
            ExcelLibHelper.PopulateInCollection($@"{login.path}Data\MarsQA.xlsx", "LanguageDetails");
            LanguageDetails.AddLanguages();

        }
        [Given(@"Edit Language Details")]
        public void GivenEditLanguageDetails()
        {
            ExcelLibHelper.PopulateInCollection($@"{login.path}Data\MarsQA.xlsx", "LanguageDetails");
            LanguageDetails.EditLanguages();
        }

        [Given(@"Delete Language Details")]
        public void GivenDeleteLanguageDetails()
        {
            LanguageDetails.DeleteLanguages();
        }

    }
}
