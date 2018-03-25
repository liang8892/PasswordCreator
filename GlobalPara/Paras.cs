using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalPara
{
    public class Paras
    {
        public static readonly string AddedString = "@8892";
        public static readonly string EncryptionPassword = "8892";
        public static readonly string PwdFile = @"C:\password\pwd.data";
        public static readonly string TempFile1 = Path.GetTempPath() + "\\" + "pwd.tmp1";
        public static readonly string TempFile2 = Path.GetTempPath() + "\\" + "pwd.tmp2";
        public static readonly char SplitStr = ';';
    }
}
