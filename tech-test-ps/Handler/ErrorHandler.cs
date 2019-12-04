namespace tech_test_ps
{
    public class ErrorHandler : FlowHandler
    {
        public ErrorHandler(AppContext appcontext) : base(appcontext)
        {
        }

        public override void Process()
        {
            context.Display.Clear();
            context.Display.ShowLine("Please insert valid values");
            context.Display.ShowLinePromptAnyKey("Press any key to try again");
            HandleRequest();
        }

        protected override void HandleRequest()
        {
            context.FlowHandler.Next().Process();
        }
    }

}
    


