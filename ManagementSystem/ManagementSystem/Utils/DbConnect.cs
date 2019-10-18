using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Utils
{
    public class DbConnect
    {
        private String connection = String.Empty;
        private Boolean pool = false;

        public DbConnect(String DBConfig, String Path)
        {
            IniFile ini = new IniFile(Path);

            String Serv = ini.IniReadValue(DBConfig, "server");
            String DB = ini.IniReadValue(DBConfig, "database");
            String UID = ini.IniReadValue(DBConfig, "uid");
            String Password = ini.IniReadValue(DBConfig, "password");
            String pool = ini.IniReadValue(DBConfig, "pool");
            Int32 maxcon = Convert.ToInt32(ini.IniReadValue(DBConfig, "maxcon"));
            Int32 mincon = Convert.ToInt32(ini.IniReadValue(DBConfig, "mincon"));
            Int32 tout = Convert.ToInt32(ini.IniReadValue(DBConfig, "tout"));

            Initialize(Serv, DB, UID, Password, pool, maxcon, mincon, tout);
        }
        private void Initialize(string Serv, string DB, string UID, string Password, string pooling, int maxcon, int mincon, int tout)
        {
            try
            {
                if (pooling.Equals("1"))
                {
                    pool = true;
                }

                connection = "server = " + Serv + "; database = " + DB + "; uid = " + UID + "; password = " + Password + ";pooling = " + pool + ";min pool size = " + mincon + ";max pool size = " + maxcon + ";connection lifetime=0; Command Timeout=28800; connection timeout=" + tout + ";Allow Zero Datetime=true";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public String getConnection()
        {
            return connection;
        }
    }
}
