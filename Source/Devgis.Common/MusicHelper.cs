using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devgis.Common
{
    public class MusicHelper
    {
        private static MCI mci = null;
        public static void Play(string MusicPath)
        {
            try
            {
                GC.Collect();
                mci = new MCI();
                mci.FileName = MusicPath;
                mci.play();
            }
            catch
            { }
        }
    }
}
