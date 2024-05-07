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

            Assert.AreEqual(2.0/3.0 * 100.0, SoGo.CalculateSuccessRate());
        }
    }
}



//Создается новый экземпляр класса TestPeople с именем SoGo.
//Добавляются три призывника с разными возрастами: 20 лет, 17 лет и 25 лет.
//Затем с помощью метода CalculateSuccessRate() вычисляется процент успешного призыва на основе добавленных призывников.
//С помощью утверждения Assert.AreEqual() проверяется, что фактический результат вычисления процента успешного призыва совпадает с ожидаемым значением, равным 66.666666666666657.
