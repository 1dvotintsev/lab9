namespace lab9
{
    public class Pockemon
    {
        int attack;
        int defense;
        int stamina;
        int num;
        private static int objectCount = 0;

        public int N
        {
            get => num;
            set => num = value;
        }
        public int ATK
        {
            get => attack;
            set
            {
                if (value < 17)
                {
                    attack = 17;
                    throw new Exception("The minimum value of attack has been reached");
 
                }
                else if (value > 414)
                {
                    attack = 414;
                    throw new Exception("The maximum value of attack has been reached");
                }
                else attack = value;
            }
        }

        public int DEF
        {
            get => defense;
            set
            {
                if (value < 32)
                {
                    defense = 32;
                    throw new Exception("The minimum value of defense has been reached");
                }
                else if (value > 396)
                {
                    defense = 396;
                    throw new Exception("The maximum value of defense has been reached");
                }
                else defense = value;
            }
        }

        public int STA
        {
            get => stamina;
            set
            {
                if (value < 1)
                {
                    stamina = 1;
                    throw new Exception("The minimum value of stamina has been reached");
                }
                else if (value > 496)
                {
                    stamina = 496;
                    throw new Exception("The maximum value of stamina has been reached");
                }
                else stamina = value;
            }
        }

        public Pockemon()
        {
            ATK = 17;
            DEF = 32;
            STA = 1;


            objectCount++;
            N = objectCount;
        }

        public Pockemon(int a, int d, int s)
        {
            ATK = a;
            DEF = d;
            STA = s;

            objectCount++;
            N = objectCount;
        }

        public Pockemon(Pockemon p)
        {
            this.ATK = p.ATK;
            this.DEF = p.DEF;
            this.STA = p.STA;

            objectCount++;
            N = objectCount;
        }

        public static void ShowCount()
        {
            Console.WriteLine($"{objectCount} покемонов создано");
        }


        public static void Upgrade (Pockemon p, int a = 0, int d =0, int s = 0)
        {
            p.ATK += a;
            p.DEF += d;
            p.STA += s;
        }

        public void Upgrade(int a = 0, int d = 0, int s = 0)
        {
            this.ATK += a;
            this.DEF += d;
            this.STA += s;
        }

        public static void Show(Pockemon p)
        {
            Console.WriteLine($"\nStatistic Pockemon #{p.N}:");
            Console.WriteLine($"Attack: {p.ATK}");
            Console.WriteLine($"Defense: {p.DEF}");
            Console.WriteLine($"Stamina: {p.STA}");
            Console.WriteLine($"CP: {~p}");
        }

        public void Show()
        {
            Console.WriteLine($"\nStatistic Pockemon #{this.N}:");
            Console.WriteLine($"Attack: {this.ATK}");
            Console.WriteLine($"Defense: {this.DEF}");
            Console.WriteLine($"Stamina: {this.STA}");
            Console.WriteLine($"CP: {~this}");
        }

        public static double operator ~( Pockemon p )
        {
            double sta = (double)p.STA;
            double def = (double)p.DEF;
            double atk = (double)p.ATK;
            
            double cp = Math.Round(Math.Sqrt(sta) * atk * Math.Sqrt(def) / 10, 2);

            return cp;
        }

        public static Pockemon operator --(Pockemon p)
        {
            Pockemon p2 = new Pockemon(p);
            p2.STA--;

            return p2;
        }

        public static explicit operator int(Pockemon p)
        {
            int sum = p.ATK + p.DEF +p.STA;

            return sum;
        }

        public static implicit operator double(Pockemon p)
        {
            int sum = p.ATK + p.DEF + p.STA;

            double av = (double)sum / 3;

            return Math.Round(av,2);
        }

        public static Pockemon operator >>(Pockemon p, int sta)
        {
            Pockemon p1 = new Pockemon(p.ATK, p.DEF, p.STA + sta);
            return p1;
        }

        public static Pockemon operator >(Pockemon p, int def)
        {
            Pockemon p1 = new Pockemon(p);
            p1.DEF+=def;
            return p1;
        }

        public static Pockemon operator <(Pockemon p, int atk)
        {
            Pockemon p1 = new Pockemon(p);
            p1.ATK += atk;
            return p1;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not Pockemon) return false;
            return ((Pockemon)obj).ATK == this.ATK && ((Pockemon)obj).DEF == this.DEF && ((Pockemon)obj).STA == this.STA;
        }
    }

}
