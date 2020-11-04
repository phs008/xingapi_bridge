using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XA_DATASETLib;

namespace xingapi_bridge
{
    public class QueryCtrl : _IXAQueryEvents , _IXARealEvents
    {
        public enum QueryRes
        {
            t8435,
        }
        public IXAReal m_real;
        public IXAQuery m_query;
        public QueryCtrl()
        {
            UCOMIConnectionPoint icp;
            UCOMIConnectionPointContainer icpc;

            int dwCookie = 0;
            m_query = new XAQuery();
            //m_query.ResFileName = "\\res\\t8435.res";
            icpc = (UCOMIConnectionPointContainer)m_query;
            Guid IID_QueryEvents = typeof(_IXAQueryEvents).GUID;
            icpc.FindConnectionPoint(ref IID_QueryEvents, out icp);
            icp.Advise(this, out dwCookie);

            m_real = new XAReal();

        }
        public void SetResFilename(QueryRes res)
        {
            m_query.ResFileName = "\\res\\" + res.ToString() + ".res";
        }

        public void ReceiveData(string szTrCode)
        {
            string value = m_query.GetBlockData(szTrCode + "OutBlock");
            UI.SendConsoleMsg(this, value);
        }

        public void ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            UI.SendConsoleMsg(this, nMessageCode + "-" + szMessage);
        }

        public void ReceiveChartRealData(string szTrCode)
        {
        }

        public void ReceiveSearchRealData(string szTrCode)
        {
        }

        public void ReceiveRealData(string szTrCode)
        {
        }

        public void RecieveLinkData(string szLinkName, string szData, string szFiller)
        {
        }
    }
}
