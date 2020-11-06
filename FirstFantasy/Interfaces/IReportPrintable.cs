using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Interfaces
{
    interface IReportPrintable
    {
        public void PrintToPDF();
        public void PrintToScreen();
        public void PrintToFile();

    }
}
