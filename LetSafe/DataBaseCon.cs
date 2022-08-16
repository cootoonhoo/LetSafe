using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetSafe
{
    static class DataBaseCon
    {
        private static string server = @"vps40251.publiccloud.com.br";
        private static string dataBase = "LetSafe";
        private static string user = "michel";
        private static string password = "michel";

        public static string StrCon {
            get {
                return $"Data Source ={server}; Integrated Security=false; Initial Catalog ={dataBase}; User ID= {user}; Password={password}";
            }
        }
    }
}
