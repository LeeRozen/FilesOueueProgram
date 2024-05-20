using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Files_Queue_Program
{
    internal class DataFile
    {
        // defualt access permission is PRIVATE for the data fields:

        string fileName;
        DateTime lastUpdateTime = new DateTime(); //assigns default value 01/01/0001 00:00:00
        string data;
        FileTypeExtension type; // indicate the type of the file
        public static int Counter; // count the number of objects this class have


        public void SetData(string DataFile) // checking if *Data* is correct
        {
            data = DataFile;
        }
        public string GetData() // for getting the data
        {
            return data;
        }

        public FileTypeExtension GetType() //  for getting the type
        {
            return type;
        }
        public bool SetFileName(string fName)   // checking if *FileName* is correct
        {
            if (fName=="")
            {
                return false;
            }

            int i = 0;
            char FileN = fName[i]; // saving to an assist variable each char by each loop, for the comparison 
            while (i < fName.Length)
            {
                if (FileN == '<' || FileN == '?' || FileN == '*' || FileN == ':' || FileN == '/' || FileN == '\\' || FileN == '|' || FileN == '>')
                {
                    Console.WriteLine("Error! A file name can't contain any of the following characters:\\ / : * ? \" < > | ");
                    return false;   // going out from the method + indication for failure
                }
                i++;                // advance to next char in the string
            }                       // when finished checking the whole word and came out from the "while" loop, it means this is a proper file name

            fileName = fName;        // assign the checked file name

            return true;             // indication for succeed
        }
        public string GetFileName()  // for getting the file name
        {
            return fileName;
        }
        public void SetTime()                // setting the update time
        {
            lastUpdateTime = DateTime.Now;  // current date/time based on current system
        }
        public DateTime GetTime()            // for getting the last update time of the file
        {
            return lastUpdateTime;
        }
        public DataFile(string filename, string data, FileTypeExtension type) // constructor no.1 - three arguments c'tor
        {
           while (!SetFileName(filename))
           {
                Console.WriteLine("Please enter file name again:");
                filename = Console.ReadLine();
           }
            SetData(data);
            SetTime();
            this.type = type;
            Counter++;
        }
        public DataFile() : this("defultName"+ (Counter+1) , "", FileTypeExtension.TXT)  // default (empty) constructor
        {
        }
        public DataFile(DataFile other) // Copy constructor
        {
            fileName = other.fileName + "(1)";  // for differentiate between the file copies
            data = other.data;
            SetTime();  // setting the time for the new copy
            type = other.type;
            Counter++;
        }
        public float GetSize(string DFile) // file size (in bytes)
        {
            float FileSizeInBytes = DFile.Length;
            return FileSizeInBytes;
        }
        public string Dir() // print the class fields (like the ToString() method).
        {
            float FileSizeInKB = GetSize(data) / 1024;
            string FileDetails = lastUpdateTime + " " + FileSizeInKB + " KB " + fileName + "." +type + "\n\r";
            return FileDetails;
        }
    }
}