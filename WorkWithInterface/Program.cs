using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WorkWithInterface.Program;

namespace WorkWithInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        public interface IBook
        {
            void Read();
        }

        public interface IDevice
        {
            void TurnOn();
            void TurnOff();
        }
        class Books : IBook, IDevice
        {
            void IBook.Read() { }

            void IDevice.TurnOn() { }

            void IDevice.TurnOff() { }
        }
    }
}
