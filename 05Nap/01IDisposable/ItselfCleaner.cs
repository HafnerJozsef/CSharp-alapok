using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace _01IDisposable
{
    public class ItselfCleaner : IDisposable
    {
        //első példa: menedzselt stream, de IDisposable felületet implementál
        private Stream fileStream = new FileStream("file.txt",FileMode.Create);
        //második példa : menedzselt lista, de nagy méretű
        private List<string> managedMemory = new List<string>();
        //harmadik példa: nem menedzselt memória
        private IntPtr unmanagedMemory = IntPtr.Zero;

        private int isDisposed = 0;

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

        public int FuggvenyAmiFigyelADisposeRa()
        {
            EnsureNotDisposed();
            return  1;
        }

        public int MyProperty
        {
            get
            {
                EnsureNotDisposed();
                return 1;
            }

            set
            {
                EnsureNotDisposed();
            }
        }

        private void EnsureNotDisposed()
        {
            if (isDisposed == 1)
            {
                throw new ObjectDisposedException(nameof(ItselfCleaner));
            }
        }

        public void Dispose()
        {

            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ItselfCleaner()
        {
            Dispose(false);
        }

        private void Dispose(bool dispose)
        {

            if (Interlocked.Exchange(ref isDisposed, 1) == 1)
            {
                //return;
                //amennyiben kétszer fut le, az általában logikai hiba. Érdemest ezt hangosan jelezni!
                throw new ObjectDisposedException(nameof (ItselfCleaner));
            }

            //takarítunk

            if (dispose)
            {//Dispose-l hívtuk, így a menedzselt részeket is takarítjuk

                if (fileStream != null)
                {
                    fileStream.Dispose();
                    fileStream = null;
                }
                if (managedMemory != null)
                {
                    managedMemory.Clear();
                    managedMemory = null;
                }

            }

            if (unmanagedMemory != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(unmanagedMemory);
                GC.RemoveMemoryPressure(1000000);
            }

            

        }
    }
}