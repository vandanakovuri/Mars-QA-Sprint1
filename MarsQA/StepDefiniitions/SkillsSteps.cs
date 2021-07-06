using MarsQA.Helpers;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefiniitions
{
    [Binding]
    public class SkillsSteps
    {
        [Given(@"Add Skill Details")]
        public void GivenAddSkillDetails()
        {
            ExcelLibHelper.PopulateInCollection($@"{login.path}Data\MarsQA.xlsx", "Skills");
            Skills.AddSkills();
        }
        
        [Given(@"Edit Skill Details")]
        public void GivenEditSkillDetails()
        {
            ExcelLibHelper.PopulateInCollection($@"{login.path}Data\MarsQA.xlsx", "Skills");
            Skills.EditSkills();
        }
        
        [Given(@"Delete Skill Details")]
        public void GivenDeleteSkillDetails()
        {
            Skills.DeleteSkills();
        }
    }
}
