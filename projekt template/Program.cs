namespace Project
{
    class Program
    {
        public static void Analyze(string textToTest)
        {

            Console.WriteLine("Test text: " + textToTest + "\n");

            StringAnalysis testString = new StringAnalysis(textToTest);
                        
            //Výpis počtu slov
            Console.WriteLine("Word count: " + testString.CountWords());

            //Výpis počtu riadkov
            Console.WriteLine("Line count: " + testString.CountLines());

            //Výpis počtu viet
            Console.WriteLine("Sentence count: " + testString.CountSentences() + "\n");

            int n = 3;
            bool run = true;

            while (run)
            {

                Console.Write("Input number of words that you want to print: ");
                int temp = Convert.ToInt32(Console.ReadLine());

                if (temp > 0)
                {
                    n = temp;
                    run = false;
                }
                else
                {
                    Console.WriteLine("Error: Number must be greater than 0!");
                }
            }

            //Výpis 3 najdlhších slov
            Console.Write(n + " longest words: ");

            foreach (var word in testString.LongestWords().Take(n))
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine();


            //Výpis 3 najkretších slov
            Console.Write(n + " shortest words: ");
            foreach (var word in testString.ShortestWords().Take(n))
            {
                Console.Write(word + ", ");
            }
            Console.WriteLine("\n");


            //Výpis najčastejšieho slova
            Console.Write("Most common word: ");
            foreach (var word in testString.MostOftenWords())
            {
                Console.Write(word);
            }
            Console.WriteLine("");


            //Výpis abecedne zoradených slov
            Console.Write("Alphabetically ordered text: ");
            foreach (var word in testString.sortABC())
            {
                Console.Write(word + ", ");
            }

            Console.WriteLine("\n\n");
            Console.WriteLine(testString.getText());
            Console.WriteLine("\n\n");
            Console.WriteLine(testString.getTextNoPunctuation());
            

        }

        static void Main(string[] args)
        {

            Console.WriteLine("Dostupne súbory:\n");

            foreach (var path in Directory.GetFiles(@"C:/Users/David/Moje veci/Documents/OOP/projekt template/stringArchive/"))
            {
                //Console.WriteLine(path); // full path
                Console.WriteLine(System.IO.Path.GetFileName(path)); // file name
            }



            string fileToAnalyze = "C:/Users/David/Moje veci/Documents/OOP/projekt template/stringArchive/"+Console.ReadLine()+".txt";

            string testString = File.ReadAllText(fileToAnalyze);
			
            Analyze(testString);
                        


        }
    }
}
