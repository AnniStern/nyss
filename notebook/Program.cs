using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;

namespace notebook
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = new string[100];
            string[] array1 = new string[100];

            Console.WriteLine("ТЕЛЕФОННАЯ КНИЖКА \n");

        workСycle:
            
            Console.WriteLine("Выберите номер из меню и введите его, чтобы совершить какое-либо действие \n");
            Console.WriteLine("МЕНЮ:");
            Console.WriteLine("1 - Добавить запись");
            Console.WriteLine("2 - Показать все записи");
            Console.WriteLine("3 - Удалить запись");
            Console.WriteLine("4 - Редактирование записи");
            Console.WriteLine("5 - Краткая информация");
            
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("СОЗДАНИЕ НОВОЙ ЗАПИСИ");
                    Console.Write("Введите фамилию: ");
                    string s1 = Console.ReadLine();
                    Console.Write("Введите имя: ");
                    string s2 = Console.ReadLine();
                    Console.Write("Введите отчество(при наличии): ");
                    string s3 = Console.ReadLine();
                    Console.Write("Введите номер телефона: ");
                    string s4 = Console.ReadLine();
                    Console.Write("Введите дату рождения: ");
                    string s5 = Console.ReadLine();
                    Console.Write("Введите страну: ");
                    string s6 = Console.ReadLine();
                    Console.Write("Введите организацию: ");
                    string s7 = Console.ReadLine();
                    Console.Write("Введите должность: ");
                    string s8 = Console.ReadLine();
                    Console.Write("Прочие заметки: ");
                    string s9 = Console.ReadLine();
                    Note note = new Note(s1, s2, s3, s4, s5, s6, s7, s8, s9);
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] == null)
                        {

                            array[i] = "Запись № " + (i + 1) + "\n" + Convert.ToString(note);
                            array1[i] = "Запись № " + Convert.ToString(i + 1) + "\n" + "Имя: " + s2 + "\nФамилия: " + s1 + "\nТелефон: " + s4;
                            break;
                        }
                    }
                    goto workСycle;
                    

                case 2:
                    
                    int k = 0;
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] == null)
                        {
                            k++;
                        }
                    }
                    if (k == array.Length - 1)
                    { Console.WriteLine("Записная книжка пока пуста.."); 
                        goto workСycle; 
                    }
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] != null)
                        {
                            Console.WriteLine(array[i]);
                            
                        }
                    }
                    goto workСycle;


                case 3:
                    Console.WriteLine("Введите запись, которую хотите удалить!");
                    int N = Convert.ToInt32(Console.ReadLine());
                    array[N-1] = null;
                    array1[N-1] = null;
                    goto workСycle;

                case 4:
                    Console.WriteLine("Введите номер записи для редактирования");
                    int g = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите фамилию: ");
                    s1 = Console.ReadLine();
                    Console.Write("Введите имя: ");
                    s2 = Console.ReadLine();
                    Console.Write("Введите отчество(при наличии): ");
                    s3 = Console.ReadLine();
                    Console.Write("Введите телефон: ");
                    s4 = Console.ReadLine();
                    Console.Write("Введите дату рождения: ");
                    s5 = Console.ReadLine();
                    Console.Write("Введите страну: ");
                    s6 = Console.ReadLine();
                    Console.Write("Введите организацию: ");
                    s7 = Console.ReadLine();
                    Console.Write("Введите должность: ");
                    s8 = Console.ReadLine();
                    Console.Write("Введите другое: ");
                    s9 = Console.ReadLine();
                    Note note1 = new Note(s1, s2, s3, s4, s5, s6, s7, s8, s9); ;
                    array[g-1] = "Запись № " + g + "\n" + Convert.ToString(note1);
                    goto workСycle;

                case 5:
                    int k1 = 0;
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] == null)
                        {
                            k1++;
                        }
                    }
                    if (k1 == array.Length - 1)
                    { Console.WriteLine("Записная книжка пока пуста.."); goto workСycle; }

                    for (int i = 0; i < array1.Length - 1; i++)
                    {
                        if (array1[i] != null)
                        {
                            Console.WriteLine(array1[i]);
                            
                        }
                    }
                    goto workСycle;
                default:
                    Console.WriteLine("Под таким номером нет ничего... Выберете имеющийся пункт меню");
                    goto workСycle;
            }


        }
        class Note
        {
            public string name;
            public string surname;
            public string patronymic = "-";
            public string numberPhone;
            public string country = "-";
            public string data = "-";
            public string organization = "-";
            public string post = "-";
            public string notes = "-";


            public Note(string surname, string name, string patronymic, string numberPhone, string data, string country, string organization, string post, string notes)
            {
                this.name = name;
                this.surname = surname;
                this.patronymic = patronymic;
                this.numberPhone = numberPhone;
                this.country = country;
                this.data = data;
                this.organization = organization;
                this.post = post;
                this.notes = notes;
            }

          

            public override string ToString()
            {
                return "Фамилия: " + surname + "\nИмя: " + this.name + "\nОтчество: " + patronymic + "\nНомер телефона: " + numberPhone + "\nДата рождения:" + this.data + "\nСтрана: " + country + "\nОрганизация: " + organization + "\nДолжность: " + post + "\nПрочие заметки: " + notes;
            }

        }
        
    }
}
