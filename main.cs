using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

ChromeOptions options = new ChromeOptions();
IWebDriver driver;
driver = new ChromeDriver(options);

Console.Clear();
Console.WriteLine("$ movie scraper $ \n");
driver.Navigate().GoToUrl("https://www.imdb.com/chart/top/");
var elements = driver.FindElements(By.ClassName("ipc-metadata-list-summary-item"));

foreach (var element in elements)
{
    var title = element.FindElement(By.ClassName("ipc-metadata-list-item__title")).Text;
    Console.WriteLine(title);
}
