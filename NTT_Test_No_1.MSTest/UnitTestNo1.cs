namespace NTT_Test_No_1.MSTest
{
    [TestClass]
    public class UnitTestNo1
    {
        [TestMethod]
        [DataRow(new int[] { 4, 6, 15, 25, 45, 2, 8 }, 10)]
        public void SoalA_AnswerUsingJsonFormat_ReturnEquals(int[] numberEnteredTest, int referenceSummarizeNumberTest)
        {
            var actualResult = NTT.NTT_Test_No_1.AnswerUsingJsonFormat(numberEnteredTest, referenceSummarizeNumberTest);
            string expectedResult = "[[4,6],[2,8]]";
            Assert.AreEqual(expectedResult, actualResult.Replace("\"", ""));
        }

        [TestMethod]
        [DataRow(new int[] { 4, 7, 12, 1, 4, 8, 8 }, 12)]
        public void SoalB_AnswerUsingJsonFormat_ReturnEquals(int[] numberEnteredTest, int referenceSummarizeNumberTest)
        {
            var actualResult = NTT.NTT_Test_No_1.AnswerUsingJsonFormat(numberEnteredTest, referenceSummarizeNumberTest);
            string expectedResult = "[[4,8]]";
            Assert.AreEqual(expectedResult, actualResult.Replace("\"", ""));
        }


        [TestMethod]
        [DataRow(new int[] { 4, 6, 15, 25, 45, 2, 8 }, 10)]
        public void SoalA_AnswerUsingStandardFormat_ReturnTrueStandardFormat(int[] numberEnteredTest, int referenceSummarizeNumberTest)
        {
            var actualResult = NTT.NTT_Test_No_1.AnswerUsingStandardFormat(numberEnteredTest, referenceSummarizeNumberTest);
            string expectedResult = "[[4,6],[2,8]]";
            Assert.AreEqual(expectedResult, actualResult.Replace("\"", ""));
        }

        [TestMethod]
        [DataRow(new int[] { 4, 7, 12, 1, 4, 8, 8 }, 12)]
        public void SoalB_AnswerUsingStandardFormat_ReturnTrueStandardFormat(int[] numberEnteredTest, int referenceSummarizeNumberTest)
        {
            var actualResult = NTT.NTT_Test_No_1.AnswerUsingStandardFormat(numberEnteredTest, referenceSummarizeNumberTest);
            string expectedResult = "[[4,8]]";
            Assert.AreEqual(expectedResult, actualResult.Replace("\"", ""));
        }
    }
}