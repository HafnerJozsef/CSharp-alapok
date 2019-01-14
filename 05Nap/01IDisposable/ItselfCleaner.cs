using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace _01IDisposable
{
    public class ItselfCleaner : IDisposable
    {
        private bool isDisposed = false;
        //első példa: menedzselt stream, de IDisposable felületet implementál
        private Stream fileStream = new FileStream("file.txt",FileMode.Create);
        //második példa : menedzselt lista, de nagy méretű
        private List<string> managedMemory = new List<string>();
        //harmadik példa: nem menedzselt memória
        private IntPtr unmanagedMemory = IntPtr.Zero;

        


        public ItselfCleaner()
        {
            //menedzselt memória feltöltése
            for (int i = 0; i < 1000000; i++)
            {
                managedMemory.Add("AAAAAAA");
            }
            //nem menedzselt memória lefoglalása
            unmanagedMemory = Marshal.AllocHGlobal(1000000);
            GC.AddMemoryPressure(1000000);
        }

        public void Dispose()
        {
            
            if(isDisposed)
            {
                return;
            }

            //takarítunk

            fileStream.Dispose();
            fileStream = null;

            managedMemory.Clear();
            managedMemory = null;

            Marshal.FreeHGlobal(unmanagedMemory);
            GC.RemoveMemoryPressure(1000000);

            isDisposed = true;
        }

        ~ItselfCleaner()
        {
            Dispose();
        }
    }
}