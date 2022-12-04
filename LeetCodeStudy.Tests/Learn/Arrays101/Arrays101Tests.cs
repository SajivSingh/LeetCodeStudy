using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeStudy.Learn.Arrays101.Tests
{
    [TestClass()]
    public class Arrays101Tests
    {
        private MaxConsecutiveOnes _maxConsecutiveOnes;

        public Arrays101Tests()
        {
            _maxConsecutiveOnes = new MaxConsecutiveOnes();
        }

        [DataRow(new int[] { 1, 1, 0, 1, 1, 1 }, 3)]
        [TestMethod]
        public void FindMaxConsecutiveOnes(int[] nums, int result)
        {
            int maxCount = _maxConsecutiveOnes.FindMaxConsecutiveOnes(nums);
            Assert.AreEqual(maxCount, result);
        }
    }
}