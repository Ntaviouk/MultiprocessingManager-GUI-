namespace yt_DesignUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxA = new yt_DesignUI.EgoldsGoogleTextBox();
            this.textBoxB = new yt_DesignUI.EgoldsGoogleTextBox();
            this.textBoxSteps = new yt_DesignUI.EgoldsGoogleTextBox();
            this.buttonStart = new yt_DesignUI.yt_Button();
            this.comboBoxCountProcesses = new System.Windows.Forms.ComboBox();
            this.groupBoxTaylorRow = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonResumeProcess = new yt_DesignUI.yt_Button();
            this.buttonPauseProcess = new yt_DesignUI.yt_Button();
            this.buttonKillProcess = new yt_DesignUI.yt_Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBoxMultiprocessingManager = new System.Windows.Forms.GroupBox();
            this.groupBoxTaylorRow.SuspendLayout();
            this.groupBoxMultiprocessingManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.White;
            this.textBoxA.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBoxA.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxA.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxA.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxA.ForeColor = System.Drawing.Color.Black;
            this.textBoxA.Location = new System.Drawing.Point(10, 19);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.SelectionStart = 0;
            this.textBoxA.Size = new System.Drawing.Size(150, 40);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.TextInput = "";
            this.textBoxA.TextPreview = "A";
            this.textBoxA.UseSystemPasswordChar = false;
            // 
            // textBoxB
            // 
            this.textBoxB.BackColor = System.Drawing.Color.White;
            this.textBoxB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBoxB.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxB.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxB.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxB.ForeColor = System.Drawing.Color.Black;
            this.textBoxB.Location = new System.Drawing.Point(10, 65);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.SelectionStart = 0;
            this.textBoxB.Size = new System.Drawing.Size(150, 40);
            this.textBoxB.TabIndex = 1;
            this.textBoxB.TextInput = "";
            this.textBoxB.TextPreview = "B";
            this.textBoxB.UseSystemPasswordChar = false;
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.BackColor = System.Drawing.Color.White;
            this.textBoxSteps.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBoxSteps.BorderColorNotActive = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.textBoxSteps.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSteps.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxSteps.FontTextPreview = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.textBoxSteps.ForeColor = System.Drawing.Color.Black;
            this.textBoxSteps.Location = new System.Drawing.Point(10, 107);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.SelectionStart = 0;
            this.textBoxSteps.Size = new System.Drawing.Size(150, 40);
            this.textBoxSteps.TabIndex = 2;
            this.textBoxSteps.TextInput = "";
            this.textBoxSteps.TextPreview = "Steps";
            this.textBoxSteps.UseSystemPasswordChar = false;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonStart.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonStart.BackColorGradientEnabled = true;
            this.buttonStart.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttonStart.BorderColor = System.Drawing.Color.DimGray;
            this.buttonStart.BorderColorEnabled = true;
            this.buttonStart.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonStart.BorderColorOnHoverEnabled = false;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(10, 153);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RippleColor = System.Drawing.Color.Black;
            this.buttonStart.Rounding = 40;
            this.buttonStart.RoundingEnable = true;
            this.buttonStart.Size = new System.Drawing.Size(86, 27);
            this.buttonStart.TabIndex = 25;
            this.buttonStart.Text = "Start";
            this.buttonStart.TextHover = null;
            this.buttonStart.UseDownPressEffectOnClick = true;
            this.buttonStart.UseRippleEffect = true;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.UseZoomEffectOnHover = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxCountProcesses
            // 
            this.comboBoxCountProcesses.Font = new System.Drawing.Font("Arial", 11.25F);
            this.comboBoxCountProcesses.FormattingEnabled = true;
            this.comboBoxCountProcesses.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "8"});
            this.comboBoxCountProcesses.Location = new System.Drawing.Point(102, 153);
            this.comboBoxCountProcesses.Name = "comboBoxCountProcesses";
            this.comboBoxCountProcesses.Size = new System.Drawing.Size(58, 25);
            this.comboBoxCountProcesses.TabIndex = 26;
            // 
            // groupBoxTaylorRow
            // 
            this.groupBoxTaylorRow.Controls.Add(this.comboBoxCountProcesses);
            this.groupBoxTaylorRow.Controls.Add(this.buttonStart);
            this.groupBoxTaylorRow.Controls.Add(this.textBoxSteps);
            this.groupBoxTaylorRow.Controls.Add(this.textBoxB);
            this.groupBoxTaylorRow.Controls.Add(this.textBoxA);
            this.groupBoxTaylorRow.Font = new System.Drawing.Font("Arial", 11.25F);
            this.groupBoxTaylorRow.Location = new System.Drawing.Point(47, 22);
            this.groupBoxTaylorRow.Name = "groupBoxTaylorRow";
            this.groupBoxTaylorRow.Size = new System.Drawing.Size(184, 206);
            this.groupBoxTaylorRow.TabIndex = 27;
            this.groupBoxTaylorRow.TabStop = false;
            this.groupBoxTaylorRow.Text = "Taylor Row";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 25);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // buttonResumeProcess
            // 
            this.buttonResumeProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonResumeProcess.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonResumeProcess.BackColorGradientEnabled = true;
            this.buttonResumeProcess.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttonResumeProcess.BorderColor = System.Drawing.Color.DimGray;
            this.buttonResumeProcess.BorderColorEnabled = true;
            this.buttonResumeProcess.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonResumeProcess.BorderColorOnHoverEnabled = false;
            this.buttonResumeProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResumeProcess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResumeProcess.ForeColor = System.Drawing.Color.White;
            this.buttonResumeProcess.Location = new System.Drawing.Point(85, 61);
            this.buttonResumeProcess.Name = "buttonResumeProcess";
            this.buttonResumeProcess.RippleColor = System.Drawing.Color.Black;
            this.buttonResumeProcess.Rounding = 40;
            this.buttonResumeProcess.RoundingEnable = true;
            this.buttonResumeProcess.Size = new System.Drawing.Size(61, 27);
            this.buttonResumeProcess.TabIndex = 27;
            this.buttonResumeProcess.Text = "Resume";
            this.buttonResumeProcess.TextHover = null;
            this.buttonResumeProcess.UseDownPressEffectOnClick = true;
            this.buttonResumeProcess.UseRippleEffect = true;
            this.buttonResumeProcess.UseVisualStyleBackColor = false;
            this.buttonResumeProcess.UseZoomEffectOnHover = true;
            this.buttonResumeProcess.Click += new System.EventHandler(this.buttonResumeProcess_Click);
            // 
            // buttonPauseProcess
            // 
            this.buttonPauseProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPauseProcess.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPauseProcess.BackColorGradientEnabled = true;
            this.buttonPauseProcess.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttonPauseProcess.BorderColor = System.Drawing.Color.DimGray;
            this.buttonPauseProcess.BorderColorEnabled = true;
            this.buttonPauseProcess.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonPauseProcess.BorderColorOnHoverEnabled = false;
            this.buttonPauseProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPauseProcess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPauseProcess.ForeColor = System.Drawing.Color.White;
            this.buttonPauseProcess.Location = new System.Drawing.Point(18, 61);
            this.buttonPauseProcess.Name = "buttonPauseProcess";
            this.buttonPauseProcess.RippleColor = System.Drawing.Color.Black;
            this.buttonPauseProcess.Rounding = 40;
            this.buttonPauseProcess.RoundingEnable = true;
            this.buttonPauseProcess.Size = new System.Drawing.Size(61, 27);
            this.buttonPauseProcess.TabIndex = 28;
            this.buttonPauseProcess.Text = "Pause";
            this.buttonPauseProcess.TextHover = null;
            this.buttonPauseProcess.UseDownPressEffectOnClick = true;
            this.buttonPauseProcess.UseRippleEffect = true;
            this.buttonPauseProcess.UseVisualStyleBackColor = false;
            this.buttonPauseProcess.UseZoomEffectOnHover = true;
            this.buttonPauseProcess.Click += new System.EventHandler(this.buttonPauseProcess_Click);
            // 
            // buttonKillProcess
            // 
            this.buttonKillProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonKillProcess.BackColorAdditional = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonKillProcess.BackColorGradientEnabled = true;
            this.buttonKillProcess.BackColorGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.buttonKillProcess.BorderColor = System.Drawing.Color.DimGray;
            this.buttonKillProcess.BorderColorEnabled = true;
            this.buttonKillProcess.BorderColorOnHover = System.Drawing.Color.Tomato;
            this.buttonKillProcess.BorderColorOnHoverEnabled = false;
            this.buttonKillProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKillProcess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKillProcess.ForeColor = System.Drawing.Color.White;
            this.buttonKillProcess.Location = new System.Drawing.Point(152, 61);
            this.buttonKillProcess.Name = "buttonKillProcess";
            this.buttonKillProcess.RippleColor = System.Drawing.Color.Black;
            this.buttonKillProcess.Rounding = 40;
            this.buttonKillProcess.RoundingEnable = true;
            this.buttonKillProcess.Size = new System.Drawing.Size(61, 27);
            this.buttonKillProcess.TabIndex = 29;
            this.buttonKillProcess.Text = "Stop";
            this.buttonKillProcess.TextHover = null;
            this.buttonKillProcess.UseDownPressEffectOnClick = true;
            this.buttonKillProcess.UseRippleEffect = true;
            this.buttonKillProcess.UseVisualStyleBackColor = false;
            this.buttonKillProcess.UseZoomEffectOnHover = true;
            this.buttonKillProcess.Click += new System.EventHandler(this.buttonKillProcess_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 11.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "High",
            "Idle",
            "Normal"});
            this.comboBox2.Location = new System.Drawing.Point(130, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(83, 25);
            this.comboBox2.TabIndex = 30;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBoxMultiprocessingManager
            // 
            this.groupBoxMultiprocessingManager.Controls.Add(this.comboBox2);
            this.groupBoxMultiprocessingManager.Controls.Add(this.buttonKillProcess);
            this.groupBoxMultiprocessingManager.Controls.Add(this.buttonPauseProcess);
            this.groupBoxMultiprocessingManager.Controls.Add(this.buttonResumeProcess);
            this.groupBoxMultiprocessingManager.Controls.Add(this.comboBox1);
            this.groupBoxMultiprocessingManager.Font = new System.Drawing.Font("Arial", 11.25F);
            this.groupBoxMultiprocessingManager.Location = new System.Drawing.Point(12, 31);
            this.groupBoxMultiprocessingManager.Name = "groupBoxMultiprocessingManager";
            this.groupBoxMultiprocessingManager.Size = new System.Drawing.Size(231, 106);
            this.groupBoxMultiprocessingManager.TabIndex = 31;
            this.groupBoxMultiprocessingManager.TabStop = false;
            this.groupBoxMultiprocessingManager.Text = "MultiprocessingManager";
            this.groupBoxMultiprocessingManager.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 269);
            this.Controls.Add(this.groupBoxMultiprocessingManager);
            this.Controls.Add(this.groupBoxTaylorRow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxTaylorRow.ResumeLayout(false);
            this.groupBoxMultiprocessingManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private EgoldsGoogleTextBox textBoxA;
        private EgoldsGoogleTextBox textBoxB;
        private EgoldsGoogleTextBox textBoxSteps;
        private yt_Button buttonStart;
        private System.Windows.Forms.ComboBox comboBoxCountProcesses;
        private System.Windows.Forms.GroupBox groupBoxTaylorRow;
        private System.Windows.Forms.ComboBox comboBox1;
        private yt_Button buttonResumeProcess;
        private yt_Button buttonPauseProcess;
        private yt_Button buttonKillProcess;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBoxMultiprocessingManager;
    }
}