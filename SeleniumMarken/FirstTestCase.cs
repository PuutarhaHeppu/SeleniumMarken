using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V127.Animation;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Xml.Linq;

namespace SeleniumMarken
{
    public class FirstTestCase
    {
        public event EventHandler? Clicked;

        static void Main(string[] args)
        {
            //TestHidingButton();
            //TestClickTwice();
            //TestHiddenButtons();
            //TestClick();
            //TestWaitForButton();
            //TestTextInput();
        }
        [Test]
        public static void TestHidingButton()
        {
            //koolis
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";
            //kodus
            //string binaryLocation = "C:\\Users\\kasutaja\\Desktop\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            //koolis
            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            //kodus
            //IWebDriver driver = new FirefoxDriver("C:\\Users\\kasutaja\\Documents\\GitHub\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/scrollbars";

            IWebElement element = driver.FindElement(By.Id("hidingButton"));
            element.Click();
        }
        [Test]
        public static void TestClickTwice()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/mouseover";

            Actions actions = new Actions(driver);
            IWebElement element = driver.FindElement(By.ClassName("text-primary"));
            actions.DoubleClick(element).Perform();

        }
        [Test]
        public static void TestHiddenButtons()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/visibility";

            IWebElement element = driver.FindElement(By.Id("hideButton"));
            element.Click();
            try
            {
                IWebElement element2 = driver.FindElement(By.Id("removedButton"));
            }
            catch
            {
                Console.WriteLine("button2 not found");
            }
            try
            {
                IWebElement element3 = driver.FindElement(By.Id("zeroWidthButton"));
            }
            catch
            {
                Console.WriteLine("button3 not found");
            }
            try
            {
                IWebElement element4 = driver.FindElement(By.Id("overlappedButton"));
            }
            catch
            {
                Console.WriteLine("button4 not found");
            }
            try
            {
                IWebElement element5 = driver.FindElement(By.Id("transparentButton"));
            }
            catch
            {
                Console.WriteLine("button5 not found");
            }
            try
            {
                IWebElement element6 = driver.FindElement(By.Id("invisibleButton"));
            }
            catch
            {
                Console.WriteLine("button6 not found");
            }
            try
            {
                IWebElement element7 = driver.FindElement(By.Id("notdisplayedButton"));
            }
            catch
            {
                Console.WriteLine("button7 not found");
            }
            try
            {
                IWebElement element8 = driver.FindElement(By.Id("offscreenButton"));
            }
            catch
            {
                Console.WriteLine("button8 not found");
            }
        }
        [Test]
        public static void TestClick()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/click";

            IWebElement element = driver.FindElement(By.Id("badButton"));
            element.Click();
            try
            {
                element.Click();
            }
            catch
            {
                Console.WriteLine("Cannot click button");
            }

        }
        [Test]
        public static void TestWaitForButton()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/autowait";

            IWebElement element = driver.FindElement(By.Id("applyButton3"));
            element.Click();
            Task.Delay(4000).Wait();
            IWebElement element2 = driver.FindElement(By.Id("target"));
            element2.Click();

        }
        [Test]
        public static void TestTextInput()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://www.uitestingplayground.com/textinput";


            IWebElement element = driver.FindElement(By.Id("newButtonName"));
            element.SendKeys("uus nupu nimi");
            IWebElement element2 = driver.FindElement(By.Id("updatingButton"));
            element2.Click();

        }
    }
}
