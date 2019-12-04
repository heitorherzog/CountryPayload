namespace tech_test_ps
{
    public class GermanyPayrollState : PayRollState
    {
        public GermanyPayrollState(AppContext appcontext) : base(appcontext)
        {
        }

        public override void SetValidCountryPayRoll()
        {
            if (_context.UserInput.EmployeesLocation == Country.germany.ToString())
            {

            }
            else
            {
               
            }
        }
    }

}
    


