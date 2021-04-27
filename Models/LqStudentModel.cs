using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MVCBasics.Models
{
    public class LqStudentModel : BaseModel
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // public string ID { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Class { get; set; }
        public string Sec { get; set; }
        public int EnglishM { get; set; }
        public int MathsM { get; set; }
        public int ScienceM { get; set; }
    }
}
