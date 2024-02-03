using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9
{
    public class PockemonArray
    {
        string number = "Сколько покемонов создать в коолекции? ";
        string attackText = "Введите атаку покемона: ";
        string defenseText = "Введите защиту покемона: ";
        string staminaText = "Введите выносливость покемона: ";
        static int Input(int a, int b, string text)   //выбор действия из целых
        {
            Console.WriteLine(text);
            int answer = 0;
            bool checkAnswer;
            do
            {
                checkAnswer = int.TryParse(Console.ReadLine(), out answer);
                if ((answer > b || answer < a) || (!checkAnswer))
                {
                    Console.WriteLine("Вы некорректно ввели число, повторите ввод еще раз. Обратите внимание на то, что именно нужно ввести.");
                }
            } while ((answer > b || answer < a) || (!checkAnswer));

            return answer;
        }

        static Random rnd = new Random();
        Pockemon[] pockemons;
        int num;
        private static int count = 0;

        public int N
        {
            get => num;
            set => num = value;
        }

        public int Length
        {
            get => pockemons.Length;

        }
        public PockemonArray(bool way = true)
        {

            if (!way)
            {
                int length = Input(0, int.MaxValue, number);
                pockemons = new Pockemon[length];
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"Введите характеристики для покемона {i + 1}\n");
                    pockemons[i] = new Pockemon(Input(17, 414, attackText), Input(32, 396, defenseText), Input(1, 496, staminaText));
                }
            }
            else
            {
                pockemons = new Pockemon[5];
                for (int i = 0; i < 5; i++)
                {
                    pockemons[i] = new Pockemon();
                }
            }
            count++;
            N = count;
        }
        public PockemonArray(int length)
        {
            pockemons = new Pockemon[length];
            for (int i = 0; i < length; i++)
            {
                pockemons[i] = new Pockemon(rnd.Next(17,414),rnd.Next(32,396),rnd.Next(1,496));
            }
            count++;
            N = count;
        }
        public PockemonArray(PockemonArray other)
        {
            pockemons = new Pockemon[other.Length];
            for (int i = 0;i < other.Length;i++) 
            { 
                pockemons[i] = new Pockemon(other.pockemons[i]);
            }
            count++;
            N = count;
        }
        public void Show()
        {
            Console.WriteLine($"\nСостав коллекции #{this.N}");
            if (this.Length >= 1)
            {
                for (int i = 0; i < this.Length; i++)
                {
                    this.pockemons[i].Show();
                }
            }
            else
            {
                Console.WriteLine("Коллекция пуста");
            }
        }
        public int Mode()
        {
            int mode = 0;
            int maxCount = 0;

            for (int i = 0; i < this.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < this.Length; j++)
                {
                    if (pockemons[j].STA == pockemons[i].STA)
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    mode = pockemons[i].STA;
                }
            }

            return mode;
        }
        public Pockemon this[int index]
        {
            get
            {
                if (0 <= index && index < this.Length)
                    return pockemons[index];
                else
                    throw new Exception("Выход за границу массива");
            }
            set
            {
                if (0 <= index && index < this.Length) 
                    pockemons[index] = value;
                else
                    throw new Exception("Выход за границу массива");
            }
        }

    }
}
