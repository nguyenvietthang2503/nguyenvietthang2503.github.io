using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    class Student
    {
        //// 1. trường Name
        private string Name;
        //// 2.thuộc tính StudentName từ trường Name
        public string StudentName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        //// 3.Phương thức khởi tạo Student(string stName)
        public void student(string stName)
        {
            Name = stName;
        }
    }
}
