using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Sales_And_Inventory_Management.DAO;

namespace Sales_And_Inventory_Management.SRV
{
   public class Login
    {
       public Login()
       {
           Uname = String.Empty;
           Pass = String.Empty;
           
       }
      
       private string uname;

      public string Uname
      {
          get { return uname; }
          set { uname = value; }
      }
      private string pass;

      public string Pass
      {
          get { return pass; }
          set { pass = value; }
      }
      private string utype;

      public string Utype
      {
          get { return utype; }
          set { utype = value; }
      }
      private string email;

      public string Email
      {
          get { return email; }
          set { email = value; }
      }

      public DataTable LoadAccount(string uname,string pass,string utype)
      {
          DataTable dt=new DataTable();
          string sql = "SELECT * from login where uname='" + this.Uname + "' and pass='" + this.Pass + "' and utype='" + this.Utype + "'";
          dt=DatabaseAccess.ExecuteQuery(sql);
          return dt;
          
      }

      public void Insert()
      {
          string sql = "INSERT INTO [login](uname,pass,utype)VALUES ('" + this.Uname + "','" + this.Pass + "','" + this.Utype + "')";
          DatabaseAccess.ExecuteNonquery(sql);
      }
      public DataTable LoadUser(string uname)
      {
          DataTable dt = new DataTable();
          string sql = "SELECT * from login where uname='" + uname + "'";
          dt = DatabaseAccess.ExecuteQuery(sql);
          return dt;

      }
    
      
    
    }
}
