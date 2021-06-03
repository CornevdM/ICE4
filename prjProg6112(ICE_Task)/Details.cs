using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace prjProg6112_ICE_Task_
{
    abstract class Details
    {
        public string PlayerName = "";
        public string PlayerSurName = "";
        public string PlayerEmail = "";

        public abstract void SetName(string strPlayerName);
        public abstract void SetSurName(string strPlayerSurName);
        public abstract void SetEmail(string strPlayerEmail);
    }
    
}
