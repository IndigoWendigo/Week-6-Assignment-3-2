namespace Week6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solutions.SolutionOne();
            Solutions.SolutionTwo();
        }

        public class Solutions
        {
            public static void SolutionOne()
            {
                var list = new List<String>();

                while (true)
                {
                    Console.WriteLine("Write a name:");
                    var input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                        break;
                    else
                        list.Add(input);

                }

                switch (list.Count)
                {
                    case 0:
                        Console.WriteLine("Nobody likes your post");
                        break;
                    case 1:
                        Console.WriteLine("{0} likes your post", list[0]);
                        break;
                    case 2:
                        Console.WriteLine("{0} and {1} liked your post", list[0], list[1]);
                        break;
                    default:
                        Console.WriteLine("{0} and {1} and {2} other people liked your post", list[0], list[1], (list.Count - 2));
                        break;
                }
            }
            public static void SolutionTwo()
            {
                Console.WriteLine("Enter a sentence: ");
                string sentence = Console.ReadLine();

                Dictionary<char,int> occurances = new Dictionary<char,int>();

                foreach (char ch in sentence.Replace(" ", string.Empty))
                {
                    if(occurances.ContainsKey(ch))
                    {
                        occurances[ch] = occurances[ch] + 1;
                    }
                    else
                    {
                        occurances.Add(ch, 1);
                    }
                }
                
                foreach(var item in occurances.Keys)
                {
                    Console.WriteLine(item + " | " + occurances[item]);
                }

                Console.ReadKey();
            }
        }
    }
}