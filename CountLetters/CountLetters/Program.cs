public class Program
{
    public static void Main()
    {
        //string str;
        int wrd, l;


        //str = Console.ReadLine();
        string str = System.IO.File.ReadAllText(Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, "Input.txt"));

        l = 1;
        wrd = 1;


        /* loop till end of string */
        while (l <= str.Length - 1)      
        {
            /* check whether the current character is white space or new line or tab character*/
            if ((str[l] == '.' || str[l] == ' ' || str[l] == '\t' || str[l] == ',' || str[l] == '?' || str[l] == '\n') && (str[l - 1] == 't' || str[l - 1] == 'e'))
            {
                wrd++;
            }
            else if ((str[l] == '!') && (str[l - 1] == 't' || str[l - 1] == 'e'))
            {
                _ = wrd + 1;
            }
            l++;
        }

        Console.Write("There are {0} words ending in t or e", wrd);
    }
}