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
            get;
            set;
        }
    }
    public class Universities {
        public string university {
            get;
            set;
        }
        public IList<Student> students {
            get;
            set;
        }
    }
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

            // @TODO kbae --- Add code here...
            // https://www.c-sharpcorner.com/article/working-with-json-in-C-Sharp/

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