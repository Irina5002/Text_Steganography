using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Text_Steganography
{
    internal class DataBase
    {
        //Подключение к БД
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = DESKTOP-GQN4FO7\SQLEXPRESS; Initial Catalog = Stegano; Integrated Security = true");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) 
            {
                 sqlConnection.Open(); 
            }
        }
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
