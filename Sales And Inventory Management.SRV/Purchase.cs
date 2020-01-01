using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sales_And_Inventory_Management.DAO;
using System.Data;

namespace Sales_And_Inventory_Management.SRV
{
   public  class Purchase
    {
       public Purchase()
       { }
       private string time;

       public string Time
       {
           get { return time; }
           set { time = value; }
       }
       private string date;
      
       public string Date
       {
           get { return date; }
           set { date = value; }
       }
       private string invoice;

       public string Invoice
       {
           get { return invoice; }
           set { invoice = value; }
       }
       private string itemname;

       public string Itemname
       {
           get { return itemname; }
           set { itemname = value; }
       }

       private string itemid;

       public string Itemid
       {
           get { return itemid; }
           set { itemid = value; }
       }
     
      
       private string itemunit;

       public string Itemunit
       {
           get { return itemunit; }
           set { itemunit = value; }
       }
       private string itemucat;

       public string Itemucat
       {
           get { return itemucat; }
           set { itemucat = value; }
       }
      
       private string unitprice;

       public string Unitprice
       {
           get { return unitprice; }
           set { unitprice = value; }
       }

       private string Qty;

       public string Qty1
       {
           get { return Qty; }
           set { Qty = value; }
       }
       public DataTable Categoryinfo(string q, string p)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [stock] WHERE invoice='" + this.Invoice + "' and itemid='" + this.Itemid+"' ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public DataTable idinfo(string id)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select itemid,itemname,itemucat,qty FROM [item] ,[sitem] where item.itemid='"+id+"' and sitem.id='" + id + "'   ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }

       public DataTable idinfostock(string id)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select itemname,itemucat,qty FROM [item] inner join [sitem] on item.itemid=sitem.id where item.itemid='"+id+"' ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }


       public DataTable idinfoqty(string id)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [sitem]  WHERE itemid='" + this.Itemid + "'  ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public DataTable Loadinvoiceinfo()               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [stock] order by invoice ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public void Insert()
       {
           string sql = "INSERT INTO [stock](date,invoice,itemid,itemname,itemucat,itemunit,uprice,time) VALUES ('" + this.Date + "','" + this.Invoice + "','" + this.Itemid + "','" + this.Itemname + "','" + this.Itemucat + "','" + this.Itemunit + "','" + this.Unitprice + "','" + this.Time + "')";
           //string sql = "INSERT INTO [item](itemid,itemname,itemucat.itemucom,itemdes,itemunit,uprice) VALUES ('" + this.Itemid + "','" + this.Itemname + "','" + this.Itemucat + "','" + this.Itemucom+"','" + this.Itemdes +"','" +this.Itemunit +"',+'" + this.Unitprice+ "')";
           DatabaseAccess.ExecuteNonquery(sql);
       }

     

       public DataTable Checkinfo(string uname, string id,string date,string time)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [stock] WHERE itemid='" + this.Itemid + "' and invoice='" + this.Invoice + "'";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public void Updateiteminfo()        //update
       {



           string sql = "UPDATE [stock] SET itemname='" + this.Itemname + "',itemucat='" + this.Itemucat + "',itemunit='" + this.Itemunit + "' , uprice='" + this.Unitprice  + "' where itemid='" + this.Itemid + "' and invoice='"+ this.Invoice+"'  ";
           DatabaseAccess.ExecuteNonquery(sql);


       }

       public void Updateiteminfoqty()        //update
       {



           string sql = "UPDATE [sitem] SET qty='" + this.Itemunit + "' where id='" + this.Itemid + "'  ";
           DatabaseAccess.ExecuteNonquery(sql);


       }
    }
}
