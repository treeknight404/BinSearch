using BinSearch;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinarySearch_norm_rabotaet_chislo()
        {
            int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 10;
            int expectedResult = 4;

            BinarySearch binarySearch = new BinarySearch();
            int actualResult = binarySearch.BinSearch_int(array, target);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinarySearch_ne_nashel_chislo()
        {
            int[] array = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int target = 15;
            int expectedResult = -1;

            BinarySearch binarySearch = new BinarySearch();
            int actualResult = binarySearch.BinSearch_int(array, target);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinarySearch_norm_rabotaet_text()
        {
            string[] array = { "apple", "banana", "cherry", "grape", "orange" };
            string target = "cherry";
            int expectedResult = 2; 
            
            BinarySearch binarySearch = new BinarySearch();
            int actualResult = binarySearch.BinSearch_txt(array, target);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void BinarySearch_ne_nashel_text()
        {
            string[] array = { "apple", "banana", "cherry", "grape", "orange" };
            string target = "pear";
            int expectedResult = -1;

            BinarySearch binarySearch = new BinarySearch();
            int actualResult = binarySearch.BinSearch_txt(array, target);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void AuthorizeSuccess()
        {
            bool Authorizated = true;
            string Login = "KEK";
            string Password = "qwerty";
            DBManager dBManager = new DBManager("C:\\Users\\kek\\source\\repos\\BinSearch\\users.db");
            Assert.AreEqual(Authorizated, dBManager.CheckUser(Login, Password));
        }

        [TestMethod]
        public void AuthorizeFail()
        {
            bool Authorizated = false;
            string Login = "KEK";
            string Password = "123";
            DBManager dBManager = new DBManager("C:\\Users\\kek\\source\\repos\\BinSearch\\users.db");
            Assert.AreEqual(Authorizated, dBManager.CheckUser(Login, Password));
        }
    }
}