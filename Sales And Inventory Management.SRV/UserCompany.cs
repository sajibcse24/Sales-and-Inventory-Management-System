using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Sales_And_Inventory_Management.DAO;

namespace Sales_And_Inventory_Management.SRV
{
    public class UserCompany
    {
        public UserCompany()
        { }
        private string companyname;

        public string Companyname
        {
            get { return companyname; }
            set { companyname = value; }
        }

        private string companyid;

        public string Companyid
        {
            get { return companyid; }
            set { companyid = value; }
        }

        public void Insert()
        {
            string sql = "INSERT INTO [User Company](company_name,company_Id)VALUES ('" + this.Companyname + "','" + this.Companyid + "')";
            DatabaseAccess.ExecuteNonquery(sql);
        }
        public void DeleteCompanyinfo()               //delete 
        {


            string sql = "DELETE FROM [User Company] WHERE company_name='" + this.Companyname + "'";
            DatabaseAccess.ExecuteNonquery(sql);
        }


        public void UpdateCompanyinfo()        //update
        {



            string sql = "UPDATE [User Company] SET company_name='" + this.Companyname + " ' where company_Id='" + this.Companyid + " '";
            DatabaseAccess.ExecuteNonquery(sql);


        }

        public DataTable Companyinfo(string id,string uname)               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [User Company] WHERE company_Id='"+id+ "' or company_name='" + uname + "'";
           dt= DatabaseAccess.ExecuteQuery(sql);
           return dt;
        }
        public DataTable Loadid()               //delete 
        {

            DataTable dt = new DataTable();
            string sql = "select * FROM [User Company] order by company_Id ";
            dt = DatabaseAccess.ExecuteQuery(sql);
            return dt;
        }

    }
}
