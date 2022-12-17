using HowTouseDataStructures;

namespace HowToUseDataStructures
{
    internal class User
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Address { get; set; }
            public List<string> ExtraInfo { get; set; }

            public User(int id, string name, int age, string address)
            {
                Id = id;
                Name = name;
                Age = age;
                Address = address;
            }
        }
    class GetUserList
    {

        public void UserList()
        {
            HowToUseList howToUseList = new();


            howToUseList.userNames.Add(new User(1, "kelly", 4, "gra"));
            howToUseList.userNames.Add(new User(2, "Nelson", 5, "Emene"));
            howToUseList.userNames.Add(new User(3, "Dave", 6, "Old Park"));
            //Display users
            DisplayUser(howToUseList);
            //Removing user that match the id in this expression;
            var userRemove = howToUseList.userNames.FirstOrDefault(user => user.Id == 1);
            howToUseList.userNames.Remove(userRemove); // Removing user with remove method in list;
            Console.ReadLine();
            //display new users
            DisplayUser(howToUseList);

        }

        /*Functon that will display users to avoid repetition of codes*/
        public static void DisplayUser(HowToUseList userNames)
        {
            foreach (var item in userNames.userNames)
            {
                Console.WriteLine($"{item.Id}: {item.Name} is {item.Age} years old and live at {item.Address}");
            }
        }
    }
    }
