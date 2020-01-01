using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Sales_And_Inventory_Management.DAO;

namespace Sales_And_Inventory_Management.SRV
{
    public class Item
    {
        public Item()
        { }
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
        private string itemdes;

        public string Itemdes
        {
            get { return itemdes; }
            set { itemdes = value; }
        }
        private string uprice;

        public string Uprice
        {
            get { return uprice; }
            set { uprice = value; }
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
        private string itemucom;

        public string Itemucom
        {
            get { return itemucom; }
            set { itemucom = value; }
        }
      

        public DataTable Iteminfo(string uname)               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [item] WHERE itemname='" + this.Itemname + "'";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
        public void Insert()
        {
            string sql = "INSERT INTO [item](itemid,itemname,itemucat,itemucom,itemdes,itemunit) VALUES ('" + this.Itemid + "','" + this.Itemname + "','" + this.Itemucat + "','" + this.Itemucom + "','" + this.Itemdes + "','" + this.Itemunit + "')";
            //string sql = "INSERT INTO [item](itemid,itemname,itemucat.itemucom,itemdes,itemunit,uprice) VALUES ('" + this.Itemid + "','" + this.Itemname + "','" + this.Itemucat + "','" + this.Itemucom+"','" + this.Itemdes +"','" +this.Itemunit +"',+'" + this.Unitprice+ "')";
            DatabaseAccess.ExecuteNonquery(sql);
        }

        public void Insertsitem()
        {
            string sql = "INSERT INTO [sitem](id) VALUES ('" + this.Itemid + "')";
            //string sql = "INSERT INTO [item](itemid,itemname,itemucat.itemucom,itemdes,itemunit,uprice) VALUES ('" + this.Itemid + "','" + this.Itemname + "','" + this.Itemucat + "','" + this.Itemucom+"','" + this.Itemdes +"','" +this.Itemunit +"',+'" + this.Unitprice+ "')";
            DatabaseAccess.ExecuteNonquery(sql);
        }
        public void Updateiteminfo()        //update
        {



            string sql = "UPDATE [item] SET itemname='" + this.Itemname + "',itemucat='" + this.Itemucat + "',itemucom='" + this.Itemucom + "',itemdes='" + this.Itemdes + "' , itemunit='" + this.Itemunit + "' where itemid='" + this.Itemid + "' ";
            DatabaseAccess.ExecuteNonquery(sql);


        }
        public DataTable LoadItemcatinfo()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [Category] order by cname ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }

        public DataTable LoadIteminfo()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [item] order by itemname ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
        public DataTable Loadidinfo()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [item] order by itemid ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
        public void DeleteIteminfo()               //delete 
        {


            string sql = "DELETE FROM [item] WHERE itemname='" + this.Itemname + "'";
            DatabaseAccess.ExecuteNonquery(sql);
        }
        public DataTable LoadItemcominfo()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [User company] order by company_name ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
        public DataTable Loaditeminfo()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [Category] order by cname ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
        public DataTable LoadItemCominfo()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [User Company] order by company_name ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }

        public DataSet searchinpinfobyitemid(string id)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name]  from [item] where itemid like '" + id + "%'  ";

            ds = DatabaseAccess.ExecuteQuery1(sql);
          
            return ds;
        }

        public DataSet searchinpinfobyitemidname(string id,string name)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name]  from [item] where itemid like '" + id + "%' and itemname like '" + name + "%'  ";

            ds = DatabaseAccess.ExecuteQuery1(sql);

            return ds;
        }


        public DataSet searchDN(string id)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name]  from [item] where itemname like '" + id + "%'  ";

            ds = DatabaseAccess.ExecuteQuery1(sql);

            return ds;
        }



        public DataSet searchn(string id)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name] from [item] where itemname like '" + id + "%'  ";

            ds = DatabaseAccess.ExecuteQuery1(sql);

            return ds;
        }

     

        public DataSet searchDiscount(string id)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Category ],itemucom as[Brand],itemdes as[Item Description],itemunit as[Item Unit],price as [Unit Price],vat as[VAT (%)],type as[Discount Type], amount as[Discount]  from (([item] inner join [price] on item.itemid=price.id) inner join [discount]on item.itemid=discount.id) where item.itemid like '" + id + "%' ";

            ds = DatabaseAccess.ExecuteQuery1(sql);

            return ds;
        }

        public DataSet searchDiscountName(string id)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Category ],itemucom as[Brand],itemdes as[Item Description],itemunit as[Item Unit],price as [Unit Price],vat as[VAT (%)],type as[Discount Type], amount as[Discount]  from (([item] inner join [price] on item.itemid=price.id) inner join [discount]on item.itemid=discount.id) where item.itemname like '" + id + "%' ";

            ds = DatabaseAccess.ExecuteQuery1(sql);

            return ds;
        }
      

        public void DeleteIteminfo1()               //delete 
        {


            string sql = "DELETE FROM [discount] WHERE id='" + this.Itemid + "'";
            DatabaseAccess.ExecuteNonquery(sql);
        }

      
        public void DeleteItemQty()               //delete 
        {


            string sql = "DELETE FROM [sitem] WHERE id='" + this.Itemid + "'";
            DatabaseAccess.ExecuteNonquery(sql);
        }
        public void DELETEPrice()
        {
            string sql = "DELETE FROM [price] where id='" + this.Itemid + "'";
            DatabaseAccess.ExecuteNonquery(sql);

        }
        public DataSet searchDiscountNID(string id,string name)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Category ],itemucom as[Brand],itemdes as[Item Description],itemunit as[Item Unit],price as [Unit Price],vat as[VAT (%)],type as[Discount Type], amount as[Discount]  from (([item] inner join [price] on item.itemid=price.id) inner join [discount]on item.itemid=discount.id) where item.itemid like '" + id + "%'and item.itemname like '" + name + "%' ";

            ds = DatabaseAccess.ExecuteQuery1(sql);

            return ds;
        }

        public DataSet searchAllItem()
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Category ],itemucom as[Brand],itemdes as[Item Description],itemunit as[Item Unit],price as [Unit Price],vat as[VAT (%)],type as[Discount Type], amount as[Discount]  from (([item] inner join [price] on item.itemid=price.id) inner join [discount]on item.itemid=discount.id)  ";

            ds = DatabaseAccess.ExecuteQuery1(sql);

            return ds;
        }

       

        public DataSet searchItemName(string id)
        {
            DataSet ds = new DataSet();
            string sql = "select itemid as [Item Id],itemname as[Item Name],itemucat as[Category ],itemucom as[Brand],itemdes as[Item Description],itemunit as[Item Unit],price as [Unit Price],vat as[VAT],type as[Discount Type], amount as[Discount]  from [item],[price],[discount] where item.itemname like '" + id + "%' and price.name like '" + id + "' and discount.name like '" + id + "'";
            ds = DatabaseAccess.ExecuteQuery1(sql);
            return ds;
        }
          

        
    }
}
