using System;

namespace EnumIndexerExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework

            //foreach (int item in CustomSort())
            //{
            //    Console.Write(item + " ");
            //}

            //foreach (Person item in CustomSort2())
            //{
            //    //Console.WriteLine($"{item.FullName} {item.Age}");
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Nullable type

            //int? id = 10;
            ////id = null;

            //if (id == null)
            //{
            //    Console.WriteLine("Butun elanlar");
            //}
            //else
            //{
            //    Console.WriteLine($"{id}-li elan");
            //}

            //bool? isAdmin = false;
            //isAdmin = null;

            #endregion

            #region Enum

            //int a = 2;
            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    default:
            //        break;
            //}

            //WeekDay a = WeekDay.Tuesday;
            //Console.WriteLine(a.ToString());
            //Console.WriteLine(a);
            //Console.WriteLine((int)a);
            //switch (a)
            //{
            //    case WeekDay.Monday:
            //        Console.WriteLine("Monday");
            //        break;
            //    case WeekDay.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case WeekDay.Wednesday:
            //        break;
            //    case WeekDay.Thursday:
            //        break;
            //    case WeekDay.Friday:
            //        break;
            //    case WeekDay.Saturday:
            //        break;
            //    case WeekDay.Sunday:
            //        break;
            //    default:
            //        break;
            //}

            //foreach (var item in figures)
            //{
            //    //if (item.Type == "circlee")
            //    //{
            //    //    item.CalculateArea();
            //    //}
            //    if (item.Type == FigureEnum.circle)
            //    {
            //        item.CalculateArea();
            //    }
            //}

            //ErrorCode code = ErrorCode.NotFound;
            //if (code == ErrorCode.NotFound)
            ////if (code == "Not Found")
            //{
            //    Console.WriteLine("404 - NotFound");
            //}

            #endregion

            #region Indexer

            //string word = "Hello";
            //word[0] = "";
            //Console.WriteLine(word[0]);

            //Book b1 = new Book("Sefiller", 25);
            //Book b2 = new Book("Ali & Nino", 30);

            //Library library1 = new Library("Libraff");
            //library1[0] = b1;
            //library1[1] = b2;
            //Console.WriteLine(library1[0]);
            //Console.WriteLine(library1[100]);

            #endregion

            #region Struct - value type

            //int a = 10;
            //Area a1 = new Area();
            //Console.WriteLine(a1);
            //Area a2;
            //a2.Length = 10;
            //Console.WriteLine(a2.Length);
            //a2.Height = 10;
            //Console.WriteLine(a2.Height);

            #endregion

            #region Extensions

            //string word = "hello";
            ////Console.WriteLine(Extensions.IsFirstCharUpper(word)); 
            //Console.WriteLine(word.IsFirstCharUpper());

            //double a = 10;
            //Console.WriteLine(a.GetPower(5));

            #endregion
        }

        #region Homework

        public static int[] CustomSort()
        {
            int[] arr = { 55, 23, 17, 1, 2, 4, 8, 9, 4 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr;
        }

        public static Person[] CustomSort2()
        {
            Person[] people =
            {
                new Person("Parviz Asadov", 20),
                new Person("Aziz Shirinov", 24),
                new Person("Ilkin Bayramov", 22),
            };

            for (int i = 0; i < people.Length - 1; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] > people[j])
                    {
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }

            return people;
        }

        #endregion
    }

    //value typedir
    //parametrless constructor override olunmur
    //property ve field-ler ctor-da set olmalidir
    //inheritance ala bilmir

    interface ITest
    {

    }

    struct Test
    {

    }

    struct Area : ITest
    {
        public int Length { get; set; }

        public int Width { get; set; }

        public int Height;

        public string Test;

        public Area(int width, int length)
        {
            Length = 10;
            Width = width;
            Height = 10;
            Test = "";
        }
    }

    class Library
    {
        public string Name { get; set; }

        private Book[] _books;

        public Library(string name)
        {
            Name = name;
            _books = new Book[100];
        }

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
            set
            {
                _books[index] = value;
            }
        }
    }

    class Book
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " " + Price + " AZN";
        }
    }

    enum WeekDay : int
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum ErrorCode
    {
        BadRequest = 401,
        NotFound = 404,
        InternalServerError = 500,
    }

    class Person
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public static bool operator >(Person p1, Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }

        public override string ToString()
        {
            return $"{FullName} {Age}";
        }
    }
}
