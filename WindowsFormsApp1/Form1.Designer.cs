namespace WindowsFormsApp1
{
    partial class INTRAK
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.RSCOM = new System.IO.Ports.SerialPort(this.components);
            this.lbCOM = new System.Windows.Forms.Label();
            this.COMSBOX = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnMSTARTSTOP = new System.Windows.Forms.Button();
            this.btnRESET = new System.Windows.Forms.Button();
            this.btnGETPARAMS = new System.Windows.Forms.Button();
            this.btnSETPARAMS = new System.Windows.Forms.Button();
            this.btnGetData = new System.Windows.Forms.Button();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtTolerance = new System.Windows.Forms.TextBox();
            this.txtAMax = new System.Windows.Forms.TextBox();
            this.lbPoint = new System.Windows.Forms.Label();
            this.lbTolerance = new System.Windows.Forms.Label();
            this.lbAngMax = new System.Windows.Forms.Label();
            this.lbAngMin = new System.Windows.Forms.Label();
            this.lbProcesTimeout = new System.Windows.Forms.Label();
            this.lbIMAX = new System.Windows.Forms.Label();
            this.lbPI = new System.Windows.Forms.Label();
            this.lbKi = new System.Windows.Forms.Label();
            this.txtAMin = new System.Windows.Forms.TextBox();
            this.txtPTimeout = new System.Windows.Forms.TextBox();
            this.txtPi = new System.Windows.Forms.TextBox();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtIMax = new System.Windows.Forms.TextBox();
            this.btnVALVE_LP_ON = new System.Windows.Forms.Button();
            this.btnVALVE_DOWN_ON = new System.Windows.Forms.Button();
            this.txtINVPOS = new System.Windows.Forms.TextBox();
            this.lbINVPOS = new System.Windows.Forms.Label();
            this.btnMSTOP = new System.Windows.Forms.Button();
            this.btnVALVE_LP_OFF = new System.Windows.Forms.Button();
            this.btnVALVE_DOWN_OFF = new System.Windows.Forms.Button();
            this.lbUmin = new System.Windows.Forms.Label();
            this.lbUmax = new System.Windows.Forms.Label();
            this.txtUmin = new System.Windows.Forms.TextBox();
            this.txtUmax = new System.Windows.Forms.TextBox();
            this.lbPointCal = new System.Windows.Forms.Label();
            this.lbToleranceCal = new System.Windows.Forms.Label();
            this.lbAMAX = new System.Windows.Forms.Label();
            this.lbAMIN = new System.Windows.Forms.Label();
            this.lbIMAXCal = new System.Windows.Forms.Label();
            this.lbtouts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartDelay = new System.Windows.Forms.TextBox();
            this.lbstartdelay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbActPos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RSCOM
            // 
            this.RSCOM.ReadTimeout = 500;
            this.RSCOM.WriteTimeout = 500;
            // 
            // lbCOM
            // 
            this.lbCOM.AutoSize = true;
            this.lbCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCOM.Location = new System.Drawing.Point(791, 6);
            this.lbCOM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCOM.Name = "lbCOM";
            this.lbCOM.Size = new System.Drawing.Size(51, 16);
            this.lbCOM.TabIndex = 0;
            this.lbCOM.Text = "COMS";
            // 
            // COMSBOX
            // 
            this.COMSBOX.AutoCompleteCustomSource.AddRange(new string[] {
            "COM1",
            "COM2"});
            this.COMSBOX.FormattingEnabled = true;
            this.COMSBOX.Location = new System.Drawing.Point(757, 23);
            this.COMSBOX.Margin = new System.Windows.Forms.Padding(4);
            this.COMSBOX.MaxDropDownItems = 6;
            this.COMSBOX.MaxLength = 5;
            this.COMSBOX.Name = "COMSBOX";
            this.COMSBOX.Size = new System.Drawing.Size(131, 24);
            this.COMSBOX.Sorted = true;
            this.COMSBOX.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.Location = new System.Drawing.Point(741, 60);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMSTARTSTOP
            // 
            this.btnMSTARTSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMSTARTSTOP.Location = new System.Drawing.Point(741, 96);
            this.btnMSTARTSTOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnMSTARTSTOP.Name = "btnMSTARTSTOP";
            this.btnMSTARTSTOP.Size = new System.Drawing.Size(150, 28);
            this.btnMSTARTSTOP.TabIndex = 3;
            this.btnMSTARTSTOP.Text = "MOTOR START";
            this.btnMSTARTSTOP.UseVisualStyleBackColor = true;
            this.btnMSTARTSTOP.Click += new System.EventHandler(this.btnMSTART_Click);
            // 
            // btnRESET
            // 
            this.btnRESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRESET.Location = new System.Drawing.Point(741, 306);
            this.btnRESET.Margin = new System.Windows.Forms.Padding(4);
            this.btnRESET.Name = "btnRESET";
            this.btnRESET.Size = new System.Drawing.Size(150, 28);
            this.btnRESET.TabIndex = 4;
            this.btnRESET.Text = "RESET";
            this.btnRESET.UseVisualStyleBackColor = true;
            this.btnRESET.Click += new System.EventHandler(this.btnRESET_Click);
            // 
            // btnGETPARAMS
            // 
            this.btnGETPARAMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGETPARAMS.Location = new System.Drawing.Point(18, 15);
            this.btnGETPARAMS.Margin = new System.Windows.Forms.Padding(4);
            this.btnGETPARAMS.Name = "btnGETPARAMS";
            this.btnGETPARAMS.Size = new System.Drawing.Size(150, 28);
            this.btnGETPARAMS.TabIndex = 5;
            this.btnGETPARAMS.Text = "GETPARAMS";
            this.btnGETPARAMS.UseVisualStyleBackColor = true;
            this.btnGETPARAMS.Click += new System.EventHandler(this.btnGETPARAMS_Click);
            // 
            // btnSETPARAMS
            // 
            this.btnSETPARAMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSETPARAMS.Location = new System.Drawing.Point(177, 15);
            this.btnSETPARAMS.Margin = new System.Windows.Forms.Padding(4);
            this.btnSETPARAMS.Name = "btnSETPARAMS";
            this.btnSETPARAMS.Size = new System.Drawing.Size(150, 28);
            this.btnSETPARAMS.TabIndex = 6;
            this.btnSETPARAMS.Text = "SETPARAMS";
            this.btnSETPARAMS.UseVisualStyleBackColor = true;
            this.btnSETPARAMS.Click += new System.EventHandler(this.btnSETPARAMS_Click);
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGetData.Location = new System.Drawing.Point(554, 12);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(150, 28);
            this.btnGetData.TabIndex = 7;
            this.btnGetData.Text = "GETDATA OFF";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(554, 63);
            this.txtPos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(67, 22);
            this.txtPos.TabIndex = 8;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPosition.Location = new System.Drawing.Point(584, 44);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(64, 16);
            this.lbPosition.TabIndex = 9;
            this.lbPosition.Text = "Position";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(177, 64);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(148, 22);
            this.txtPoint.TabIndex = 10;
            this.txtPoint.TextChanged += new System.EventHandler(this.txtPoint_TextChanged);
            // 
            // txtTolerance
            // 
            this.txtTolerance.Location = new System.Drawing.Point(177, 96);
            this.txtTolerance.Margin = new System.Windows.Forms.Padding(4);
            this.txtTolerance.Name = "txtTolerance";
            this.txtTolerance.Size = new System.Drawing.Size(148, 22);
            this.txtTolerance.TabIndex = 11;
            this.txtTolerance.TextChanged += new System.EventHandler(this.txtTolerance_TextChanged);
            // 
            // txtAMax
            // 
            this.txtAMax.Location = new System.Drawing.Point(177, 128);
            this.txtAMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtAMax.Name = "txtAMax";
            this.txtAMax.Size = new System.Drawing.Size(148, 22);
            this.txtAMax.TabIndex = 12;
            this.txtAMax.TextChanged += new System.EventHandler(this.txtAMax_TextChanged);
            this.txtAMax.Validated += new System.EventHandler(this.txtAMax_Validated);
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPoint.Location = new System.Drawing.Point(18, 68);
            this.lbPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(54, 16);
            this.lbPoint.TabIndex = 13;
            this.lbPoint.Text = "POINT";
            this.lbPoint.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbTolerance
            // 
            this.lbTolerance.AutoSize = true;
            this.lbTolerance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTolerance.Location = new System.Drawing.Point(18, 100);
            this.lbTolerance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTolerance.Name = "lbTolerance";
            this.lbTolerance.Size = new System.Drawing.Size(99, 16);
            this.lbTolerance.TabIndex = 14;
            this.lbTolerance.Text = "TOLERANCE";
            // 
            // lbAngMax
            // 
            this.lbAngMax.AutoSize = true;
            this.lbAngMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAngMax.Location = new System.Drawing.Point(18, 132);
            this.lbAngMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAngMax.Name = "lbAngMax";
            this.lbAngMax.Size = new System.Drawing.Size(89, 16);
            this.lbAngMax.TabIndex = 15;
            this.lbAngMax.Text = "ANGLEMAX";
            // 
            // lbAngMin
            // 
            this.lbAngMin.AutoSize = true;
            this.lbAngMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAngMin.Location = new System.Drawing.Point(18, 164);
            this.lbAngMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAngMin.Name = "lbAngMin";
            this.lbAngMin.Size = new System.Drawing.Size(85, 16);
            this.lbAngMin.TabIndex = 16;
            this.lbAngMin.Text = "ANGLEMIN";
            // 
            // lbProcesTimeout
            // 
            this.lbProcesTimeout.AutoSize = true;
            this.lbProcesTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbProcesTimeout.Location = new System.Drawing.Point(18, 196);
            this.lbProcesTimeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProcesTimeout.Name = "lbProcesTimeout";
            this.lbProcesTimeout.Size = new System.Drawing.Size(138, 16);
            this.lbProcesTimeout.TabIndex = 17;
            this.lbProcesTimeout.Text = "PROCESTIMEOUT";
            // 
            // lbIMAX
            // 
            this.lbIMAX.AutoSize = true;
            this.lbIMAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbIMAX.Location = new System.Drawing.Point(18, 327);
            this.lbIMAX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIMAX.Name = "lbIMAX";
            this.lbIMAX.Size = new System.Drawing.Size(43, 16);
            this.lbIMAX.TabIndex = 18;
            this.lbIMAX.Text = "IMAX";
            // 
            // lbPI
            // 
            this.lbPI.AutoSize = true;
            this.lbPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPI.Location = new System.Drawing.Point(18, 261);
            this.lbPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPI.Name = "lbPI";
            this.lbPI.Size = new System.Drawing.Size(22, 16);
            this.lbPI.TabIndex = 19;
            this.lbPI.Text = "PI";
            // 
            // lbKi
            // 
            this.lbKi.AutoSize = true;
            this.lbKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbKi.Location = new System.Drawing.Point(18, 295);
            this.lbKi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKi.Name = "lbKi";
            this.lbKi.Size = new System.Drawing.Size(21, 16);
            this.lbKi.TabIndex = 20;
            this.lbKi.Text = "KI";
            // 
            // txtAMin
            // 
            this.txtAMin.Location = new System.Drawing.Point(177, 160);
            this.txtAMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtAMin.Name = "txtAMin";
            this.txtAMin.Size = new System.Drawing.Size(148, 22);
            this.txtAMin.TabIndex = 21;
            this.txtAMin.TextChanged += new System.EventHandler(this.txtAMin_TextChanged);
            // 
            // txtPTimeout
            // 
            this.txtPTimeout.Location = new System.Drawing.Point(177, 192);
            this.txtPTimeout.Margin = new System.Windows.Forms.Padding(4);
            this.txtPTimeout.Name = "txtPTimeout";
            this.txtPTimeout.Size = new System.Drawing.Size(148, 22);
            this.txtPTimeout.TabIndex = 22;
            // 
            // txtPi
            // 
            this.txtPi.Location = new System.Drawing.Point(177, 257);
            this.txtPi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPi.Name = "txtPi";
            this.txtPi.Size = new System.Drawing.Size(148, 22);
            this.txtPi.TabIndex = 23;
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(177, 292);
            this.txtKi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(148, 22);
            this.txtKi.TabIndex = 24;
            // 
            // txtIMax
            // 
            this.txtIMax.Location = new System.Drawing.Point(177, 324);
            this.txtIMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtIMax.Name = "txtIMax";
            this.txtIMax.Size = new System.Drawing.Size(148, 22);
            this.txtIMax.TabIndex = 25;
            this.txtIMax.TextChanged += new System.EventHandler(this.txtIMax_TextChanged);
            // 
            // btnVALVE_LP_ON
            // 
            this.btnVALVE_LP_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVALVE_LP_ON.Location = new System.Drawing.Point(741, 167);
            this.btnVALVE_LP_ON.Margin = new System.Windows.Forms.Padding(4);
            this.btnVALVE_LP_ON.Name = "btnVALVE_LP_ON";
            this.btnVALVE_LP_ON.Size = new System.Drawing.Size(150, 28);
            this.btnVALVE_LP_ON.TabIndex = 26;
            this.btnVALVE_LP_ON.Text = "VALVE LP ON";
            this.btnVALVE_LP_ON.UseVisualStyleBackColor = true;
            this.btnVALVE_LP_ON.Click += new System.EventHandler(this.btnVALVE_LP_Click);
            // 
            // btnVALVE_DOWN_ON
            // 
            this.btnVALVE_DOWN_ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVALVE_DOWN_ON.Location = new System.Drawing.Point(712, 236);
            this.btnVALVE_DOWN_ON.Margin = new System.Windows.Forms.Padding(4);
            this.btnVALVE_DOWN_ON.Name = "btnVALVE_DOWN_ON";
            this.btnVALVE_DOWN_ON.Size = new System.Drawing.Size(179, 28);
            this.btnVALVE_DOWN_ON.TabIndex = 27;
            this.btnVALVE_DOWN_ON.Text = "VALVE DOWN ON";
            this.btnVALVE_DOWN_ON.UseVisualStyleBackColor = true;
            this.btnVALVE_DOWN_ON.Click += new System.EventHandler(this.btnVALVE_DOWN_ON_Click);
            // 
            // txtINVPOS
            // 
            this.txtINVPOS.Location = new System.Drawing.Point(177, 356);
            this.txtINVPOS.Margin = new System.Windows.Forms.Padding(4);
            this.txtINVPOS.Name = "txtINVPOS";
            this.txtINVPOS.Size = new System.Drawing.Size(148, 22);
            this.txtINVPOS.TabIndex = 29;
            // 
            // lbINVPOS
            // 
            this.lbINVPOS.AutoSize = true;
            this.lbINVPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbINVPOS.Location = new System.Drawing.Point(18, 359);
            this.lbINVPOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbINVPOS.Name = "lbINVPOS";
            this.lbINVPOS.Size = new System.Drawing.Size(64, 16);
            this.lbINVPOS.TabIndex = 28;
            this.lbINVPOS.Text = "INVPOS";
            // 
            // btnMSTOP
            // 
            this.btnMSTOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMSTOP.Location = new System.Drawing.Point(741, 132);
            this.btnMSTOP.Margin = new System.Windows.Forms.Padding(4);
            this.btnMSTOP.Name = "btnMSTOP";
            this.btnMSTOP.Size = new System.Drawing.Size(150, 28);
            this.btnMSTOP.TabIndex = 30;
            this.btnMSTOP.Text = "MOTOR STOP";
            this.btnMSTOP.UseVisualStyleBackColor = true;
            this.btnMSTOP.Click += new System.EventHandler(this.btnMSTOP_Click);
            // 
            // btnVALVE_LP_OFF
            // 
            this.btnVALVE_LP_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVALVE_LP_OFF.Location = new System.Drawing.Point(741, 201);
            this.btnVALVE_LP_OFF.Margin = new System.Windows.Forms.Padding(4);
            this.btnVALVE_LP_OFF.Name = "btnVALVE_LP_OFF";
            this.btnVALVE_LP_OFF.Size = new System.Drawing.Size(150, 28);
            this.btnVALVE_LP_OFF.TabIndex = 31;
            this.btnVALVE_LP_OFF.Text = "VALVE LP OFF";
            this.btnVALVE_LP_OFF.UseVisualStyleBackColor = true;
            this.btnVALVE_LP_OFF.Click += new System.EventHandler(this.btnVALVE_LP_OFF_Click);
            // 
            // btnVALVE_DOWN_OFF
            // 
            this.btnVALVE_DOWN_OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVALVE_DOWN_OFF.Location = new System.Drawing.Point(712, 272);
            this.btnVALVE_DOWN_OFF.Margin = new System.Windows.Forms.Padding(4);
            this.btnVALVE_DOWN_OFF.Name = "btnVALVE_DOWN_OFF";
            this.btnVALVE_DOWN_OFF.Size = new System.Drawing.Size(179, 28);
            this.btnVALVE_DOWN_OFF.TabIndex = 32;
            this.btnVALVE_DOWN_OFF.Text = "VALVE DOWN OFF";
            this.btnVALVE_DOWN_OFF.UseVisualStyleBackColor = true;
            this.btnVALVE_DOWN_OFF.Click += new System.EventHandler(this.btnVALVE_DOWN_OFF_Click);
            // 
            // lbUmin
            // 
            this.lbUmin.AutoSize = true;
            this.lbUmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUmin.Location = new System.Drawing.Point(18, 394);
            this.lbUmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUmin.Name = "lbUmin";
            this.lbUmin.Size = new System.Drawing.Size(46, 16);
            this.lbUmin.TabIndex = 33;
            this.lbUmin.Text = "UMIN";
            // 
            // lbUmax
            // 
            this.lbUmax.AutoSize = true;
            this.lbUmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUmax.Location = new System.Drawing.Point(18, 430);
            this.lbUmax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUmax.Name = "lbUmax";
            this.lbUmax.Size = new System.Drawing.Size(50, 16);
            this.lbUmax.TabIndex = 34;
            this.lbUmax.Text = "UMAX";
            // 
            // txtUmin
            // 
            this.txtUmin.Location = new System.Drawing.Point(177, 390);
            this.txtUmin.Margin = new System.Windows.Forms.Padding(4);
            this.txtUmin.Name = "txtUmin";
            this.txtUmin.Size = new System.Drawing.Size(148, 22);
            this.txtUmin.TabIndex = 35;
            // 
            // txtUmax
            // 
            this.txtUmax.Location = new System.Drawing.Point(177, 426);
            this.txtUmax.Margin = new System.Windows.Forms.Padding(4);
            this.txtUmax.Name = "txtUmax";
            this.txtUmax.Size = new System.Drawing.Size(148, 22);
            this.txtUmax.TabIndex = 36;
            // 
            // lbPointCal
            // 
            this.lbPointCal.AutoSize = true;
            this.lbPointCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPointCal.Location = new System.Drawing.Point(351, 68);
            this.lbPointCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPointCal.Name = "lbPointCal";
            this.lbPointCal.Size = new System.Drawing.Size(54, 16);
            this.lbPointCal.TabIndex = 37;
            this.lbPointCal.Text = "POINT";
            // 
            // lbToleranceCal
            // 
            this.lbToleranceCal.AutoSize = true;
            this.lbToleranceCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbToleranceCal.Location = new System.Drawing.Point(351, 102);
            this.lbToleranceCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbToleranceCal.Name = "lbToleranceCal";
            this.lbToleranceCal.Size = new System.Drawing.Size(99, 16);
            this.lbToleranceCal.TabIndex = 38;
            this.lbToleranceCal.Text = "TOLERANCE";
            // 
            // lbAMAX
            // 
            this.lbAMAX.AutoSize = true;
            this.lbAMAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAMAX.Location = new System.Drawing.Point(351, 132);
            this.lbAMAX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAMAX.Name = "lbAMAX";
            this.lbAMAX.Size = new System.Drawing.Size(49, 16);
            this.lbAMAX.TabIndex = 39;
            this.lbAMAX.Text = "AMAX";
            // 
            // lbAMIN
            // 
            this.lbAMIN.AutoSize = true;
            this.lbAMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAMIN.Location = new System.Drawing.Point(351, 164);
            this.lbAMIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAMIN.Name = "lbAMIN";
            this.lbAMIN.Size = new System.Drawing.Size(45, 16);
            this.lbAMIN.TabIndex = 40;
            this.lbAMIN.Text = "AMIN";
            // 
            // lbIMAXCal
            // 
            this.lbIMAXCal.AutoSize = true;
            this.lbIMAXCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbIMAXCal.Location = new System.Drawing.Point(351, 327);
            this.lbIMAXCal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIMAXCal.Name = "lbIMAXCal";
            this.lbIMAXCal.Size = new System.Drawing.Size(43, 16);
            this.lbIMAXCal.TabIndex = 41;
            this.lbIMAXCal.Text = "IMAX";
            this.lbIMAXCal.TextChanged += new System.EventHandler(this.lbIMAXCal_TextChanged);
            // 
            // lbtouts
            // 
            this.lbtouts.AutoSize = true;
            this.lbtouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbtouts.Location = new System.Drawing.Point(350, 196);
            this.lbtouts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbtouts.Name = "lbtouts";
            this.lbtouts.Size = new System.Drawing.Size(38, 16);
            this.lbtouts.TabIndex = 42;
            this.lbtouts.Text = "[ms]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(350, 229);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "[ms]";
            // 
            // txtStartDelay
            // 
            this.txtStartDelay.Location = new System.Drawing.Point(177, 225);
            this.txtStartDelay.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDelay.Name = "txtStartDelay";
            this.txtStartDelay.Size = new System.Drawing.Size(148, 22);
            this.txtStartDelay.TabIndex = 44;
            // 
            // lbstartdelay
            // 
            this.lbstartdelay.AutoSize = true;
            this.lbstartdelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbstartdelay.Location = new System.Drawing.Point(18, 229);
            this.lbstartdelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbstartdelay.Name = "lbstartdelay";
            this.lbstartdelay.Size = new System.Drawing.Size(108, 16);
            this.lbstartdelay.TabIndex = 43;
            this.lbstartdelay.Text = "STARTDELAY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(351, 394);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "0°";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(350, 430);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "90°";
            // 
            // lbActPos
            // 
            this.lbActPos.AutoSize = true;
            this.lbActPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbActPos.Location = new System.Drawing.Point(630, 66);
            this.lbActPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbActPos.Name = "lbActPos";
            this.lbActPos.Size = new System.Drawing.Size(54, 16);
            this.lbActPos.TabIndex = 48;
            this.lbActPos.Text = "POINT";
            // 
            // INTRAK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 577);
            this.Controls.Add(this.lbActPos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartDelay);
            this.Controls.Add(this.lbstartdelay);
            this.Controls.Add(this.lbtouts);
            this.Controls.Add(this.lbIMAXCal);
            this.Controls.Add(this.lbAMIN);
            this.Controls.Add(this.lbAMAX);
            this.Controls.Add(this.lbToleranceCal);
            this.Controls.Add(this.lbPointCal);
            this.Controls.Add(this.txtUmax);
            this.Controls.Add(this.txtUmin);
            this.Controls.Add(this.lbUmax);
            this.Controls.Add(this.lbUmin);
            this.Controls.Add(this.btnVALVE_DOWN_OFF);
            this.Controls.Add(this.btnVALVE_LP_OFF);
            this.Controls.Add(this.btnMSTOP);
            this.Controls.Add(this.txtINVPOS);
            this.Controls.Add(this.lbINVPOS);
            this.Controls.Add(this.btnVALVE_DOWN_ON);
            this.Controls.Add(this.btnVALVE_LP_ON);
            this.Controls.Add(this.txtIMax);
            this.Controls.Add(this.txtKi);
            this.Controls.Add(this.txtPi);
            this.Controls.Add(this.txtPTimeout);
            this.Controls.Add(this.txtAMin);
            this.Controls.Add(this.lbKi);
            this.Controls.Add(this.lbPI);
            this.Controls.Add(this.lbIMAX);
            this.Controls.Add(this.lbProcesTimeout);
            this.Controls.Add(this.lbAngMin);
            this.Controls.Add(this.lbAngMax);
            this.Controls.Add(this.lbTolerance);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.txtAMax);
            this.Controls.Add(this.txtTolerance);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.btnSETPARAMS);
            this.Controls.Add(this.btnGETPARAMS);
            this.Controls.Add(this.btnRESET);
            this.Controls.Add(this.btnMSTARTSTOP);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.COMSBOX);
            this.Controls.Add(this.lbCOM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "INTRAK";
            this.Text = "DRIVE MANAGER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCOM;
        private System.Windows.Forms.ComboBox COMSBOX;
        public System.IO.Ports.SerialPort RSCOM;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnMSTARTSTOP;
        private System.Windows.Forms.Button btnRESET;
        private System.Windows.Forms.Button btnGETPARAMS;
        private System.Windows.Forms.Button btnSETPARAMS;
        private System.Windows.Forms.Button btnGetData;
        public System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtTolerance;
        private System.Windows.Forms.TextBox txtAMax;
        private System.Windows.Forms.Label lbPoint;
        private System.Windows.Forms.Label lbTolerance;
        private System.Windows.Forms.Label lbAngMax;
        private System.Windows.Forms.Label lbAngMin;
        private System.Windows.Forms.Label lbProcesTimeout;
        private System.Windows.Forms.Label lbIMAX;
        private System.Windows.Forms.Label lbPI;
        private System.Windows.Forms.Label lbKi;
        private System.Windows.Forms.TextBox txtAMin;
        private System.Windows.Forms.TextBox txtPTimeout;
        private System.Windows.Forms.TextBox txtPi;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtIMax;
        private System.Windows.Forms.Button btnVALVE_LP_ON;
        private System.Windows.Forms.Button btnVALVE_DOWN_ON;
        private System.Windows.Forms.TextBox txtINVPOS;
        private System.Windows.Forms.Label lbINVPOS;
        private System.Windows.Forms.Button btnMSTOP;
        private System.Windows.Forms.Button btnVALVE_LP_OFF;
        private System.Windows.Forms.Button btnVALVE_DOWN_OFF;
        private System.Windows.Forms.Label lbUmin;
        private System.Windows.Forms.Label lbUmax;
        private System.Windows.Forms.TextBox txtUmin;
        private System.Windows.Forms.TextBox txtUmax;
        private System.Windows.Forms.Label lbPointCal;
        private System.Windows.Forms.Label lbToleranceCal;
        private System.Windows.Forms.Label lbAMAX;
        private System.Windows.Forms.Label lbAMIN;
        private System.Windows.Forms.Label lbIMAXCal;
        private System.Windows.Forms.Label lbtouts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartDelay;
        private System.Windows.Forms.Label lbstartdelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbActPos;
    }
}

