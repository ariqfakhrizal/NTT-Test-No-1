namespace NTT_Test_No_1.MSTest
{
    [TestClass]
    public class UnitTestNo1
    {
        [TestMethod]
        public void SoalA_AnswerUsingJSON_ReturnTrueJsonResult()
        {
            int[] dataArray = new int[] { 4, 6, 15, 25, 45, 2, 8 };
            int sumArray = 10;

            var result = NTT.NTT_Test_No_1.AnswerUsingJSON(dataArray, sumArray);
            Assert.AreEqual("[[4,6],[2,8]]", result.Replace("\"", ""));
        }

        [TestMethod]
        public void SoalB_AnswerUsingJSON_ReturnTrueJsonResult()
        {
            int[] dataArray = new int[] { 4, 7, 12, 1, 4, 8, 8 };
            int sumArray = 12;

            var result = NTT.NTT_Test_No_1.AnswerUsingJSON(dataArray, sumArray);
            Assert.AreEqual("[[4,8]]", result.Replace("\"", ""));
        }


        [TestMethod]
        public void SoalA_AnswerUsingStandardFormat_ReturnTrueStandardFormat()
        {
            int[] dataArray = new int[] { 4, 6, 15, 25, 45, 2, 8 };
            int sumArray = 10;

            var result = NTT.NTT_Test_No_1.AnswerUsingStandardFormat(dataArray, sumArray);
            Assert.AreEqual("[[4,6],[2,8]]", result.Replace("\"", ""));
        }

        [TestMethod]
        public void SoalB_AnswerUsingStandardFormat_ReturnTrueStandardFormat()
        {
            int[] dataArray = new int[] { 4, 7, 12, 1, 4, 8, 8 };
            int sumArray = 12;

            var result = NTT.NTT_Test_No_1.AnswerUsingStandardFormat(dataArray, sumArray);
            Assert.AreEqual("[[4,8]]", result.Replace("\"", ""));
        }
    }
}