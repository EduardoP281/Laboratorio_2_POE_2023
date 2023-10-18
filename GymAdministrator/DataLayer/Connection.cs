using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Connection
    {
        private SqlConnection _connetion = new SqlConnection(@"Data Source=EDUARDO\SQLEXPRESS;Initial Catalog=db-gym;Integrated Security=True");

        public SqlConnection OpenConnection()
        {
            if (_connetion.State == ConnectionState.Closed)
            {
                _connetion.Open();
            }
            return _connetion;
        }

        public SqlConnection CloseConnection()
        {
            if (_connetion.State == ConnectionState.Open)
            {
                _connetion.Close();
            }
            return _connetion;
        }
    }
}
