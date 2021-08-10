using System.Collections.Generic;
using System.Linq;
using Dapper;
using ui;
using Xunit;

namespace unit_tests
{
    public class ExampleTest
    {
        [Fact]
        public void ShouldPass()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();

            var sql = "SELECT 1";
            var expectedResult = 1;
            var actualResult = dbConnection.QueryFirst<int>(sql);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void NumberOfBranchesFetchedCorrectly()
        {
            var dbConnection = new Database().GetConnection;
            dbConnection.Open();
            var sql = "SELECT COUNT(*) FROM branches";
            var expectedResult = dbConnection.QueryFirst<int>(sql);
            dbConnection.Close();

            var db = new Database();
            var actualResult = db.FetchAllBranches();

            Assert.Equal(expectedResult, actualResult.Count());
        }
        [Fact]
        public void DateFilterOrder()
        {
            var db = new Database();
            var orderOne = db.FetchOrderDetails(1);
            var orderOneDict = orderOne.First() as IDictionary<string, object>;
            System.DateTime orderOneDate = (System.DateTime)orderOneDict["order_date"];
           var positiveStartDate = orderOneDate.AddMonths(-1).ToString("yyyy-MM-dd");
            var negativeStartDate = orderOneDate.AddMonths(1).ToString("yyyy-MM-dd");
            var positiveResult = db.FetchDateFilteredOrderDetails(1, positiveStartDate);
            Assert.True(positiveResult.Count() == 0);
            Assert.True(db.FetchDateFilteredOrderDetails(1, negativeStartDate).Count() > 0);
 

        }
    }
}