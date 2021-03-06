﻿using System;
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
            command = new SQLiteCommand("INSERT INTO Orders (Orders_ID, Name, Type, Starting_Date, Expiring_Date, Barcode, Ext_Code, Phase_ID, Products_ID, Notes, Number) VALUES (@ordId, @name,@Type,@SDate,@EDate,@Barcode,@Ext_Code,@Phase,@Products_ID, @Notes, @Number)", dbC);
            command.Parameters.AddWithValue("@ordId", AddOrder[0]);
            command.Parameters.AddWithValue("@name", AddOrder[1]);
            command.Parameters.AddWithValue("@Type", AddOrder[2]);
            command.Parameters.AddWithValue("@SDate", AddOrder[3]);
            command.Parameters.AddWithValue("@EDate", AddOrder[4]);
            command.Parameters.AddWithValue("@Barcode", AddOrder[5]);
            command.Parameters.AddWithValue("@Ext_Code", AddOrder[6]);
            command.Parameters.AddWithValue("@Phase", AddOrder[7]);
            command.Parameters.AddWithValue("@Products_ID", AddOrder[8]);
            command.Parameters.AddWithValue("@Notes", AddOrder[9]);
            command.Parameters.AddWithValue("@Number", AddOrder[10]);
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
            command = new SQLiteCommand("UPDATE Orders SET Name = @name ,Type = @Type , Starting_Date = @SDate , Expiring_Date = @EDate , Barcode = @Barcode , Ext_Code = @Ext_Code , Phase_ID = @Phase, Products_ID = @Products_ID, Notes = @Notes, Number = @Number Where Orders_ID = @ID", dbC);
            command.Parameters.AddWithValue("@ID", EditOrder[0]);
            command.Parameters.AddWithValue("@name", EditOrder[1]);
            command.Parameters.AddWithValue("@Type", EditOrder[2]);
            command.Parameters.AddWithValue("@SDate", EditOrder[3]);
            command.Parameters.AddWithValue("@EDate", EditOrder[4]);
            command.Parameters.AddWithValue("@Barcode", EditOrder[5]);
            command.Parameters.AddWithValue("@Ext_Code", EditOrder[6]);
            command.Parameters.AddWithValue("@Phase", EditOrder[7]);
            command.Parameters.AddWithValue("@Products_ID", EditOrder[8]);
            command.Parameters.AddWithValue("@Notes", EditOrder[9]);
            command.Parameters.AddWithValue("@Number", EditOrder[10]);
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


        public bool EditProduction(List<string> EditProd)
        {
            dbC.Open();
            command = new SQLiteCommand("UPDATE Production SET Time_ID = @time, Obj_ID = @obj, Order_ID = @order, Phase_ID = @phase, Day_ID = @day Where Production_ID = @ID", dbC);
            command.Parameters.AddWithValue("@time", EditProd[0]);
            command.Parameters.AddWithValue("@obj", EditProd[1]);
            command.Parameters.AddWithValue("@order", EditProd[2]);
            command.Parameters.AddWithValue("@phase", EditProd[3]);
            command.Parameters.AddWithValue("@day", EditProd[4]);
            command.Parameters.AddWithValue("@ID", EditProd[5]);
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

        public bool RemoveRowsFromDB(string table, string column, int ID)
        {
            dbC.Open();
            command = new SQLiteCommand("DELETE FROM " + table + " WHERE " + column + " = @ID", dbC);
            command.Parameters.AddWithValue("@ID", ID);
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
                command = new SQLiteCommand("INSERT INTO Objs (Name,Surname,Specialization,Type,Spec_Int,Spec_Ext) VALUES (@Name,@Surname,@Specialization,@Type,@Spec_Int,@Spec_Ext)", dbC);

                command.Parameters.AddWithValue("@Name", Aobject[0]);
                command.Parameters.AddWithValue("@Surname", Aobject[1]);
                command.Parameters.AddWithValue("@Specialization", Aobject[2]);
                command.Parameters.AddWithValue("@Type", Aobject[3]);
                command.Parameters.AddWithValue("@Spec_Int", Aobject[4]);  
                command.Parameters.AddWithValue("@Spec_Ext", Aobject[5]); 

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

            command = new SQLiteCommand("UPDATE Objs SET Name = @Name, Surname = @Surname, Specialization = @Specialization, Type = @Type, Spec_Int = @Spec_Int, Spec_Ext = @Spec_Ext Where Objs_ID = @ID", dbC);
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

        public int GetLastRowID(string nameRowID, string table)
        {
            int rowID = -1;
            dbC.Open();
            string query = "SELECT " + nameRowID + " FROM " + table + " WHERE " + nameRowID + " = (SELECT MAX(" + nameRowID + ") FROM Orders)";
            command = new SQLiteCommand(query, dbC);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    rowID = int.Parse(reader[nameRowID].ToString());
                }
                dbC.Close();
            }
            catch
            {
                dbC.Close();
            }
            dbC.Close();
            return rowID;
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


        public int GetRowID(int index, string ID, string table, string whereCol, string whereClause)
        {
            //ha la funzione del ROW_NUMBER in SQL normale
            int objID = -1;
            dbC.Open();
            string query = "SELECT " + ID + " FROM " + table + " WHERE " + whereCol + " = @whereClause LIMIT 1 OFFSET @index";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@index", index);
            command.Parameters.AddWithValue("@whereClause", whereClause);
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

        public string SelectWithWhereOneRow(string selColumn, string table, string whereCol, string whereClause)
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

        public List<string> SelectWithWhereList(string selColumn, string table, string whereCol, string whereClause)
        {
            List<string> retString = new List<string>();
            dbC.Open();
            string query = "SELECT " + selColumn + " FROM " + table + " WHERE " + whereCol + " = @whereClause";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@whereClause", whereClause);
            SQLiteDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    string namePH = reader[selColumn].ToString();
                    retString.Add(namePH);
                }
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
                prod[i].Add(reader["Time_ID"].ToString()); string x1 = prod[i][0];
                prod[i].Add(reader["Obj_ID"].ToString()); string x2 = prod[i][1];
                prod[i].Add(reader["Phase_ID"].ToString()); string x3 = prod[i][2];
                prod[i].Add(reader["Day"].ToString()); string x4 = prod[i][3];
                i++;
            }
            dbC.Close();
            return prod;
        }

        public List<List<string>> GetProductionGroupBy(int orderID, int phaseID)
        {
            List<List<string>> prod = new List<List<string>>();
            List<string> temp = new List<string>();
            dbC.Open();
            string query = "SELECT Time_ID, Obj_ID, Phase_ID, strftime('%Y/%d/%m', Day_ID) as Day FROM Production WHERE Order_ID = @orderID AND Phase_ID = @phaseID GROUP BY Obj_ID";
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
                prod[i].Add(reader["Time_ID"].ToString()); string x1 = prod[i][0];
                prod[i].Add(reader["Obj_ID"].ToString()); string x2 = prod[i][1];
                prod[i].Add(reader["Phase_ID"].ToString()); string x3 = prod[i][2];
                prod[i].Add(reader["Day"].ToString()); string x4 = prod[i][3];
                i++;
            }
            dbC.Close();
            return prod;
        }

        public int GetNOfPhasesInProd(int orderID)
        {
            int phases = -1;

            dbC.Open();
            string query = "select COUNT(*) as count FROM (select COUNT(*) as ct FROM PRODUCTION WHERE PRODUCTION.ORDER_ID = @orderID GROUP BY PHASE_ID) t";
            //string query = "SELECT COUNT(*) FROM Production WHERE Order_ID = @OrderID AND Obj_ID = @ObjID AND Phase_ID = @PhaseID AND Day_ID = strftime('%Y/%d/%m', @dayID)";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@orderID", orderID);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                phases = int.Parse(reader["count"].ToString());
            }
            dbC.Close();
            return phases;
        }

        public int GetNOfObjsInProd(int orderID, int phaseID)
        {
            int ctObjs = -1;
            dbC.Open();
            string query = "select COUNT(*) as ctObjs FROM (select COUNT(*) as ct FROM PRODUCTION WHERE Order_ID = @orderID AND Phase_ID = @phaseID GROUP BY PHASE_ID, OBJ_ID) t";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@phaseID", phaseID);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ctObjs = int.Parse(reader["ctObjs"].ToString());
            }
            dbC.Close();
            return ctObjs;
        }

        public List<string> GetStartingAndEndingDateTime(int orderID, int phaseID, int objID)
        {
            List<string> time = new List<string>();
            dbC.Open();
            string query = "SELECT * FROM (SELECT Time_ID as STime, strftime('%Y/%d/%m', Day_ID) as SDay FROM PRODUCTION WHERE Order_ID = @orderID AND Phase_ID = @phaseID AND Obj_ID = @objID ORDER BY Day_ID ASC, Time_ID ASC LIMIT 1) as Starting, (SELECT (Time_ID+1) as ETime, strftime('%Y/%d/%m', Day_ID) as EDay FROM Production WHERE Order_ID = @orderID AND Phase_ID = @phaseID AND Obj_ID = @objID ORDER BY Day_ID DESC, Time_ID DESC LIMIT 1) as Ending";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@orderID", orderID);
            command.Parameters.AddWithValue("@phaseID", phaseID);
            command.Parameters.AddWithValue("@objID", objID);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                time.Add(reader["STime"].ToString());
                time.Add(reader["SDay"].ToString());
                time.Add(reader["ETime"].ToString());
                time.Add(reader["EDay"].ToString());
            }
            dbC.Close();
            return time;
        }

        public List<List<string>> GetOrders()
        {
            List<List<string>> orders = new List<List<string>>();
            List<string> temp = new List<string>();
            dbC.Open();
            string query = "SELECT Orders_ID, Orders.Name, CASE Orders.Type WHEN 0 THEN 'esterno' ELSE 'interno' END as Type, strftime('%Y/%d/%m', Starting_Date) as Starting_Date, strftime('%Y/%d/%m', Expiring_Date) as Expiring_Date, Barcode, Ext_Code, Phase_ID, Products.Name as nameProd, Measure, Notes FROM Orders JOIN Products ON Products.Products_ID = Orders.Products_ID";
            command = new SQLiteCommand(query, dbC);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                orders.Add(temp);
                orders[i] = new List<string>();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    orders[i].Add(reader[reader.GetName(j)].ToString());
                }
                i++;
            }
            dbC.Close();
            return orders;
        }

        public List<List<string>> GetProducts()
        {
            List<List<string>> orders = new List<List<string>>();
            List<string> temp = new List<string>();
            dbC.Open();
            string date = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
            string query = "SELECT Products.Products_ID, Products.Name, CASE Orders.Products_ID WHEN Orders.Products_ID IS NOT NULL AND strftime('%Y/%d/%m', Production.Day_ID) >= strftime('%Y/%d/%m', @date) THEN 'si' ELSE 'no' END as InProduzione, CASE Products.Type WHEN 0 THEN 'esterno' ELSE 'interno' END as Type FROM Products LEFT JOIN Orders ON(Products.Products_ID = Orders.Products_ID) LEFT JOIN Production ON(Orders.Orders_ID = Production.Order_ID) GROUP BY Products.Products_ID";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@date", date);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                orders.Add(temp);
                orders[i] = new List<string>();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    orders[i].Add(reader[reader.GetName(j)].ToString());
                }
                i++;
            }
            dbC.Close();
            return orders;
        }

        public List<List<string>> GetObjs()
        {
            List<List<string>> objs = new List<List<string>>();
            List<string> temp = new List<string>();
            dbC.Open();
            string query = "SELECT Objs.Objs_ID, Objs.Name, Objs.Surname, CASE Objs.Type WHEN 0 THEN 'lavoratore' ELSE 'macchinario' END as 'lav/macch', CASE Objs.Spec_Int WHEN 0 THEN 'NON abilitato' WHEN 1 THEN 'abilitato' ELSE 'abilitato' END as 'lavorare interno', CASE Objs.Spec_Ext WHEN 0 THEN 'NON abilitato' WHEN 1 THEN 'abilitato' ELSE 'abilitato' END as 'lavorare esterno', Objs.Specialization FROM Objs";
            command = new SQLiteCommand(query, dbC);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                objs.Add(temp);
                objs[i] = new List<string>();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    objs[i].Add(reader[reader.GetName(j)].ToString());
                }
                i++;
            }
            dbC.Close();
            return objs;
        }

        public int CountPhasesByType(int type)
        {
            int count = -1;
            dbC.Open();
            string query = "SELECT COUNT(*) as cnt FROM Phases WHERE Type = @type";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@type", type);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            { count = int.Parse(reader["cnt"].ToString()); }
            dbC.Close();
            return count;
        }

        public int GetType(int position, string table)
        {
            int type = -1;
            dbC.Open();
            string query = "SELECT Type FROM " + table + " LIMIT 1 OFFSET @position";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@position", position);
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

        public bool AddDefaultPhases(List<string> AddPhases)
        {
            dbC.Open();
            command = new SQLiteCommand("INSERT INTO DefaultPhases (Objs_ID, Phases_ID, Products_ID, Length) VALUES (@Objs_ID, @Phases_ID , @Products_ID , @Length)", dbC);
            command.Parameters.AddWithValue("@Objs_ID", AddPhases[0]);
            command.Parameters.AddWithValue("@Phases_ID", AddPhases[1]);
            command.Parameters.AddWithValue("@Products_ID", AddPhases[2]);
            command.Parameters.AddWithValue("@Length", AddPhases[3]);
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

        public List<List<string>> GetDefaultPhasesOneProd(int productID, out bool existDefPh)
        {
            List<List<string>> defaultPh = new List<List<string>>();
            List<string> temp = new List<string>();
            dbC.Open();
            string query = "SELECT Objs_ID, Phases_ID, Length FROM DefaultPhases WHERE products_ID = @productID ORDER BY Phases_ID";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@productID", productID);
            SQLiteDataReader reader = command.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                defaultPh.Add(temp);
                defaultPh[i] = new List<string>();
                for (int j = 0; j < reader.FieldCount; j++)
                {
                    string row = reader[reader.GetName(j)].ToString();
                    defaultPh[i].Add(row);
                }
                i++;
            }
            existDefPh = defaultPh.Count > 0;
            dbC.Close();
            return defaultPh;
        }

        public List<int> RowsInOneDefaultPhases(int productID)
        {
            List<int> countRows = new List<int>();
            dbC.Open();
            string query = "SELECT COUNT(*) as ct FROM DefaultPhases WHERE products_ID = @productID GROUP BY Phases_ID";
            command = new SQLiteCommand(query, dbC);
            command.Parameters.AddWithValue("@productID", productID);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int x = int.Parse(reader["ct"].ToString());
                countRows.Add(x); }
            dbC.Close();
            return countRows;
        }
    }

 //   private List<List<int>> Get
}

