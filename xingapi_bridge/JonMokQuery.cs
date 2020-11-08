using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;

namespace xingapi_bridge
{
    public class JonMokQuery : _IXAQueryEvents
    {
        public IXAQuery query;
        public JonMokQuery()
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

        public void GetJongMokCode()
        {
            query.SetFieldData("t8435InBlock", "gubun", 0, "SF");
            query.Request(true);
        }

        public void ReceiveData(string szTrCode)
        {
            int block_cnt = query.GetBlockCount(szTrCode + "OutBlock");

            string hname = query.GetFieldData(szTrCode + "OutBlock", "hname", 0);
            string shcode = query.GetFieldData(szTrCode + "OutBlock", "shcode", 0);
            string expcode = query.GetFieldData(szTrCode + "OutBlock", "expcode", 0);
            string upprice = query.GetFieldData(szTrCode + "OutBlock", "uplmtprice", 0);
            string dnprice = query.GetFieldData(szTrCode + "OutBlock", "dnlmtprice", 0);
            string C = query.GetFieldData(szTrCode + "OutBlock", "jnilclose", 0);
            string H = query.GetFieldData(szTrCode + "OutBlock", "jnilhigh", 0);
            string L = query.GetFieldData(szTrCode + "OutBlock", "jnillow", 0);
            string S = query.GetFieldData(szTrCode + "OutBlock", "recprice", 0);
            UI.SendConsoleMsg(this,
                hname + "_" + shcode + "_" + expcode + "_" + upprice + "_" + dnprice + "_" + C + "_" + H + "_" + L +
                "_" + S);

            User_Info.jongmok = shcode;
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
