using System;
using System.Globalization;
using System.Text;

namespace tech_test_ps
{
    public class FineHandler : FlowHandler
    {
        private Deductions Deductions { get; set; }
        public FineHandler(AppContext appcontext, Expression expression) : base(appcontext, expression)
        {
        }

        public override void Process()
        {
            Context.Display.Clear();
            Context.UserInput.StrHoursWorked = Context.Display.ShowLinePrompt("Please enter the hours worked: ");
            Context.UserInput.StrHoursRate = Context.Display.ShowLinePrompt("Please enter the hourly rate: ");
            Context.UserInput.EmployeesLocation = Context.Display.ShowLinePrompt("Please enter the employee’s location: ");

            HandleRequest();
        }

        protected override void HandleRequest()
        {
            Expression.Interpret(Context);

            if (Expression.isValid)
            {
               var payrollrule = Context.PayRollState.SetCountryPayRoll();
                HandleOutPut(payrollrule?.ComputeTaxes());

                Context.FlowHandler.Process();
            }
            else
            {
                Context.FlowHandler.Next().Process();
            }  
        }

        protected override void HandleResponse()
        {
            var culture = new CultureInfo("en-IE", true);
            var b = new StringBuilder();
            b.AppendFormat("Employee location: {0}{1}", Deductions.Employeelocation, Environment.NewLine);
            b.AppendFormat(culture,"Gross Amount: {0:C}{1}", Deductions.GrossAmount, Environment.NewLine);
            b.AppendLine("Less deductions");
            b.AppendFormat(culture, "Income Tax: {0:C}{1}", Deductions.IncomeTax, Environment.NewLine);
            b.AppendFormat(culture,"Universal Social Charge: {0:C}{1}", Deductions.UniversalSocialCharge, Environment.NewLine);
            b.AppendFormat(culture, "Pension: {0:C}{1}", Deductions.Pension, Environment.NewLine);
            b.AppendFormat(culture, "Net Amount: {0:C}{1}", Deductions.NetAmount, Environment.NewLine);

            Context.Display.Clear();
            Context.Display.ShowLinePromptAnyKey(b.ToString());
        }

        private void HandleOutPut(Deductions deductions)
        {
            Deductions = deductions;
            HandleResponse();
        }

       
    }

}
    


