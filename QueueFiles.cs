using Files_Queue_Program;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Files_Queue_Program
{
    internal class QueueFiles
    {
        DataFile[] arr;
        int whereAvailable; // indicate where there is a place in the array for a new item
        
        public QueueFiles()  // default (empty) c'tor 
        {
            arr = new DataFile[0];
            whereAvailable = -1;
        }
        public QueueFiles(QueueFiles Queue) // copy c'tor
        {
            arr = new DataFile[Queue.arr.Length];
            Queue.arr.CopyTo(arr, 0);
            whereAvailable = Queue.arr.Length+1;
        }

        public DataFile[] GetArray()
        {
            return arr;
        }

        public bool IsEmpty(DataFile[] arr)
        {
            if (arr == null) 
            {
                Console.WriteLine("The queue is empty");
                return true;
            }
            return false;
        }
        public void Enqueue(DataFile newfile) // method to add file to the queue
        {
            for (int i = 0; i < arr.Length; i++)
            {
               if (CompareFiles.EqualFiles(newfile, arr[i])) // checking if the file already in the arr, if it is - is true
               { 
                    Console.WriteLine("This file already exist");
                    return;
               }
            }

            if (arr.Length == 0)
            {
                arr = new DataFile[1]; 
                arr[0] = newfile;
                whereAvailable = 1;
                return;
            }

            Array.Resize(ref arr, whereAvailable+1);
            arr[whereAvailable] = newfile;
            whereAvailable++;
        }

        public DataFile Dequeue() // method to remove file from the queue. The first file is automaticly removed - no choice
        {
            if (IsEmpty(arr))
            {
                Console.WriteLine("this file not exist");
                return null;
            }

            else
            {
                DataFile fileToRemove = arr[0];

                DataFile[] temp = new DataFile[arr.Length - 1];
                
                if (temp.Length == 0) // when the array has only one item thats going to be removed
                {
                    arr = null;
                    return fileToRemove;
                }

                int j = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    temp[j++] = arr[i];
                }

                arr = temp; // update the array 
                whereAvailable--;
                return fileToRemove; 
            } 
        }

        public DataFile BigFile()
        {

            if (IsEmpty(arr))
            { 
                return null; 
            }

            if (whereAvailable == 1)
            {
                Console.WriteLine("The array has only one file");
                return null;
            }

            DataFile TheBigFile = arr[0]; // hold the 1 item
            foreach(DataFile item in arr)
            {
                if (CompareFiles.CompareSizeFiles(TheBigFile, item) == 1) // if 1 > 2
                {
                    continue;
                }
                if (CompareFiles.CompareSizeFiles(TheBigFile, item) == 0) // if 1 = 2
                {
                    continue;
                }
                else TheBigFile = item; // if 1 < 2 ---> the holder change his hold to 2
            }

            return TheBigFile;

        }

        public void PrintQueue()
        {
            if (IsEmpty(arr))
            {
                return;
            }

            QueueFiles copiedQueue = new QueueFiles(this);
            DataFile dataFile;

            while (!IsEmpty(copiedQueue.arr))
            {
                dataFile = copiedQueue.Dequeue();
                dataFile.Dir();
            }
        }

        public DataFile[] SearchFileByType (FileTypeExtension type)
        {  
            if (IsEmpty(arr))
            {
                return null;
            }
     
            QueueFiles queueFiles = new QueueFiles();

            foreach (DataFile item in this.arr) // to find the files with this type
            {
                if (item.GetType() == type)
                {
                    
                    queueFiles.Enqueue(item);
                }
            }

            if (queueFiles.arr == null) { return null; }

            return queueFiles.arr;
        }
    }
}
