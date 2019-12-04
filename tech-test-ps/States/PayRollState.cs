namespace tech_test_ps
{
    public abstract class PayRollState
    {
        protected AppContext _context;
        protected IPayRollCountryState CountryState { get; set; }
        protected PayRollState _sucessor;

        protected PayRollState(AppContext appcontext)
        {
            _context = appcontext;
        }
        public void SetSuccessor(PayRollState handler)
        {
            _sucessor = handler;
        }

        public abstract void SetValidCountryPayRoll();
    }

}
    


