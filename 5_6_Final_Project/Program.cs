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

            Console.WriteLine("Есть ли у вас питомец? да или нет: ");

            string StrPet = Console.ReadLine();
            string pet;

            if (StrPet == "да")
            {
                do
                {
                    Console.WriteLine("Сколько у вас питомцев? ");
                    pet = Console.ReadLine();
                } while (!CheckNum(pet, out Pet.NumberPets));

                Pet.NamePet = GreateArrayPets(Pet.NumberPets);

                for (int i = 0; i < Pet.NamePet.Length; i++)
                {
                    Console.WriteLine("Как зовут вашего {0} питомца: ", i + 1);
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
        static void Main(string[] args)
        {
            EnterUser();
            EnterPet();
        }
    }
}
