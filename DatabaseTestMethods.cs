using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbstrack_ve_Interface
{

    public abstract class BaseDb        //Metodun kullanımını zorunlu bırakıyoruz ve içine kod yazıyoruz
    {
        public abstract string GetDbVersion();

        public DataTable ExecuteSql(string sql)
        {
            return new DataTable();
        }
    }
    public class MySqlDb : BaseDb
    {
        public override string GetDbVersion() => "MySql Database";

    }

    public class SqlServerDb : BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2012";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WİTH(NOLOCK) WHERE ID = {id}";
        }
    }

    public class OracleDb : BaseDb
    {
        public override string GetDbVersion() => "Oracle 18c";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS USER_ID = {id}";
        }
    }
}
