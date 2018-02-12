using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentService {
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1 {

        [OperationContract]
        void AddStudent(string name, string className, string room);

        [OperationContract]
        List<string> FindStudents(string name);

        [OperationContract]
        List<List<string>> GetAllStudents();

        [OperationContract]
        void RemoveStudent(string name);

        [OperationContract]
        void EditStudent(string name, string className, string room);
    }
}
