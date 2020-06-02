using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateModel;

namespace DAL
{
    public class ClassDAL
    {
        DBHelper db = new DBHelper();
        //显示
        public List<Student> Show()
        {
            string str = "select * from Student";
            return db.GetToList<Student>(str);
        }
        //学院
        public List<Class> College()  //学院
        {
            string str = "select * from Class where ParentId = 1";
            return db.GetToList<Class>(str);
        }
        public List<Class> Class(int CollegeId)
        {
            string str = "select * from Class where ParentId = " + CollegeId;
            return db.GetToList<Class>(str);
        }
        //添加
        public int Add(Student m)
        {
            string str = string.Format("insert into Student values('{0}',{1},'{2}','{3}')", m.Name, m.Age, m.Remark, m.CS);
            //string str = $"insert into Student values('{m.Name}',{m.Age},'{m.Remark}','{m.CS}')";
            return db.ExecuteNonQuery(str);
        }
    }
}
