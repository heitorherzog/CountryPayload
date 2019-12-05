using System.Collections.Generic;
using tech_test_ps.Payrolls;

namespace tech_test_ps
{
    public class AppContext
    {
        public UserInput UserInput { get; }
        public IDisplay Display { get; }
        public FlowHandler FlowHandler { get; }
        public CountryPayRollHandler PayRollState { get; }

        public AppContext(IDisplay display)
        {
            UserInput = new UserInput();
            Display = display;

            FlowHandler = FlowHandler
            .SetUpChain(new List<FlowHandler>()
            {
                new FineHandler(this, new UserInterpret()),
                new ErrorHandler(this)
            });

          
            PayRollState = CountryPayRollHandler
            .SetUpChain(new List<CountryPayRollHandler>()
            {
                new IrelandPayrollHandler(this),
                new GermanyPayrollHandler(this)
            });
        }

        public void Initialize()
        {
            FlowHandler.Process();
        }

      
    }

}
    


