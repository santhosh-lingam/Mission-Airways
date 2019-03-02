using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BAPrepaidWallet
    {
        public static void BAWalletBalance(string Name, out string Balance)
        {
            try
            {
                DAPrepaidWallet.DAWalletBalance(Name, out Balance);
            }
            catch (Exception Excptn_BAWalletBalance)
            {
                throw Excptn_BAWalletBalance;
            }
           
        }
    }
}
