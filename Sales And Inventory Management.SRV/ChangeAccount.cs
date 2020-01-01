using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Sales_And_Inventory_Management.DAO;

namespace Sales_And_Inventory_Management.SRV
{
  public   class ChangeAccount
    {
      public ChangeAccount()
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
      private string nuname;

      public string Nuname
      {
          get { return nuname; }
          set { nuname = value; }
      }

      public DataTable LoadPass(string uname,string utype)
      {
          DataTable dt = new DataTable();
          string sql = "SELECT * from login where uname='" + this.Uname + "'and utype='" + this.Utype + "' ";
          dt = DatabaseAccess.ExecuteQuery(sql);
          return dt;

      }
      public DataTable LoadAccount(string uname, string pass,string utype)
      {
          DataTable dt = new DataTable();
          string sql = "SELECT * from login where uname='" + this.Uname + "' and pass='" + this.Pass + "' and utype='" + this.Utype + "'";
          dt = DatabaseAccess.ExecuteQuery(sql);
          return dt;

      }

      public void updateaccount()          // update student
      {
          try
          {


              string Query = "UPDATE [login] SET uname='" + this.Nuname + "',pass='" + this.Pass + "' where uname='" + this.Uname + "' and utype='" + this.Utype + "'";
              DatabaseAccess.ExecuteNonquery(Query);
             

          }
          catch (Exception e)
          {
              throw new Exception(e.Message, e);
          }
      }



       
    }
}
