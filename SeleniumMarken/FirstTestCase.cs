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
            //TestLogin(); //TC1
            //TestSignUp(); //TC2
            TestPlaneView(); //TC3
            //TestPlaneClientView(); //TC4
            //TestCarView(); //TC5
            //TestCarClientView(); //TC6
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

        [Test]
        public static void TestLogin()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://localhost:5115/";


            IWebElement element2 = driver.FindElement(By.Id("username"));
            element2.SendKeys("Kiur");
            IWebElement element3 = driver.FindElement(By.Id("password"));
            element3.SendKeys("Kiur");
            IWebElement element4 = driver.FindElement(By.CssSelector("input[type='submit']"));
            element4.Click();

        }

        [Test]
        public static void TestSignUp()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://localhost:5115/";


            IWebElement element = driver.FindElement(By.LinkText("Create Account"));
            element.Click();
            IWebElement element2 = driver.FindElement(By.Id("username"));
            element2.SendKeys("kiurkiur");
            IWebElement element3 = driver.FindElement(By.Id("password"));
            element3.SendKeys("kiurkiur");
            IWebElement element4 = driver.FindElement(By.CssSelector("button[type='submit']"));
            element4.Click();
            IWebElement element5 = driver.FindElement(By.LinkText("Cars"));
            element5.Click();
            Task.Delay(2000).Wait();
            IWebElement element6 = driver.FindElement(By.LinkText("Planes"));
            element6.Click();

        }

        [Test]
        public static void TestPlaneView()
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "http://localhost:5115/";


            IWebElement element2 = driver.FindElement(By.Id("username"));
            element2.SendKeys("Kiur");
            IWebElement element3 = driver.FindElement(By.Id("password"));
            element3.SendKeys("Kiur");
            IWebElement element4 = driver.FindElement(By.CssSelector("input[type='submit']"));
            element4.Click();
            IWebElement element6 = driver.FindElement(By.LinkText("Planes"));
            element6.Click();
            IWebElement element7 = driver.FindElement(By.LinkText("Add Car"));
            element7.Click();
            IWebElement element8 = driver.FindElement(By.Id("Name"));
            element8.SendKeys("Boeing");
            IWebElement element11 = driver.FindElement(By.Id("Price"));
            element11.SendKeys("11");
            IWebElement element12 = driver.FindElement(By.Id("Model"));
            element12.SendKeys("Boeing");
            IWebElement element13 = driver.FindElement(By.Id("Description"));
            element13.SendKeys("Boeing");
            IWebElement element14 = driver.FindElement(By.Id("Year"));
            element14.SendKeys("11");
            IWebElement element15 = driver.FindElement(By.Id("Register"));
            element15.SendKeys("Boeing");
            IWebElement element16 = driver.FindElement(By.Id("SerialNumber"));
            element16.SendKeys("11");
            IWebElement element17 = driver.FindElement(By.Id("Engine"));
            element17.SendKeys("Boeing");
            IWebElement element18 = driver.FindElement(By.Id("Propeller"));
            element18.SendKeys("Boeing");
            IWebElement element19 = driver.FindElement(By.Id("TotalTime"));
            element19.SendKeys("11");
            IWebElement element9 = driver.FindElement(By.Id("Seats"));
            element9.SendKeys("11");
            IWebElement element10 = driver.FindElement(By.Id("Inspection"));
            element10.Click();
            IWebElement element20 = driver.FindElement(By.Id("Files"));
            string filePath = @"C:\Users\opilane\source\repos\brumbrum.png";
            element20.SendKeys(filePath);
            IWebElement element21 = driver.FindElement(By.CssSelector("input[type='submit']"));
            element21.Click();


        }
    }
}
