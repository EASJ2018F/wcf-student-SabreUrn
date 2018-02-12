using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1 {
        private Dictionary<string, Student> _studentList = new Dictionary<string, Student>();

        public void AddStudent(string name, string className, string room) {
            Student student = new Student(name, className, room);
            _studentList.Add(student.Name, student);
        }

        public void EditStudent(string name, string className, string room) {
            Student student = new Student(name, className, room);
            _studentList[name] = student;
        }

        public List<string> FindStudents(string name) {
            List<string> student = new List<string>();
            student.Add(_studentList[name].Name);
            student.Add(_studentList[name].ClassName);
            student.Add(_studentList[name].Room);

            return student;
        }

        public List<string> GetAllStudents() {
            throw new NotImplementedException();
        }

        public void RemoveStudent(string name) {
            _studentList.Remove(name);
        }
    }
}
