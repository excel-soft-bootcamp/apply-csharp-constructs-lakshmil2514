using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceProgram
{

    public class TataCar
    {
        Iengine _engine;

        public TataCar(Iengine engine)
        {

            this._engine = engine;
        }

        public void Drive()
        {

            _engine.Start();
        }
        public void Halt()
        {

            _engine.Stop();
        }


    }
}

    


    

        

       

    



