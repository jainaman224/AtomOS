﻿using System;
using Kernel_alpha.x86;
using System.Collections.Generic;
using Kernel_alpha.Drivers;
using Kernel_alpha.Drivers.Input;
using Kernel_alpha.Drivers.Buses.ATA;

namespace Kernel_alpha
{
    public static class Global
    {
        public static Keyboard KBD;
        public static PS2Mouse Mouse;
        public static acpi ACPI;

        public static IDE PrimaryIDE;
        public static IDE SecondayIDE;

        public static List<Partition> Parts;

        public static void Init()
        {
            // Setup PCI
            Console.Write ("Setting up PCI... ");
            PCI.Setup();
            Console.WriteLine ("OK");

            // Start ACPI
            // Initializes and enables itself
            Console.Write ("Setting up ACPI... ");
            ACPI = new acpi(true, true);
            Console.WriteLine ("OK");

            // Setup Mouse
            Console.Write ("Setting up PS/2 Mouse... ");
            Mouse = new PS2Mouse();
            Mouse.Initialize();
            Console.WriteLine ("OK");

            // Setup Keyboard
            Console.Write("Setting up PS/2 Keyboard... ");
            KBD = new Keyboard();
            Console.WriteLine("OK");

            //Loading ATA
            Console.Write ("Loading ATA SubSystem... ");
            LoadATA();
            Console.WriteLine("OK");

            //Load Parts
            Console.Write ("Loading Partitions... ");
            Parts = new List<Partition>();
            if (PrimaryIDE != null && PrimaryIDE.DriveInfo.Device == Device.IDE_ATA)
            {
                var xMBR = new Drivers.PartInfo.MBR(PrimaryIDE);
                Parts = xMBR.PartInfo;
            }
            Console.WriteLine("OK");
        }

        private static void LoadATA()
        {
            var xDevice = PCI.GetDeviceClass(0x1, 0x1); //media storage IDE controller device
            if (xDevice != null)
            {
                //Have to work here
            }
            else
            {
                //Now we check if parallel ATA is present
                PrimaryIDE = new IDE(false);
                SecondayIDE = new IDE(true);
            }
        }
    }
}