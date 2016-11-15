using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crud.Models
{
    public interface Istudent
    {
        List<Student> SelectAll();
        Student SelectById(int sno);
        void Create(Student st);
        void Update(Student st);
        void Delete(int sno);
        void Save();
    }
}