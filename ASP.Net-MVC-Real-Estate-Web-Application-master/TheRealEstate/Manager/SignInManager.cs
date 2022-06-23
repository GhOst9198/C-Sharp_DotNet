using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheReaLState.Models;
using System.Data.SqlClient;
using System.Data;

namespace TheReaLState.Manager
{
    public class SignInManager : GeneralManager
    {
        public int SignIn(SignInModel Sign)
        {
            int a = 0;
            List<SignInModel> SignProperties = new List<SignInModel>();
            string Query = "Select * From Users Where Username = '"+Sign.UserName+"' and Password = '"+Sign.Password+"'";
            Con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter DA = new SqlDataAdapter(Query, Con);
            DA.Fill(dt);
            Con.Close();
            foreach (DataRow Row in dt.Rows)
            {
                SignInModel SIM = new SignInModel()
                {
                    UserName = Row["Username"].ToString(),
                    Password = Row["Password"].ToString()
                };
                SignProperties.Add(SIM);
            }
            if (SignProperties.Count != 0)
            {
                a = 1;
            }
            return a;
        }
    }
}