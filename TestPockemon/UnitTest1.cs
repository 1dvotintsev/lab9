using lab9;
namespace TestPockemon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPockemonConstractors()
        {
            Pockemon pockemon = new Pockemon(50, 50, 50);
            Pockemon p = new Pockemon();
            Pockemon p1 = new Pockemon(17, 32, 1);

            Pockemon new_pockemon = new Pockemon(pockemon);

            Assert.AreEqual(pockemon, new_pockemon);
            Assert.AreEqual(p, p1);

            p.N = 1;

            Assert.AreEqual(1, p.N);
        }
        [TestMethod]
        public void TestPockemon_ADS()
        {
            try
            {
                Pockemon p1 = new Pockemon(-100, -100, -100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Pockemon p1 = new Pockemon(50, -100, -100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Pockemon p1 = new Pockemon(50, 50, -100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Pockemon p1 = new Pockemon(5000, 50, -100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Pockemon p1 = new Pockemon(50, 50000, -100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Pockemon p1 = new Pockemon(50, 50, 50000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        [TestMethod]
        public void TestPockemonFunction()
        {
            Pockemon p = new Pockemon(50, 50, 50);
            Pockemon p1 = new Pockemon(51, 51, 51);
            Pockemon p2 = new Pockemon(52, 52, 52);

            p.Upgrade(1, 1, 1);
            Assert.AreEqual(p, p1);

            Pockemon.Upgrade(p, 1, 1, 1);
            Assert.AreEqual(p, p2);
        }

        [TestMethod]
        public void TestPockemonArrayConstraktors()
        {
            PockemonArray array = new PockemonArray();
            PockemonArray array1 = new PockemonArray(5);

            PockemonArray array2 = new PockemonArray(array);

            Assert.AreEqual(array.Length, 5);
            Assert.AreEqual(1, array.N);
            Assert.AreEqual(5, array1.Length);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], array2[i]);
            }

        }

        [TestMethod]
        public void TestPockemonUn()
        {
            Pockemon p = new Pockemon(50, 50, 50);

            Assert.AreEqual(250, ~p);
        }

        [TestMethod]
        public void TestPockemonUn1()
        {
            Pockemon p = new Pockemon(50, 50, 50);

            --p;

            Assert.AreEqual(p.STA, 49);
        }

        [TestMethod]
        public void TestPockemonSum()
        {
            Pockemon p = new Pockemon(50, 50, 50);

            Assert.AreEqual(150, (int)p);
        }

        [TestMethod]
        public void TestPockemonDouble()
        {
            Pockemon p = new Pockemon(50, 50, 50);

            Assert.AreEqual(50.00, p/1);
        }
        [TestMethod]
        public void TestPockemonBin()
        {
            Pockemon p = new Pockemon(50, 50, 50);

            p = p >> 5;
            
            Assert.AreEqual(p.STA, 55);
        }
        [TestMethod]
        public void TestPockemonBin1()
        {
            Pockemon p = new Pockemon(50, 50, 50);

            p = p > 5;

            Assert.AreEqual(p.DEF, 55);
        }

        [TestMethod]
        public void TestPockemonBin2()
        {
            Pockemon p = new Pockemon(50, 50, 50);

            p = p < 5;

            Assert.AreEqual(p.ATK, 55);
        }
        [TestMethod]
        public void TestPockemonArrayIndex()
        {
            PockemonArray arr = new PockemonArray();
            Pockemon p = new Pockemon(50,50,50);

            try
            {
                arr[6].ATK = 50;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                arr[10].Show();
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            arr[2].ATK = 50;

            arr[4] = p;

            try
            {
                arr[6] = p;
            }
            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Assert.AreEqual(arr[2].ATK, 50);
            Assert.AreEqual(p, arr[4]);
        }

        [TestMethod]
        public void TestPockemonArrayMode() 
        {
            PockemonArray arr = new PockemonArray();

            Assert.AreEqual(1, arr.Mode());
        }

        

        
    }
}