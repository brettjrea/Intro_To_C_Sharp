public class Program
{
    public static void Main()
    {
        //attach input file location to variable
        string inputfile = System.IO.File.ReadAllText(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Input.txt"));
        //string str;
        int twrd, wrd, l;
        

        //have str consume the input file
        string str = inputfile;

        l = 1;
        wrd = 1;
        twrd = 0;


        //loop till end of string 
        while (l <= str.Length - 1)      
        {

            //Counting total words *without* the t and e condition by looking for spaces, punctuation marks, and carriage returns. 
            if ((str[l] == '.' || str[l] == ' ' || str[l] == '\t' || str[l] == ',' || str[l] == '?' || str[l] == '\n'))
            {
                twrd++;
            }

            //Exclamation marks where returning a 2 count so needed to mnaually set to 1.
            else if ((str[l] == '!'))
            {
                _ = twrd + 1;
            }

            //Counting total words *with* the t and e condition by looking for spaces, punctuation marks, and carriage returns. 
            if ((str[l] == '.' || str[l] == ' ' || str[l] == '\t' || str[l] == ',' || str[l] == '?' || str[l] == '\n') && (str[l - 1] == 't' || str[l - 1] == 'e'))
            {
                wrd++;
            }

            //Exclamation marks where returning a 2 count so needed to mnaually set to 1.
            else if ((str[l] == '!') && (str[l - 1] == 't' || str[l - 1] == 'e'))
            {
                _ = wrd + 1;
            }

            //Total characters traversed.
            l++;
        }

        //Write to console.
        Console.Write("Read file results:\nThere are {0} total characters.\nMaking {1} total words.\nThat have {2} words ending in t or e.\n\n\n", l , twrd, wrd);
    }
}