namespace Asm2_Ph46130
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        //1<=a,b<=20
        [Test]
        [TestCase(5, 8)]
        [TestCase(5.8, 8)]
        [TestCase(-5.8, -8)]
        [TestCase(-8, -7)]
        [TestCase(8, -7.8)]
        [TestCase(1, 20)]
        [TestCase(0, 21)]
        [TestCase(0, 20)]
        [TestCase(21, 0)]
        [TestCase(20, 1)]
        public void Test1_TinhTong(double a, double b)
        {
            if (a != (int)a)
            {
                throw new ArgumentException("a không phải là số nguyên");
            };
            if (b != (int)b)
            {
                throw new ArgumentException("b không phải là số nguyên");
            };
            double hieu = a + b;

            Assert.Greater(hieu, 0);
        }
        // -2<=a,b<=10
        [Test]
        [TestCase(5, 8)]
        [TestCase(5.8, 8)]
        [TestCase(-5.8, -8)]
        [TestCase(-8, -7)]
        [TestCase(8, -7.8)]
        [TestCase(-2, 10)]
        [TestCase(-3, 11)]
        [TestCase(-3, 10)]
        [TestCase(-2, 11)]
        [TestCase(11, -2)]

        public void Test2_KiemTraSoNguyen(double a, double b)
        {
            bool kt1 = false, kt2 = false;
            if (a == (int)a)
            {
                kt1 = true;
            }
            if (b == (int)b)
            {
                kt2 = true;
            }
            if (kt1 && kt2)
            {
                Assert.That(true);
            }
            else
           if (kt1 && !kt2)
            {
                throw new ArgumentException("Số b không phải là số nguyên");
            }
            else
           if (!kt1 && kt2)
            {
                throw new ArgumentException("Số a không phải là số nguyên");
            }

        }
        //1<=a,b<=20
        [Test]
        [TestCase(5, 8)]
        [TestCase(5.8, 8)]
        [TestCase(-5.8, -8)]
        [TestCase(-8, -7)]
        [TestCase(8, -7.8)]
        [TestCase(1, 20)]
        [TestCase(0, 21)]
        [TestCase(0, 20)]
        [TestCase(21, 0)]
        [TestCase(20, 1)]
        public void Test3_TinhHieu(double a, double b)
        {
            if (a != (int)a)
            {
                throw new ArgumentException("a không phải là số nguyên");
            };
            if (b != (int)b)
            {
                throw new ArgumentException("b không phải là số nguyên");
            };
            double hieu = a - b;

            Assert.Greater(hieu, 0);
        }
        [Test]
        [TestCase(new double[] { 5, 6, 7, 8, 9 })]
        [TestCase(new double[] { 0 })]
        [TestCase(new double[] { 5, -7 })]
        [TestCase(new double[] { 5, 6, 7.8, 8.1, 9 })]
        [TestCase(new double[] { })]

        public void Test4_TBC(double[] n)
        {

            if (n.Length == 0)
            {
                throw new ArithmeticException("Không thể chia cho 0");
            };
            var tbc = n.Sum(x => x) / n.Length;
            Console.WriteLine(tbc);

            Assert.That(tbc != 0, Is.EqualTo(true));
        }
        [Test]
        [TestCase(new double[] { 5, 6, 7, 8, 9 }, 9)]
        [TestCase(new double[] { 5, 6, 7, 8, 9 }, 5.8)]
        [TestCase(new double[] { 5, 6, 7, 8, 9 }, 6)]
        [TestCase(new double[] { 5, 6, 7.8, 8.1, 9 }, 8.1)]
        [TestCase(new double[] { }, 1)]

        public void Test5_GetElementAtIndex(double[] n, double a)
        {
            if (n.Length == 0)
            {
                throw new ArgumentException("Dãy rỗng");
            };
            if (!n.Contains(a))
            {
                throw new IndexOutOfRangeException("Chỉ mục được cung cấp nằm ngoài phạm vi mảng");
            };
            bool kt = false;
            if (n.Contains(a))
            {
                kt = true;
                Console.WriteLine(n.ToList().IndexOf(a) + 1);
            }

            Assert.That(kt, Is.EqualTo(true));
        }
    }
}