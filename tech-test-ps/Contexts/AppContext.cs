using System.Collections.Generic;

namespace tech_test_ps
{
    public class AppContext
    {
        Deductions Deductions { get; }
        public UserInput UserInput { get; }
        public Display Display { get; }
        public FlowHandler FlowHandler { get; }
        public PayRollState PayRollState { get; }

        public AppContext()
        {
            UserInput = new UserInput();
            FlowHandler = FlowHandler
            .SetUpChain(new List<FlowHandler>()
            {
                new FineHandler(this, new UserInterpret()),
                new ErrorHandler(this)
            });

            Display = new Display(new ConsoleWrapper());
            PayRollState = new IrelandPayrollState(this);
        }

        public void Initialize()
        {
            FlowHandler.Process();
        }

      
    }

}
    


