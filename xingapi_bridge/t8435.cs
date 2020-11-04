using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;

namespace xingapi_bridge
{
    public class t8435 : _IXAQueryEvents
    {
        public IXAQuery query;
        public t8435()
        {
            UCOMIConnectionPoint icp;
            UCOMIConnectionPointContainer icpc;

            int dwCookie = 0;
            query = new XAQuery();
            query.ResFileName = "\\res\\t8435.res";
            icpc = (UCOMIConnectionPointContainer)query;
            Guid IID_QueryEvents = typeof(_IXAQueryEvents).GUID;
            icpc.FindConnectionPoint(ref IID_QueryEvents, out icp);
            icp.Advise(this, out dwCookie);
        }
        public void ReceiveData(string szTrCode)
        {
            int block_cnt = query.GetBlockCount(szTrCode + "OutBlock");
            for (int i = 0; i < block_cnt; i++)
            {
                string hname = query.GetFieldData(szTrCode + "OutBlock", "hname", i);
                string shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", i);
                string expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", i);
                string upprice = query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", i);
                string dnprice = query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", i);
                string C = query.GetFieldData(szTrCode + "OutBlock", "jnilclose", i);
                string H = query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", i);
                string L = query.GetFieldData(szTrCode + "OutBlock", "jnillow", i);
                string S = query.GetFieldData(szTrCode + "OutBlock", "recprice", i);
                UI.SendConsoleMsg(this,
                    hname + "_" + shcode + "_" + expcode + "_" + upprice + "_" + dnprice + "_" + C + "_" + H + "_" + L +
                    "_" + S);
            }
        }

        public void ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            UI.SendConsoleMsg(this, nMessageCode + "_" + szMessage);
        }

        public void ReceiveChartRealData(string szTrCode)
        {
        }

        public void ReceiveSearchRealData(string szTrCode)
        {
        }
    }
}
