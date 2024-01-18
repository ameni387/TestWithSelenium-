using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Drawing;
using System.Threading.Tasks;



namespace testwithSel
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.ma-calculatrice.fr/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1500);
            Console.WriteLine("Initialisation du site web");
        }
        [TearDown] // méthode qui s'exécute après chaque test
        public void Clean()
        {
            driver.Close();
            Console.WriteLine("fermer le site web");
        }
        [OneTimeTearDown]
        public void Quit()
        {
            driver.Quit();
        }

        [Category("ViewTest")]
        [Test]
        public void AdditionTestOfSelenium()
        {
            // Test Case 1: Addition

            var Un = driver.FindElement(By.Id("un"));
            //var Deux = driver.FindElement(By.Id("deux"));
            var Total = driver.FindElement(By.Id("total"));
            var Egal = driver.FindElement(By.Id("egale"));
            var Addition = driver.FindElement(By.Id("addition"));
            var expectedSum = 2;
            Un.Click();
            //var numb1 = Total.GetAttribute("value");
            Addition.Click();
            Un.Click();
            Egal.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5)); // 2 seconds sleep

            var actualTotal = Total.Text;
            Console.WriteLine(actualTotal);
            Assert.That(actualTotal, Is.EqualTo(expectedSum.ToString()));
            Thread.Sleep(TimeSpan.FromSeconds(5)); // 2 seconds sleep

        }


        [Test]
        public void SubtractionTestOfSelenium()
        {
            var sept = driver.FindElement(By.Id("sept"));
            var trois = driver.FindElement(By.Id("trois"));
            var Total = driver.FindElement(By.Id("total"));
            var Egal = driver.FindElement(By.Id("egale"));
            var moins = driver.FindElement(By.Id("moins"));
            
            //var Addition = driver.FindElement(By.Id("addition"));
            var expectedSub = 4;
            sept.Click();
            //var numb1 = Total.GetAttribute("value");
            moins.Click();
            trois.Click();
            Egal.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5)); // 2 seconds sleep

            var actualTotal = Total.Text;
            Console.WriteLine(actualTotal);
            Assert.That(actualTotal, Is.EqualTo(expectedSub.ToString()));
            Thread.Sleep(TimeSpan.FromSeconds(5)); // 2 seconds sleep

        }
        [Test]
        public void MultiplicationTestOfSelenium()
        {
            var neuf = driver.FindElement(By.Id("neuf"));
            var six = driver.FindElement(By.Id("six"));
            var Total = driver.FindElement(By.Id("total"));
            var Egal = driver.FindElement(By.Id("egale"));
            var multiplier = driver.FindElement(By.Id("multiplier"));

            //var Addition = driver.FindElement(By.Id("addition"));
            var expectedMul = 54;
            six.Click();
            //var numb1 = Total.GetAttribute("value");
            multiplier.Click();
            neuf.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5)); // 2 seconds sleep

            Egal.Click();

            var actualMultiplication = Total.Text;
            Console.WriteLine(actualMultiplication);
            Assert.That(actualMultiplication, Is.EqualTo(expectedMul.ToString()));
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
        [Test]
        public void DivisionTestOfSelenium()
        {
            var quatre = driver.FindElement(By.Id("quatre"));
            var huit = driver.FindElement(By.Id("huit"));
            var Total = driver.FindElement(By.Id("total"));
            var Egal = driver.FindElement(By.Id("egale"));
            var diviser = driver.FindElement(By.Id("diviser"));

            //var Addition = driver.FindElement(By.Id("addition"));
            var expectedDiv = 2;
            huit.Click();
            //var numb1 = Total.GetAttribute("value");
            diviser.Click();
            quatre.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5)); // 2 seconds sleep

            Egal.Click();
            var actualDivision = Total.Text;
            Console.WriteLine(actualDivision);
            Assert.That(actualDivision, Is.EqualTo(expectedDiv.ToString()));
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
