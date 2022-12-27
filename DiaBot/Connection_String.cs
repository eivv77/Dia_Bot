using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaBot
{
    public class Connection_String
    {
        private string connectionString = @"Data Source=TXBBNUEYVAZOV\WORKEIVV77;Database=dia_bot;Trusted_Connection=True;MultipleActiveResultSets=True";

        public string Connection_string
        {
            get { return connectionString; }

        }
    }
}
