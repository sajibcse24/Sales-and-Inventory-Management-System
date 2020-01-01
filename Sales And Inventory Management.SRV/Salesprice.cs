using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Sales_And_Inventory_Management.DAO;

namespace Sales_And_Inventory_Management.SRV
{
   public class Salesprice
    {
       public Salesprice()
       { }
       private string vat;

       public string Vat
       {
           get { return vat; }
           set { vat = value; }
       }
       private string id;

       public string Id
       {
           get { return id; }
           set { id = value; }
       }

       private string name;

       public string Name
       {
           get { return name; }
           set { name = value; }
       }

       private string price;

       public string Price
       {
           get { return price; }
           set { price = value; }
       }
       public void Insert()
       {
           string sql = "INSERT INTO [price](id,price,vat) VALUES ('" + this.Id + "','" + this.Price + "','" + this.Vat + "')";
           DatabaseAccess.ExecuteNonquery(sql);

       }
     
       public DataTable idinfo(string id)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [item] WHERE itemid='" + this.Id + "' ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public DataTable Loadidinfo()               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [price] order by id ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public DataTable Iteminfo(string uname)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [price] WHERE id='" + this.Id + "'";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }

       public void UpdateDiscountinfo()        //update
       {


           // string sql = "UPDATE [item] SET itemname='" + this.Itemname + "',itemucat='" + this.Itemucat + "',itemucom='" + this.Itemucom + "',itemdes='" + this.Itemdes + "' , itemunit='" + this.Itemunit + "' where itemid='" + this.Itemid + "' ";
           string sql = "UPDATE [price] SET price='" + this.Price + " ',vat='" + this.Vat + "' where id='" + this.Id + " '";
           DatabaseAccess.ExecuteNonquery(sql);


       }
    }
}
