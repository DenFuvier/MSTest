using Army;

namespace ArmyTest
{
    [TestClass]
    public class TestPeopleTests
    {
        [TestMethod]
        public void addPrizivnik_ValidConscript_CountIncrements()
        {
            
            TestPeople SoGO = new TestPeople();
            PrizivnikInfo prizivnik = new PrizivnikInfo(20);

            
            SoGO.addPrizivnik(prizivnik);

            
            Assert.AreEqual(1, SoGO.TotalConscripts);
        }

        [TestMethod]
        public void addPrizivnik_InvalidConscript_RejectedCountIncrements()
        {
            
            TestPeople SoGO = new TestPeople();
            PrizivnikInfo prizivnik = new PrizivnikInfo(17); 

            
            SoGO.addPrizivnik(prizivnik);

          
            Assert.AreEqual(1, SoGO.RejectedConscripts);
        }

        [TestMethod]
        public void CalculateSuccessRate_NoConscripts_ReturnsZero()
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

            
            Assert.AreEqual(66.666666666666657, SoGo.CalculateSuccessRate()); //проверяется, что результат вызова метода CalculateSuccessRate() для объекта SoGo равен 66.666666666666657.
                                                                              //Если фактическое значение, возвращаемое методом CalculateSuccessRate(), не совпадает с ожидаемым (в данном случае 66.666666666666657),
                                                                              //тест будет неудачным
        }
    }
}