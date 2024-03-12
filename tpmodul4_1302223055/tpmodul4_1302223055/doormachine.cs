﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302223055.door
{
    internal class DoorMachine
    {
        public enum StateKeys { Terbuka, Tertutup, Terkunci, Exit };
        public enum StateKunci { Kunci, Tidak_kunci };

        public void run()
        {
            StateKeys defaults = StateKeys.Terkunci;
            String Command = "terbuka";
            while (defaults != StateKeys.Exit)
            {
                switch (defaults)
                {
                    case StateKeys.Terbuka:
                        Console.WriteLine("Pintu terbuka");
                        break;
                    case StateKeys.Terkunci:
                        Console.WriteLine("Pintu terkunci");
                        break;
                    case StateKeys.Exit:
                        Console.WriteLine("Keluar");
                        break;
                }
                Console.WriteLine("Masukkan perintah : ");
                Command = Console.ReadLine();

                if (Command == "BukaPintu" || Command == "buka")
                {
                    if (defaults == StateKeys.Terkunci)
                    {
                        defaults = StateKeys.Terbuka;
                    }
                    else
                    {
                        Console.WriteLine("tidak terkunci");
                    }
                }
                else if (Command == "KunciPintu" || Command == "kunci")
                {
                    if (defaults == StateKeys.Terbuka)
                    {
                        defaults = StateKeys.Terkunci;
                    }
                    else
                    {
                        Console.WriteLine("terkunci");
                    }
                }
                else if (Command == "Exit" || Command == "EXIT")
                {
                    defaults = StateKeys.Exit;
                }
                else
                {
                    Console.WriteLine("Perintah tidak dikenal");
                }
            }

        }
    }
}

