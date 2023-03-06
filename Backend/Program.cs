using MessegeCenter;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.RegisterMesseges();
        }

        private   void RegisterMesseges()
        {
            WeakReferenceMessenger.Default.Register<SaveMessege>(this, (r, m) =>
            {
                SaveNumber(m);
            });
        }

        private static void SaveNumber(object value)
        {
            //Save To DB
        }
    }
}
