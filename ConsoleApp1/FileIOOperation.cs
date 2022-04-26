using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FileIOOperation
    {

        public static void Main()
        {
            FileStream fs = new FileStream( "~/abc.txt",  FileMode.Create , FileAccess.ReadWrite);

            for(int i = 0; i <= 20; i++)
            {

                fs.WriteByte((byte)i);

            }

            fs.Close();
        }
    }
}


//FILE
//- A file is a collection of data stored in a disc with some name, under some directory.
//-When a file is opened for reading and writing, it becomes a Stream.
//-A Stream is basically a sequence of bytes of data passing through communication path.
//-There are 2 types of Streams; Input and Output Stream
//-Input Stream is used for reading a Data from a file
//-Output Stream is used for writing a data from a file
//-System.IO namespace is used for various classes, for the files.
//-IO classes Examples: 
//	Binary reader - Reads data from Binary Stream
//	Binary writer - Writes the data in a Binary format
//	Buffered Stream - Temporary storage for a stream of bytes
//	Directory - It helps us in manipulating Directory structures
//	Directory info - Is used to perform operation on directories
//	Drive info - Is used to give the information of drive
//	File Info - Is used to give the information of files
//	File -  Helps in manipulating files
//	File Stream - Is used to read and write file at any location
//	Path - Is used to perform operations on path information
//	Stream Reader - Is used to read a characters from byte stream
//	Write Stream - Is used to write character to a stream


