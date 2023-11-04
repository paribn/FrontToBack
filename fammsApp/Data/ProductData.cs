using fammsApp.Entities;
using Microsoft.Data.SqlClient;
using System.Data;
namespace fammsApp.Data;
public class ProductData
{
    private const string SqlConnectionString = "Server=DOCUMENT\\SQLEXPRESS;Database=FammsDB;Trusted_Connection=True;Encrypt=false;Trusted_Connection=True;";
    public static List<Products> ListProducts()
    {
        SqlConnection con = null;
        DataSet ds = null;
        List<Products> products = new();

        try
        {
            con = new SqlConnection(SqlConnectionString);
            var cmd = new SqlCommand("SELECT * FROM dbo.FamProducts", con);
            con.Open();

            var da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                var product = new Products();
                product.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                product.Price = Convert.ToDecimal(ds.Tables[0].Rows[i]["Price"].ToString());

                product.ImagePath = ds.Tables[0].Rows[i]["ImagePath"].ToString();

                products.Add(product);
            }

        }
        finally
        {
            con.Close();
        }
        return products;
    }
}
