using System.Collections.Generic;
using System.Linq;

namespace tech_test_ps
{
    public abstract class FlowHandler
    {
        private List<FlowHandler> chain;
        protected FlowHandler successor;

        protected AppContext context;
        protected Expression expression;
        protected IPayRollCountryState countryState;

        private int index;
        private bool recursive;

        protected FlowHandler(AppContext appcontext, Expression exp = null)
        {
            context = appcontext;
            this.expression = exp;
        }
        public static FlowHandler SetUpChain(List<FlowHandler> list)
        {
            int last = list.Count - 1;
            for (int i = 0; i < list.Count -1 ; i++)
            {
                list[i].successor = list[+i];
            }

            return list[0];            
        }

        public  FlowHandler Next(bool loop = true)
        {
            var handler = chain[index];
            ++index;

            if(loop)
            index %= chain.Count;

            return handler;
        }

        protected abstract void HandleRequest();
        public abstract void Process();
        
    }
}

