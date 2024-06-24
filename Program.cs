namespace Assignment7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "amazon";
            string output = ReverseVowels(input);


            Console.WriteLine(output);
        }

        static Boolean isVowel(char c)
        {
            return (c == 'a' || c == 'A' || c == 'e' 
                    || c == 'E' || c == 'i' || c == 'I' 
                    || c == 'o' || c == 'O' || c == 'u'
                    || c == 'U');
        }

        static string ReverseVowels(string input)
        {
            string output = "";

            int i = 0;
            int j = input.Length - 1;
            char[] str1 = input.ToCharArray();

            while (i < j)
            {
                if (!isVowel(str1[i]))
                {
                    i++;
                    continue;
                }

                if (!isVowel(str1[j]))
                {
                    j--;
                    continue;
                }

                char temp = str1[i];
                str1[i] = str1[j];
                str1[j] = temp;

                i++;
                j--;

            }
            String str2 = String.Join("", str1);
            return str2;
          

            
        }
    }
}
