using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Student_Record_System.classes
{
    class Code
    {
        

        public void readdata()
        {

          DataTable dt=new DataTable();
            var tr = new StreamReader(@"D:\SDN\Student_Record_System\Student_Record_System\Student_Record_System\bin\Debug\Student_Record.txt");
            
                while (!tr.EndOfStream)
                {
                    var data = tr.ReadLine();

                   string[] parts=data.Split('\t');

                   dt.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);

                }
                
            
            
        }

    }
}
