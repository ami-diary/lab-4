using Lab4_MaxElement; // подключаем основной проект
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab4_Test
{
    [TestClass]
    public class MaxElementTests
    {
        // Позитивный тест
        [TestMethod]
        public void TestFindFirstMax_PositiveNumbers()
        {
            double[] arr = { 1, 3, 2, 5, 4 };
            int result = Program.FindFirstMax(arr);
            Assert.AreEqual(3, result); // индекс первого максимального элемента
        }

        // Негативный тест 1: все отрицательные числа
        [TestMethod]
        public void TestFindFirstMax_AllNegative()
        {
            double[] arr = { -5, -3, -10, -1 };
            int result = Program.FindFirstMax(arr);
            Assert.AreEqual(3, result); // индекс первого максимального элемента
        }

        // Негативный тест 2: массив из одного элемента
        [TestMethod]
        public void TestFindFirstMax_SingleElement()
        {
            double[] arr = { 42 };
            int result = Program.FindFirstMax(arr);
            Assert.AreEqual(0, result);
        }

        // Негативный тест 3: пустой массив
        [TestMethod]
        public void TestFindFirstMax_EmptyArray()
        {
            double[] arr = { };
            Assert.ThrowsException<IndexOutOfRangeException>(() => Program.FindFirstMax(arr));
        }

        // Негативный тест 4: несколько одинаковых максимальных элементов
        [TestMethod]
        public void TestFindFirstMax_MultipleMax()
        {
            double[] arr = { 2, 5, 5, 1 };
            int result = Program.FindFirstMax(arr);
            Assert.AreEqual(1, result); // первый максимальный элемент
        }
    }
}