using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramLogicDll;
using System.Windows.Forms;

namespace UIApplication
{
    public class Generate
    {
        ConnectDb dataBase = new ConnectDb();
        public void DistributionOfStudents()
        {
            List<KeyValuePair<int, string>> grups = new List<KeyValuePair<int, string>>();
            List<KeyValuePair<int, string>> students = new List<KeyValuePair<int, string>>();
            List<KeyValuePair<int, int>> audiense = new List<KeyValuePair<int, int>>();
            
            foreach (var item in dataBase.Audiences)
                audiense.Add(new KeyValuePair<int, int>(item.AudienceId, item.NumberOfSeats));
            foreach (var item in dataBase.Groups.Where(x => x.Audiences == null).ToList())
                grups.Add(new KeyValuePair<int, string>(item.GroupId, item.Students.Count.ToString()));
            AddGroupToAudiense(grups, audiense);
            grups.Clear();

            foreach (var item in dataBase.Groups.Where(x => x.Students.Count < x.Audiences.NumberOfSeats).ToList())
                grups.Add(new KeyValuePair<int, string>(item.GroupId, item.Profession));
            foreach (var item in dataBase.Students.Where(x => x.Groups == null).ToList())
                students.Add(new KeyValuePair<int, string>(item.StudentId, item.Profession));
            AddStudentToGrup(grups, students);
            ComputersToAudiences();
        }
        public bool AddStudentToGrup(List<KeyValuePair<int, string>> grups, List<KeyValuePair<int, string>> students)
        {
            foreach (var item in grups)
            {
                var grop = dataBase.Groups.Where(x => x.GroupId == item.Key).FirstOrDefault();
                foreach (var item1 in students)
                {
                    if (grop.Students.Count < grop.Audiences.NumberOfSeats)
                    {
                        if (item.Value == item1.Value)
                        {
                            var stud = dataBase.Students.Where(x => x.StudentId == item1.Key).FirstOrDefault();
                            stud.Groups = grop;
                            grop.Students.Add(stud);
                            dataBase.SaveChanges();
                        }
                    }
                }
            }
            return true;
        }
        public void AddGroupToAudiense(List<KeyValuePair<int, string>> grups, List<KeyValuePair<int, int>> audiense)
        {
            foreach (var item in audiense)
            {
                foreach (var item1 in grups)
                {
                    if (item.Value >= Convert.ToInt32(item1.Value))
                    {
                        var aud = dataBase.Audiences.Where(x => x.AudienceId == item.Key).FirstOrDefault();
                        var gr = dataBase.Groups.Where(x => x.GroupId == item1.Key).FirstOrDefault();
                        if (CheckTime(aud.Groups.ToList(), gr.HoursOfStudy) && gr.Audiences == null)
                        {
                            aud.Groups.Add(gr);
                            gr.Audiences = aud;
                            dataBase.SaveChanges();
                        }
                    }
                }

            }
        }
        public bool CheckTime(List<ProgramLogicDll.Group> gr, string time)
        {
            int t = Convert.ToInt32(time.Remove(2));
            foreach (var item in gr)
            {
                int s = Convert.ToInt32(item.HoursOfStudy.Remove(2));
                if (s + 3 == t + 3 || (t >= s && t < s + 3))
                    return false;
            }
            return true;
        }
        public void ComputersToAudiences()
        {
            foreach (var item1 in dataBase.Audiences.Where(aud => aud.Computers.Count < aud.NumberOfSeats).ToList())
            {
                foreach (var item in dataBase.Computers.Where(comp => comp.Audiences == null).ToList())
                {
                    if (item1.Computers.Count < item1.NumberOfSeats)
                    {
                        item1.Computers.Add(item);
                        dataBase.Computers.Where(comp => comp.ComputerId == item.ComputerId).FirstOrDefault().Audiences = item1;
                        dataBase.SaveChanges();
                    }
                }
            }
        }
    }
}
