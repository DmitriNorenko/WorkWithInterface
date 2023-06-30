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
            IUpdater<Account> updater = new Updater();
        }
        class Updater : IUpdater<User>
        {
            public void Update(User account) { }
        }
        public interface IUpdater<in T>
        {
            void Update(T entity);
        }
        public class User
        {

        }

        public class Account : User
        {

        }
    }
}
