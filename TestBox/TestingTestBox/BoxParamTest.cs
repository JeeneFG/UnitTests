using TestBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingTestBox
{
    
    
    /// <summary>
    ///Это класс теста для BoxParamTest, в котором должны
    ///находиться все модульные тесты BoxParamTest
    ///</summary>
    [TestClass()]
    public class BoxParamTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты теста
        // 
        //При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        //ClassInitialize используется для выполнения кода до запуска первого теста в классе
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //TestInitialize используется для выполнения кода перед запуском каждого теста
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Тест для GetValume
        ///</summary>
        [TestMethod()]
        public void GetVolumeTest()
        {
            Box box = new Box(1, 2, 3); // TODO: инициализация подходящего значения
            double expected = 6F; // TODO: инициализация подходящего значения
            double actual;
            actual = BoxParam.GetVolume(box);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для GetValume
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void GetValumeTestException()
        {
            Box box = null;
            double actual = BoxParam.GetVolume(box);
        }

        /// <summary>
        ///Тест для GetArea
        ///</summary>
        [TestMethod()]
        public void GetAreaTest()
        {
            BoxParam target = new BoxParam(); // TODO: инициализация подходящего значения
            Box box = new Box(1, 2 ,3); // TODO: инициализация подходящего значения
            double expected = 22F; // TODO: инициализация подходящего значения
            double actual;
            actual = target.GetArea(box);
            Assert.AreEqual(expected, actual);
        }
     }
}
