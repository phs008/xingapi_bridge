using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XA_DATASETLib;
using XA_SESSIONLib;

namespace xingapi_bridge
{
    
    public partial class Form1 : Form
    {
        protected XingSessionCtrl m_Session;
        protected JonMokQuery _jonMokQuery = new JonMokQuery();
        protected Order _order = new Order();
        public Form1()
        {
            InitializeComponent();
            m_Session = new XingSessionCtrl();
            UI.console_event += Update_ConsoleLog;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!File.Exists("./user_info.txt"))
            {
                MessageBox.Show("user_info.txt 파일이 없거나 해당경로에 없습니다. 확인해주세요", "ERROR", MessageBoxButtons.OK);
                this.Close();
            }
            
            string[] user_info = File.ReadAllLines("./user_info.txt");
            User_Info.mode = user_info[0].Split(new char[] { ':' })[1].Trim();
            User_Info.id = user_info[1].Split(new char[] {':'})[1].Trim();
            User_Info.passwd = user_info[2].Split(new char[] { ':' })[1].Trim();
            User_Info.ckpt_passwd = user_info[3].Split(new char[] { ':' })[1].Trim();
            User_Info.account = user_info[4].Split(new char[] { ':' })[1].Trim();
            if (User_Info.mode == "real")
            {
                UI.SendConsoleMsg(this, "실제 서버 접속");
                m_Session.XaSession.ConnectServer("hts.etrade.co.kr", 20001);
            }
            else if (User_Info.mode == "test")
            {
                UI.SendConsoleMsg(this, "모의투자 서버 접속");
                m_Session.XaSession.ConnectServer("demo.etrade.co.kr", 20001);
            }
            m_Session.XaSession.Login(User_Info.id, User_Info.passwd, User_Info.ckpt_passwd, 1, true);
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            _order.Ordering(Order.OrderType.Buy, User_Info.jongmok, Order.hogaType.Price, "1260.5", "1");
        }

        private void Update_ConsoleLog(object sender, string msg)
        {
            consoleview.AppendText(msg + "\n");
            //Console.WriteLine(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _jonMokQuery.GetJongMokCode();
        }
    }
    public class UI
    {
        public static event EventHandler<string> console_event;
        public static void SendConsoleMsg(object sender , string msg)
        {
            if (UI.console_event != null)
            {
                UI.console_event(sender, msg);
            }
        }
    }
    
}