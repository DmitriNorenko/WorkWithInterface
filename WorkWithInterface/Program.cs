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
        public interface IWorker
        {
            void Build();
        }
        public class Worker : IWorker
        {
            public void Build() { }
        }
    }
}
