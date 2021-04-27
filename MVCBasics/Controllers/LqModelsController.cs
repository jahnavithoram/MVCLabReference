using DataLayer;
using MVCBasics.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MVCBasics.Controllers
{
    public class LqModelsController : BaseController<LqStudentModel>
    {

        public LqModelsController(IBaseRepositry<LqStudentModel> repo) : base(repo)
        {
        }
        public List<LqStudentModel> Get()
        {
            List<LqStudentModel> data = new List<LqStudentModel>();
            string connectionString = "Server=HSC-6DBN1G2\\SQLEXPRESS; Database=AppDB; Trusted_Connection=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from [LqStudentModel]", con);
                cmd.CommandType = System.Data.CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LqStudentModel user = new LqStudentModel();
                    user.Name = rdr["Name"].ToString();
                    user.Class = rdr["Class"].ToString();
                    user.RollNo = Convert.ToInt32(rdr["RollNo"]);
                    user.Sec = rdr["Sec"].ToString();
                    user.EnglishM = Convert.ToInt32(rdr["EnglishM"]);
                    user.MathsM = Convert.ToInt32(rdr["MathsM"]);
                    user.ScienceM = Convert.ToInt32(rdr["ScienceM"]);
                    data.Add(user);
                }
                con.Close();
            }
            return data;
        }
        public ActionResult Stat()
        {
            List<LqStudentModel> data =Get();
           var a1 = data.Max(u => u.EnglishM);
            ViewBag.MaxEng = from stu in data where stu.EnglishM == a1 select new { Name = stu.Name ,stu.RollNo, marks = stu.EnglishM }.ToString();
            ViewBag.MaxMath = from stu in data where stu.MathsM == data.Max(u => u.MathsM) select new { Name = stu.Name,  stu.RollNo , marks = stu.MathsM }.ToString();
            ViewBag.MaxSci = from stu in data where stu.ScienceM == data.Max(u => u.ScienceM) select new { Name = stu.Name, stu.RollNo , marks = stu.ScienceM }.ToString();

            ViewBag.MinEng = from stu in data where stu.EnglishM == data.Min(u => u.EnglishM) select new { Name = stu.Name, stu.RollNo, marks = stu.EnglishM }.ToString();

            ViewBag.MinMath = from stu in data where stu.MathsM == data.Min(u => u.MathsM) select new { Name = stu.Name, stu.RollNo, marks = stu.MathsM }.ToString();
            ViewBag.MinSci = from stu in data where stu.ScienceM == data.Min(u => u.ScienceM) select new { Name = stu.Name, stu.RollNo, marks = stu.ScienceM }.ToString();
            

            ViewBag.stucount = data.Count();
            ViewBag.avgEng = data.Average(u => u.EnglishM);
            ViewBag.avgMath = data.Average(u => u.MathsM);
            ViewBag.avgSci = data.Average(u => u.ScienceM);
            return View();
        }

        
    }
}




