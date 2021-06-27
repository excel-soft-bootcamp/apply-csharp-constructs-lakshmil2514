using System;

namespace Inheritance

{
    public abstract class IdCardDetails
    {
        private string _ColgCode;
        private string _Address;
        public IdCardDetails(string Id, string address)
        {

            this._ColgCode = Id;
            this._Address = address;
        }

    }
}
