using System.IO;
using NUnit.Framework;
using PortfolioAppServer.AboutDataSystem;

namespace PortfolioAppTests;

public class AboutHtmlDataFileReaderTests
{
    [Test]
    public void ReadDataFromFile_DataEqualsToExpected()
    {
        string testAboutHtmlData = "<div>About</div>";
        File.WriteAllText("testData.html", testAboutHtmlData);
        IAboutDataProvider aboutHtmlDataProvider = new AboutHtmlDataFileReader("testData.html");
        string aboutHtmlData = aboutHtmlDataProvider.GetData();

        Assert.AreEqual(testAboutHtmlData, aboutHtmlData);
        File.Delete("testData.html");
    }
}