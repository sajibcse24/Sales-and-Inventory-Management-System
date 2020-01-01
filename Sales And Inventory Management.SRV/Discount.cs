using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sales_And_Inventory_Management.DAO;
using System.Data;
using System.Data.SqlClient;


namespace Sales_And_Inventory_Management.SRV
{
   public class Discount
    {
        public Discount()
        { }
        private string itemid;

        public string Itemid
        {
            get { return itemid; }
            set { itemid = value; }
        }

        private string itemname;

        public string Itemname
        {
            get { return itemname; }
            set { itemname = value; }
        }
        private string itemtype;

        public string Itemtype
        {
            get { return itemtype; }
            set { itemtype = value; }
        }
        private string itemamount;

        public string Itemamount
        {
            get { return itemamount; }
            set { itemamount = value; }
        }



        public void Insert()
        {
            string sql = "INSERT INTO [discount](id,type,amount) VALUES ('" + this.Itemid + "','" + this.Itemtype + "','" + this.Itemamount + "')";
            DatabaseAccess.ExecuteNonquery(sql);

        }

        public void UpdateDiscountinfo()        //update
        {


            // string sql = "UPDATE [item] SET itemname='" + this.Itemname + "',itemucat='" + this.Itemucat + "',itemucom='" + this.Itemucom + "',itemdes='" + this.Itemdes + "' , itemunit='" + this.Itemunit + "' where itemid='" + this.Itemid + "' ";
            string sql = "UPDATE [discount] SET type='" + this.Itemtype + " ',amount='" + this.Itemamount + "' where id='" + this.Itemid + " '";
            DatabaseAccess.ExecuteNonquery(sql);


        }


        public DataTable idinfo(string id)               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [item] WHERE itemid='" + this.Itemid + "' ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
        /*  public DataTable Loadidinfo()               //delete 
          {

              DataTable dt = new DataTable();
              string sql = "select * FROM [price] order by id ";
              dt = DatabaseAccess.ExecuteQuery(sql);
              return dt;
          }*/
      
      

       
        public DataTable Iteminfo(string uname)               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [discount] WHERE id='" + this.Itemid + "'";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
  
 

    }
}
