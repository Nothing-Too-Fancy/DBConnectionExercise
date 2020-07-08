using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionExercise
{
    class DbCommand
    {
        DbConnection Connection;
        string Instruction;
        public DbCommand(DbConnection connection, string instruction)
        {
            if(connection != null && instruction != null && instruction.Length != 0)
            {
                Connection = connection;
                Instruction = instruction;
            }
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine(Instruction);
            Connection.Close();
        }
    }
}
