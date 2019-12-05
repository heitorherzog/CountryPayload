using System;
using System.Collections.Generic;
using System.Text;

namespace tech_test_ps.Payrolls
{
    public class GermanyPayroll : CountryPayRollHandler, IPayRollCountry
    {
        public GermanyPayroll(AppContext appcontext) : base(appcontext)
        {
        }

        public Deductions ComputeTaxes()
        {
            throw new NotImplementedException();
        }

       
        public override IPayRollCountry SetCountryPayRoll()
        {
            throw new NotImplementedException();
        }
    }
}
