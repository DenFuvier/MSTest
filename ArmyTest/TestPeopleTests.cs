using Army;
using Army.Army;

namespace ArmyTest
{
    [TestClass]
    public class TestPeopleTests
    {
        [TestMethod]
        public void addPrizivnik1()
        {
            TestPeople SoGO = new TestPeople();
            PrizivnikInfo prizivnik = new PrizivnikInfo(20);

            SoGO.addPrizivnik(prizivnik);

            Assert.AreEqual(1, SoGO.ColVoPriziv);
        }

        [TestMethod]
        public void addPrizivnik2()
        {
            TestPeople SoGO = new TestPeople();
            PrizivnikInfo prizivnik = new PrizivnikInfo(17);

            SoGO.addPrizivnik(prizivnik);

            Assert.AreEqual(1, SoGO.ColVoOtclon);
        }

        [TestMethod]
        public void CalculateSuccessRate()
        {
            TestPeople SoGO = new TestPeople();

            Assert.AreEqual(0, SoGO.CalculateSuccessRate());
        }

        [TestMethod]
        public void CalculateSuccessRate_WithConscripts_ReturnsCorrectRate()
        {
            TestPeople SoGo = new TestPeople();
            SoGo.addPrizivnik(new PrizivnikInfo(20));
            SoGo.addPrizivnik(new PrizivnikInfo(17));
            SoGo.addPrizivnik(new PrizivnikInfo(25));

            Assert.AreEqual(66.666666666666657, SoGo.CalculateSuccessRate());
        }
    }
}
            
            
//проверяется, что результат вызова метода CalculateSuccessRate() для объекта SoGo равен 66.666666666666657.
//Если фактическое значение, возвращаемое методом CalculateSuccessRate(), не совпадает с ожидаемым (в данном случае 66.666666666666657),