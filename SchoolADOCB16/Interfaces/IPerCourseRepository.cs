using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolADOCB16.RepositoryServices
{
    interface IPerCourseRepository<T>
    {
        List<T> DataPerCourseReadList();
        void AddToCourse(int num,int num2);
        void UpdateDataPerCourse(int num, int num2,int num3,int num4);
        void DeleteDataFromCourse(int num);
    }
}
