using ConsoleApp1;

namespace Pr1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void pass_0() => proverka("тест", 0);
        [TestMethod]
        public void pass_1() => proverka("1", 1);
        [TestMethod]
        public void pass_2() => proverka("passs1", 2);
        [TestMethod]
        public void pass_3() => proverka("Pass2", 3);
        [TestMethod]
        public void pass_4() => proverka("Pass<3", 4);
        [TestMethod]
        public void pass_5() => proverka("Pass<3word", 5);

        public void proverka(string password, int result)
        {
            Class1 class1 = new Class1();
            int actual = class1.IsPass(password);
            Assert.AreEqual(result, actual);
        }
    }
}