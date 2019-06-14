using System.Windows.Forms;

namespace Corvus
{
    partial class FrmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.gBoxUsernamePasswordLogin = new System.Windows.Forms.GroupBox();
            this.chkBoxSaveUsernamePassword = new System.Windows.Forms.CheckBox();
            this.lblPortal = new System.Windows.Forms.Label();
            this.comboBoxLoginPortal = new System.Windows.Forms.ComboBox();
            this.rbUsernamePasswordLogin = new System.Windows.Forms.RadioButton();
            this.chkBoxReconnect = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gBoxSessionIDLogin = new System.Windows.Forms.GroupBox();
            this.rbSessionIdLogin = new System.Windows.Forms.RadioButton();
            this.txtSessionId = new System.Windows.Forms.TextBox();
            this.lblSessionId = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.tabPageGalaxyGates = new System.Windows.Forms.TabPage();
            this.lblWaitGate = new System.Windows.Forms.Label();
            this.nudGateWait = new System.Windows.Forms.NumericUpDown();
            this.comboBoxOptionABG = new System.Windows.Forms.ComboBox();
            this.comboBoxEnergyCharge = new System.Windows.Forms.ComboBox();
            this.lblEnergyCharge = new System.Windows.Forms.Label();
            this.gates = new System.Windows.Forms.Label();
            this.statistics = new System.Windows.Forms.Label();
            this.accountinfo = new System.Windows.Forms.Label();
            this.chkSpinOnlyEE = new System.Windows.Forms.CheckBox();
            this.nudMinimumUridium = new System.Windows.Forms.NumericUpDown();
            this.lblMinimumUridium = new System.Windows.Forms.Label();
            this.chkBoxPlaceGate = new System.Windows.Forms.CheckBox();
            this.chkBoxSpinGate = new System.Windows.Forms.CheckBox();
            this.lblReceivedParts = new System.Windows.Forms.Label();
            this.nudGateDelay = new System.Windows.Forms.NumericUpDown();
            this.lblGateDelay = new System.Windows.Forms.Label();
            this.lblSpinCost = new System.Windows.Forms.Label();
            this.lblReceivedNanoHull = new System.Windows.Forms.Label();
            this.lblReceivedXenomit = new System.Windows.Forms.Label();
            this.lblReceivedRepairCredits = new System.Windows.Forms.Label();
            this.lblReceivedLogDisks = new System.Windows.Forms.Label();
            this.lblReceivedACM = new System.Windows.Forms.Label();
            this.lblReceivedPLT2021 = new System.Windows.Forms.Label();
            this.lblReceivedSAB = new System.Windows.Forms.Label();
            this.lblReceivedX4 = new System.Windows.Forms.Label();
            this.lblReceivedX3 = new System.Windows.Forms.Label();
            this.lblReceivedX2 = new System.Windows.Forms.Label();
            this.lblTotalSpins = new System.Windows.Forms.Label();
            this.lblExtraEnergy = new System.Windows.Forms.Label();
            this.lblUridium = new System.Windows.Forms.Label();
            this.dgvGates = new System.Windows.Forms.DataGridView();
            this.clmnGateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGateParts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnGateReady = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnGateOnMap = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnGatesBuilt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdResetGateStats = new System.Windows.Forms.Button();
            this.rbBuildKuiper = new System.Windows.Forms.RadioButton();
            this.rbBuildHades = new System.Windows.Forms.RadioButton();
            this.rbBuildKappa = new System.Windows.Forms.RadioButton();
            this.rbBuildLambda = new System.Windows.Forms.RadioButton();
            this.rbBuildZeta = new System.Windows.Forms.RadioButton();
            this.rbBuildEpsilon = new System.Windows.Forms.RadioButton();
            this.rbBuildDelta = new System.Windows.Forms.RadioButton();
            this.rbBuildABG = new System.Windows.Forms.RadioButton();
            this.tabPageTechFactory = new System.Windows.Forms.TabPage();
            this.nudCheckTechFactoryEvery = new System.Windows.Forms.NumericUpDown();
            this.lblCheckTechFactoryEvery = new System.Windows.Forms.Label();
            this.chkBoxBuildTechs = new System.Windows.Forms.CheckBox();
            this.dgvTechFactory = new System.Windows.Forms.DataGridView();
            this.clmnTechName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTechAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTechBuilding = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnTechTimeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTechBuild = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageSkylab = new System.Windows.Forms.TabPage();
            this.nudCheckSkylabEvery = new System.Windows.Forms.NumericUpDown();
            this.lblCheckSkylabEvery = new System.Windows.Forms.Label();
            this.chkBoxUpgradeSkylab = new System.Windows.Forms.CheckBox();
            this.dgvSkylab = new System.Windows.Forms.DataGridView();
            this.clmnModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnModuleLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnModuleUpgrading = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnModuleTimeLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnModuleUpgrade = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdOpenBackPage = new System.Windows.Forms.Button();
            this.lblLastStatus = new System.Windows.Forms.Label();
            this.cmdSaveSettings = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tcMain.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.gBoxUsernamePasswordLogin.SuspendLayout();
            this.gBoxSessionIDLogin.SuspendLayout();
            this.tabPageGalaxyGates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGateWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumUridium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGateDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGates)).BeginInit();
            this.tabPageTechFactory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckTechFactoryEvery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechFactory)).BeginInit();
            this.tabPageSkylab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckSkylabEvery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkylab)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPageLogin);
            this.tcMain.Controls.Add(this.tabPageGalaxyGates);
            this.tcMain.Controls.Add(this.tabPageTechFactory);
            this.tcMain.Controls.Add(this.tabPageSkylab);
            this.tcMain.Controls.Add(this.tabPageLog);
            this.tcMain.Location = new System.Drawing.Point(13, 39);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(775, 386);
            this.tcMain.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.cmdLogin);
            this.tabPageLogin.Controls.Add(this.gBoxUsernamePasswordLogin);
            this.tabPageLogin.Controls.Add(this.gBoxSessionIDLogin);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Size = new System.Drawing.Size(767, 360);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // cmdLogin
            // 
            this.cmdLogin.Location = new System.Drawing.Point(18, 247);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(330, 23);
            this.cmdLogin.TabIndex = 7;
            this.cmdLogin.Text = "&Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // gBoxUsernamePasswordLogin
            // 
            this.gBoxUsernamePasswordLogin.Controls.Add(this.chkBoxSaveUsernamePassword);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.lblPortal);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.comboBoxLoginPortal);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.rbUsernamePasswordLogin);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.chkBoxReconnect);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.txtPassword);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.lblPassword);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.txtUsername);
            this.gBoxUsernamePasswordLogin.Controls.Add(this.lblUsername);
            this.gBoxUsernamePasswordLogin.Location = new System.Drawing.Point(18, 21);
            this.gBoxUsernamePasswordLogin.Name = "gBoxUsernamePasswordLogin";
            this.gBoxUsernamePasswordLogin.Size = new System.Drawing.Size(330, 131);
            this.gBoxUsernamePasswordLogin.TabIndex = 0;
            this.gBoxUsernamePasswordLogin.TabStop = false;
            this.gBoxUsernamePasswordLogin.Text = "                                                      ";
            // 
            // chkBoxSaveUsernamePassword
            // 
            this.chkBoxSaveUsernamePassword.AutoSize = true;
            this.chkBoxSaveUsernamePassword.Checked = true;
            this.chkBoxSaveUsernamePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxSaveUsernamePassword.Location = new System.Drawing.Point(193, 101);
            this.chkBoxSaveUsernamePassword.Name = "chkBoxSaveUsernamePassword";
            this.chkBoxSaveUsernamePassword.Size = new System.Drawing.Size(75, 17);
            this.chkBoxSaveUsernamePassword.TabIndex = 11;
            this.chkBoxSaveUsernamePassword.Text = "Save data";
            this.chkBoxSaveUsernamePassword.UseVisualStyleBackColor = true;
            // 
            // lblPortal
            // 
            this.lblPortal.AutoSize = true;
            this.lblPortal.Location = new System.Drawing.Point(6, 77);
            this.lblPortal.Name = "lblPortal";
            this.lblPortal.Size = new System.Drawing.Size(37, 13);
            this.lblPortal.TabIndex = 10;
            this.lblPortal.Text = "Portal:";
            // 
            // comboBoxLoginPortal
            // 
            this.comboBoxLoginPortal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoginPortal.FormattingEnabled = true;
            this.comboBoxLoginPortal.Items.AddRange(new object[] {
            "https://darkorbit.com/",
            "https://www.dark-orbit.it/",
            "https://lp.darkorbit.com/"});
            this.comboBoxLoginPortal.Location = new System.Drawing.Point(70, 74);
            this.comboBoxLoginPortal.Name = "comboBoxLoginPortal";
            this.comboBoxLoginPortal.Size = new System.Drawing.Size(254, 21);
            this.comboBoxLoginPortal.TabIndex = 9;
            // 
            // rbUsernamePasswordLogin
            // 
            this.rbUsernamePasswordLogin.AutoSize = true;
            this.rbUsernamePasswordLogin.Location = new System.Drawing.Point(15, 0);
            this.rbUsernamePasswordLogin.Name = "rbUsernamePasswordLogin";
            this.rbUsernamePasswordLogin.Size = new System.Drawing.Size(153, 17);
            this.rbUsernamePasswordLogin.TabIndex = 8;
            this.rbUsernamePasswordLogin.Text = "&Username/Password Login";
            this.rbUsernamePasswordLogin.UseVisualStyleBackColor = true;
            this.rbUsernamePasswordLogin.CheckedChanged += new System.EventHandler(this.rbUsernamePasswordLogin_CheckedChanged);
            // 
            // chkBoxReconnect
            // 
            this.chkBoxReconnect.AutoSize = true;
            this.chkBoxReconnect.Checked = true;
            this.chkBoxReconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxReconnect.Location = new System.Drawing.Point(70, 101);
            this.chkBoxReconnect.Name = "chkBoxReconnect";
            this.chkBoxReconnect.Size = new System.Drawing.Size(117, 17);
            this.chkBoxReconnect.TabIndex = 5;
            this.chkBoxReconnect.Text = "Reconnect on kick";
            this.chkBoxReconnect.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(70, 48);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(254, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 51);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(70, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // gBoxSessionIDLogin
            // 
            this.gBoxSessionIDLogin.Controls.Add(this.rbSessionIdLogin);
            this.gBoxSessionIDLogin.Controls.Add(this.txtSessionId);
            this.gBoxSessionIDLogin.Controls.Add(this.lblSessionId);
            this.gBoxSessionIDLogin.Controls.Add(this.txtServer);
            this.gBoxSessionIDLogin.Controls.Add(this.lblServer);
            this.gBoxSessionIDLogin.Location = new System.Drawing.Point(18, 158);
            this.gBoxSessionIDLogin.Name = "gBoxSessionIDLogin";
            this.gBoxSessionIDLogin.Size = new System.Drawing.Size(330, 83);
            this.gBoxSessionIDLogin.TabIndex = 6;
            this.gBoxSessionIDLogin.TabStop = false;
            this.gBoxSessionIDLogin.Text = "                                    ";
            // 
            // rbSessionIdLogin
            // 
            this.rbSessionIdLogin.AutoSize = true;
            this.rbSessionIdLogin.Checked = true;
            this.rbSessionIdLogin.Location = new System.Drawing.Point(15, 0);
            this.rbSessionIdLogin.Name = "rbSessionIdLogin";
            this.rbSessionIdLogin.Size = new System.Drawing.Size(100, 17);
            this.rbSessionIdLogin.TabIndex = 9;
            this.rbSessionIdLogin.TabStop = true;
            this.rbSessionIdLogin.Text = "&SessionId Login";
            this.rbSessionIdLogin.UseVisualStyleBackColor = true;
            this.rbSessionIdLogin.CheckedChanged += new System.EventHandler(this.rbSessionIdLogin_CheckedChanged);
            // 
            // txtSessionId
            // 
            this.txtSessionId.Location = new System.Drawing.Point(70, 49);
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Size = new System.Drawing.Size(254, 20);
            this.txtSessionId.TabIndex = 3;
            // 
            // lblSessionId
            // 
            this.lblSessionId.AutoSize = true;
            this.lblSessionId.Location = new System.Drawing.Point(6, 52);
            this.lblSessionId.Name = "lblSessionId";
            this.lblSessionId.Size = new System.Drawing.Size(56, 13);
            this.lblSessionId.TabIndex = 2;
            this.lblSessionId.Text = "SessionId:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(70, 23);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(254, 20);
            this.txtServer.TabIndex = 1;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(6, 26);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server:";
            // 
            // tabPageGalaxyGates
            // 
            this.tabPageGalaxyGates.Controls.Add(this.lblWaitGate);
            this.tabPageGalaxyGates.Controls.Add(this.nudGateWait);
            this.tabPageGalaxyGates.Controls.Add(this.comboBoxOptionABG);
            this.tabPageGalaxyGates.Controls.Add(this.comboBoxEnergyCharge);
            this.tabPageGalaxyGates.Controls.Add(this.lblEnergyCharge);
            this.tabPageGalaxyGates.Controls.Add(this.gates);
            this.tabPageGalaxyGates.Controls.Add(this.statistics);
            this.tabPageGalaxyGates.Controls.Add(this.accountinfo);
            this.tabPageGalaxyGates.Controls.Add(this.chkSpinOnlyEE);
            this.tabPageGalaxyGates.Controls.Add(this.nudMinimumUridium);
            this.tabPageGalaxyGates.Controls.Add(this.lblMinimumUridium);
            this.tabPageGalaxyGates.Controls.Add(this.chkBoxPlaceGate);
            this.tabPageGalaxyGates.Controls.Add(this.chkBoxSpinGate);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedParts);
            this.tabPageGalaxyGates.Controls.Add(this.nudGateDelay);
            this.tabPageGalaxyGates.Controls.Add(this.lblGateDelay);
            this.tabPageGalaxyGates.Controls.Add(this.lblSpinCost);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedNanoHull);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedXenomit);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedRepairCredits);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedLogDisks);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedACM);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedPLT2021);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedSAB);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedX4);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedX3);
            this.tabPageGalaxyGates.Controls.Add(this.lblReceivedX2);
            this.tabPageGalaxyGates.Controls.Add(this.lblTotalSpins);
            this.tabPageGalaxyGates.Controls.Add(this.lblExtraEnergy);
            this.tabPageGalaxyGates.Controls.Add(this.lblUridium);
            this.tabPageGalaxyGates.Controls.Add(this.dgvGates);
            this.tabPageGalaxyGates.Controls.Add(this.cmdResetGateStats);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildKuiper);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildHades);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildKappa);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildLambda);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildZeta);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildEpsilon);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildDelta);
            this.tabPageGalaxyGates.Controls.Add(this.rbBuildABG);
            this.tabPageGalaxyGates.Location = new System.Drawing.Point(4, 22);
            this.tabPageGalaxyGates.Name = "tabPageGalaxyGates";
            this.tabPageGalaxyGates.Size = new System.Drawing.Size(767, 360);
            this.tabPageGalaxyGates.TabIndex = 1;
            this.tabPageGalaxyGates.Text = "Galaxy Gates";
            this.tabPageGalaxyGates.UseVisualStyleBackColor = true;
            // 
            // lblWaitGate
            // 
            this.lblWaitGate.AutoSize = true;
            this.lblWaitGate.Location = new System.Drawing.Point(70, 62);
            this.lblWaitGate.Name = "lblWaitGate";
            this.lblWaitGate.Size = new System.Drawing.Size(78, 13);
            this.lblWaitGate.TabIndex = 44;
            this.lblWaitGate.Text = "Wait (seconds)";
            // 
            // nudGateWait
            // 
            this.nudGateWait.Location = new System.Drawing.Point(20, 58);
            this.nudGateWait.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nudGateWait.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudGateWait.Name = "nudGateWait";
            this.nudGateWait.Size = new System.Drawing.Size(50, 20);
            this.nudGateWait.TabIndex = 43;
            this.nudGateWait.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // comboBoxOptionABG
            // 
            this.comboBoxOptionABG.AllowDrop = true;
            this.comboBoxOptionABG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptionABG.DropDownWidth = 253;
            this.comboBoxOptionABG.FormattingEnabled = true;
            this.comboBoxOptionABG.IntegralHeight = false;
            this.comboBoxOptionABG.Items.AddRange(new object[] {
            "1. It should just stop when the alpha portal is 2/2",
            "2. It should just stop when the beta portal is 2/2",
            "3. It should just stop when the gamma portal is 2/2",
            "4. It should just stop when any of the 3 portals is 2/2",
            "5. It should just stop when the 3 portals are 2/2"});
            this.comboBoxOptionABG.Location = new System.Drawing.Point(73, 175);
            this.comboBoxOptionABG.Name = "comboBoxOptionABG";
            this.comboBoxOptionABG.Size = new System.Drawing.Size(69, 21);
            this.comboBoxOptionABG.TabIndex = 42;
            // 
            // comboBoxEnergyCharge
            // 
            this.comboBoxEnergyCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEnergyCharge.FormattingEnabled = true;
            this.comboBoxEnergyCharge.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "100"});
            this.comboBoxEnergyCharge.Location = new System.Drawing.Point(95, 31);
            this.comboBoxEnergyCharge.Name = "comboBoxEnergyCharge";
            this.comboBoxEnergyCharge.Size = new System.Drawing.Size(45, 21);
            this.comboBoxEnergyCharge.TabIndex = 41;
            // 
            // lblEnergyCharge
            // 
            this.lblEnergyCharge.AutoSize = true;
            this.lblEnergyCharge.Location = new System.Drawing.Point(17, 35);
            this.lblEnergyCharge.Name = "lblEnergyCharge";
            this.lblEnergyCharge.Size = new System.Drawing.Size(79, 13);
            this.lblEnergyCharge.TabIndex = 40;
            this.lblEnergyCharge.Text = "Energy charge:";
            // 
            // gates
            // 
            this.gates.AutoSize = true;
            this.gates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gates.Location = new System.Drawing.Point(17, 155);
            this.gates.Name = "gates";
            this.gates.Size = new System.Drawing.Size(50, 17);
            this.gates.TabIndex = 39;
            this.gates.Text = "Gates:";
            // 
            // statistics
            // 
            this.statistics.AutoSize = true;
            this.statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statistics.Location = new System.Drawing.Point(510, 112);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(68, 17);
            this.statistics.TabIndex = 38;
            this.statistics.Text = "Statistics:";
            // 
            // accountinfo
            // 
            this.accountinfo.AutoSize = true;
            this.accountinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountinfo.Location = new System.Drawing.Point(510, 10);
            this.accountinfo.Name = "accountinfo";
            this.accountinfo.Size = new System.Drawing.Size(90, 17);
            this.accountinfo.TabIndex = 37;
            this.accountinfo.Text = "Account info:";
            // 
            // chkSpinOnlyEE
            // 
            this.chkSpinOnlyEE.AutoSize = true;
            this.chkSpinOnlyEE.Location = new System.Drawing.Point(664, 12);
            this.chkSpinOnlyEE.Name = "chkSpinOnlyEE";
            this.chkSpinOnlyEE.Size = new System.Drawing.Size(86, 17);
            this.chkSpinOnlyEE.TabIndex = 34;
            this.chkSpinOnlyEE.Text = "Spin only EE";
            this.chkSpinOnlyEE.UseVisualStyleBackColor = true;
            // 
            // nudMinimumUridium
            // 
            this.nudMinimumUridium.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinimumUridium.Location = new System.Drawing.Point(81, 132);
            this.nudMinimumUridium.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMinimumUridium.Name = "nudMinimumUridium";
            this.nudMinimumUridium.Size = new System.Drawing.Size(59, 20);
            this.nudMinimumUridium.TabIndex = 31;
            this.nudMinimumUridium.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblMinimumUridium
            // 
            this.lblMinimumUridium.AutoSize = true;
            this.lblMinimumUridium.Location = new System.Drawing.Point(17, 134);
            this.lblMinimumUridium.Name = "lblMinimumUridium";
            this.lblMinimumUridium.Size = new System.Drawing.Size(63, 13);
            this.lblMinimumUridium.TabIndex = 30;
            this.lblMinimumUridium.Text = "Min uridium:";
            // 
            // chkBoxPlaceGate
            // 
            this.chkBoxPlaceGate.AutoSize = true;
            this.chkBoxPlaceGate.Location = new System.Drawing.Point(20, 110);
            this.chkBoxPlaceGate.Name = "chkBoxPlaceGate";
            this.chkBoxPlaceGate.Size = new System.Drawing.Size(115, 17);
            this.chkBoxPlaceGate.TabIndex = 29;
            this.chkBoxPlaceGate.Text = "Place gate on map";
            this.chkBoxPlaceGate.UseVisualStyleBackColor = true;
            // 
            // chkBoxSpinGate
            // 
            this.chkBoxSpinGate.AutoSize = true;
            this.chkBoxSpinGate.Location = new System.Drawing.Point(20, 10);
            this.chkBoxSpinGate.Name = "chkBoxSpinGate";
            this.chkBoxSpinGate.Size = new System.Drawing.Size(71, 17);
            this.chkBoxSpinGate.TabIndex = 28;
            this.chkBoxSpinGate.Text = "Spin gate";
            this.chkBoxSpinGate.UseVisualStyleBackColor = true;
            // 
            // lblReceivedParts
            // 
            this.lblReceivedParts.AutoSize = true;
            this.lblReceivedParts.Location = new System.Drawing.Point(630, 160);
            this.lblReceivedParts.Name = "lblReceivedParts";
            this.lblReceivedParts.Size = new System.Drawing.Size(34, 13);
            this.lblReceivedParts.TabIndex = 27;
            this.lblReceivedParts.Text = "Parts:";
            // 
            // nudGateDelay
            // 
            this.nudGateDelay.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudGateDelay.Location = new System.Drawing.Point(20, 84);
            this.nudGateDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudGateDelay.Name = "nudGateDelay";
            this.nudGateDelay.Size = new System.Drawing.Size(50, 20);
            this.nudGateDelay.TabIndex = 26;
            this.nudGateDelay.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblGateDelay
            // 
            this.lblGateDelay.AutoSize = true;
            this.lblGateDelay.Location = new System.Drawing.Point(70, 88);
            this.lblGateDelay.Name = "lblGateDelay";
            this.lblGateDelay.Size = new System.Drawing.Size(60, 13);
            this.lblGateDelay.TabIndex = 25;
            this.lblGateDelay.Text = "Speed (ms)";
            // 
            // lblSpinCost
            // 
            this.lblSpinCost.AutoSize = true;
            this.lblSpinCost.Location = new System.Drawing.Point(510, 73);
            this.lblSpinCost.Name = "lblSpinCost";
            this.lblSpinCost.Size = new System.Drawing.Size(54, 13);
            this.lblSpinCost.TabIndex = 24;
            this.lblSpinCost.Text = "Spin cost:";
            // 
            // lblReceivedNanoHull
            // 
            this.lblReceivedNanoHull.AutoSize = true;
            this.lblReceivedNanoHull.Location = new System.Drawing.Point(510, 292);
            this.lblReceivedNanoHull.Name = "lblReceivedNanoHull";
            this.lblReceivedNanoHull.Size = new System.Drawing.Size(55, 13);
            this.lblReceivedNanoHull.TabIndex = 23;
            this.lblReceivedNanoHull.Text = "Nano hull:";
            // 
            // lblReceivedXenomit
            // 
            this.lblReceivedXenomit.AutoSize = true;
            this.lblReceivedXenomit.Location = new System.Drawing.Point(630, 206);
            this.lblReceivedXenomit.Name = "lblReceivedXenomit";
            this.lblReceivedXenomit.Size = new System.Drawing.Size(48, 13);
            this.lblReceivedXenomit.TabIndex = 22;
            this.lblReceivedXenomit.Text = "Xenomit:";
            // 
            // lblReceivedRepairCredits
            // 
            this.lblReceivedRepairCredits.AutoSize = true;
            this.lblReceivedRepairCredits.Location = new System.Drawing.Point(630, 182);
            this.lblReceivedRepairCredits.Name = "lblReceivedRepairCredits";
            this.lblReceivedRepairCredits.Size = new System.Drawing.Size(75, 13);
            this.lblReceivedRepairCredits.TabIndex = 21;
            this.lblReceivedRepairCredits.Text = "Repair credits:";
            // 
            // lblReceivedLogDisks
            // 
            this.lblReceivedLogDisks.AutoSize = true;
            this.lblReceivedLogDisks.Location = new System.Drawing.Point(630, 137);
            this.lblReceivedLogDisks.Name = "lblReceivedLogDisks";
            this.lblReceivedLogDisks.Size = new System.Drawing.Size(55, 13);
            this.lblReceivedLogDisks.TabIndex = 20;
            this.lblReceivedLogDisks.Text = "Log disks:";
            // 
            // lblReceivedACM
            // 
            this.lblReceivedACM.AutoSize = true;
            this.lblReceivedACM.Location = new System.Drawing.Point(510, 273);
            this.lblReceivedACM.Name = "lblReceivedACM";
            this.lblReceivedACM.Size = new System.Drawing.Size(33, 13);
            this.lblReceivedACM.TabIndex = 19;
            this.lblReceivedACM.Text = "ACM:";
            // 
            // lblReceivedPLT2021
            // 
            this.lblReceivedPLT2021.AutoSize = true;
            this.lblReceivedPLT2021.Location = new System.Drawing.Point(510, 252);
            this.lblReceivedPLT2021.Name = "lblReceivedPLT2021";
            this.lblReceivedPLT2021.Size = new System.Drawing.Size(57, 13);
            this.lblReceivedPLT2021.TabIndex = 18;
            this.lblReceivedPLT2021.Text = "PLT-2021:";
            // 
            // lblReceivedSAB
            // 
            this.lblReceivedSAB.AutoSize = true;
            this.lblReceivedSAB.Location = new System.Drawing.Point(510, 229);
            this.lblReceivedSAB.Name = "lblReceivedSAB";
            this.lblReceivedSAB.Size = new System.Drawing.Size(31, 13);
            this.lblReceivedSAB.TabIndex = 17;
            this.lblReceivedSAB.Text = "SAB:";
            // 
            // lblReceivedX4
            // 
            this.lblReceivedX4.AutoSize = true;
            this.lblReceivedX4.Location = new System.Drawing.Point(510, 206);
            this.lblReceivedX4.Name = "lblReceivedX4";
            this.lblReceivedX4.Size = new System.Drawing.Size(23, 13);
            this.lblReceivedX4.TabIndex = 16;
            this.lblReceivedX4.Text = "X4:";
            // 
            // lblReceivedX3
            // 
            this.lblReceivedX3.AutoSize = true;
            this.lblReceivedX3.Location = new System.Drawing.Point(510, 183);
            this.lblReceivedX3.Name = "lblReceivedX3";
            this.lblReceivedX3.Size = new System.Drawing.Size(23, 13);
            this.lblReceivedX3.TabIndex = 15;
            this.lblReceivedX3.Text = "X3:";
            // 
            // lblReceivedX2
            // 
            this.lblReceivedX2.AutoSize = true;
            this.lblReceivedX2.Location = new System.Drawing.Point(510, 160);
            this.lblReceivedX2.Name = "lblReceivedX2";
            this.lblReceivedX2.Size = new System.Drawing.Size(23, 13);
            this.lblReceivedX2.TabIndex = 14;
            this.lblReceivedX2.Text = "X2:";
            // 
            // lblTotalSpins
            // 
            this.lblTotalSpins.AutoSize = true;
            this.lblTotalSpins.Location = new System.Drawing.Point(510, 137);
            this.lblTotalSpins.Name = "lblTotalSpins";
            this.lblTotalSpins.Size = new System.Drawing.Size(62, 13);
            this.lblTotalSpins.TabIndex = 13;
            this.lblTotalSpins.Text = "Spins used:";
            // 
            // lblExtraEnergy
            // 
            this.lblExtraEnergy.AutoSize = true;
            this.lblExtraEnergy.Location = new System.Drawing.Point(510, 54);
            this.lblExtraEnergy.Name = "lblExtraEnergy";
            this.lblExtraEnergy.Size = new System.Drawing.Size(70, 13);
            this.lblExtraEnergy.TabIndex = 12;
            this.lblExtraEnergy.Text = "Extra Energy:";
            // 
            // lblUridium
            // 
            this.lblUridium.AutoSize = true;
            this.lblUridium.Location = new System.Drawing.Point(510, 35);
            this.lblUridium.Name = "lblUridium";
            this.lblUridium.Size = new System.Drawing.Size(45, 13);
            this.lblUridium.TabIndex = 11;
            this.lblUridium.Text = "Uridium:";
            // 
            // dgvGates
            // 
            this.dgvGates.AllowUserToAddRows = false;
            this.dgvGates.AllowUserToDeleteRows = false;
            this.dgvGates.AllowUserToResizeColumns = false;
            this.dgvGates.AllowUserToResizeRows = false;
            this.dgvGates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGates.CausesValidation = false;
            this.dgvGates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnGateName,
            this.clmnGateParts,
            this.clmnGateReady,
            this.clmnGateOnMap,
            this.clmnGatesBuilt});
            this.dgvGates.Location = new System.Drawing.Point(148, 7);
            this.dgvGates.Name = "dgvGates";
            this.dgvGates.RowHeadersVisible = false;
            this.dgvGates.ShowCellErrors = false;
            this.dgvGates.ShowCellToolTips = false;
            this.dgvGates.ShowEditingIcon = false;
            this.dgvGates.ShowRowErrors = false;
            this.dgvGates.Size = new System.Drawing.Size(358, 348);
            this.dgvGates.TabIndex = 10;
            this.dgvGates.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // clmnGateName
            // 
            this.clmnGateName.Frozen = true;
            this.clmnGateName.HeaderText = "Name";
            this.clmnGateName.Name = "clmnGateName";
            this.clmnGateName.ReadOnly = true;
            this.clmnGateName.Width = 60;
            // 
            // clmnGateParts
            // 
            this.clmnGateParts.HeaderText = "Parts";
            this.clmnGateParts.Name = "clmnGateParts";
            this.clmnGateParts.ReadOnly = true;
            this.clmnGateParts.Width = 70;
            // 
            // clmnGateReady
            // 
            this.clmnGateReady.HeaderText = "Ready";
            this.clmnGateReady.Name = "clmnGateReady";
            this.clmnGateReady.ReadOnly = true;
            this.clmnGateReady.Width = 70;
            // 
            // clmnGateOnMap
            // 
            this.clmnGateOnMap.HeaderText = "On Map";
            this.clmnGateOnMap.Name = "clmnGateOnMap";
            this.clmnGateOnMap.ReadOnly = true;
            this.clmnGateOnMap.Width = 70;
            // 
            // clmnGatesBuilt
            // 
            this.clmnGatesBuilt.HeaderText = "Gates built";
            this.clmnGatesBuilt.Name = "clmnGatesBuilt";
            this.clmnGatesBuilt.ReadOnly = true;
            this.clmnGatesBuilt.Width = 85;
            // 
            // cmdResetGateStats
            // 
            this.cmdResetGateStats.Location = new System.Drawing.Point(513, 332);
            this.cmdResetGateStats.Name = "cmdResetGateStats";
            this.cmdResetGateStats.Size = new System.Drawing.Size(238, 23);
            this.cmdResetGateStats.TabIndex = 9;
            this.cmdResetGateStats.Text = "&Reset stats";
            this.cmdResetGateStats.UseVisualStyleBackColor = true;
            this.cmdResetGateStats.Click += new System.EventHandler(this.cmdResetGateStats_Click);
            // 
            // rbBuildKuiper
            // 
            this.rbBuildKuiper.AutoSize = true;
            this.rbBuildKuiper.Location = new System.Drawing.Point(20, 338);
            this.rbBuildKuiper.Name = "rbBuildKuiper";
            this.rbBuildKuiper.Size = new System.Drawing.Size(55, 17);
            this.rbBuildKuiper.TabIndex = 8;
            this.rbBuildKuiper.Text = "Kuiper";
            this.rbBuildKuiper.UseVisualStyleBackColor = true;
            // 
            // rbBuildHades
            // 
            this.rbBuildHades.AutoSize = true;
            this.rbBuildHades.Location = new System.Drawing.Point(20, 315);
            this.rbBuildHades.Name = "rbBuildHades";
            this.rbBuildHades.Size = new System.Drawing.Size(56, 17);
            this.rbBuildHades.TabIndex = 7;
            this.rbBuildHades.Text = "Hades";
            this.rbBuildHades.UseVisualStyleBackColor = true;
            // 
            // rbBuildKappa
            // 
            this.rbBuildKappa.AutoSize = true;
            this.rbBuildKappa.Location = new System.Drawing.Point(20, 269);
            this.rbBuildKappa.Name = "rbBuildKappa";
            this.rbBuildKappa.Size = new System.Drawing.Size(56, 17);
            this.rbBuildKappa.TabIndex = 6;
            this.rbBuildKappa.Text = "Kappa";
            this.rbBuildKappa.UseVisualStyleBackColor = true;
            // 
            // rbBuildLambda
            // 
            this.rbBuildLambda.AutoSize = true;
            this.rbBuildLambda.Location = new System.Drawing.Point(20, 292);
            this.rbBuildLambda.Name = "rbBuildLambda";
            this.rbBuildLambda.Size = new System.Drawing.Size(63, 17);
            this.rbBuildLambda.TabIndex = 5;
            this.rbBuildLambda.Text = "Lambda";
            this.rbBuildLambda.UseVisualStyleBackColor = true;
            // 
            // rbBuildZeta
            // 
            this.rbBuildZeta.AutoSize = true;
            this.rbBuildZeta.Location = new System.Drawing.Point(20, 246);
            this.rbBuildZeta.Name = "rbBuildZeta";
            this.rbBuildZeta.Size = new System.Drawing.Size(47, 17);
            this.rbBuildZeta.TabIndex = 4;
            this.rbBuildZeta.Text = "Zeta";
            this.rbBuildZeta.UseVisualStyleBackColor = true;
            // 
            // rbBuildEpsilon
            // 
            this.rbBuildEpsilon.AutoSize = true;
            this.rbBuildEpsilon.Location = new System.Drawing.Point(20, 223);
            this.rbBuildEpsilon.Name = "rbBuildEpsilon";
            this.rbBuildEpsilon.Size = new System.Drawing.Size(59, 17);
            this.rbBuildEpsilon.TabIndex = 3;
            this.rbBuildEpsilon.Text = "Epsilon";
            this.rbBuildEpsilon.UseVisualStyleBackColor = true;
            // 
            // rbBuildDelta
            // 
            this.rbBuildDelta.AutoSize = true;
            this.rbBuildDelta.Location = new System.Drawing.Point(20, 200);
            this.rbBuildDelta.Name = "rbBuildDelta";
            this.rbBuildDelta.Size = new System.Drawing.Size(50, 17);
            this.rbBuildDelta.TabIndex = 2;
            this.rbBuildDelta.Text = "Delta";
            this.rbBuildDelta.UseVisualStyleBackColor = true;
            // 
            // rbBuildABG
            // 
            this.rbBuildABG.AutoSize = true;
            this.rbBuildABG.Checked = true;
            this.rbBuildABG.Location = new System.Drawing.Point(20, 177);
            this.rbBuildABG.Name = "rbBuildABG";
            this.rbBuildABG.Size = new System.Drawing.Size(47, 17);
            this.rbBuildABG.TabIndex = 33;
            this.rbBuildABG.TabStop = true;
            this.rbBuildABG.Text = "ABG";
            this.rbBuildABG.UseVisualStyleBackColor = true;
            // 
            // tabPageTechFactory
            // 
            this.tabPageTechFactory.Controls.Add(this.nudCheckTechFactoryEvery);
            this.tabPageTechFactory.Controls.Add(this.lblCheckTechFactoryEvery);
            this.tabPageTechFactory.Controls.Add(this.chkBoxBuildTechs);
            this.tabPageTechFactory.Controls.Add(this.dgvTechFactory);
            this.tabPageTechFactory.Location = new System.Drawing.Point(4, 22);
            this.tabPageTechFactory.Name = "tabPageTechFactory";
            this.tabPageTechFactory.Size = new System.Drawing.Size(767, 360);
            this.tabPageTechFactory.TabIndex = 2;
            this.tabPageTechFactory.Text = "Tech Factory";
            this.tabPageTechFactory.UseVisualStyleBackColor = true;
            // 
            // nudCheckTechFactoryEvery
            // 
            this.nudCheckTechFactoryEvery.Location = new System.Drawing.Point(256, 9);
            this.nudCheckTechFactoryEvery.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.nudCheckTechFactoryEvery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCheckTechFactoryEvery.Name = "nudCheckTechFactoryEvery";
            this.nudCheckTechFactoryEvery.Size = new System.Drawing.Size(54, 20);
            this.nudCheckTechFactoryEvery.TabIndex = 3;
            this.nudCheckTechFactoryEvery.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblCheckTechFactoryEvery
            // 
            this.lblCheckTechFactoryEvery.AutoSize = true;
            this.lblCheckTechFactoryEvery.Location = new System.Drawing.Point(124, 11);
            this.lblCheckTechFactoryEvery.Name = "lblCheckTechFactoryEvery";
            this.lblCheckTechFactoryEvery.Size = new System.Drawing.Size(229, 13);
            this.lblCheckTechFactoryEvery.TabIndex = 4;
            this.lblCheckTechFactoryEvery.Text = "Check Tech Factory every                    minutes";
            // 
            // chkBoxBuildTechs
            // 
            this.chkBoxBuildTechs.AutoSize = true;
            this.chkBoxBuildTechs.Location = new System.Drawing.Point(20, 10);
            this.chkBoxBuildTechs.Name = "chkBoxBuildTechs";
            this.chkBoxBuildTechs.Size = new System.Drawing.Size(78, 17);
            this.chkBoxBuildTechs.TabIndex = 2;
            this.chkBoxBuildTechs.Text = "Build techs";
            this.chkBoxBuildTechs.UseVisualStyleBackColor = true;
            // 
            // dgvTechFactory
            // 
            this.dgvTechFactory.AllowUserToAddRows = false;
            this.dgvTechFactory.AllowUserToDeleteRows = false;
            this.dgvTechFactory.AllowUserToResizeColumns = false;
            this.dgvTechFactory.AllowUserToResizeRows = false;
            this.dgvTechFactory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTechFactory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechFactory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnTechName,
            this.clmnTechAmount,
            this.clmnTechBuilding,
            this.clmnTechTimeLeft,
            this.clmnTechBuild});
            this.dgvTechFactory.Location = new System.Drawing.Point(20, 33);
            this.dgvTechFactory.Name = "dgvTechFactory";
            this.dgvTechFactory.RowHeadersVisible = false;
            this.dgvTechFactory.ShowCellErrors = false;
            this.dgvTechFactory.ShowCellToolTips = false;
            this.dgvTechFactory.ShowEditingIcon = false;
            this.dgvTechFactory.ShowRowErrors = false;
            this.dgvTechFactory.Size = new System.Drawing.Size(443, 278);
            this.dgvTechFactory.TabIndex = 1;
            this.dgvTechFactory.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_CurrentCellDirtyStateChanged);
            this.dgvTechFactory.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // clmnTechName
            // 
            this.clmnTechName.HeaderText = "Tech";
            this.clmnTechName.Name = "clmnTechName";
            this.clmnTechName.ReadOnly = true;
            this.clmnTechName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnTechName.Width = 120;
            // 
            // clmnTechAmount
            // 
            this.clmnTechAmount.HeaderText = "Amount";
            this.clmnTechAmount.Name = "clmnTechAmount";
            this.clmnTechAmount.ReadOnly = true;
            this.clmnTechAmount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnTechAmount.Width = 70;
            // 
            // clmnTechBuilding
            // 
            this.clmnTechBuilding.HeaderText = "Building";
            this.clmnTechBuilding.Name = "clmnTechBuilding";
            this.clmnTechBuilding.ReadOnly = true;
            this.clmnTechBuilding.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechBuilding.Width = 80;
            // 
            // clmnTechTimeLeft
            // 
            this.clmnTechTimeLeft.HeaderText = "Time Left";
            this.clmnTechTimeLeft.Name = "clmnTechTimeLeft";
            this.clmnTechTimeLeft.ReadOnly = true;
            this.clmnTechTimeLeft.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechTimeLeft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmnTechBuild
            // 
            this.clmnTechBuild.HeaderText = "Build";
            this.clmnTechBuild.Name = "clmnTechBuild";
            this.clmnTechBuild.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnTechBuild.Width = 70;
            // 
            // tabPageSkylab
            // 
            this.tabPageSkylab.Controls.Add(this.nudCheckSkylabEvery);
            this.tabPageSkylab.Controls.Add(this.lblCheckSkylabEvery);
            this.tabPageSkylab.Controls.Add(this.chkBoxUpgradeSkylab);
            this.tabPageSkylab.Controls.Add(this.dgvSkylab);
            this.tabPageSkylab.Location = new System.Drawing.Point(4, 22);
            this.tabPageSkylab.Name = "tabPageSkylab";
            this.tabPageSkylab.Size = new System.Drawing.Size(767, 360);
            this.tabPageSkylab.TabIndex = 3;
            this.tabPageSkylab.Text = "Skylab";
            this.tabPageSkylab.UseVisualStyleBackColor = true;
            // 
            // nudCheckSkylabEvery
            // 
            this.nudCheckSkylabEvery.Location = new System.Drawing.Point(226, 9);
            this.nudCheckSkylabEvery.Maximum = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.nudCheckSkylabEvery.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCheckSkylabEvery.Name = "nudCheckSkylabEvery";
            this.nudCheckSkylabEvery.Size = new System.Drawing.Size(54, 20);
            this.nudCheckSkylabEvery.TabIndex = 5;
            this.nudCheckSkylabEvery.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblCheckSkylabEvery
            // 
            this.lblCheckSkylabEvery.AutoSize = true;
            this.lblCheckSkylabEvery.Location = new System.Drawing.Point(124, 11);
            this.lblCheckSkylabEvery.Name = "lblCheckSkylabEvery";
            this.lblCheckSkylabEvery.Size = new System.Drawing.Size(198, 13);
            this.lblCheckSkylabEvery.TabIndex = 6;
            this.lblCheckSkylabEvery.Text = "Check Skylab every                    minutes";
            // 
            // chkBoxUpgradeSkylab
            // 
            this.chkBoxUpgradeSkylab.AutoSize = true;
            this.chkBoxUpgradeSkylab.Location = new System.Drawing.Point(20, 10);
            this.chkBoxUpgradeSkylab.Name = "chkBoxUpgradeSkylab";
            this.chkBoxUpgradeSkylab.Size = new System.Drawing.Size(100, 17);
            this.chkBoxUpgradeSkylab.TabIndex = 3;
            this.chkBoxUpgradeSkylab.Text = "Upgrade skylab";
            this.chkBoxUpgradeSkylab.UseVisualStyleBackColor = true;
            // 
            // dgvSkylab
            // 
            this.dgvSkylab.AllowUserToAddRows = false;
            this.dgvSkylab.AllowUserToDeleteRows = false;
            this.dgvSkylab.AllowUserToResizeColumns = false;
            this.dgvSkylab.AllowUserToResizeRows = false;
            this.dgvSkylab.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSkylab.CausesValidation = false;
            this.dgvSkylab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkylab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnModuleName,
            this.clmnModuleLevel,
            this.clmnModuleUpgrading,
            this.clmnModuleTimeLeft,
            this.clmnModuleUpgrade});
            this.dgvSkylab.Location = new System.Drawing.Point(20, 33);
            this.dgvSkylab.Name = "dgvSkylab";
            this.dgvSkylab.RowHeadersVisible = false;
            this.dgvSkylab.ShowCellErrors = false;
            this.dgvSkylab.ShowCellToolTips = false;
            this.dgvSkylab.ShowEditingIcon = false;
            this.dgvSkylab.ShowRowErrors = false;
            this.dgvSkylab.Size = new System.Drawing.Size(543, 279);
            this.dgvSkylab.TabIndex = 0;
            this.dgvSkylab.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView_CurrentCellDirtyStateChanged);
            this.dgvSkylab.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // clmnModuleName
            // 
            this.clmnModuleName.HeaderText = "Module";
            this.clmnModuleName.Name = "clmnModuleName";
            this.clmnModuleName.ReadOnly = true;
            this.clmnModuleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnModuleName.Width = 200;
            // 
            // clmnModuleLevel
            // 
            this.clmnModuleLevel.HeaderText = "Level";
            this.clmnModuleLevel.Name = "clmnModuleLevel";
            this.clmnModuleLevel.ReadOnly = true;
            this.clmnModuleLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleLevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmnModuleLevel.Width = 70;
            // 
            // clmnModuleUpgrading
            // 
            this.clmnModuleUpgrading.HeaderText = "Upgrading";
            this.clmnModuleUpgrading.Name = "clmnModuleUpgrading";
            this.clmnModuleUpgrading.ReadOnly = true;
            this.clmnModuleUpgrading.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleUpgrading.Width = 80;
            // 
            // clmnModuleTimeLeft
            // 
            this.clmnModuleTimeLeft.HeaderText = "Time Left";
            this.clmnModuleTimeLeft.Name = "clmnModuleTimeLeft";
            this.clmnModuleTimeLeft.ReadOnly = true;
            this.clmnModuleTimeLeft.Width = 120;
            // 
            // clmnModuleUpgrade
            // 
            this.clmnModuleUpgrade.HeaderText = "Upgrade";
            this.clmnModuleUpgrade.Name = "clmnModuleUpgrade";
            this.clmnModuleUpgrade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmnModuleUpgrade.Width = 70;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.rtbLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(767, 360);
            this.tabPageLog.TabIndex = 5;
            this.tabPageLog.Text = "Debug";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            this.rtbLog.Location = new System.Drawing.Point(20, 6);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(728, 347);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(418, 12);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(499, 12);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdOpenBackPage
            // 
            this.cmdOpenBackPage.Location = new System.Drawing.Point(580, 12);
            this.cmdOpenBackPage.Name = "cmdOpenBackPage";
            this.cmdOpenBackPage.Size = new System.Drawing.Size(97, 23);
            this.cmdOpenBackPage.TabIndex = 3;
            this.cmdOpenBackPage.Text = "Open backpage";
            this.cmdOpenBackPage.UseVisualStyleBackColor = true;
            this.cmdOpenBackPage.Click += new System.EventHandler(this.cmdOpenBackPage_Click);
            // 
            // lblLastStatus
            // 
            this.lblLastStatus.AutoSize = true;
            this.lblLastStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastStatus.Location = new System.Drawing.Point(14, 15);
            this.lblLastStatus.Name = "lblLastStatus";
            this.lblLastStatus.Size = new System.Drawing.Size(71, 15);
            this.lblLastStatus.TabIndex = 4;
            this.lblLastStatus.Text = "Last status: ";
            // 
            // cmdSaveSettings
            // 
            this.cmdSaveSettings.Location = new System.Drawing.Point(683, 12);
            this.cmdSaveSettings.Name = "cmdSaveSettings";
            this.cmdSaveSettings.Size = new System.Drawing.Size(101, 23);
            this.cmdSaveSettings.TabIndex = 5;
            this.cmdSaveSettings.Text = "Save settings";
            this.cmdSaveSettings.UseVisualStyleBackColor = true;
            this.cmdSaveSettings.Click += new System.EventHandler(this.cmdSaveSettings_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 435);
            this.Controls.Add(this.cmdSaveSettings);
            this.Controls.Add(this.lblLastStatus);
            this.Controls.Add(this.cmdOpenBackPage);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.tcMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corvus - DarkOrbit Bot Helper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.tcMain.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.gBoxUsernamePasswordLogin.ResumeLayout(false);
            this.gBoxUsernamePasswordLogin.PerformLayout();
            this.gBoxSessionIDLogin.ResumeLayout(false);
            this.gBoxSessionIDLogin.PerformLayout();
            this.tabPageGalaxyGates.ResumeLayout(false);
            this.tabPageGalaxyGates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGateWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinimumUridium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGateDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGates)).EndInit();
            this.tabPageTechFactory.ResumeLayout(false);
            this.tabPageTechFactory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckTechFactoryEvery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechFactory)).EndInit();
            this.tabPageSkylab.ResumeLayout(false);
            this.tabPageSkylab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCheckSkylabEvery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkylab)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPageLogin;
        private System.Windows.Forms.GroupBox gBoxUsernamePasswordLogin;
        private System.Windows.Forms.GroupBox gBoxSessionIDLogin;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.Label lblSessionId;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.CheckBox chkBoxReconnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.RadioButton rbUsernamePasswordLogin;
        private System.Windows.Forms.RadioButton rbSessionIdLogin;
        private System.Windows.Forms.TabPage tabPageGalaxyGates;
        private System.Windows.Forms.TabPage tabPageTechFactory;
        private System.Windows.Forms.TabPage tabPageSkylab;
        private System.Windows.Forms.Label lblPortal;
        private System.Windows.Forms.ComboBox comboBoxLoginPortal;
        private System.Windows.Forms.DataGridView dgvSkylab;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.DataGridView dgvTechFactory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnModuleLevel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnModuleUpgrading;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnModuleTimeLeft;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnModuleUpgrade;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdOpenBackPage;
        private System.Windows.Forms.RadioButton rbBuildABG;
        private System.Windows.Forms.RadioButton rbBuildKuiper;
        private System.Windows.Forms.RadioButton rbBuildHades;
        private System.Windows.Forms.RadioButton rbBuildKappa;
        private System.Windows.Forms.RadioButton rbBuildLambda;
        private System.Windows.Forms.RadioButton rbBuildZeta;
        private System.Windows.Forms.RadioButton rbBuildEpsilon;
        private System.Windows.Forms.RadioButton rbBuildDelta;
        private System.Windows.Forms.Button cmdResetGateStats;
        private System.Windows.Forms.DataGridView dgvGates;
        private System.Windows.Forms.Label lblExtraEnergy;
        private System.Windows.Forms.Label lblUridium;
        private System.Windows.Forms.Label lblReceivedLogDisks;
        private System.Windows.Forms.Label lblReceivedACM;
        private System.Windows.Forms.Label lblReceivedPLT2021;
        private System.Windows.Forms.Label lblReceivedSAB;
        private System.Windows.Forms.Label lblReceivedX4;
        private System.Windows.Forms.Label lblReceivedX3;
        private System.Windows.Forms.Label lblReceivedX2;
        private System.Windows.Forms.Label lblTotalSpins;
        private System.Windows.Forms.Label lblSpinCost;
        private System.Windows.Forms.Label lblReceivedNanoHull;
        private System.Windows.Forms.Label lblReceivedXenomit;
        private System.Windows.Forms.Label lblReceivedRepairCredits;
        private System.Windows.Forms.NumericUpDown nudGateDelay;
        private System.Windows.Forms.Label lblGateDelay;
        private System.Windows.Forms.Label lblReceivedParts;
        private System.Windows.Forms.CheckBox chkBoxSpinGate;
        private System.Windows.Forms.CheckBox chkBoxPlaceGate;
        private System.Windows.Forms.NumericUpDown nudMinimumUridium;
        private System.Windows.Forms.Label lblMinimumUridium;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTechName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTechAmount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnTechBuilding;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTechTimeLeft;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnTechBuild;
        private System.Windows.Forms.CheckBox chkBoxBuildTechs;
        private System.Windows.Forms.CheckBox chkBoxUpgradeSkylab;
        private System.Windows.Forms.RichTextBox rtbLog;
        private CheckBox chkBoxSaveUsernamePassword;
        private Label lblLastStatus;
        private Button cmdSaveSettings;
        private NumericUpDown nudCheckTechFactoryEvery;
        private Label lblCheckTechFactoryEvery;
        private NumericUpDown nudCheckSkylabEvery;
        private Label lblCheckSkylabEvery;
        private CheckBox chkSpinOnlyEE;
        private Label statistics;
        private Label accountinfo;
        private Label gates;
        private ComboBox comboBoxEnergyCharge;
        private Label lblEnergyCharge;
        private DataGridViewTextBoxColumn clmnGateName;
        private DataGridViewTextBoxColumn clmnGateParts;
        private DataGridViewCheckBoxColumn clmnGateReady;
        private DataGridViewCheckBoxColumn clmnGateOnMap;
        private DataGridViewTextBoxColumn clmnGatesBuilt;
        private ComboBox comboBoxOptionABG;
        private Label lblWaitGate;
        private NumericUpDown nudGateWait;
        private NotifyIcon notifyIcon1;
    }
}

