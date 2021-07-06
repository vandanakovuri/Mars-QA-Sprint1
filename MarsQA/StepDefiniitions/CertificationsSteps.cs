using MarsQA.Helpers;
using MarsQA.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace MarsQA.StepDefiniitions
{
    [Binding]
    public class CertificationsSteps
    {
        [Given(@"Add Certification details")]
        public void GivenAddCertificationDetails()
        {
            ExcelLibHelper.PopulateInCollection($@"{login.path}Data\MarsQA.xlsx", "Certifications");
            Certifications.AddCertifications();
        }
        
        [Given(@"Edit Certification details")]
        public void GivenEditCertificationDetails()
        {
            ExcelLibHelper.PopulateInCollection($@"{login.path}Data\MarsQA.xlsx", "Certifications");
            Certifications.EditCertifications();

        }
        
        [Given(@"Delete Certification details")]
        public void GivenDeleteCertificationDetails()
        {
            Certifications.DeleteCertifications();
        }
    }
}
