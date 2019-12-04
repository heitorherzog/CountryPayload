namespace tech_test_ps
{
    public class IrelandPayrollState : PayRollState
    {
        public IrelandPayrollState(AppContext appcontext) : base(appcontext)
        {
        }

        public override void SetValidCountryPayRoll()
        {
            if(_context.UserInput.EmployeesLocation == Country.ireland.ToString())
            {
                CountryState = new IrelandPayroll();
                CountryState.ComputeTaxes();
            }
            else
            {
                _context.PayRollState.SetSuccessor(new GermanyPayrollState(_context));
                _sucessor.SetValidCountryPayRoll();
            }
        }
    }

}
    


