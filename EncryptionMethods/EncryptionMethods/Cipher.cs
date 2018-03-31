using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionMethods
{
    abstract class Cipher
    {
        protected static string alfphabet = "abcdefghijklmnopqrstuvwxyz";

        abstract public String EncryptMessage(String message);

        abstract public String DecryptMessage(String message);
    }
}
