using TestBox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingTestBox
{
    
    
    /// <summary>
    ///Это класс теста для StoreLogicTest, в котором должны
    ///находиться все модульные тесты StoreLogicTest
    ///</summary>
    [TestClass()]
    public class StoreLogicTest
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
        ///Тест для Sort
        ///</summary>
        [TestMethod()]
        public void SortTest()
        {
            Store store = new Store(); // TODO: инициализация подходящего значения
            Box minBox = new Box(1, 1, 1);
            Box middleBox = new Box(1, 2, 1);
            Box maxBox = new Box(1, 2, 2);
            store.Add(maxBox);
            store.Add(minBox);
            store.Add(middleBox);


            StoreLogic target = new StoreLogic();
            target.Sort(store);

            List<Box> expected = new List<Box>() { minBox, middleBox, maxBox };

            List<Box> actual;
            actual = target.Sort(store);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Тест для Sort
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void SortTestException()
        {
            StoreLogic target = new StoreLogic(); // TODO: инициализация подходящего значения
            Store strore = null; // TODO: инициализация подходящего значения
            List<Box> actual;
            actual = target.Sort(strore);
        }
    }
}
