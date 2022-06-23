using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheReaLState.Models;
using System.Data.SqlClient;
using System.Data;

namespace TheReaLState.Manager
{
    public class AddPropertyManager : GeneralManager
    {
        public static int UserID = 0;
        public void IDInsert(AddPropertyModel AP)
        {
            string Query = "select * from Users Where Username = '" + AP.Username + "' and Password = '" + AP.Password + "'";
            Con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(Query, Con);
            DA.Fill(dt);
            Con.Close();
            foreach (DataRow Row in dt.Rows)
            {
                UserID = Convert.ToInt32(Row["UserID"]);
            }

        }
        public int Homes(AddPropertyModel AP)
        {
            IDInsert(AP);
            string Query = "insert into dbo.Practice(UserID, City, [Location], PropertyType, Price, AreaInSqYd, Bedrooms, TVLounge, OutsideGarden, WestOpen, Corner, image) values ('" + UserID + "','" + AP.City + "','" + AP.Location + "','" + AP.PropertyType + "','" + AP.Price + "','" + AP.LandArea + "','" + AP.Bedrooms + "','" + AP.TVLounge + "','" + AP.OutsideGarden + "','" + AP.WestOpen + "','" + AP.Corner + "','" + AP.ImageUrl + "')";
            SqlCommand cmd = new SqlCommand(Query, Con);
            Con.Open();
            int a = cmd.ExecuteNonQuery();
            Con.Close();
            return a;
        }
    }
}