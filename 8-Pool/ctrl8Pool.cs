using FirsGUNA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirsGUNA
{
    public partial class ctrl8Pool : UserControl
    {
        public ctrl8Pool()
        {
            InitializeComponent();
        }
        string _TableName = "Table";
        [
            Category("Pool Config"),
            Description("The table name.")   
        ]
        public string TableName {
            set
            {
                _TableName = value;
                gbTable.Text = value;
                Invalidate();
            }
            
            get
            {
                return _TableName;
            }
        }

        private float _HourlyRate = 10.00F;

        [
        Category("Pool Config"),
        Description("Rate Per Hour.")
        ]
        public float HourlyRate
        {
            get
            {
                return _HourlyRate;
            }
            set
            {
                _HourlyRate = value;

            }
        }

        public enum enStatusGame { Start, Stop, End}

        public enum enTypeOfTable { None, Normal, VIP};
        enTypeOfTable _TypeOfTable;
        [
            Category("Pool Config"),
            Description("Type Of Table.")
            ]
        public enTypeOfTable TypeOfTable { get { return _TypeOfTable; } set 
            {
                _TypeOfTable = value;

                switch (_TypeOfTable)
                {
                    case enTypeOfTable.None:
                        {
                            picTable.Tag = "?";
                            picTable.Image = Resources.QuestionMark;
                            return;
                        }
                        case enTypeOfTable.Normal:
                        {
                            cbTypeOfTable.Text = "Normal";
                            break;
                        }
                        case enTypeOfTable.VIP:
                        {
                            cbTypeOfTable.Text = "VIP";
                            break;
                        }
                }


                _ChangePicture(false);
            } 
        }
        [
          Category("Design"),
          Description("Color Of Header.")
          ]
        public Color ColorOfHeader { get { return gbTable.CustomBorderColor; }
            set { gbTable.CustomBorderColor = value; Invalidate(); } }
        [
         Category("Design"),
         Description("Color Of Body.")
         ]
        public Color ColorOfBody { get { return gbTable.FillColor; } 
            set 
            {
                gbTable.FillColor = value;
                lblTimer.BackColor = value;
                Invalidate();
            } }
        [
          Category("Design"),
          Description("Color Of Button End.")
          ]
        public Color ColorOfbtnEnd
        {
            get { return btnEnd.FillColor; }
            set
            {
                btnEnd.FillColor = value;
                Invalidate();
            }
        }
        [
         Category("Design"),
         Description("Color Of Button Switch.")
         ]
        public Color ColorOfbtnStart
        {
            get { return btnSwitch.FillColor; }
            set
            {
                btnSwitch.FillColor = value;
                Invalidate();
            }
        }
        int _Seconds;


        public class clsEvent8Pool : EventArgs
        {
            public string TableName { get; }
            public enStatusGame statusGame { get; }
            public string StringStatusGame {
                get
                {
                    switch (statusGame)
                    {
                        case enStatusGame.Start:
                            return "Start";
                            case enStatusGame.Stop:
                            return "Stop";
                        default:
                            return "End";
                    }

                }
            }
           public string TimeText { get; }
            public int TimeInSeconds { get; }
            public float TotalFees { get; }
            public string TypeOfTable { get; }
            public float RatePerHour { get; }
           
            public clsEvent8Pool(string TableName,string TimeText,float TotalFees,
                float RatePerHour,int TimeInSeconds, enTypeOfTable typeOfTable,
                enStatusGame statusGame)
            {
                this.statusGame = statusGame;
               
                this.TableName = TableName;

                this.TimeInSeconds = TimeInSeconds;
                this.TimeInSeconds = TimeInSeconds;
                this.RatePerHour = RatePerHour;
                this.TotalFees = TotalFees;
                this.TimeText = TimeText;

                if (typeOfTable == enTypeOfTable.Normal)
                {
                    TypeOfTable = "Normal";
                }
                else
                {
                    TypeOfTable = "VIP";
                }
            }
        }


        public event EventHandler<clsEvent8Pool> OnStart8Pool;
        public event EventHandler<clsEvent8Pool> OnStop8Pool;
        public event EventHandler<clsEvent8Pool> OnEnd8Pool;

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            if(picTable.Tag == "?")
            {
                MessageBox.Show("Set Table Information to play", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (Tag == null)
                Tag = "On";
            float TotalFees = ((float)_Seconds / 60 / 60) * _HourlyRate;
            if (Tag == "On")
            {
                Tag = "Off";
                btnSwitch.Text = "Stop";
                timer1.Start();
                OnStart8Pool?.Invoke(this,new clsEvent8Pool(_TableName, lblTimer.Text,TotalFees, _HourlyRate
                    ,_Seconds, _TypeOfTable,enStatusGame.Start));
            }
            else
            {
                Tag = "On";
                btnSwitch.Text = "Start";
                timer1.Stop();
                OnStop8Pool?.Invoke(this, new clsEvent8Pool(_TableName, lblTimer.Text, TotalFees, _HourlyRate
                    , _Seconds, _TypeOfTable, enStatusGame.Stop));
            }

            _ChangePicture(true);

            nameOfTableToolStripMenuItem1.Enabled = false;
            typeOfTableToolStripMenuItem.Enabled = false;
            
        }

        void _ChangePicture(bool WithLamp)
        {
            picTable.Tag = "!";
            switch (cbTypeOfTable.Text)
            {
                case "Normal":
                    {
                        
                        if (WithLamp)
                            picTable.Image = Resources.Normal_Table_With_Lamp;
                        else
                            picTable.Image = Resources.Normal_Table_Without_Lamp;

                        break;
                    }
                default:
                    {
                        if (WithLamp)
                            picTable.Image = Resources.VIP_Table_With_Lamp;
                        else
                            picTable.Image = Resources.VIP_Table_Without_Lamp;
                        break;
                    }
                   
            }
        }
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;
            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            lblTimer.Text = str;
            lblTimer.Refresh();

        }
        void _RefreshData()
        {
            timer1.Stop();
            _Seconds = 0;
            picTable.Image = Resources.QuestionMark;
            picTable.Tag = "?";
            gbTable.Text = "Programming Advice";
            ColorOfHeader = Color.Green;
            ColorOfBody = Color.DarkSlateGray;
            lblTimer.BackColor = Color.DarkSlateGray;
            ColorOfbtnStart = Color.Green;
            ColorOfbtnEnd = Color.Green;
            lblTimer.Text = "00 : 00 : 00";
            btnSwitch.Text = "Start";
            btnSwitch.Tag = "On";
            nameOfTableToolStripMenuItem1.Enabled = true;
            typeOfTableToolStripMenuItem.Enabled = true;
            cbTypeOfTable.SelectedIndex = -1;
           // _ChangePicture(false);
        }

       

        

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            TableName = toolStripTextBox1.Text;
        }

        private void cmsTable_Opening_1(object sender, CancelEventArgs e)
        {
            toolStripTextBox1.Text = TableName;
        }

      



        void _TableInfo(string TypeOfTable, float HournltRate)
        {
            MessageBox.Show($@"Type Of Table is : {TypeOfTable},

Hourly Rate       : {HournltRate}.", "Table Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void picTable_DoubleClick(object sender, EventArgs e)
        {
            switch (cbTypeOfTable.Text)
            {
                case "Normal":
                    {
                        _TableInfo("Normal", HourlyRate);
                        break;
                    }
                case "VIP":
                    {
                        _TableInfo("VIP", HourlyRate);
                        break;
                    }
                default:
                    {
                        _TableInfo("NULL", 0);
                        break;
                    }
                   
            }
        }

        private void cbTypeOfTable_Click(object sender, EventArgs e)
        {

        }

        private void colorOfHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cdControl.ShowDialog() == DialogResult.OK)
            {
                gbTable.CustomBorderColor = cdControl.Color;
            }
        }

        private void colorOfBodyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdControl.ShowDialog() == DialogResult.OK)
            {
                gbTable.FillColor = cdControl.Color;
                lblTimer.BackColor = cdControl.Color;
            }
        }

        private void colorOfSwitchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cdControl.ShowDialog() == DialogResult.OK)
            {
                btnSwitch.FillColor = cdControl.Color;
                btnEnd.FillColor = cdControl.Color;
            }
        }

        private void typeOfTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void cbTypeOfTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            picTable.Tag = "!";
            switch (cbTypeOfTable.Text)
            {
                case "Normal":
                    {
                        picTable.Image = Resources.Normal_Table_Without_Lamp;
                       // _TableInfo("Normal", 10);
                        break;
                    }
                case "VIP":
                    {
                        picTable.Image = Resources.VIP_Table_Without_Lamp;
                       // _TableInfo("VIP", 30);
                        break;
                    }
                default:
                    {
                        picTable.Tag = "?";
                        //_TableInfo("NULL", 00);
                        break;
                    }

            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if(picTable.Tag=="!")
            {
                timer1.Stop();
                float TotalFees = ((float)_Seconds / 60 / 60) * _HourlyRate;
                OnEnd8Pool?.Invoke(this, new clsEvent8Pool(_TableName, lblTimer.Text, TotalFees, _HourlyRate
                    , _Seconds, _TypeOfTable, enStatusGame.End));
                _RefreshData();
            }
           
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
