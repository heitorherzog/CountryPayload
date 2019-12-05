namespace tech_test_ps
{
    public class ErrorHandler : FlowHandler
    {
        public ErrorHandler(AppContext appcontext) : base(appcontext)
        {
        }

        public override void Process()
        {
            Context.Display.Clear();
            Context.Display.ShowLine("Please insert valid values");
            Context.Display.ShowLinePromptAnyKey("Press any key to try again");
            HandleRequest();
        }

        protected override void HandleRequest()
        {
            Context.FlowHandler.Next().Process();
        }

        protected override void HandleResponse()
        {
            throw new System.NotImplementedException();
        }
    }

}
    


