namespace MDK_01._01_Lesson_10_3
{
 
    public interface Button
    {
        void Paint();
    }
    public interface Checkbox
    {
        void Paint();
    }
    public class WinButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("Создание кнопки для Windows");
        }
    }
    public class MacButton : Button
    {
        public void Paint()
        {
            Console.WriteLine("Создание кнопки для Mac");
        }
    }
    public class WinCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("Создание Checkbox для Windows");
        }
    }

    public class MacCheckbox : Checkbox
    {
        public void Paint()
        {
            Console.WriteLine("Создание Checkbox для Windows Mac");
        }
    }
    public interface GUIFactory
    {
        Button CreateButton();
        Checkbox CreateCheckbox();
    }

    public class WinFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public Checkbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }
    public class MacFactory : GUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }
        public Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
    public class Application
    {
        private readonly Button button;
        private readonly Checkbox checkbox;

        public Application(GUIFactory factory)
        {
            button = factory.CreateButton();
            checkbox = factory.CreateCheckbox();
        }

        public void CreateUI()
        {
            button.Paint();
            checkbox.Paint();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GUIFactory factory;

            Console.WriteLine("Введите вашу ОС (Windows/Mac): ");
            string osType = Console.ReadLine().ToLower();

            if (osType == "windows")
            {
                factory = new WinFactory();
            }
            else if (osType == "mac")
            {
                factory = new MacFactory();
            }
            else
            {
                throw new Exception("Неподдерживаемая или не существующая ОС");
            }

            Application app = new Application(factory);
            app.CreateUI();
        }
    }
}
