using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HydraTouch
{
    class Controller : HydraPluginGlobal
    {

        //private readonly HydraPlugin Hydra;
        //private readonly int Index;

        public event EventHandler DockedChanged;

        public delegate void EventHandler(Controller c, EventArgs e);



        public Controller(int index, HydraPlugin plugin) : base (index, plugin)
        {
            //Hydra = plugin;
            //Index = index;


        }

        public bool Docked
        {
            get
            {
                return this.docked;
            }
            protected set
            {
                if (this.docked != value)
                {
                    OnDockedChanged(EventArgs.Empty);
                }
            }
        }

        protected void OnDockedChanged(EventArgs e)
        {
            EventHandler handler = DockedChanged;
            if (handler != null)
                handler(this, e);
        }
    }
}
