using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Timers;
using System.Threading;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class INTRAK : Form
    {
        bool connstatus = false;
        bool active = false;
        public System.Timers.Timer aTimer;
        private const int BUF_SIZE = 500;//maks przesyłanych danych to 20480
        private byte[] buffer;
        int data;
        public float fpoint;
        public int point;
        public int tolerance;
        public float ftolerance;
        public int amax, amin;
        public float famax, famin;
        public int imax;
        public float fimax;
        public int umin,umax;
        public float ellocoeff;
        public const float anglerange = 120;
        public INTRAK()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            RSCOM = new SerialPort();
            string[] serialPortName = System.IO.Ports.SerialPort.GetPortNames();
            //string[] serialPortName = RSCOM.GetPortNames();
            foreach (string s in serialPortName)
            {
                COMSBOX.Items.Add(s);
            }

            COMSBOX.TabIndex = 0;
            COMSBOX.SelectedValue = 0;
            COMSBOX.Text = COMSBOX.Items[0].ToString();

            aTimer = new System.Timers.Timer();
            aTimer.Interval = 250;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = false;
            buffer = new byte[BUF_SIZE];
            

        }
        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (RSCOM.IsOpen)
            {
                RSCOM.Write("GETDATA\r\n");
                WaitForResponse(150);  
            }
        }
        public int WaitForResponse(int _timeout)
        {
            int offset = 0;
            int ticks = Environment.TickCount;
            while ((Environment.TickCount - ticks) < _timeout)
            {
                Thread.Sleep(10);
                int length = RSCOM.BytesToRead;

                if (length <= 0) continue;
                int read = RSCOM.Read(buffer, offset, length);

                if (read > 0)
                {
                    for (int i = offset + read - 1; i >= offset; i--)
                    {
                        if (buffer[i] == 0x0A)
                        {
                            if (buffer[i] > 0 && buffer[i - 1] == 0x0D)//znalezieno koniec ramki
                            {
                                int received = i;
                                int cut = 0;
                                int index_start_char = received;
                                //string[] temps = (buffer.ToString()).Split('\t');
                                string str = (System.Text.Encoding.ASCII.GetString(buffer));
                                string[] temps = str.Split('\t');
                                //Convert.ToInt32(buffer.ToString());
                                data = Int32.Parse(temps[0]);
                                //txtPos.Text = data.ToString();
                                float fpoint = (float)data;                            
                                if (ellocoeff == 0) { fpoint = 0; }
                                else { fpoint = (float)(fpoint - umin) / ellocoeff; }
                                if (fpoint > anglerange) { fpoint = anglerange; }
                                if (fpoint < 0) { fpoint = 0; }

                                lbActPos.Invoke(new Action(delegate () 
                                {
                                    lbActPos.Text = fpoint.ToString("0.00");
                                    lbActPos.Text += "°";
                                }));

                                txtPos.Invoke(new Action(delegate ()
                                {
                                    txtPos.Text=(Convert.ToString(data));
                                }));
                                return 0;
                            }
                        }
                    }
                }
                offset += read;
            }
            return -2;
        }
        public int GetParams(int _timeout)
        {
            int offset = 0;
            int ticks = Environment.TickCount;
            while ((Environment.TickCount - ticks) < _timeout)
            {
                Thread.Sleep(10);
                int length = RSCOM.BytesToRead;

                if (length <= 0) continue;
                int read = RSCOM.Read(buffer, offset, length);

                /*
                         public float fpoint;
                        public int point;
                        public int , ;
                        public float fanglemax, fanglemin;
                        public int imax;
                        public float fimax;
                        public int ,;
                        public float ellocoeff;
                */
                if (read > 0)
                {
                    for (int i = offset + read - 1; i >= offset; i--)
                    {
                        if (buffer[i] == 0x0A)
                        {
                            if (buffer[i] > 0 && buffer[i - 1] == 0x0D)//znalezieno koniec ramki
                            {
                                int received = i;
                                int cut = 0;
                                int index_start_char = received;                                
                                string str = (System.Text.Encoding.ASCII.GetString(buffer));
                                string[] temps = str.Split('\t');
                                point = Int32.Parse(temps[0]);
                                txtPoint.Invoke(new Action(delegate () { txtPoint.Text = (Convert.ToString(point)); }));
                                tolerance = Int32.Parse(temps[1]);

                                //txtTolerance.Invoke(new Action(delegate () { txtTolerance.Text = Convert.ToString(Int32.Parse(temps[1])); }));
                                txtTolerance.Invoke(new Action(delegate () { txtTolerance.Text = Convert.ToString(Int32.Parse(temps[1])); }));
                                amax = Int32.Parse(temps[2]);
                                txtAMax.Invoke(new Action(delegate () { txtAMax.Text = (Convert.ToString(amax)); }));
                                amin = Int32.Parse(temps[3]);
                                txtAMin.Invoke(new Action(delegate () { txtAMin.Text = (Convert.ToString(amin)); }));

                                txtPTimeout.Invoke(new Action(delegate () { txtPTimeout.Text = (Convert.ToString(Int32.Parse(temps[4]))); }));
                                txtPi.Invoke(new Action(delegate () { txtPi.Text = (Convert.ToString(float.Parse(temps[5]) / 1000)); }));
                                txtKi.Invoke(new Action(delegate () { txtKi.Text = (Convert.ToString(float.Parse(temps[6]) / 1000)); }));
                                txtIMax.Invoke(new Action(delegate () { txtIMax.Text = (Convert.ToString(float.Parse(temps[7]) / 1000)); }));
                                txtINVPOS.Invoke(new Action(delegate () { txtINVPOS.Text = (Convert.ToString(Int32.Parse(temps[8]))); }));
                                umin = Int32.Parse(temps[9]);
                                txtUmin.Invoke(new Action(delegate () { txtUmin.Text = (Convert.ToString(umin)); }));
                                umax = Int32.Parse(temps[10]);
                                txtUmax.Invoke(new Action(delegate () { txtUmax.Text = (Convert.ToString(umax)); }));
                                txtStartDelay.Invoke(new Action(delegate () { txtStartDelay.Text = (Convert.ToString(Int32.Parse(temps[11]))); }));

                                ellocoeff = (float)(umax - umin) / anglerange;
                                fpoint = (float)(point - umin) / ellocoeff;
                                //lbPointCal.Invoke(new Action(delegate () { lbPointCal.Text = (Convert.ToString("{0:F2}",fpoint)); }));
                                lbPointCal.Invoke(new Action(delegate () { lbPointCal.Text = fpoint.ToString("0.00"); lbPointCal.Text += "°"; }));
                                ftolerance = (float)(tolerance) / ellocoeff;
                                lbToleranceCal.Invoke(new Action(delegate () { lbToleranceCal.Text = ftolerance.ToString("0.00"); lbToleranceCal.Text += "°"; }));
                                amax = Convert.ToInt32(txtAMax.Text);
                                famax = (float)(amax - umin) / ellocoeff;
                                lbAMAX.Invoke(new Action(delegate () { lbAMAX.Text = famax.ToString("0.00"); lbAMAX.Text += "°"; }));
                                amin = Convert.ToInt32(txtAMin.Text);
                                famin = (float)(amin - umin) / ellocoeff;
                                lbAMIN.Invoke(new Action(delegate () { lbAMIN.Text = famin.ToString("0.00"); lbAMIN.Text += "°"; }));
                                imax= Convert.ToInt32(txtIMax.Text);
                                fimax = (float)imax * 33 / 4096;
                                lbIMAXCal.Invoke(new Action(delegate () { lbIMAXCal.Text = fimax.ToString("0.00 [A]"); }));
                                /*
                                txtPoint.Invoke(new Action(delegate () { txtPoint.Text = (Convert.ToString(Int32.Parse(temps[0])));}));
                                txtTolerance.Invoke(new Action(delegate () { txtTolerance.Text = (Convert.ToString(Int32.Parse(temps[1]))); }));
                                txtAMax.Invoke(new Action(delegate () { txtAMax.Text = (Convert.ToString(Int32.Parse(temps[2]))); }));
                                txtAMin.Invoke(new Action(delegate () { txtAMin.Text = (Convert.ToString(Int32.Parse(temps[3]))); }));
                                txtPTimeout.Invoke(new Action(delegate () { txtPTimeout.Text = (Convert.ToString(Int32.Parse(temps[4]))); }));
                                txtPi.Invoke(new Action(delegate () { txtPi.Text = (Convert.ToString(float.Parse(temps[5])/1000)); }));
                                txtKi.Invoke(new Action(delegate () { txtKi.Text = (Convert.ToString(float.Parse(temps[6])/1000)); }));
                                txtIMax.Invoke(new Action(delegate () { txtIMax.Text = (Convert.ToString(float.Parse(temps[7])/1000)); }));
                                txtINVPOS.Invoke(new Action(delegate () { txtINVPOS.Text = (Convert.ToString(Int32.Parse(temps[8]))); }));
                                txtUmin.Invoke(new Action(delegate () { txtUmin.Text = (Convert.ToString(Int32.Parse(temps[9]))); }));
                                txtUmax.Invoke(new Action(delegate () { txtUmax.Text = (Convert.ToString(Int32.Parse(temps[10]))); }));
*/
                                return 0;
                            }
                        }
                    }
                }
                offset += read;
            }
            return -2;
        }
        public void SetParams()
        {
            string data=string.Empty;
            string tpi = (float.Parse(txtPi.Text)*1000).ToString();            
            string tki = (float.Parse(txtKi.Text)*1000).ToString();
            string tim = (float.Parse(txtIMax.Text)*1000).ToString();
            data =String.Concat("SETPARAMS ",txtPoint.Text,"\t",txtTolerance.Text,"\t",txtAMax.Text,"\t",txtAMin.Text,"\t",txtPTimeout.Text,"\t",tpi,"\t",tki,"\t",tim,"\t",txtINVPOS.Text,"\t",txtUmin.Text,"\t",txtUmax.Text,"\t",txtStartDelay.Text,"\r\n");
            RSCOM.Write(data);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!connstatus)
            {
                RSCOM = new SerialPort(COMSBOX.Text, 9600, Parity.None, 8, StopBits.One);
                RSCOM.Open();
                if (RSCOM.IsOpen)
                {
                    RSCOM.ReadTimeout = 500;
                    RSCOM.WriteTimeout = 500;
                    connstatus = true;
                    btnConnect.Text = "CONNECTED";
                    RSCOM.Write("GETPARAMS\r\n");
                    GetParams(150);
                    btnGetData.Text = "GETDATA ON";
                    aTimer.Enabled = true;
                    aTimer.Start();
                }
                else
                {
                    RSCOM.Dispose();
                }
            }
            else
            {
                //if (RSCOM.IsOpen)
                {
                    connstatus = false;
                    btnConnect.Text = "CONNECT";
                    RSCOM.Close();
                    RSCOM.Dispose();
                }
            }
        }
        private void btnMSTART_Click(object sender, EventArgs e)
        {
            if (RSCOM.IsOpen)
            {
                if (btnMSTARTSTOP.Text == "MOTOR START")
                {
                    RSCOM.Write("MOTORSTART\r\n");
                    Thread.Sleep(100);
                    RSCOM.Write("MOTORSTART\r\n");
                    Thread.Sleep(100);
                    RSCOM.Write("MOTORSTART\r\n");                         
                }
            }
        }
        private void btnGetData_Click(object sender, EventArgs e)
        {
            if (btnGetData.Text == "GETDATA OFF")
            {
                btnGetData.Text="GETDATA ON";
                aTimer.Enabled = true;
                aTimer.Start();
            }
            else
            {
                btnGetData.Text = "GETDATA OFF";
                aTimer.Enabled = false;
                aTimer.Stop();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnGETPARAMS_Click(object sender, EventArgs e)
        {
            if (RSCOM.IsOpen)
            {
                RSCOM.Write("GETPARAMS\r\n");
                GetParams(150);
            }
        }
        private void btnSETPARAMS_Click(object sender, EventArgs e)
        {
            if (RSCOM.IsOpen)
            {
                SetParams();
            };
        }
        private void btnVALVE_LP_Click(object sender, EventArgs e)
        {
            if (RSCOM.IsOpen)
            {         
                    RSCOM.Write("VALVELPON\r\n");
                    Thread.Sleep(100);
                    RSCOM.Write("VALVELPON\r\n");
                    Thread.Sleep(100);
                    RSCOM.Write("VALVELPON\r\n");
                    Thread.Sleep(100);
                
            }
        }
        private void btnRESET_Click(object sender, EventArgs e)
        {
            RSCOM.Write("RESET\r\n");
            Thread.Sleep(100);
        }
        private void btnMSTOP_Click(object sender, EventArgs e)
        {
            RSCOM.Write("MOTORSTOP\r\n");
            Thread.Sleep(100);
            RSCOM.Write("MOTORSTOP\r\n");
            Thread.Sleep(100);
            RSCOM.Write("MOTORSTOP\r\n");            
        }
        private void btnVALVE_LP_OFF_Click(object sender, EventArgs e)
        {
            if (RSCOM.IsOpen)
            {
                RSCOM.Write("VALVELPOFF\r\n");
                Thread.Sleep(100);
                RSCOM.Write("VALVELPOFF\r\n");
                Thread.Sleep(100);
                RSCOM.Write("VALVELPOFF\r\n");
                Thread.Sleep(100);

            }
        }
        private void btnVALVE_DOWN_OFF_Click(object sender, EventArgs e)
        {
            if (RSCOM.IsOpen)
            {
                    RSCOM.Write("VALVEDOWNOFF\r\n");
                    Thread.Sleep(100);
                    RSCOM.Write("VALVEDOWNOFF\r\n");
                    Thread.Sleep(100);
                    RSCOM.Write("VALVEDOWNOFF\r\n");
                    Thread.Sleep(100);
                }
            }
        private void btnVALVE_DOWN_ON_Click(object sender, EventArgs e)
        {
            if (RSCOM.IsOpen)
            {
                RSCOM.Write("VALVEDOWNON\r\n");
                Thread.Sleep(100);
                RSCOM.Write("VALVEDOWNON\r\n");
                Thread.Sleep(100);
                RSCOM.Write("VALVEDOWNON\r\n");
                Thread.Sleep(100);
            }
        }
        private void txtPoint_TextChanged(object sender, EventArgs e)
        {
            if(txtPoint.Text != "")
            {
                float fpoint = Convert.ToSingle(txtPoint.Text);
                if (ellocoeff == 0) { fpoint = 0; }
                else { fpoint = (float)(fpoint - umin) / ellocoeff; }
                if (fpoint > anglerange) { fpoint = anglerange; }
                if (fpoint < 0) { fpoint = 0; }
                lbPointCal.Invoke(new Action(delegate () { lbPointCal.Text = fpoint.ToString("0.00"); lbPointCal.Text += "°"; }));
            }
    }

        private void txtTolerance_TextChanged(object sender, EventArgs e)
        {
            tolerance = Convert.ToInt32(txtTolerance.Text);
            ftolerance = (float)(tolerance) / ellocoeff;
            lbToleranceCal.Invoke(new Action(delegate () { lbToleranceCal.Text = ftolerance.ToString("0.00"); }));
        }

        private void txtIMax_TextChanged(object sender, EventArgs e)
        {
            imax = Convert.ToInt32(txtIMax.Text);
            fimax = (float)imax * 33 / 4096;
            lbIMAXCal.Invoke(new Action(delegate () { lbIMAXCal.Text = fimax.ToString("0.00 [A]"); }));
        }

        private void txtAMax_TextChanged(object sender, EventArgs e)
        {
            if (ellocoeff != 0)
            {
                amax = Convert.ToInt32(txtAMax.Text);
                famax = (float)(amax - umin) / ellocoeff;
                lbAMAX.Invoke(new Action(delegate () { lbAMAX.Text = famax.ToString("0.00"); }));
            }
        }

        private void lbIMAXCal_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void txtAMin_TextChanged(object sender, EventArgs e)
        {
            if (ellocoeff != 0)
            { 
                amin = Convert.ToInt32(txtAMin.Text);
                famin = (float)(amin - umin) / ellocoeff;
                lbAMIN.Invoke(new Action(delegate () { lbAMIN.Text = famin.ToString("0.00"); }));
            }
        }

        private void txtAMax_Validated(object sender, EventArgs e)
        {

        }
/*
        private void txtPoint_Validated(object sender, EventArgs e)
        {            

        }
*/
    }
}
