using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class MotocycleBuilder
    {
        private IBrake _brake = null;
        private IEngine _engine = null;
        private ITyre _tyre = null;

        public MotocycleBuilder SetBrake(IBrake value)
        {
            this._brake = value;
            return this;
        }

        public MotocycleBuilder SetEngine(IEngine value)
        {
            this._engine = value;
            return this;
        }

        public MotocycleBuilder SetTyre(ITyre value)
        {
            this._tyre = value;
            return this;
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
