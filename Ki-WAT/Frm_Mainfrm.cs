using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcpLib;
using static TcpLib.KI_TcpClient;

namespace Ki_WAT
{
    public partial class Frm_Mainfrm : Form
    {
        
        private int m_nCurrentFrmIdx = Def.FOM_IDX_MAIN;
        private Form m_ActiveSubForm;
        public Frm_Main m_frmMain = new Frm_Main();
        public Frm_Config m_frmConfig = new Frm_Config();
        private KI_TcpClient m_tcpBoardSpeed = new KI_TcpClient();


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
            ShowFrm(Def.FOM_IDX_MAIN);
            m_tcpBoardSpeed.Connect("127.0.0.1", 8511);
            m_tcpBoardSpeed.OnDataReceived += new DataReceivedHandler(event_GetSpeedData);
            //m_tcpSpeed =  new KI_TcpClient("127.0.0.1", 8511);
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
            }

            
            f.Show();
            f.BringToFront();
            ActiveSubForm = f;

        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            ShowFrm(Def.FOM_IDX_CONFIG);
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            ShowFrm(Def.FOM_IDX_MAIN);
        }
    }
}
