namespace tech_test_ps
{
    public class ConsoleContext
    {
        private AppContext AppContext { get; }

        public ConsoleContext()
        {
            AppContext = new AppContext();
        }

        public void Start()
        {
            AppContext.Initialize();
        }
    }

}
    


