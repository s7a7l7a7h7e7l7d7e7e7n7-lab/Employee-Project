#region
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

#endregion

namespace employee
{
    class basic
    {
        // بيانات عن الرسائل التي تظهر عند كل ضغطه زر على حفظ او غيره في اي فورم
       
        #region
        public static string use = "";
        public static string psw = "";
        public static string namecom = "";

        // عند اتمام العمليه بدون مشاكل
 /* محتوى الرساله*/ public static string boodysave = "هل تريد الحفظ",/*راس الرساله*/ titlesave = "أستمرار العمليه";
        public static string boodyupdate = "هل تريد التعديل", titleupdate = "أستمرار العمليه";
        public static string boodydelete = "هل تريد الحذف", titledelete = "أستمرار العمليه";
        // عند وجود اي مشكله او خطا
        public static string boodysaveerr = "لم يتم الحفظ", titlesaveerr = "خطأ";
        public static string boodyupdateerr = "لم يتم التعديل", titleupdateerr = "خطأ";
        public static string boodydeleteerr = "لم يتم الحذف", titledeleteerr = "خطأ";
        public static string boodyselect = "فشل البحث", titleselect = "لاتوجد بيانات بهذه الارقام";
        #endregion

        // بيانات عن مسار قاعده البيانات والاتصال بها

        #region


        public static string s = "'";
        public static string username = "data";// اسم المستخدم
        public static string passowrd = "information";// كلمه المرور
        public static string connect = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\dilow.mdb;Persist Security Info=True;Jet OLEDB:Database Password=1980";

 #endregion

        // العمليات في كل فورم مثل الحفظ والتعديل والحذف والاستعلام

        #region

        public static void save(string tables, params string[] colomn)
        {
            OleDbConnection ole = new OleDbConnection(basic.connect);
            OleDbCommand olec = new OleDbCommand();
            try
            {
                string text = "INSERT INTO " + tables + " VALUES ( " + colomn[0];

                for (int i = 1; i < colomn.Length; i++)
                {
                    text = text + "," + colomn[i];
                }
                text = text + " )";
                olec.Connection = ole;
                olec.CommandText = text; 
                ole.Open();

                try
                {
                    olec.ExecuteNonQuery();
                    MessageBox.Show("تمت عمليه الحفظ بنجاح", "نحاح");
                    ole.Close();
                }
                catch
                { 
                   
                 MessageBox.Show("هذه المعلومات مكرره وموجوده من قبل","لم يتم الحفظ"); ole.Close(); return; }
               
            }
            catch (Exception ms)
            {
                throw new Exception(ms.Message);
            }
        }

        public static void edit(string tables, string becouse, params string[] colomn)
        {
            OleDbConnection ole = new OleDbConnection(basic.connect);
            OleDbCommand olec = new OleDbCommand();

            try {
                string text = "UPDATE " + tables + "SET " + colomn[0];
                for (int i = 1; i < colomn.Length; i++)
                {
                    text = text + " , " + colomn[i];
                }
                if (becouse != null)
                {
                    text = text + " WHERE " + becouse;
                }
                olec.Connection = ole;
                olec.CommandText = text;
                ole.Open();
                olec.ExecuteNonQuery();
                ole.Close();
                MessageBox.Show("تمت عمليه التعديل بنجاح","نجاح");
            }
            catch(Exception ms){throw new Exception(ms.Message);}

        }

        public static DataSet choise(string tables,string[] becouse,params string[] colomn)
        {
            OleDbConnection ole = new OleDbConnection(basic.connect);
            DataSet result;
            try {
                string text = "SELECT " + colomn[0];
                for (int i = 1; i < colomn.Length; i++)
                {
                    text += " , " + colomn[i];
                }
                text = text + " FROM " + tables;

                if (becouse != null)
                {
                    text += " WHERE ";
                    for (int i = 0; i < becouse.Length; i++)
                    {
                        text += becouse[i] + " ";
                    } 

                } 
                OleDbDataAdapter adapter = new OleDbDataAdapter(text,ole);
                DataSet work = new DataSet();
                adapter.Fill(work, tables);
                ole.Close();
                result = work;

                          
            }
            catch (Exception ms)
            {
                throw new Exception(ms.Message);
            }
            return result;
        }

        public static void clear(string tables, params string[] becouse)
        {
            OleDbConnection ole = new OleDbConnection(basic.connect);
            OleDbCommand olec = new OleDbCommand();
            try
            {
                string text = "DELETE FROM " + tables;

                if (becouse != null)
                {
                    text += " WHERE ";
                    for (int i = 0; i < becouse.Length; i++)
                    {
                        text = text + " " + becouse[i];
                    }
                }
                olec.Connection = ole;
                olec.CommandText = text;
                ole.Open();
                olec.ExecuteNonQuery();
                ole.Close();
                MessageBox.Show("تمت عمليه الحذف بنجاح","نجاح");
                
            }

            catch(Exception ms)
            {
                throw new Exception(ms.Message);
            }
        }
       
        public static void clearall(params string[] tabll)
        {
            OleDbConnection ole = new OleDbConnection(basic.connect);
            OleDbCommand olec = new OleDbCommand();
            try
            {
                string text = "DELETE FROM " + tabll[0];

                
           
                    
                    for (int i = 1; i == tabll.Length; i++)
                    {
                        text = text + " " + tabll[i];
                    }
              
                olec.Connection = ole;
                olec.CommandText = text;
                ole.Open();
                olec.ExecuteNonQuery();
                ole.Close();
                MessageBox.Show("لقد تم حذف جميع البيانات من قاعده البيانات", "تم تصفير قاعده البيانات");

            }

            catch (Exception ms)
            {
                throw new Exception(ms.Message);
            }
        }
       
        #endregion
    
    
    
    }
}
