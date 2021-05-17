using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Tools
    {
        private static Context context = new Context();

        // Classroom
        public static IEnumerable<Classroom> GetClassRoomList() => context.Classrooms.ToList();
        public static string GetClassroomName(int id) => context.Classrooms.Find(id).Name;

        // Position
        public static string GetPositionName(int id) => context.Positions.Find(id).Name;

        // Student
        public static string getStudentName(string id) => context.Students.Find(id).Name;
        public static string GetNextStudentID()
        {
            int count = context.Students.Count() + 1;
            string id = count.ToString();
            while (id.Length < 6)
            {
                id = "0" + id;
            }
            return $"stu{DateTime.Now.ToString("yy")}{id}";
        }

        // Staff
        public static string GetNextStaffID()
        {
            int count = context.Staffs.Count() + 1;
            string id = count.ToString();
            while (id.Length < 6)
            {
                id = "0" + id;
            }
            return $"sta{DateTime.Now.ToString("yy")}{id}";
        }
    }
}
