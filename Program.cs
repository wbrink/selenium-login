// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

public static class Selenium 
{
    static void Main() 
    {
        using (IWebDriver driver = new ChromeDriver(".\\"))
        {
            string url = @"https://libraries.tusd.net/";
            driver.Navigate().GoToUrl(url);

            // this grabs the Single Sign On Button libraries.tusd.net 
            IWebElement link = driver.FindElement(By.CssSelector("[href='/common/welcome.jsp?site=100']"));

            // click the link to be taken to link with sso button
            link.Click();

            // loginButton.Click(); // sends us the sso form
            // Console.WriteLine(loginButton);
            Console.ReadKey();
        }
    }
}



