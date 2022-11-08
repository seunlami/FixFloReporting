using FixFloReporting.PageObjects;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace FixFloReporting.StepDefinition
{
    [Binding]
    public class FaultReportSteps
    {

        FaultReportPage faultReportPage;

        public FaultReportSteps()
        {
            faultReportPage = new FaultReportPage();
        }

        [Given(@"the user navigates to website ""(.*)""")]
        public void GivenTheUserNavigatesToWebsite(string url)
        {
            faultReportPage.NavigateToWebsite(url);
        }
        
        [Given(@"user clicks on water and leaks")]
        public void GivenUserClicksOnWaterAndLeaks()
        {
            faultReportPage.ClickWaterAndLeaks();
        }
        
        [Given(@"user clicks on leak")]
        public void GivenUserClicksOnLeak()
        {
            faultReportPage.ClickOnLeak();
        }
        
        [Given(@"user clicks on Water leak within property")]
        public void GivenUserClicksOnWaterLeakWithinProperty()
        {
            faultReportPage.ClickWaterLeakWithinProperty();
        }
        
        [Given(@"user clicks on continue")]
        public void GivenUserClicksOnContinue()
        {
            faultReportPage.ClickContinueButton();

        }

        

        [Given(@"user selects bowl inside the container text box")]
        public void GivenUserSelectsBowlInsideTheContainerTextBox()
        {
            faultReportPage.ClickOnContainerSize();
        }


        [Given(@"user selects minutes insde the how often text box")]
        public void GivenUserSelectsMinutesInsdeTheHowOftenTextBox()
        {
            faultReportPage.SelectHowOften();
        }


        [Given(@"user selects leak frequency in text box")]
        public void GivenUserSelectsLeakFrequencyInTextBox()
        {
            faultReportPage.SelectLeakFrequency();
        }       
        
        [Given(@"user enters fault details ""(.*)""")]
        public void GivenUserEntersFaultDetails(string fault)
        {
            faultReportPage.EnterFaultDetails(fault);
        }
        
        [Given(@"user clicks on Next")]
        public void GivenUserClicksOnNext()
        {
            faultReportPage.ClickNext();
        }
        
        [Given(@"user clicks on second Next button")]
        public void GivenUserClicksOnSecondNextButton()
        {
            faultReportPage.ClickNextButton();
        }

        [Given(@"user enters the postcode ""(.*)""")]
        public void GivenUserEntersThePostcode(string postcode)
        {
            faultReportPage.InsertPostCode(postcode);
        }


        [Given(@"user clicks search button")]
        public void GivenUserClicksSearchButton()
        {
            faultReportPage.ClickSearch();
        }


        [Given(@"user selects the address")]
        public void GivenUserSelectsTheAddress()
        {
            faultReportPage.SelectTheAddress();
        }

        [Given(@"user clicks the next button")]
        public void GivenUserClicksTheNextButton()
        {
            faultReportPage.ClickTheNextbutton();
        }

        [Given(@"user enters Title ""(.*)""")]
        public void GivenUserEntersTitle(string title)
        {
            faultReportPage.EnterTitle(title);
        }
        
        [Given(@"user enters First name ""(.*)""")]
        public void GivenUserEntersFirstName(string firstname)
        {
            faultReportPage.EnterFirstName(firstname);
        }
        
        [Given(@"user enters Surname ""(.*)""")]
        public void GivenUserEntersSurname(string surname)
        {
            faultReportPage.EnterSurname(surname);
        }
        
        [Given(@"user enters Email ""(.*)""")]
        public void GivenUserEntersEmail(string email)
        {
            faultReportPage.EnterEmail(email);
        }
        
        [Given(@"user enters phone number ""(.*)""")]
        public void GivenUserEntersPhoneNumber(string phonenumber)
        {
            faultReportPage.EnterPhoneNumber(phonenumber);
        }

        [When(@"user clicks the next button")]
        public void WhenUserClicksTheNextButton()
        {
            faultReportPage.ClickTheNextButton();
        }

        [Then(@"the submit issue button should be displayed")]
        public void ThenTheSubmitIssueButtonShouldBeDisplayed()
        {
            Assert.That(faultReportPage.IsSubmitButtonDisplayed);
        }

    }
}
