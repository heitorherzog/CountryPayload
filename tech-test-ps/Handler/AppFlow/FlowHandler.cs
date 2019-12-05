using System.Collections.Generic;
using System.Linq;

namespace tech_test_ps
{
    public abstract class FlowHandler
    {
        private List<FlowHandler> Chain{ get; set; }
        protected FlowHandler Successor { get; set; }
        protected AppContext Context { get; set; }
        protected Expression Expression { get; set; }
        private static int index { get; set; }

        protected FlowHandler(AppContext appcontext, Expression exp = null)
        {
            Context = appcontext;
            this.Expression = exp;
        }
        public static FlowHandler SetUpChain(List<FlowHandler> list)
        {
            int last = list.Count - 1;
            for (int i = 0; i < list.Count -1 ; i++)
            {
                list[i].Successor = list[+i];
            }

            list[0].Chain = list;
            index = 1;
            return list[0];            
        }

        public  FlowHandler Next(bool loop = true)
        {
            var handler = Chain[index];
            ++index;

            if(loop)
            index %= Chain.Count;

            return handler;
        }

        protected abstract void HandleRequest();
        protected abstract void HandleResponse();
        public abstract void Process();
        
    }
}

