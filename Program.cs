namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir cümle giriniz");
            string Input = Console.ReadLine();
            Reverse(Input);

        }

        static void Reverse(string Input) 
        { 
            char[] split = { ' ' };
            string[] splitting = Input.Split(split);

            for(int i=0; i <splitting.Length; i++) 
            { 
                
                    char[] charArray = splitting[i].ToCharArray(); 
                    char yedek = charArray[0];
                    charArray[0] = charArray[charArray.Length - 1];
                    charArray[charArray.Length - 1] = yedek;
                    string reversedString = string.Concat(charArray);
                    System.Console.Write(reversedString + " ");
            }
        }        
 
    }
}
