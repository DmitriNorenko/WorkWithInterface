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
        public interface IManager
        {
            void Create();
            void Read();
            void Update();
            void Delete();
        }
        public class Manager : IManager
        {
            public void Create()
            {

            }

            public void Read()
            {

            }

            public void Update()
            {

            }

            public void Delete()
            {

            }
        }
    }
}
