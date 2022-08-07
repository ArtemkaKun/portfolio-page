using NUnit.Framework;
using PortfolioAppServer.AboutDataSystem;

namespace PortfolioAppTests;

public class AboutHtmlDataManagerTests
{
    [Test]
    public void RequestAboutData_ReturnedDataEqualToExpected()
    {
        const string expectedData = "About Data";
        IAboutDataProvider dataProvider = new FakeDataProvider(expectedData);
        IAboutDataManager aboutDataManager = new AboutHtmlDataManager(dataProvider);
        string actualData = aboutDataManager.RequestData();
        Assert.AreEqual(expectedData, actualData);
    }

    [Test]
    public void RequestAboutData_ReturnedHtmlDataEqualToExpected()
    {
        const string expectedHtmlData =
            @"<div>
                <h1>About Data</h1>

                <li> 
                    <a href=""#"">About Data</a> 
                </li>
            </div>";

        IAboutDataProvider dataProvider = new FakeDataProvider(expectedHtmlData);
        IAboutDataManager aboutDataManager = new AboutHtmlDataManager(dataProvider);
        string actualData = aboutDataManager.RequestData();
        Assert.AreEqual(expectedHtmlData, actualData);
    }

    private class FakeDataProvider : IAboutDataProvider
    {
        private readonly string _data;

        public FakeDataProvider(string data)
        {
            _data = data;
        }

        public string GetData()
        {
            return _data;
        }
    }
}