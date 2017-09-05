using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace WindowsFormsApp1
{
    class Production
    {
        SQLiteConnection dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));
        
        public void AddOrder()
        {
            //query(Objs: Name,Type,SDate,EDate,Barcode,Ext_Code(null),Phase)
            dbC.Open();

            dbC.Close();
          
        }

        public void EditOrder()
        {

            {
                //Update query(Objs: Name,Type,SDate,EDate,Barcode,Ext_Code(null),Phase)
            }
        }

        public void UpdatePhase()
        {
            if (0 == 0)
            {
                //Update query(Objs: Phase = Phase +- 1)
            }
        }

        //OBJ,TIME
    }


}
