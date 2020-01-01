using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Sales_And_Inventory_Management.DAO;

namespace Sales_And_Inventory_Management.SRV
{
    public class category
    {
        public category()
        { }
        private string categoryname;

        public string Categoryname
        {
            get { return categoryname; }
            set { categoryname = value; }
        }
        private string categoryid;

        public string Categoryid
        {
            get { return categoryid; }
            set { categoryid = value; }
        }
        private string categorydes;

        public string Categorydes
        {
            get { return categorydes; }
            set { categorydes = value; }
        }

        public void Insert()
        {
            string sql = "INSERT INTO [Category](cname,cdes)VALUES ('" + this.Categoryname + "','" + this.Categorydes + "')";
            DatabaseAccess.ExecuteNonquery(sql);
        }
        public DataTable Companyinfo(string uname,string id)               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [Category] WHERE cname='"+uname+"' or cid='"+id+"' ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
        public void UpdateCategoryinfo()        //update
        {



            string sql = "UPDATE [Category] SET cname='" + this.Categoryname + "',cdes='" + this.Categorydes +  "' where cid='"+ this.Categoryid+"' ";
            DatabaseAccess.ExecuteNonquery(sql);


        }
        public void DeleteCompanyinfo()               //delete 
        {


            string sql = "DELETE FROM [Category] WHERE cname='" + this.Categoryname + "'";
            DatabaseAccess.ExecuteNonquery(sql);
        }

        public DataTable Categoryinfo(string uname)               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [Category] WHERE cid='" + this.Categoryid + "' ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }

        public DataTable LoadCategoryinfo()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select cid FROM [Category] order by cid ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }
    }
}
