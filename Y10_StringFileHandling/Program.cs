using System.IO; //for file handling
namespace Y10_StringFileHandling
{
    internal class Program
    {
        static void StringHandling()
        {
            //Substrings
            string sample = "Hello World!";
            string sub = Convert.ToString(sample[6]); //can treat strings like arrays
            string sub2 = sample.Substring(6, 5); //first param is first index of substring, second param is length of string
            string sub3 = sample.Substring(6); //in substrings if you dont provide a second parameter, it will go up to the end of the string
            Console.WriteLine(sub2);

            //Splitting a string
            string words = "The quick brown fox jumps over the lazy dog.";
            string[] words_split = words.Split(); //first and only param is the 'character' that determines where the words should split (can leave blank and the breaking char will default to a space)
            foreach (string word in words_split)
            {
                Console.WriteLine(word);
            }
        }
        static void FileHandling()
        {
            StreamReader FileToRead = new StreamReader("//hgs-fs6/users$/students/22/22zkeyan/My Documents/MB A2S2 for cs.txt");
            Console.WriteLine(FileToRead.ReadToEnd()); //reads file from start to end
            Console.WriteLine(FileToRead.ReadLine()); //reads the first line
            FileToRead.Close(); //closes the current file so that when it's reopended it will start reading from the start of the text
            FileToRead = new StreamReader("//hgs-fs6/users$/students/22/22zkeyan/My Documents/MB A2S2 for cs.txt"); //same as line 25
            do
            {
                Console.WriteLine(FileToRead.ReadLine());
            } while (!FileToRead.EndOfStream); //continues until reaches end of file
        }
        static void Main(string[] args)
        {
            FileHandling();
        }
    }
}
