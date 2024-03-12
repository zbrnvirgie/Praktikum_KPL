using tpmodul4_1302223055.kodepos;
namespace tpmodul4_1302223055.door;
using System;

namespace tpmodul4_1302223055
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contoh_1 :");
            KodePos kodepos = new KodePos();
            kodepos.setKodePost();
            kodepos.getKodePos();

            Console.WriteLine("\nContoh_2 :");
            KodePos1 kodepos1 = new KodePos1();
            kodepos1.getKodePos();

            Console.WriteLine("\nSoal 3 :");
            DoorMachine door = new DoorMachine();
            door.run();
        }
    }
}