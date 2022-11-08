using FixFloReporting.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FixFloReporting.PageObjects
{
    class FaultReportPage
    {
        public FaultReportPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement WaterAndLeaks => driver.FindElement(By.XPath("//*[text()='Water and Leaks']"));
        IWebElement Leak => driver.FindElement(By.XPath("(//*[@class='card-img'])[1]"));
        IWebElement WaterLeakWithinProperty => driver.FindElement(By.XPath("//*[text()='Water leak within property']"));
        IWebElement Continue => driver.FindElement(By.XPath("(//*[@role='button'])[11]"));
        IWebElement ContainerSize => driver.FindElement(By.XPath("//*[@id='InputFaultLeakContainer']"));
        IWebElement SelectBowl => driver.FindElement(By.XPath("//*[@id='InputFaultLeakContainer']"));
        IWebElement SelectMinutes => driver.FindElement(By.XPath("//*[@id='InputFaultLeakEmptyRate']"));
        IWebElement LeakFrequency => driver.FindElement(By.XPath("//*[@id='InputFaultLeakIntermittency']"));
        IWebElement SelectIntermittent => driver.FindElement(By.XPath("//*[@id='InputFaultLeakIntermittency']"));
        IWebElement FaultDetails => driver.FindElement(By.XPath("//*[@id='InputFaultNotes']"));
        IWebElement Next => driver.FindElement(By.XPath("(//*[@type='button'])[8]"));
        IWebElement NextButton => driver.FindElement(By.XPath("(//*[@class='btn btn-primary next'])[1]"));
        IWebElement PostCode => driver.FindElement(By.XPath("//input[@placeholder='Find by postcode']"));
        IWebElement Search => driver.FindElement(By.XPath("(//*[@class='icon-search'])[2]"));
        IWebElement AddressSelection => driver.FindElement(By.XPath("//a[text()='2 Hedgemans Way, DAGENHAM, RM9 6DB']"));
        IWebElement Nextbutton => driver.FindElement(By.XPath("(//*[@type='button'])[14]"));
        IWebElement Title => driver.FindElement(By.XPath("//*[@id='inputTitle']"));
        IWebElement FirstName => driver.FindElement(By.XPath("//*[@id='inputFirstName']"));
        IWebElement Surname => driver.FindElement(By.XPath("//*[@id='inputSurname']"));
        IWebElement Email => driver.FindElement(By.XPath("//*[@id='inputEmail']"));
        IWebElement PhoneNumber => driver.FindElement(By.XPath("//*[@id='inputContactNo']"));
        IWebElement TheNextButton => driver.FindElement(By.XPath("(//*[@type='button'])[16]"));
        IWebElement SubmitButton => driver.FindElement(By.XPath("//*[@class='btn btn-primary btn-confirm']"));




        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickWaterAndLeaks()
        {
            WaterAndLeaks.Click();  
        }

        public void ClickOnLeak()
        {
            Thread.Sleep(1000);
            Leak.Click();
        }

        public void ClickWaterLeakWithinProperty()
        {
            Thread.Sleep(1000);
            WaterLeakWithinProperty.Click();
        }

        public void ClickContinueButton()
        {
            Thread.Sleep(1000);
            Continue.Click();
        }

        public void ClickOnContainerSize()
        {
            SelectElement select = new SelectElement(SelectBowl);
            select.SelectByText("Bowl");

        }           

        public void SelectHowOften()
        {
            SelectElement select = new SelectElement(SelectMinutes);
            select.SelectByText("15 minutes");
        }

        public void SelectLeakFrequency()
        {
           
            SelectElement select = new SelectElement(SelectIntermittent);
            select.SelectByText("Intermittent");
        }

        public void EnterFaultDetails(string fault)
        {
            FaultDetails.SendKeys(fault);
        }

        public void ClickNext()
        {
            Next.Click();
        }

        public void ClickNextButton()
        {
            Thread.Sleep(1000);
            NextButton.Click();
        }

        public void InsertPostCode(string postcode)
        {
            
            PostCode.SendKeys(postcode);
        }

        public void ClickSearch()
        {
            
            Search.Click();
            
        }

        public void SelectTheAddress()
        {
            Thread.Sleep(1000);
            AddressSelection.Click();
            
        }

        public void ClickTheNextbutton()
        {
            Nextbutton.Click();
        }

        public void EnterTitle(string title)
        {
            Title.SendKeys(title);
        }

        public void EnterFirstName(string firstname)
        {
            FirstName.SendKeys(firstname);
        }

        public void EnterSurname(string surname)
        {
            Surname.SendKeys(surname);
        }

        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void EnterPhoneNumber(string phonenumber)
        {
            PhoneNumber.SendKeys(phonenumber);
        }

        public void ClickTheNextButton()
        {
            TheNextButton.Click();
        }

        public bool IsSubmitButtonDisplayed()
        {
            Thread.Sleep(1000);
            return SubmitButton.Displayed;
        }





    }
}
