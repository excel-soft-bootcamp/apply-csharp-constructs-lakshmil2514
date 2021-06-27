using System;

namespace Inheritance

{
    class abstract Collegemember
    {
        private string _ColgCode;
        private string _Address;
        public Collegemember(string Id, string address)
        {

            this._ColgCode = Id;
            this._Address = address;
        }

    }
}
