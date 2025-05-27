using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KINT_Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using static KINT_Lib.KI_TcpClient;

namespace Ki_WAT
{
    public partial class Frm_Mainfrm : Form
    {

        public Frm_Main m_frmMain = new Frm_Main();
        public Frm_Config m_frmConfig = new Frm_Config();
        public Frm_Operator User_Monitor = null;
        public Frm_PitInMonitor Pit_Monitor = null;
        public Frm_Rolling m_frmRoll = new Frm_Rolling();

        private List<Button> m_NavButtons = new List<Button>();
        private int m_nCurrentFrmIdx = Def.FOM_IDX_MAIN;
        private Form m_ActiveSubForm;
        
        

        private KI_TcpClient m_tcpBoardSpeed = new KI_TcpClient();
        private KI_Tcp_Server m_tcp_Server = new KI_Tcp_Server();
        
        private DB_LocalWat m_dbJob;
        public Frm_Mainfrm()
        {
            InitializeComponent();
        }
        private void Frm_Mainfrm_Load(object sender, EventArgs e)
        {
            m_frmMain.SetParent(this);
            m_frmConfig.SetParent(this);

            InitializeSubForm(m_frmMain);
            InitializeSubForm(m_frmConfig);
            InitializeSubForm(m_frmRoll);
            
            ShowFrm(Def.FOM_IDX_MAIN);


            m_tcp_Server.Start("127.0.0.1", 8511);

            m_tcpBoardSpeed.Connect("127.0.0.1", 8511);
            m_tcpBoardSpeed.OnDataReceived += new DataReceiveClient(event_GetSpeedData);
            m_dbJob = new DB_LocalWat(Application.StartupPath + "\\System\\WAT-DataDB.mdb");

            m_NavButtons.Add(BtnMain);
            m_NavButtons.Add(BtnParam);
            m_NavButtons.Add(BtnManual);
            m_NavButtons.Add(btnIo);
            m_NavButtons.Add(BtnConfig);
            m_NavButtons.Add(BtnCal);


            if (!this.DesignMode)
            {
                if (User_Monitor == null || User_Monitor.Text == "")
                {
                    User_Monitor = new Frm_Operator();
                    User_Monitor.Show();
                }
                //if (Pit_Monitor == null || Pit_Monitor.Text == "")
                //{
                //    Pit_Monitor = new Frm_PitInMonitor();
                //    Pit_Monitor.Show();
                //}

            }

            //m_tcpSpeed =  new KI_TcpClient("127.0.0.1", 8511);
        }
        private void ChangeButtonColor(Button pButton)
        {
            foreach (Button btn in m_NavButtons)
            { 
                if (pButton.Text == btn.Text)
                {
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = SystemColors.ControlLightLight;
                }
                else
                {
                    btn.BackColor = Color.Gainsboro;  // SystemColors.Control;
                    btn.ForeColor = Color.Black;      // SystemColors.ControlText; 
                }
            }
        }
        public void event_GetSpeedData(byte[] data)
        {
            Console.WriteLine("");
        }

        private void InitializeSubForm(Form f)
        {
            f.ControlBox = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.StartPosition = FormStartPosition.Manual;
            f.MdiParent = this;
        }


        private void RepositionSubForm(Form fSubform)
        {
            if (fSubform == null)
                return;
            fSubform.Location = new Point(0, 0);
            fSubform.Size = new Size(ClientSize.Width - panelNavBar.Size.Width - 4, ClientSize.Height - 4);
            
        }

        public Form ActiveSubForm
        {
            get
            {
                return m_ActiveSubForm;
            }
            set
            {
                m_ActiveSubForm = value;
                if (m_ActiveSubForm == null)
                    return;
                
                RepositionSubForm(m_ActiveSubForm);
            }
        }


        private void ShowFrm(int nIdx)
        {
            m_nCurrentFrmIdx = nIdx;
            Form f = new Form();
            switch (m_nCurrentFrmIdx)
            {
                case Def.FOM_IDX_MAIN:
                    f = m_frmMain;
                    break;
                case Def.FOM_IDX_CONFIG:
                    f = m_frmConfig;
                    break;
                case Def.FOM_IDX_ROLLING:
                    f = m_frmRoll;
                    break;
            }

            
            f.Show();
            f.BringToFront();
            ActiveSubForm = f;

        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {

            ChangeButtonColor((Button)sender);
            ShowFrm(Def.FOM_IDX_CONFIG);
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            ShowFrm(Def.FOM_IDX_MAIN);
        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
        }

        private void Btn_T_Click(object sender, EventArgs e)
        {
            m_dbJob.SelectCarInfo("2024061100202");
            m_frmMain._Log_ListBox("asdf");
        }

        private void btnIo_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
        }

        private void BtnCal_Click(object sender, EventArgs e)
        {
            ChangeButtonColor((Button)sender);
            ShowFrm(Def.FOM_IDX_ROLLING);
        }
    }
}
