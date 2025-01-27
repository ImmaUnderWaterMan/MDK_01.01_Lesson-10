namespace MDK_01._01_Lesson_10
{
    
    internal class Program
    {
        public interface ISelectable 
        {
            void OnSelect();
        }
        public interface IUpdatable
        {
            void Refresh();
        }

        class Screen : ISelectable, IUpdatable
        {
            public void OnSelect()
            {
                Console.WriteLine("Интерфейс выбран");
            }
            public void Refresh()
            {
                Console.WriteLine("Данные обнавленны");
            }
        }
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.OnSelect();
            screen.Refresh();
            Console.ReadKey();
        }
    }
}
