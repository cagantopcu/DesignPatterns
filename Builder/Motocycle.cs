﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Motocycle
    {
        private IBrake _brake = null;
        private IEngine _engine = null;
        private ITyre _tyre = null;

        public Motocycle(MotocycleBuilder builder)
        {
            this._brake = builder.GetBrake();
            this._tyre = builder.GetTyre();
            this._engine = builder.GetEngine();
        }

        public IBrake GetBrake()
        {
            return this._brake;
        }

        public IEngine GetEngine()
        {
            return this._engine;
        }

        public ITyre GetTyre()
        {
            return this._tyre;
        }
    }

   
}
