using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace ProdCycleBoer
{
    class Production
    {
        SQLiteConnection dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));
        SQLiteCommand command;

        public bool AddOrder(List<string> Aorder) /// query(Objs: Name,Type,SDate,EDate,Barcode,Ext_Code(null),Phase)
        {

            {

                dbC.Open();

                command = new SQLiteCommand("INSERT INTO Orders (Name,Type,Starting_Date,Expiring_Date,Barcode,Ext_Code,Phase_ID) VALUES (@name,@Type,@SDate,@EDate,@Barcode,@Ext_Code,@Phase)", dbC);
                command.Parameters.AddWithValue("@name", Aorder[0]);
                command.Parameters.AddWithValue("@Type", Aorder[1]);
                command.Parameters.AddWithValue("@SDate", Aorder[2]);
                command.Parameters.AddWithValue("@EDate", Aorder[3]);
                command.Parameters.AddWithValue("@Barcode", Aorder[4]);
                command.Parameters.AddWithValue("@Ext_Code", Aorder[5]);
                command.Parameters.AddWithValue("@Phase", Aorder[6]);
                try
                {
                    command.ExecuteNonQuery();
                    dbC.Close();
                    return true;

                }
                catch
                {
                    dbC.Close();
                    return false;

                }

                
            }
        }

        public bool EditOrder(List<string> Eorder)
        {
            dbC.Open();

            command = new SQLiteCommand("UPDATE Orders SET Name = @name ,Type = @Type , Starting_Date = @SDate , Expiring_Date = @EDate , Barcode = @Barcode , Ext_Code = @Ext_Code , Phase_ID = @Phase Where ID = @ID", dbC);
            command.Parameters.AddWithValue("@name", Eorder[0]);
            command.Parameters.AddWithValue("@Type", Eorder[1]);
            command.Parameters.AddWithValue("@SDate", Eorder[2]);
            command.Parameters.AddWithValue("@EDate", Eorder[3]);
            command.Parameters.AddWithValue("@Barcode", Eorder[4]);
            command.Parameters.AddWithValue("@Ext_Code", Eorder[5]);
            command.Parameters.AddWithValue("@Phase", Eorder[6]);
            command.Parameters.AddWithValue("@ID", Eorder[7]);
            try
            {
                command.ExecuteNonQuery();
                dbC.Close();
                return true;

            }
            catch
            {
                dbC.Close();
                return false;
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
