using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XA_DATASETLib;

namespace xingapi_bridge
{
    public class Order : _IXAQueryEvents
    {
        public enum OrderType
        {
            Sell = 1,
            Buy = 2
        }
        public enum hogaType
        {
            Price = 00,
            MarketPrice = 03,
            ConditionPrice = 05
        }
        public IXAQuery query;

        public Order()
        {
            UCOMIConnectionPoint icp;
            UCOMIConnectionPointContainer icpc;

            int dwCookie = 0;
            query = new XAQuery();
            query.ResFileName = "\\res\\CFOAT00100_1.res";
            icpc = (UCOMIConnectionPointContainer)query;
            Guid IID_QueryEvents = typeof(_IXAQueryEvents).GUID;
            icpc.FindConnectionPoint(ref IID_QueryEvents, out icp);
            icp.Advise(this, out dwCookie);
        }

        public void Ordering(OrderType _orderType , string jongmokcode , hogaType _hogaType , string orderPrice , string orderCnt)
        {
            query.SetFieldData("CFOAT00100InBlock1", "AcntNo", 0, User_Info.account);
            query.SetFieldData("CFOAT00100InBlock1", "Pwd", 0, User_Info.passwd);
            query.SetFieldData("CFOAT00100InBlock1", "FnoIsuNo", 0, jongmokcode);
            query.SetFieldData("CFOAT00100InBlock1", "BnsTpCode", 0, ((int)_orderType).ToString());
            query.SetFieldData("CFOAT00100InBlock1", "FnoOrdprcPtnCode", 0, ((int)_hogaType).ToString());
            query.SetFieldData("CFOAT00100InBlock1", "OrdPrc", 0, orderPrice);
            query.SetFieldData("CFOAT00100InBlock1", "OrdQty", 0, orderCnt);
            query.Request(false);
        }
        public void ReceiveData(string szTrCode)
        {
            UI.SendConsoleMsg(this, szTrCode);
        }

        public void ReceiveMessage(bool bIsSystemError, string nMessageCode, string szMessage)
        {
            UI.SendConsoleMsg(this, nMessageCode + "_" + szMessage);
        }

        public void ReceiveChartRealData(string szTrCode)
        {
            UI.SendConsoleMsg(this, szTrCode);
        }

        public void ReceiveSearchRealData(string szTrCode)
        {
            UI.SendConsoleMsg(this, szTrCode);
        }
    }
}
