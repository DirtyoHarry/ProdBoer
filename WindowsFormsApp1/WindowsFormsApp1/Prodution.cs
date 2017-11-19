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

        public bool AddProduct(List<string> AddProduct)
        {
            dbC.Open();
            command = new SQLiteCommand("INSERT INTO Products (Name, Measure, Type) VALUES (@name , @measure , @type)", dbC);
            command.Parameters.AddWithValue("@name", AddProduct[0]);
            command.Parameters.AddWithValue("@measure", AddProduct[1]);
            command.Parameters.AddWithValue("@type", AddProduct[2]);
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

        public bool AddOrder(List<string> AddOrder)
        {
            //Name, Type, Starting_Date, Expiring_Date, Barcode, Ext_Code, Phase_ID, Products_ID, Notes, Number
            dbC.Open();
            command = new SQLiteCommand("INSERT INTO Orders (Name, Type, Starting_Date, Expiring_Date, Barcode, Ext_Code, Phase_ID, Products_ID, Notes, Number) VALUES (@name,@Type,@SDate,@EDate,@Barcode,@Ext_Code,@Phase,@Products_ID, @Notes, @Number)", dbC);
            command.Parameters.AddWithValue("@name", AddOrder[0]);
            command.Parameters.AddWithValue("@Type", AddOrder[1]);
            command.Parameters.AddWithValue("@SDate", AddOrder[2]);
            command.Parameters.AddWithValue("@EDate", AddOrder[3]);
            command.Parameters.AddWithValue("@Barcode", AddOrder[4]);
            command.Parameters.AddWithValue("@Ext_Code", AddOrder[5]);
            command.Parameters.AddWithValue("@Phase", AddOrder[6]);
            command.Parameters.AddWithValue("@Products_ID", AddOrder[7]);
            command.Parameters.AddWithValue("@Notes", AddOrder[8]);
            command.Parameters.AddWithValue("@Number", AddOrder[9]);
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

        public bool AddProduction(List<string> AddProd) /// query(Objs: Name,Type,SDate,EDate,Barcode,Ext_Code(null),Phase)
        {
            //Time_ID, Obj_ID, Order_ID, Phase_ID, Day_ID            
            dbC.Open();
            command = new SQLiteCommand("INSERT INTO Production (Time_ID, Obj_ID, Order_ID, Phase_ID, Day_ID) VALUES (@Time_ID, @Obj_ID, @Order_ID, @Phase_ID, @Day_ID)", dbC);
            command.Parameters.AddWithValue("@Time_ID", AddProd[0]);
            command.Parameters.AddWithValue("@Obj_ID", AddProd[1]);
            command.Parameters.AddWithValue("@Order_ID", AddProd[2]);
            command.Parameters.AddWithValue("@Phase_ID", AddProd[3]);
            command.Parameters.AddWithValue("@Day_ID", AddProd[4]);
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


                command = new SQLiteCommand("INSERT INTO Objs (Name,Surname,Specialization,Type) VALUES (@Name,@Surname,@Specialization,@Type)", dbC);

                command = new SQLiteCommand("INSERT INTO Objs (Name,Surname,Specialization,Type,Spec_Int,Spec_Ext) VALUES (@Name,@Surname,@Specialization,@Type,@Spec_Int,@Spec_Ext)", dbC);

                command.Parameters.AddWithValue("@Name", Aobject[0]);
                command.Parameters.AddWithValue("@Surname", Aobject[1]);
                command.Parameters.AddWithValue("@Specialization", Aobject[2]);
                command.Parameters.AddWithValue("@Type", Aobject[3]);
                command.Parameters.AddWithValue("@Spec_Int", "0"); // Aobject[4]
                command.Parameters.AddWithValue("@Spec_Ext", "0"); //Aobject[5]

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

            command = new SQLiteCommand("UPDATE Objs SET Name = @Name, Surname = @Surname, Specialization = @Specialization, Type = @Type, Spec_Int = @Spec_Int, Spec_Ext = @Spec_Ext Where ID = @ID", dbC);
            command.Parameters.AddWithValue("@Name", Eobject[0]);
            command.Parameters.AddWithValue("@Surname", Eobject[1]);
            command.Parameters.AddWithValue("@Specialization", Eobject[2]);
            command.Parameters.AddWithValue("@Type", Eobject[3]);
            command.Parameters.AddWithValue("@Spec_Int", Eobject[4]);
            command.Parameters.AddWithValue("@Spec_Ext", Eobject[5]);
            command.Parameters.AddWithValue("@ID", Eobject[6]);
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

        public List<string> GetProducts(out List<int> prodType)
        {
            prodType = new List<int>();
            List<string> prod = new List<string>();
            dbC.Open();
            try
            {
                command = new SQLiteCommand("SELECT Name, Measure, Type FROM Products", dbC);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prod.Add(reader["Name"].ToString() + " - " + reader["Measure"].ToString());
                    prodType.Add(int.Parse(reader["Type"].ToString()));
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            return prod;
        }


        public List<string> GetObjs(out List<int> objType)
        {
            objType = new List<int>();
            List<string> obj = new List<string>();
            dbC.Open();
            try
            {
                command = new SQLiteCommand("SELECT Name, Surname, Type FROM Objs", dbC);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string a = reader["Name"].ToString() + " " + reader["Surname"].ToString();
                    obj.Add(reader["Name"].ToString() + " " + reader["Surname"].ToString());
                    objType.Add(int.Parse(reader["Type"].ToString()));
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            return obj;
        }

        public int GetObjAndProdRowID(int index, int type, string ID, string table)
        {
            //ha la funzione del ROW_NUMBER in SQL normale
            int objID = -1;
            dbC.Open();
            string query = "SELECT " + ID + " FROM " + table + " WHERE Type = @type LIMIT 1 OFFSET @index";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@index", index);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    objID = int.Parse(reader[ID].ToString());
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            dbC.Close();
            return objID;
        }

        public int GetType(int Id, string table, string rowID)
        {
            int type = -1;
            dbC.Open();
            string query = "SELECT Type FROM " + table + " WHERE " + rowID + " = @rowID";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@rowID", Id);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    type = int.Parse(reader["Type"].ToString());
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            dbC.Close();
            return type;
        }

        public int GetObjAndProdRow(string Id, int type, string table, int rowID)
        {
            //ha la funzione del ROW_NUMBER in SQL normale
            int objID = -1;
            dbC.Open();
            string query = "SELECT COUNT(*) FROM " + table + " WHERE Type = @type AND " + Id + " <= @rowID";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@Id", Id);
            command.Parameters.AddWithValue("@rowID", rowID);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    objID = int.Parse(reader["COUNT(*)"].ToString());
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            dbC.Close();
            return objID;
        }

        public int GetRowID(int index, string ID, string table)
        {
            //ha la funzione del ROW_NUMBER in SQL normale
            int objID = -1;
            dbC.Open();
            string query = "SELECT " + ID + " FROM " + table + " LIMIT 1 OFFSET @index";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@index", index);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    objID = int.Parse(reader[ID].ToString());
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            dbC.Close();
            return objID;
        }
        
        public string SelectWithWhere(string selColumn, string table, string whereCol, string whereClause)
        {
            string retString = "";
            dbC.Open();
            string query = "SELECT " + selColumn + " FROM " + table + " WHERE " + whereCol + " = @whereClause";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@whereClause", whereClause);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                retString = reader[selColumn].ToString();                
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            return retString;
        }

        public List<string> SelectWithWhereOrders(string whereCol, string whereClause)
        {
            List<string> retString = new List<string>();
            dbC.Open();
            string query = "SELECT Name, Type, strftime('%Y/%d/%m', Starting_Date) as sd, strftime('%Y/%d/%m', Expiring_Date) as ed, Barcode, Ext_Code, Phase_ID, Products_ID, Notes, Number FROM Orders WHERE " + whereCol + " = @whereClause";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@whereClause", whereClause);
            SQLiteDataReader reader = command.ExecuteReader();
            retString.Add(reader["Name"].ToString());
            retString.Add(reader["Type"].ToString());
            retString.Add(reader["sd"].ToString());
            retString.Add(reader["ed"].ToString());
            retString.Add(reader["Barcode"].ToString());
            retString.Add(reader["Ext_Code"].ToString());
            retString.Add(reader["Phase_ID"].ToString());
            retString.Add(reader["Products_ID"].ToString());
            retString.Add(reader["Notes"].ToString());
            retString.Add(reader["Number"].ToString());
            dbC.Close();
            return retString;
        }

        public int CountRows(string table)
        {
            int count = -1;
            dbC.Open();
            string query = "SELECT COUNT(*) as c FROM " + table;
            command = new SQLiteCommand(query, dbC);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    count = int.Parse(reader["c"].ToString());
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            return count;
        }

        public List<List<string>> GetProduction(int orderID, int phaseID)
        {
            List<List<string>> prod = new List<List<string>>();
            List<string> temp = new List<string>();
            dbC.Open();
            string query = "SELECT Time_ID, Obj_ID, Phase_ID, strftime('%Y/%d/%m', Day_ID) as Day FROM Production WHERE Order_ID = @orderID AND Phase_ID = @phaseID";
            //string query = "SELECT COUNT(*) FROM Production WHERE Order_ID = @OrderID AND Obj_ID = @ObjID AND Phase_ID = @PhaseID AND Day_ID = strftime('%Y/%d/%m', @dayID)";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@phaseID", phaseID);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                prod.Add(temp);
                prod[i] = new List<string>();
                prod[i].Add(reader["Time_ID"].ToString());
                prod[i].Add(reader["Obj_ID"].ToString());
                prod[i].Add(reader["Phase_ID"].ToString());
                prod[i].Add(reader["Day"].ToString());
                i++;
            }
            dbC.Close();
            return prod;
        }

    }
}

