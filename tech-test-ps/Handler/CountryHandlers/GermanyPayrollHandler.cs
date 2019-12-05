namespace tech_test_ps
{
    public class GermanyPayrollHandler : CountryPayRollHandler
    {
        public GermanyPayrollHandler(AppContext appcontext) : base(appcontext)
        {
        }

        public override IPayRollCountry SetCountryPayRoll()
        {
            Context.Display.ShowLinePromptAnyKey("Not Implemented");
            Context.FlowHandler.Process();
            return null;
        }
    }

}
    


