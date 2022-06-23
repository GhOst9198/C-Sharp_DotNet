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
    public class BuyManager : GeneralManager
    {
        public static string[] array = new string[11];
        /*public static bool [] array1 = new bool[4];*/
        /*public int Homes(BuyModel Buy)
        {
            string Query = "insert into dbo.Practice(City, [Location], PropertyType, PriceRange, AreaInSqYd, Bedrooms, TVLounge, OutsideGarden, WestOpen, Corner) values ('" + Buy.City + "','" + Buy.Location + "','" + Buy.PropertyType + "','" + Buy.PriceRange + "','" + Buy.AreaInSqYd + "','" + Buy.Bedrooms + "','" + Buy.TVLounge + "','" + Buy.OutsideGarden + "','" + Buy.WestOpen + "','" + Buy.Corner + "')";
            SqlCommand cmd = new SqlCommand(Query, Con);
            Con.Open();
            int a = cmd.ExecuteNonQuery();
            Con.Close();
            return a;
        }*/
        public int Homes(BuyModel Buy)
        {
            int a = 0;

            array[0] = Buy.City;
            array[1] = Buy.Location;
            array[2] = Buy.PropertyType;
            array[3] = Convert.ToString(Buy.MinPriceRange);
            array[4] = Convert.ToString(Buy.MaxPriceRange);
            array[5] = Buy.AreaInSqYd;
            array[6] = Buy.Bedrooms;
            array[7] = Convert.ToString(Buy.TVLounge);
            array[8] = Convert.ToString(Buy.OutsideGarden);
            array[9] = Convert.ToString(Buy.WestOpen);
            array[10] = Convert.ToString(Buy.Corner);
            return a;
        }
        public List<BuyModel> SelectBuy()
        {
            List<BuyModel> BuyProperties = new List<BuyModel>();
            
            if (array [0] == null && array[1] == null && array[2] == null && array[3] == null && array[4] == null && array[5] == null && array[6] == null)
            {
                string Query = "select * from Practice";
                Con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(Query, Con);
                DA.Fill(dt);
                Con.Close();
                foreach (DataRow Row in dt.Rows)
                {
                    BuyModel BM = new BuyModel()
                    {
                        PropertyID = Row["PropertyID"].ToString(),
                        City = Row["City"].ToString(),
                        Location = Row["Location"].ToString(),
                        PropertyType = Row["PropertyType"].ToString(),
                        MinPriceRange = Row["Price"].ToString(),
                        AreaInSqYd = Row["AreaInSqYd"].ToString(),
                        Bedrooms = Row["Bedrooms"].ToString(),
                        TVLounge = Convert.ToBoolean(Row["TVLounge"]),
                        OutsideGarden = Convert.ToBoolean(Row["OutsideGarden"]),
                        WestOpen = Convert.ToBoolean(Row["WestOpen"]),
                        Corner = Convert.ToBoolean(Row["Corner"]),
                        image = Row["image"].ToString()
                    };
                    BuyProperties.Add(BM);
                }
                return BuyProperties;
            }
            
            else if (array[0] != null && array[2] != null && array[1] == null && array[3] == null && array[4] == null && array[5] == null && array[6] == null && array[7] == "False" && array[8] == "False" && array[9] == "False" && array[10] == "False")
            {
                string Query = "select * from Practice Where City = '" + array[0] + "' and PropertyType = '" + array[2] + "'";
                Con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(Query, Con);
                DA.Fill(dt);
                Con.Close();

                foreach (DataRow Row in dt.Rows)
                {
                    BuyModel BM = new BuyModel()
                    {
                        PropertyID = Row["PropertyID"].ToString(),
                        City = Row["City"].ToString(),
                        Location = Row["Location"].ToString(),
                        PropertyType = Row["PropertyType"].ToString(),
                        MinPriceRange = Row["Price"].ToString(),
                        AreaInSqYd = Row["AreaInSqYd"].ToString(),
                        Bedrooms = Row["Bedrooms"].ToString(),
                        TVLounge = Convert.ToBoolean(Row["TVLounge"]),
                        OutsideGarden = Convert.ToBoolean(Row["OutsideGarden"]),
                        WestOpen = Convert.ToBoolean(Row["WestOpen"]),
                        Corner = Convert.ToBoolean(Row["Corner"]),
                        image = Row["image"].ToString()
                    };
                    BuyProperties.Add(BM);
                }
                return BuyProperties;
            }
            else if (array != null)
            {
                string Query = "select * from Practice Where City = '" + array[0] + "' and Location = '" + array[1] + "' and PropertyType = '" + array[2] + "' and Price >= '" + Convert.ToInt32(array[3]) + "' and Price <=  '" + Convert.ToInt32(array[4]) + "' and AreaInSqYd = '" + array[5] + "' and Bedrooms = '" + array[6] + "' and TVLounge = '" + Convert.ToBoolean(array[7]) + "' and OutsideGarden = '" + Convert.ToBoolean(array[8]) + "' and WestOpen = '" + Convert.ToBoolean(array[9]) + "' and Corner = '" + Convert.ToBoolean(array[10]) + "'";
                Con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter DA = new SqlDataAdapter(Query, Con);
                DA.Fill(dt);
                Con.Close();

                foreach (DataRow Row in dt.Rows)
                {
                    BuyModel BM = new BuyModel()
                    {
                        PropertyID = Row["PropertyID"].ToString(),
                        City = Row["City"].ToString(),
                        Location = Row["Location"].ToString(),
                        PropertyType = Row["PropertyType"].ToString(),
                        MinPriceRange = Row["Price"].ToString(),
                        AreaInSqYd = Row["AreaInSqYd"].ToString(),
                        Bedrooms = Row["Bedrooms"].ToString(),
                        TVLounge = Convert.ToBoolean(Row["TVLounge"]),
                        OutsideGarden = Convert.ToBoolean(Row["OutsideGarden"]),
                        WestOpen = Convert.ToBoolean(Row["WestOpen"]),
                        Corner = Convert.ToBoolean(Row["Corner"]),
                        image = Row["image"].ToString()
                    };
                    BuyProperties.Add(BM);
                }
                return BuyProperties;
            }
            return BuyProperties;
        }
    }
}