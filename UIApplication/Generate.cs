using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogicDll;
namespace UIApplication
{
   public static class Generate
    {
        public static void DistributionOfStudents(ConnectDb db)
        {
            List<KeyValuePair<int, string>> grups = new List<KeyValuePair<int, string>>();
            foreach (var item in db.Groups)
            {
                if(item.Students.Count()<item.Audiences.NumberOfSeats)
                {
                    grups.Add(new KeyValuePair<int, string>(item.GroupId, item.Profession));
                }
            } 

        }
    }
}
