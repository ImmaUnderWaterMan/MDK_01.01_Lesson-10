namespace MDK_01._01_Lesson_10_2
{
    internal class Program
    {
        public abstract class Translator
        {
            public abstract string GetLanguage();

            public string Translate()
            {
                return "Я переводчик с " + GetLanguage();
            }
        }

        public class EnglishTranslator : Translator
        {
            public override string GetLanguage()
            {
                return "английского";
            }
        }

        static void Main(string[] args)
        {
            EnglishTranslator englishTranslator = new EnglishTranslator();
            Console.WriteLine(englishTranslator.Translate());
            Console.ReadKey();
        }
    }
}
