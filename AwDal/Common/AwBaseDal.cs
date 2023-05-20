﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AwDal.Common;

using System.Data.SqlClient;

namespace AwDal.Common
{
    public class AwBaseDal
    {
        public string ConnectionString { get; set; }
        public AwBaseDal(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
