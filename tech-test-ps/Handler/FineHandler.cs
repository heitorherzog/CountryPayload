using System.Collections.Generic;
namespace tech_test_ps
{
    public class FineHandler : FlowHandler
    {
        public FineHandler(AppContext appcontext, Expression expression) : base(appcontext, expression)
        {
        }

        public override void Process()
        {
            //context.Display.Clear();
            //context.UserInput.HoursWorked = context.Display.ShowLinePrompt("Please enter the hours worked: ");
            //context.UserInput.HoursRate = context.Display.ShowLinePrompt("Please enter the hourly rate: ");
            //context.UserInput.EmployeesLocation = context.Display.ShowLinePrompt("Please enter the employee’s location: ");

            HandleRequest();
        }

        protected override void HandleRequest()
        {
            //expression.Interpret(context);

            //if (expression.isValid)
            //{
            //    context.PayRollState.SetValidCountryPayRoll();
            //}
            //else
            //{
               
            //}

            context.FlowHandler.Next().Process();
        }
    }

}
    


