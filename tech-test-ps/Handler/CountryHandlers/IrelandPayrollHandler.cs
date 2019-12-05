using System.Text;

namespace tech_test_ps
{
    public class IrelandPayrollHandler : CountryPayRollHandler
    {
        public IrelandPayrollHandler(AppContext appcontext) : base(appcontext)
        {
        }

        public override IPayRollCountry SetCountryPayRoll()
        {
            if(Context.UserInput.EmployeesLocation == Countries.ireland.ToString())
            {
              return  new IrelandPayroll(Context);
            }
            else
            {
                Context.PayRollState.Next().SetCountryPayRoll();
            }

            return null;
        }
    }

}
    


