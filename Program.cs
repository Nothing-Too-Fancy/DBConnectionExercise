using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnection Sql = new SqlConnection("123.456.789");
            DbConnection Oracle = new OracleConnection("987.654.321");

            DbCommand instruction = new DbCommand(Oracle, "Write");
            instruction.Execute();

            Console.ReadLine();
        }
    }
}
