using System;

namespace _5_6_Final_Project
{
    internal class Program
    {
        static string[] GreateArrayPets(int num)
        {
            var result = new string[num];   

            return result;
        }
        static bool CheckNum(string input, out int number)
        {
            if (int.TryParse(input, out int intnum))
            {
                if (intnum > 0)
                {
                    Console.WriteLine("Преобразование прошло успешно.");
                    number = intnum;

                    return true;
                }
            }
            {
                Console.WriteLine("Преобразование завершилось неудачно.");
                number = 0;

                return false;
            }
        }
        static (string Name, string LastName, int Age) EnterUser()
        {
            (string Name, string LastName, int Age) User;

            Console.Write("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            User.LastName = Console.ReadLine();

            string age;
            int intage;

            do
            {
                Console.Write("Введите возраст цифрами: ");
                age = Console.ReadLine();

            } while (!CheckNum(age, out intage));

            User.Age = intage;

            return User;
        }

        static (int NumberPets, string[] NamePet) EnterPet()
        {
            (int NumberPets, string[] NamePet) Pet;

            Console.Write("Есть ли у вас питомец? да или нет: ");

            string StrPet = Console.ReadLine();
            string numpet;

            if (StrPet == "да")
            {
                do
                {
                    Console.Write("Сколько у вас питомцев? ");
                    numpet = Console.ReadLine();
                } while (!CheckNum(numpet, out Pet.NumberPets));

                Pet.NamePet = GreateArrayPets(Pet.NumberPets);

                for (int i = 0; i < Pet.NamePet.Length; i++)
                {
                    Console.Write("Как зовут вашего {0} питомца: ", i + 1);
                    Pet.NamePet[i] = Console.ReadLine();
                }
            }
            else
            {
                Pet.NumberPets = 0;
                Pet.NamePet = GreateArrayPets(Pet.NumberPets);
            }
           
            return Pet;
        }
        static (int NumberColors, string[] NameColor) EnterColor()
        {
            (int NumberColors, string[] NameColor) Color;

            string numColor;

            do
            {
                Console.Write("Введите количество любимых цветов: ");
                numColor = Console.ReadLine();

            } while (!CheckNum(numColor, out Color.NumberColors));

            if(Color.NumberColors > 0)
            {
                Color.NameColor = GreateArrayPets(Color.NumberColors);

                for (int i = 0; i < Color.NameColor.Length; i++)
                {
                    Console.Write("Введите название {0} любимого цвета: ", i + 1);
                    Color.NameColor[i] = Console.ReadLine();
                }
            }
            else
            {
                Color.NameColor = GreateArrayPets(Color.NumberColors);
            }

            return Color;
        }
        static void Data()
        {
            var UserTuple = EnterUser();
            var PetTuple = EnterPet();
            var ColorTuple = EnterColor();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Имя: " + UserTuple.Item1);
            Console.WriteLine("Фамилия: " + UserTuple.Item2);
            Console.WriteLine("Возраст: " + UserTuple.Item3);

            
            Console.WriteLine("Количество питомцев: " + PetTuple.Item1);

            for (int i = 0; i < PetTuple.Item2.Length; i++)
            {
                Console.WriteLine("Имя {0} питомца: {1}", i + 1, PetTuple.Item2[i]);
            }

            Console.WriteLine("Количество любимых цветов: " + ColorTuple.Item1);

            for (int i = 0; i < ColorTuple.Item2.Length; i++)
            {
                Console.WriteLine("Название {0] любимого цвета: {1}", i + 1, ColorTuple.Item2[i]);
            }
           
        }
        static void Main(string[] args)
        {

            Data();

            Console.ReadKey();
        }
    }
}
