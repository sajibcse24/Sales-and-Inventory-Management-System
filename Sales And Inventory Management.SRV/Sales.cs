using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Sales_And_Inventory_Management.DAO;

namespace Sales_And_Inventory_Management.SRV
{
   public  class Sales
    {
       public Sales()
       { }
       private string date;

       public string Date
       {
           get { return date; }
           set { date = value; }
       }
       private string time;

       public string Time
       {
           get { return time; }
           set { time = value; }
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

       private string uprice;

       public string Uprice
       {
           get { return uprice; }
           set { uprice = value; }
       }
       private string quantity;

       public string Quantity
       {
           get { return quantity; }
           set { quantity = value; }
       }
       private string stotal;

       public string Stotal
       {
           get { return stotal; }
           set { stotal = value; }
       }
       private string vat;

       public string Vat
       {
           get { return vat; }
           set { vat = value; }
       }
       private string discount;

       public string Discount
       {
           get { return discount; }
           set { discount = value; }
       }
       private string gtotal;

       public string Gtotal
       {
           get { return gtotal; }
           set { gtotal = value; }
       }
       private string net;

       public string Net
       {
           get { return net; }
           set { net = value; }
       }
       private string tpayment;

       public string Tpayment
       {
           get { return tpayment; }
           set { tpayment = value; }
       }
       private string pdue;

       public string Pdue
       {
           get { return pdue; }
           set { pdue = value; }
       }
       private string damount;

       public string Damount
       {
           get { return damount; }
           set { damount = value; }
       }
       private string totalamount;

       public string Totalamount
       {
           get { return totalamount; }
           set { totalamount = value; }
       }
       private string iamount;

       public string Iamount
       {
           get { return iamount; }
           set { iamount = value; }
       }
       private string payment;

       public string Payment
       {
           get { return payment; }
           set { payment = value; }
       }
       private string due;

       public string Due
       {
           get { return due; }
           set { due = value; }
       }
       private string month;

       public string Month
       {
           get { return month; }
           set { month = value; }
       }
       private string year;

       public string Year
       {
           get { return year; }
           set { year = value; }
       }
       private string mno;

       public string Mno
       {
           get { return mno; }
           set { mno = value; }
       }

       private string itemunit;

       public string Itemunit
       {
           get { return itemunit; }
           set { itemunit = value; }
       }
      
       public void UpdateStock()        //update
       {



           string sql = "UPDATE [sale] SET iamount='" + this.Stotal + "',vat='" + this.Vat + "',net='" + this.Net + "',discount='" + this.Discount + "' , damount='" + this.Damount + "',totalamount='" + this.Totalamount + "',payment='" + this.Payment + "',due='" + this.Due + "',month1='" + this.Month + "',year1='" + this.Year + "' where invoice='" + this.Invoice + "' ";
           DatabaseAccess.ExecuteNonquery(sql);


       }
       public void UpdateS()        //update
       {



           string sql = "UPDATE [stock] SET itemunit='" + this.Itemunit + "' where itemid='" + this.Itemid + "' ";
           DatabaseAccess.ExecuteNonquery(sql);


       }
     

       public DataTable Checkinfo(string invoice,string id)               //delete 
       {

           DataTable dt = new DataTable();
           string sql = "select * FROM [sales] WHERE  invoice='" + this.Invoice + "' and id='"+this.Itemid+"'";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public void Insert()
       {
           string sql = "INSERT INTO [sold_item](id,quantity,subtotal,invoice) VALUES ('" + this.Itemid + "','" + this.Quantity + "','" + this.Stotal + "' ,'" + this.Invoice + "')";
           //string sql = "INSERT INTO [item](itemid,itemname,itemucat.itemucom,itemdes,itemunit,uprice) VALUES ('" + this.Itemid + "','" + this.Itemname + "','" + this.Itemucat + "','" + this.Itemucom+"','" + this.Itemdes +"','" +this.Itemunit +"',+'" + this.Unitprice+ "')";
           DatabaseAccess.ExecuteNonquery(sql);
       }

       public void Insert1()
       {
           string sql = "INSERT INTO [sales](date,time,mno,m,y,payment) VALUES ('" + this.Date + "','" + this.Time + "','" + this.Mno + "','" + this.Month + "','" + this.Year + "','" + this.Payment + "')";
           //string sql = "INSERT INTO [item](itemid,itemname,itemucat.itemucom,itemdes,itemunit,uprice) VALUES ('" + this.Itemid + "','" + this.Itemname + "','" + this.Itemucat + "','" + this.Itemucom+"','" + this.Itemdes +"','" +this.Itemunit +"',+'" + this.Unitprice+ "')";
           DatabaseAccess.ExecuteNonquery(sql);
       }
       public DataTable idinfo(string id)               //delete 
       {

           DataTable dt = new DataTable();

           string sql = " select item.itemname,item.itemunit,vat,price,discount.type,amount,qty from item,price,discount,sitem where item.itemid='" + id + "' and price.id='" + id + "' and discount.id='" + id + "' and sitem.id='"+id+"'  ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }

       public DataTable invoice1()               //delete 
       {

           DataTable dt = new DataTable();
           // string sql = "select * FROM [item] WHERE itemid='" + this.Itemid + "' ";
           //string sql1 = " select type,amount from item join discount on item.itemid='" + id + "' and discount.id='" + id1 + "' ";
           string sql = " select invoice from sales  ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }
       public DataTable id(string id)               //delete 
       {

           DataTable dt = new DataTable();
           // string sql = "select * FROM [item] WHERE itemid='" + this.Itemid + "' ";
           string sql = " select type,amount from discount where id='"+id +"' ";
         //  string sql = " select itemname ,itemunit,vat,price from item join price on item.itemid='" + id + "' and price.id='" + id1 + "' ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }

       public DataTable LoadInfoDbill(string id)
       {

           DataTable dt = new DataTable();
          // string sql = "select date,sold_item.id,itemname,sum(quantity) as qty,price,sum(subtotal) as stotal from item,price,sales,sold_item where sold_item.id=item.itemid and sold_item.id=price.id   and sales.invoice=sold_item.invoice and date='04/21/2015' group by date,itemname,price,sold_item.id ";
           string sql = "select sales.invoice,sold_item.id,itemname,quantity,itemunit,price,vat,type,amount,subtotal,payment from item,price,discount,sales,sold_item where sold_item.id=item.itemid and sold_item.id=price.id  and sold_item.id=discount.id and sales.invoice='" + id + "' and sold_item.invoice='" + id + "' order by sold_item.id  ";
           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }

       public DataTable ReportPeriod(string id,string id1)
       {
           DataTable dt = new DataTable();
           string sql = "select date,sold_item.id,itemname,sum(quantity)as qty,sum(subtotal)as stotal,price as p from sold_item,sales,item,price where sales.invoice=sold_item.invoice and sold_item.id=item.itemid and sold_item.id=price.id and date between '" + id + "' and '" + id1+ "' group by date,itemname,sold_item.id ,price";

           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }

       public DataTable ReportDaily(string id)
       {
           DataTable dt = new DataTable();
           string sql = "select date,sold_item.id,itemname,sum(quantity)as qty,sum(subtotal)as stotal,price as p from sold_item,sales,item,price where sales.invoice=sold_item.invoice and sold_item.id=item.itemid and sold_item.id=price.id and date='"+id+"' group by date,itemname,sold_item.id ,price";

           dt = DatabaseAccess.ExecuteQuery(sql);
           return dt;
       }



       public DataSet daily(string id)
       {
           DataSet ds = new DataSet();
           // string sql = "select   title as[Book Title ], author as[Author],cno as[Call No], vol as[Volume], edition as[Edition], imprint as[Imprint], isbn as[ISBN], sup as[Supplier], price as[Price],count(*) as [Avilable Copy], dept as[Department] from [book] where title like '" + id + "%' and icopy is null  group by cno,title,author,vol,edition,imprint,isbn,sup,price,dept ";
           string sql = "select invoice as [Invoice No],totalamount as[Total Amount],due as[Payment] from [sale] where date = '" + id + "'order by date ";

           ds = DatabaseAccess.ExecuteQuery1(sql);
           return ds;
       }

      

       //public DataSet  yearly(string  id)
      // {
         //  DataSet ds = new DataSet();
          // string sql = "select   title as[Book Title ], author as[Author],cno as[Call No], vol as[Volume], edition as[Edition], imprint as[Imprint], isbn as[ISBN], sup as[Supplier], price as[Price],count(*) as [Avilable Copy], dept as[Department] from [book] where title like '" + id + "%' and icopy is null  group by cno,title,author,vol,edition,imprint,isbn,sup,price,dept ";
         //  string sql = "select distinct month1 as[Month],sum(totalamount) as[Total Amount] from [sale] where year1 = '" + id + "'group by month1 ";

          //ds= DatabaseAccess.ExecuteQuery1(sql);
          // return ds;
     //  }

       public DataTable yearlyReport(string id)
       {
           DataTable ds = new DataTable();
           // string sql = "select   title as[Book Title ], author as[Author],cno as[Call No], vol as[Volume], edition as[Edition], imprint as[Imprint], isbn as[ISBN], sup as[Supplier], price as[Price],count(*) as [Avilable Copy], dept as[Department] from [book] where title like '" + id + "%' and icopy is null  group by cno,title,author,vol,edition,imprint,isbn,sup,price,dept ";
           string sql = "select m,sum(subtotal) as total from sales,sold_item where y='"+id+"' and sales.invoice=sold_item.invoice group by m,mno";

           ds = DatabaseAccess.ExecuteQuery(sql);
           return ds;
       }

       public DataTable MonthlyReport(string id,string id1)
       {
           DataTable ds = new DataTable();
           // string sql = "select   title as[Book Title ], author as[Author],cno as[Call No], vol as[Volume], edition as[Edition], imprint as[Imprint], isbn as[ISBN], sup as[Supplier], price as[Price],count(*) as [Avilable Copy], dept as[Department] from [book] where title like '" + id + "%' and icopy is null  group by cno,title,author,vol,edition,imprint,isbn,sup,price,dept ";
           string sql = "select date,sum(subtotal) as total from sales,sold_item where y='" + id + "' and m='"+id1+"' and sales.invoice=sold_item.invoice group by date";

           ds = DatabaseAccess.ExecuteQuery(sql);
           return ds;
       }

       public DataSet monthly(string id)
       {
           DataSet ds = new DataSet();
           // string sql = "select   title as[Book Title ], author as[Author],cno as[Call No], vol as[Volume], edition as[Edition], imprint as[Imprint], isbn as[ISBN], sup as[Supplier], price as[Price],count(*) as [Avilable Copy], dept as[Department] from [book] where title like '" + id + "%' and icopy is null  group by cno,title,author,vol,edition,imprint,isbn,sup,price,dept ";
           string sql = "select distinct month1 as[Month],sum(totalamount) as[Total Amount] from [sale] where month1 = '" + id + "'group by month1 ";

           ds = DatabaseAccess.ExecuteQuery1(sql);
           return ds;
       }

       public DataSet period(string id,string id1)
       {
           DataSet ds = new DataSet();
           // string sql = "select   title as[Book Title ], author as[Author],cno as[Call No], vol as[Volume], edition as[Edition], imprint as[Imprint], isbn as[ISBN], sup as[Supplier], price as[Price],count(*) as [Avilable Copy], dept as[Department] from [book] where title like '" + id + "%' and icopy is null  group by cno,title,author,vol,edition,imprint,isbn,sup,price,dept ";
           string sql = "select invoice as [Invoice No],totalamount as[Total Amount],due as[Payment] from [sale] where date between '" + id + "' and '" + id1 + "' order by date ";

           ds = DatabaseAccess.ExecuteQuery1(sql);
           return ds;
       }

       public DataSet searchinfo(string invoice)
       {
           DataSet ds = new DataSet();
           string sql = "select id as [Item ID],quantity as [Quantity], subtotal as [Amount] from sales where invoice='"+invoice+"' ";
           ds = DatabaseAccess.ExecuteQuery1(sql);
           return ds;
       }

    }
}
