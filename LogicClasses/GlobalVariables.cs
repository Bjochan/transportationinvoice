using System;
using System.Data;

namespace TransportationInvoice.LogicClasses
{
    class GlobalVariables
    {
        public static String ApplicationName = "交通旅費請求";
        public class Item
        {
            public string Name;
            public string Value;

            public Item(string name, string value)
            {
                Name = name; Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        public static string Version;
        public static string User;
        public static string userName;
                
        public static int IsAdmin = 0;
               
        public class DataTableHelper
        {
            public DataTable SelectDistinct(string TableName, DataTable SourceTable, string FieldName, string fillter)
            {
                DataTable dt = new DataTable(TableName);
                dt.Columns.Add(FieldName, SourceTable.Columns[FieldName].DataType);

                object LastValue = null;
                foreach (DataRow dr in SourceTable.Select(fillter, FieldName))
                {
                    if (LastValue == null || !(ColumnEqual(LastValue, dr[FieldName])))
                    {
                        LastValue = dr[FieldName];
                        dt.Rows.Add(new object[] { LastValue });
                    }
                }
                return dt;
            }
            private bool ColumnEqual(object A, object B)
            {

                // Compares two values to see if they are equal. Also compares DBNULL.Value.
                // Note: If your DataTable contains object fields, then you must extend this
                // function to handle them in a meaningful way if you intend to group on them.

                if (A == DBNull.Value && B == DBNull.Value) //  both are DBNull.Value
                    return true;
                if (A == DBNull.Value || B == DBNull.Value) //  only one is DBNull.Value
                    return false;
                return (A.Equals(B));  // value type standard comparison
            }
        }
    }
}
