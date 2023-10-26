using NUnit.Framework;
using MarketingCenterData;
using MarketingCenterData.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace MarketingCenter_dev5.DTI.Tests
{
    [TestFixture()]
    public class CategoryDtiTests
    {

        private CategoryDti _categorydti;
        private McdbContext _context;
        private ILogger _logger;

        [SetUp]
        public void SetUp()
        {
        }

        [Test()]
        public void GetCategoriesTest()
        {
            // No entities to be tested (business rules)
        }
    }
}