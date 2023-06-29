using System;
using System.Collections.Generic;
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
        public interface IWriter
        {
            void Write();
        }
        public class Writer : IWriter
        {
            void IWriter.Write()
            {
                Console.WriteLine("Явная реализация.");
            }
        }
    }
}
