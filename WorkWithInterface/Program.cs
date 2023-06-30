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
            FileManager fileManager = new FileManager();
            ((IFileReader)fileManager).ReadFile();
            ((IFileWriter)fileManager).WriteFile();
            ((IFileWriter)fileManager).ReadFile();
        }
        public interface IFileReader
        {
            void ReadFile();
        }
        public interface IFileWriter
        {
            void ReadFile();
            void WriteFile();
        }
        class FileManager : IFileReader, IFileWriter
        {
            void IFileReader.ReadFile() { Console.WriteLine("IFileReader.ReadFile"); }
            void IFileWriter.WriteFile() { Console.WriteLine("IFileWriter.WriteFile"); }
            void IFileWriter.ReadFile() { Console.WriteLine("IFileWriter.ReadFile()"); }
        }
    }
}
