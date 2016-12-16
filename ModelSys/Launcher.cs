using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelSys
{
    class Launcher
    {

        public static void Launch()
        {
            Process.Start(Path.GetFullPath("LIB/LIB2.exe"),"fbx assetbundle");
            if (MainWindow.close)
            {
                Environment.Exit(0);
            }
        }
    }
}
