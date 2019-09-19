using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PackLibrary.Clases
{
    public class GetDataSqlServer
    {
        public GetDataSqlServer()
        {
            using (MicommSql micomm = new MicommSql())
            {
                SqlCommand command = new SqlCommand(R.STRING_SQL.GET_PONCHES);
            }
        }

    }
}
