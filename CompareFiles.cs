using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Queue_Program
{
    internal static class CompareFiles
    {
        public static bool EqualFiles(DataFile file1, DataFile file2)
        {
            if ((file1.GetFileName() == file2.GetFileName()) && (file1.GetData() == file2.GetData()))
            {
                return true;
            }
            return false;
        }
            
        public static int CompareSizeFiles(DataFile file1, DataFile file2)
        {
            if ( file1.GetSize(file1.GetData()) > file2.GetSize(file2.GetData()) )
            {
                return 1;
            }
            if (file1.GetSize(file1.GetData()) < file2.GetSize(file2.GetData()))
            {
                return -1;
            }
            else return 0; // if the sizes equals
        }



    }
}
