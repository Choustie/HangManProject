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

            while (lifeLeft > 0 && dislplayString.ToString() != secretWord)
            {
                Console.WriteLine("Skriv bokstav");
                var input = Console.ReadLine();

                Console.Clear();

                char letter = input[0];

                var hit = false;

                for (int i = 0; i<secretWord.Length; i++)
                {
                    if (letter == secretWord[i])
                    {
                        hit = true;
                    }
                }

                if (hit)
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if(letter == secretWord[i])
                        {
                            Console.WriteLine("correct");
                            dislplayString[i]=secretWord[i];
                        }
                    }
                }

                else
                {
                    lifeLeft--;
                    Console.WriteLine("fail");
                }
                Console.WriteLine(dislplayString);
            }

            if (lifeLeft == 0)
            {
                Console.WriteLine("boohoo");
            }
            else
            {
                Console.WriteLine("hurray");
            }
        }
    }
}
  //Console.WriteLine(Console.ReadLine());
            //jello!!