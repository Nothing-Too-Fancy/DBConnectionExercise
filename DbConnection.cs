using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectionExercise
{
    abstract class DbConnection
    {
        string ConnectionString;
        TimeSpan Timeout;

        public DbConnection(string connectStr)
        {
            if (connectStr != null && connectStr.Length != 0)
                ConnectionString = connectStr;
            else
                throw new InvalidOperationException("String cannot be null or empty");
        }

        public abstract void Open();
        public abstract void Close();
    }
}
