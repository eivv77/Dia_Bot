using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaBot
{
    public class Connection_String
    {
        private string connectionString = @"Data Source=TXBBNUEYVAZOV\WORKSTATION;Database=Dia_Bot;Trusted_Connection=True;MultipleActiveResultSets=True";
        private const string TOKEN = "5774023928:AAH0Zj0hgqpgErS0KX5mOeDb9Ze-A_C_BQw";

        public string Connection_string
        {
            get { return connectionString; }

        }

        public string Connection_token
        {
            get { return TOKEN; }
        }

    }
}
