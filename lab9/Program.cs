namespace lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pockemon p = new Pockemon(50,50,50);            
            p.Show();

            Pockemon p1 = new Pockemon();
            p1.Show();

            Pockemon p2 = new Pockemon(p);
            p2.Show();

            Pockemon.ShowCount();

            Console.WriteLine($"\n----------------\n ");

            try
            {
                Pockemon.Upgrade(p, 100, 100, -1000);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            p.Show();

            p1.Upgrade(10, 10, 10);
            p1.Show();

            Console.WriteLine($"\n----------------\n ");
            
            Pockemon p3 = new Pockemon();
            Pockemon p4 = p3 >> 1;
            Pockemon p5 = p3 > 1;
            Pockemon p6 = p3 < 1;

            p3.Show();
            p4.Show();
            p5.Show();
            p6.Show();
            Console.WriteLine("");
            int a = (int)p3;
            Console.WriteLine($"{p3/1}    {a}");

            Console.WriteLine($"\n----------------\n ");

            PockemonArray arr = new PockemonArray(5);
            arr.Show();

            PockemonArray arr1 = new PockemonArray(arr);

            PockemonArray arr2 = new PockemonArray(false);
            //arr1[0] = arr1[0] >> 1;
            //arr.Show();
            //arr1.Show();
            arr2.Show();

            

            Console.WriteLine(arr.Mode());

            arr[3].STA = 231;
            arr[4].STA = 231;
            arr.Show();

            Console.WriteLine(arr.Mode());


        }
    }
}