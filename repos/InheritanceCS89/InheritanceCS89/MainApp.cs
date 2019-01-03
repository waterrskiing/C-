using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceCS89
{
    class MainApp
    {
        Student objStudent;
        Employee objEmployee;
        /* Constructor without params */
        public MainApp()
        {
            objStudent = new Student();
            objEmployee = new Employee();
        }
        public void ThucThi()
        {
            objStudent.ThemMoiSinhVien();
            objEmployee.ThemMoiNhanVien();
        }
    }
}
