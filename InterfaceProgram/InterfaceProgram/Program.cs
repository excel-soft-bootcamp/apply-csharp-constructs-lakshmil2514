using System;

namespace InterfaceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            DiCorEngine _harrier = new DiCorEngine();
            TataCar car1 = new TataCar(_harrier);
            car1.Drive();
            car1.Halt();
            VeriCorEngine _nexon = new VeriCorEngine();
            TataCar car2 = new TataCar(_nexon);
            car2.Drive();
            car2.Halt();
            MultiJetEngine _hexa = new MultiJetEngine();
            TataCar car3 = new TataCar(_hexa);
            car3.Drive();
            car3.Halt();
            RevorTron _safari = new RevorTron();
            TataCar car4 = new TataCar(_safari);
            car4.Drive();
            car4.Halt();
            


        }
    }
}
