using NUnit.Framework;
using PortfolioApp.AboutDataSystem;

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