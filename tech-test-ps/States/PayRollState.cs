using System.Collections.Generic;

namespace tech_test_ps
{
    public abstract class CountryPayRollHandler
    {
        protected AppContext Context { get; set; }
        private List<CountryPayRollHandler> Chain { get; set; }
        protected CountryPayRollHandler Sucessor { get; set; }
        private static int Index { get; set; }

        protected CountryPayRollHandler(AppContext appcontext)
        {
            Context = appcontext;
        }
        public static CountryPayRollHandler SetUpChain(List<CountryPayRollHandler> list)
        {
            int last = list.Count - 1;
            for (int i = 0; i < list.Count - 1; i++)
            {
                list[i].Sucessor = list[+i];
            }

            list[0].Chain = list;
            Index = 1;
            return list[0];
        }
        public CountryPayRollHandler Next(bool loop = true)
        {
            var handler = Chain[Index];
            ++Index;

            if (loop)
                Index %= Chain.Count;

            return handler;
        }
        public abstract IPayRollCountry SetCountryPayRoll();
    }

}
    


