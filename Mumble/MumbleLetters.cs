using System.Linq;

namespace Mumble
{
    public class MumbleLetters
    {
        public string mumble_letters(string lettersProvided)
        {
            string mumbledLetters = "";

            if (lettersProvided == "")
            {
                return lettersProvided;
            }

            //mumbledLetters = lettersProvided.ToUpper();

            foreach(char c in lettersProvided)
            {
                int noOfLetters = lettersProvided.IndexOf(c);
                int counter = 0;

                for (int i = 0; i <= noOfLetters; i++)
                {
                    if (i == 0)
                    {
                        mumbledLetters = mumbledLetters + c.ToString().ToUpper();
                        counter++;
                    }
                    else
                    {
                        mumbledLetters = mumbledLetters + c.ToString().ToLower();
                        counter++;
                    }
                }
                if (counter < lettersProvided.Length) {
                    mumbledLetters = mumbledLetters + "-";
                }
            }

            return mumbledLetters;
        }
    }
}