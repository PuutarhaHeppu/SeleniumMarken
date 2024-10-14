using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumMarken
{
    public class FirstTestCase
    {
        static void Main(string[] args)
        {
            string binaryLocation = "C:\\Users\\opilane\\source\\repos\\FFP\\FirefoxPortable\\App\\Firefox64\\Firefox.exe";

            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = binaryLocation;

            IWebDriver driver = new FirefoxDriver("C:\\Users\\opilane\\source\\repos\\SeleniumMarken\\SeleniumMarken\\drivers", options);
            driver.Url = "https://localhost:7156/";
        }
    }
}
