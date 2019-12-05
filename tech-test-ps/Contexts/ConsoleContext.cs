namespace tech_test_ps
{
    public class ConsoleContext
    {
        private AppContext AppContext { get; }
        public ConsoleContext()
        {
            AppContext = new AppContext(new Display(new ConsoleWrapper()));
        }

        public void Start()
        {
            AppContext.Initialize();
        }
    }
}
    


