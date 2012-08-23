using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loudbit.WebHerdrNS
{
    class ProtocolAppList : List<ProtocolAppData>
    {
        private static ProtocolAppList pal;

        public static ProtocolAppList getInstance()
        {
            if (pal == null)
            {
                pal = new ProtocolAppList();
            }
            return pal;
        }

        private ProtocolAppList()
        {

        }
    }
}
