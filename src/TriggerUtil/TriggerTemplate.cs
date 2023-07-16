﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerUtil
{
    public class TriggerTemplate
    {

        public TriggerTemplate() {
            Context = new TriggerContext();
        }

        protected TriggerContext Context { get; set; }

        protected virtual void Process()
        {
            
        }

        private bool _hasBuilt = false;

        public bool Build(string path)
        {
            if (!_hasBuilt) 
            {
                _hasBuilt = true;
                Process();
            }
            
            return Context.Compile(path);
        }
    }


}