using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI.WebControls;

namespace CommonSqlClass
{
    /// <summary>
    /// This class contains the Helper function related to Fetching data and Loading data in Data set
    /// </summary>
    public static class MySqlFunctions
    {
        //Created a refrence variable of required classes 
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader rdr;
        static DataTable dt;

        //Method for Fetching Data From user Query
        public static SqlDataReader FetchReaderData(string uquery, string str)
        {
            //Passing the Connection string to the SqlConnection
            con = new SqlConnection(str);

            //Sql Query
            string query = uquery;
            cmd = new SqlCommand(query, con);

            //Opening the Connection
            con.Open();

            //Reading the query output
            rdr = cmd.ExecuteReader();

            return rdr;
        }

        //Method for Fetching Single Cell value
        public static object FetchSingleData(string uquery, string str)
        {
            //Passing the Connection string to the SqlConnection
            con = new SqlConnection(str);

            //Sql Query
            string query = uquery;
            cmd = new SqlCommand(query, con);

            //Opening the Connection
            con.Open();

            //Reading the query output only single value is return in the form of object
            object obj = cmd.ExecuteScalar();

            return obj;
        }

        //Load Data in the Grid 
        public static void LoadData(GridView gd, string query, string str)
        {
            rdr = FetchReaderData(query, str);
            dt = new DataTable();
            dt.Load(rdr);
            gd.DataSource = dt;
            gd.DataBind();
        }

        //Load DropDownList
        public static void LoadDDL(DropDownList ddl, string query, string str)
        {
            ddl.Items.Clear();
            rdr = FetchReaderData(query, str);
            while (rdr.Read())
            {
                ddl.Items.Add(rdr[0].ToString());
            }
        }

    }
}
