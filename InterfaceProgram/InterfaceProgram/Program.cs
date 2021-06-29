using System;

namespace InterfaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            DiCorEngine dicorengine = new DiCorEngine();
            TataCar _harrier = new TataCar(dicorengine);
            _harrier.Drive();
            _harrier.Halt();

           
            TataCar _nexon = new TataCar(new VeriCorEngine());
            _nexon.Drive();
            _nexon.Halt();

            
            TataCar _hexa = new TataCar(new MultiJetEngine());
            _hexa.Drive();
            _hexa.Halt();


           
            TataCar _safari = new TataCar(new RevorTron());
            _safari.Drive();
            _safari.Halt();



        }
    }
}
