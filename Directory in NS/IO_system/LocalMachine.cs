using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMachineIO
{
    internal class LocalMachine
    {
        public void GetMachineParameters()
        {
            // The info about OS and Kernel
            Console.WriteLine("-----------------------------[ SYSTEM and SoC]-----------------------------");
            Console.WriteLine($"Your OS and Kernel: {System.Environment.OSVersion}");
            Console.WriteLine($"Your system is 64 bit architecture: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"PC Name: {Environment.MachineName}");
            Console.WriteLine($"How many CPUs does your PC have: {Environment.ProcessorCount}");



            // The info about drive(s)

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.WriteLine("-----------------------------[ DRIVES ]-----------------------------");
                Console.WriteLine("Drive {0}", d.Name);
                Console.WriteLine("  Drive type: {0}", d.DriveType);
                if (d.IsReady == true)
                {
                    Console.WriteLine("  Volume label: {0}", d.VolumeLabel);
                    Console.WriteLine("  File system: {0}", d.DriveFormat);
                    Console.WriteLine($"  Root directory: {d.RootDirectory}");
                    Console.WriteLine(
                        "  Available space to current user:{0, 15} bytes",
                        d.AvailableFreeSpace);

                    Console.WriteLine(
                        "  Total available space:          {0, 15} bytes",
                        d.TotalFreeSpace);

                    Console.WriteLine(
                        "  Total size of drive:            {0, 15} bytes ",
                        d.TotalSize);


                }
            }
        }
    }
}
