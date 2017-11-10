using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Reflection;

namespace ProdCycleBoer
{
    class Production
    {
        SQLiteConnection dbC = new SQLiteConnection(ConfigurationManager.AppSettings.Get("dbConnectionString"));
        SQLiteCommand command;

        public bool AddOrder(List<string> AddOrder) /// query(Objs: Name,Type,SDate,EDate,Barcode,Ext_Code(null),Phase)
        {
            {
                dbC.Open();

                command = new SQLiteCommand("INSERT INTO Orders (Name, Type, Starting_Date, Expiring_Date, Barcode, Ext_Code, Phase_ID, Products_ID, Notes) VALUES (@name,@Type,@SDate,@EDate,@Barcode,@Ext_Code,@Phase,@Products_ID, @Notes)", dbC);
                command.Parameters.AddWithValue("@name", AddOrder[0]);
                command.Parameters.AddWithValue("@Type", AddOrder[1]);
                command.Parameters.AddWithValue("@SDate", AddOrder[2]);
                command.Parameters.AddWithValue("@EDate", AddOrder[3]);
                command.Parameters.AddWithValue("@Barcode", AddOrder[4]);
                command.Parameters.AddWithValue("@Ext_Code", AddOrder[5]);
                command.Parameters.AddWithValue("@Phase", AddOrder[6]);
                command.Parameters.AddWithValue("@Products_ID", AddOrder[7]);
                command.Parameters.AddWithValue("@Notes", AddOrder[8]);
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

        public bool EditOrder(List<string> EditOrder)
        {
            dbC.Open();

            command = new SQLiteCommand("UPDATE Orders SET Name = @name ,Type = @Type , Starting_Date = @SDate , Expiring_Date = @EDate , Barcode = @Barcode , Ext_Code = @Ext_Code , Phase_ID = @Phase, Products_ID = @Products_ID, Notes = @Notes Where ID = @ID", dbC);
            command.Parameters.AddWithValue("@name", EditOrder[0]);
            command.Parameters.AddWithValue("@Type", EditOrder[1]);
            command.Parameters.AddWithValue("@SDate", EditOrder[2]);
            command.Parameters.AddWithValue("@EDate", EditOrder[3]);
            command.Parameters.AddWithValue("@Barcode", EditOrder[4]);
            command.Parameters.AddWithValue("@Ext_Code", EditOrder[5]);
            command.Parameters.AddWithValue("@Phase", EditOrder[6]);
            command.Parameters.AddWithValue("@Products_ID", EditOrder[7]);
            command.Parameters.AddWithValue("@Notes", EditOrder[8]);
            command.Parameters.AddWithValue("@ID", EditOrder[9]);
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

        public bool AddObject(List<string> Aobject) /// query(Objs: Name,Type,SDate,EDate,Barcode,Ext_Code(null),Phase)
        {
            {
                dbC.Open();

                command = new SQLiteCommand("INSERT INTO Objs (Name,Surname,Specialization) VALUES (@Name,@Surname,@Specialization)", dbC);
                command.Parameters.AddWithValue("@Name", Aobject[0]);
                command.Parameters.AddWithValue("@Surname", Aobject[1]);
                command.Parameters.AddWithValue("@Specialization", Aobject[2]);
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

        public bool EditObject(List<string> Eobject)
        {
            dbC.Open();

            command = new SQLiteCommand("UPDATE Objs SET Name = @Name, Surname = @Surname, Specialization = @Specialization Where ID = @ID", dbC);
            command.Parameters.AddWithValue("@Name", Eobject[0]);
            command.Parameters.AddWithValue("@Surname", Eobject[1]);
            command.Parameters.AddWithValue("@Specialization", Eobject[2]);
            command.Parameters.AddWithValue("@ID", Eobject[3]);
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
        //TIME
    }
}
