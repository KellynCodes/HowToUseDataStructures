using HowTouseDataStructures;

namespace HowToUseDataStructures
{
    internal class Indexing
    {
        List<User> users = new List<User>();

        public int _one;
        public int _two;
        public Indexing(int one, int tow)
        {
            _one = one;
            _two = _two;
        }

        public void DisplayUserByIndex()
        {
            users = new List<User>()
            {
                new User(1, "UpKing", 30, "Lagos State"),
                new User(2, "DownKing", 40, "Anambra")
            };

            Console.WriteLine(users[0].Id);
            Console.WriteLine(users[0].Name);
            Console.WriteLine(users[0].Age);
            Console.WriteLine(users[0].Address);
            Console.WriteLine("=================================");

            var result = users.OrderBy(user => user.Name);
            foreach(var item in result)
            {
                Console.WriteLine(item.Name);
            }

            List<int> ints = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        }
    }

    class DifferentDataStructures

    {
        public Dictionary<int, string> user = new Dictionary<int, string>();

        public void UsingDictionary()
        {
        start: try
            {
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                user.Add(1, "Kelly");
                user.Add(2, "Nelson");

                foreach (var item in user)
                {
                    Console.Write($"{item.Key}  {item.Value} ");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto start;
            }
        }

        public static void UsingStack()

        {
            Stack<string> strings = new();

            strings.Push("NElson");
            strings.Push("Chigozie");
            strings.Push("KEllY");

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            strings.Pop();
            Console.WriteLine("============================");
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public static void UsingQueue()
        {
            Queue<string> strings = new();
            strings.Enqueue("Kelechi");
            strings.Enqueue("Nelson");
            strings.Enqueue("Chigozie");
            strings.Enqueue("Chizoba");
            strings.Enqueue("Joshua");

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============================");
            strings.Dequeue();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
