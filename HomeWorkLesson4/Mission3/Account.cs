using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mission3
{
    struct Account
    {
        public string dbLogin;
        public string dbPass;

        public void ReadFile()
        {
            StreamReader sr = new StreamReader("Account.txt");

            dbLogin = sr.ReadLine();
            dbPass = sr.ReadLine();
        }

        public bool Checkout(string LgCnsl, string PssCnsl)
        {
            bool bool1;

            if (LgCnsl == dbLogin && dbPass == PssCnsl)
            {
                bool1 = true;
            }
            else bool1 = false;
            return bool1;
        }
        

    }
}
