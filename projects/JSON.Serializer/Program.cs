/*
 * Author: pra2e
 * JSONStrSerializer Project (Console App using .NET Core)
 * Project to explore creating JSON string.
 * https://www.jsonutils.com can be used to auto-create the classes.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;          // JSON Package needed to serialize JSON strings

namespace JSON.Serializer {
    public class Student {
        public string name {
            get;     // auto property --- "return this.name"
            set;     // auto property --- "this.name = value"
        }
    }
    public class Universities {
        public string university {
            get;
            set;
        }
        public IList <Student> students {
            get;
            set;
        }
    }
    // ClassUniversities contains...
    public class ClassUniversities {
        public Universities universities {
            get;
            set;
        }
    }
    
    // Main class
    class Program {
        // Entry point
        static void Main(string[] args) {
            // Create an instance (university1 obj) of ClassUniversities class
            ClassUniversities university1 = new ClassUniversities();
            // Create an instance of Universities class
            university1.universities = new Universities();

            // Create a list of objects
            List <Student> listStudent = new List<Student>();
            Student student1 = new Student {     // collection initializer?  @TODO kbae -- continue here...
                name = "Eric Bae"
            }

        }
    }
}


/* EXAMPLE OF A JSON
 *      1. "students" is the key.
 *      2. "[" and "]" are array statement.
 *      3. Everything in [ ] are value of "students" key.
 *      
 * 
JSON
{  
    "universities":   
    {  
        "university": "UMCP",  
        "students": [  
          { "name": "Eric B."}, 
          { "name": "Heidi S."},
          { "name": "Randall C."}
         ]  
    }  
}      
*/