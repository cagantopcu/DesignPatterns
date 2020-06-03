using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class IMotocycle
    {
        private ITyre _tyre { get; set; }
        private IBrake _brake { get; set; }
        private IEngine _engine { get; set; }

        public IEngine GetEngine() => this._engine;
        public ITyre GetTyre() => this._tyre;
        public IBrake GetBrake() => this._brake;

        public void BuildEngine(IEngine value)
        {
            this._engine = value;
        }
        public void BuildTyre(ITyre value)
        {
            this._tyre = value;
        }
        public void BuildBrake(IBrake value)
        {

            this._brake = value;
        }
    }
}
