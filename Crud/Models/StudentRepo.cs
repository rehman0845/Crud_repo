using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Models
{
    public class StudentRepo:Istudent
    {
        rehmanEntities re = null;
        public StudentRepo()
        {
            re = new rehmanEntities();
        }
        public List<Student> SelectAll()
        {
            return re.Students.ToList();
        }
        public Student SelectById(int sno)
        {
            return re.Students.Where(s => s.sno == sno).FirstOrDefault();
        }
        public void Create(Student st)
        {
                re.Students.Add(st);
        }
        public void Update(Student st)
        {
            var st1 = re.Students.Where(s => s.sno == st.sno).FirstOrDefault();
            st1.sname = st.sname;
            st1.course = st.course;
            st1.fee = st1.fee;
        }
        public void Delete(int sno)
        {
            re.Students.Remove(re.Students.Where(s => s.sno == sno).FirstOrDefault());
        }
        public void Save()
        {
            re.SaveChanges();
        }
    }
}