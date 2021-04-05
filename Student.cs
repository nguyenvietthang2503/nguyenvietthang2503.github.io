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
   
    private void btnTalk_Click(object sender, RoutedEventArgs e)
    {
        Student st1 = new Student("Minh");
        st.Talk();
        Student st2 = new Student();
        st1.StudentName = "Dung";
        st1.Talk();
    }
}
