using System.Text;

namespace HangManProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Init HangMan");
            var lifeLeft = 5;
            var secretWord = "spel";
            StringBuilder dislplayString = new StringBuilder();

            for (int i = 0; i < secretWord.Length; i++)
            {
                dislplayString.Append('_');
            }

            Console.WriteLine(dislplayString.ToString());
            //Console.WriteLine(Console.ReadLine());
            //jello!!
        }
    }
}