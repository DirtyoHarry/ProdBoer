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
        SQLiteCommand command;

        public bool AddOrder(List<string> order) /// query(Objs: Name,Type,SDate,EDate,Barcode,Ext_Code(null),Phase)
        {

            {

                dbC.Open();

                command = new SQLiteCommand("INSERT INTO Orders (Name,Type,Starting_Date,Expiring_Date,Barcode,Ext_Code,Phase_ID) VALUES (@name,@Type,@SDate,@EDate,@Barcode,@Ext_Code,@Phase)", dbC);
                command.Parameters.AddWithValue("@name", order[0]);
                command.Parameters.AddWithValue("@Type", order[1]);
                command.Parameters.AddWithValue("@SDate", order[2]);
                command.Parameters.AddWithValue("@EDate", order[3]);
                command.Parameters.AddWithValue("@Barcode", order[4]);
                command.Parameters.AddWithValue("@Ext_Code", order[5]);
                command.Parameters.AddWithValue("@Phase", order[6]);
                try
                {
                    command.ExecuteNonQuery();
                    return true;

                }
                catch
                {
                    return false;
                }

                dbC.Close();
            }
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
