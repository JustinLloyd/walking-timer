
namespace WalkingTimer
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonStartPauseToggle = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRemoveLap = new System.Windows.Forms.Button();
            this.buttonAddLap = new System.Windows.Forms.Button();
            this.labelLaps = new System.Windows.Forms.Label();
            this.buttonEndOfDay = new System.Windows.Forms.Button();
            this.labelEstimatedSteps = new System.Windows.Forms.Label();
            this.labelEstimatedDistance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelTotalElapsedTime = new System.Windows.Forms.Label();
            this.labelSessionElapsedTime = new System.Windows.Forms.Label();
            this.buttonEndSession = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEstimatedSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 771);
            this.listBox1.TabIndex = 0;
            // 
            // buttonStartPauseToggle
            // 
            this.buttonStartPauseToggle.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartPauseToggle.Location = new System.Drawing.Point(1554, 7);
            this.buttonStartPauseToggle.Name = "buttonStartPauseToggle";
            this.buttonStartPauseToggle.Size = new System.Drawing.Size(338, 120);
            this.buttonStartPauseToggle.TabIndex = 1;
            this.buttonStartPauseToggle.Text = "Start";
            this.buttonStartPauseToggle.UseVisualStyleBackColor = true;
            this.buttonStartPauseToggle.Click += new System.EventHandler(this.buttonStartPauseToggle_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(1554, 133);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(338, 120);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Clear";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRemoveLap
            // 
            this.buttonRemoveLap.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveLap.Location = new System.Drawing.Point(1554, 910);
            this.buttonRemoveLap.Name = "buttonRemoveLap";
            this.buttonRemoveLap.Size = new System.Drawing.Size(338, 120);
            this.buttonRemoveLap.TabIndex = 4;
            this.buttonRemoveLap.Text = "- Lap";
            this.buttonRemoveLap.UseVisualStyleBackColor = true;
            this.buttonRemoveLap.Click += new System.EventHandler(this.buttonRemoveLap_Click);
            // 
            // buttonAddLap
            // 
            this.buttonAddLap.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddLap.Location = new System.Drawing.Point(1554, 783);
            this.buttonAddLap.Name = "buttonAddLap";
            this.buttonAddLap.Size = new System.Drawing.Size(338, 120);
            this.buttonAddLap.TabIndex = 5;
            this.buttonAddLap.Text = "+ Lap";
            this.buttonAddLap.UseVisualStyleBackColor = true;
            this.buttonAddLap.Click += new System.EventHandler(this.buttonAddLap_Click);
            // 
            // labelLaps
            // 
            this.labelLaps.AutoSize = true;
            this.labelLaps.Font = new System.Drawing.Font("DSEG14 Classic Mini", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaps.Location = new System.Drawing.Point(1273, 896);
            this.labelLaps.Name = "labelLaps";
            this.labelLaps.Size = new System.Drawing.Size(275, 134);
            this.labelLaps.TabIndex = 11;
            this.labelLaps.Text = "00";
            this.labelLaps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonEndOfDay
            // 
            this.buttonEndOfDay.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndOfDay.Location = new System.Drawing.Point(1554, 552);
            this.buttonEndOfDay.Name = "buttonEndOfDay";
            this.buttonEndOfDay.Size = new System.Drawing.Size(338, 120);
            this.buttonEndOfDay.TabIndex = 17;
            this.buttonEndOfDay.Text = "End of Day";
            this.buttonEndOfDay.UseVisualStyleBackColor = true;
            this.buttonEndOfDay.Click += new System.EventHandler(this.buttonEndOfDay_Click);
            // 
            // labelEstimatedSteps
            // 
            this.labelEstimatedSteps.AutoSize = true;
            this.labelEstimatedSteps.Font = new System.Drawing.Font("DSEG14 Classic Mini", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstimatedSteps.Location = new System.Drawing.Point(665, 896);
            this.labelEstimatedSteps.Name = "labelEstimatedSteps";
            this.labelEstimatedSteps.Size = new System.Drawing.Size(602, 134);
            this.labelEstimatedSteps.TabIndex = 18;
            this.labelEstimatedSteps.Text = "00000";
            this.labelEstimatedSteps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEstimatedDistance
            // 
            this.labelEstimatedDistance.AutoSize = true;
            this.labelEstimatedDistance.Font = new System.Drawing.Font("DSEG14 Classic Mini", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstimatedDistance.Location = new System.Drawing.Point(293, 896);
            this.labelEstimatedDistance.Name = "labelEstimatedDistance";
            this.labelEstimatedDistance.Size = new System.Drawing.Size(384, 134);
            this.labelEstimatedDistance.TabIndex = 19;
            this.labelEstimatedDistance.Text = "0.00";
            this.labelEstimatedDistance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F);
            this.label7.Location = new System.Drawing.Point(293, 819);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 49);
            this.label7.TabIndex = 20;
            this.label7.Text = "Distance";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F);
            this.label8.Location = new System.Drawing.Point(688, 819);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(579, 49);
            this.label8.TabIndex = 21;
            this.label8.Text = "Steps";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F);
            this.label9.Location = new System.Drawing.Point(1296, 819);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 49);
            this.label9.TabIndex = 22;
            this.label9.Text = "Laps";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F);
            this.label10.Location = new System.Drawing.Point(230, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1318, 43);
            this.label10.TabIndex = 23;
            this.label10.Text = "Session Elapsed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F);
            this.label11.Location = new System.Drawing.Point(230, 469);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1318, 43);
            this.label11.TabIndex = 24;
            this.label11.Text = "Total Daily Elapsed Time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalElapsedTime
            // 
            this.labelTotalElapsedTime.Font = new System.Drawing.Font("DSEG14 Classic Mini", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalElapsedTime.Location = new System.Drawing.Point(230, 528);
            this.labelTotalElapsedTime.Name = "labelTotalElapsedTime";
            this.labelTotalElapsedTime.Size = new System.Drawing.Size(1310, 160);
            this.labelTotalElapsedTime.TabIndex = 25;
            this.labelTotalElapsedTime.Text = "00  :  00  :  00";
            this.labelTotalElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSessionElapsedTime
            // 
            this.labelSessionElapsedTime.Font = new System.Drawing.Font("DSEG14 Classic Mini", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionElapsedTime.Location = new System.Drawing.Point(230, 148);
            this.labelSessionElapsedTime.Name = "labelSessionElapsedTime";
            this.labelSessionElapsedTime.Size = new System.Drawing.Size(1318, 160);
            this.labelSessionElapsedTime.TabIndex = 6;
            this.labelSessionElapsedTime.Text = "00  :  00  :  00";
            this.labelSessionElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEndSession
            // 
            this.buttonEndSession.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndSession.Location = new System.Drawing.Point(1554, 259);
            this.buttonEndSession.Name = "buttonEndSession";
            this.buttonEndSession.Size = new System.Drawing.Size(338, 120);
            this.buttonEndSession.TabIndex = 26;
            this.buttonEndSession.Text = "Done";
            this.buttonEndSession.UseVisualStyleBackColor = true;
            this.buttonEndSession.Click += new System.EventHandler(this.buttonEndSession_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("DSEG14 Classic Mini", 32F);
            this.label2.Location = new System.Drawing.Point(12, 819);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 49);
            this.label2.TabIndex = 30;
            this.label2.Text = "Speed";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEstimatedSpeed
            // 
            this.labelEstimatedSpeed.AutoSize = true;
            this.labelEstimatedSpeed.Font = new System.Drawing.Font("DSEG14 Classic Mini", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstimatedSpeed.Location = new System.Drawing.Point(12, 896);
            this.labelEstimatedSpeed.Name = "labelEstimatedSpeed";
            this.labelEstimatedSpeed.Size = new System.Drawing.Size(275, 134);
            this.labelEstimatedSpeed.TabIndex = 29;
            this.labelEstimatedSpeed.Text = "0.0";
            this.labelEstimatedSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEstimatedSpeed);
            this.Controls.Add(this.buttonEndSession);
            this.Controls.Add(this.labelTotalElapsedTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelEstimatedDistance);
            this.Controls.Add(this.labelEstimatedSteps);
            this.Controls.Add(this.buttonEndOfDay);
            this.Controls.Add(this.labelLaps);
            this.Controls.Add(this.labelSessionElapsedTime);
            this.Controls.Add(this.buttonAddLap);
            this.Controls.Add(this.buttonRemoveLap);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonStartPauseToggle);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walking Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonStartPauseToggle;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRemoveLap;
        private System.Windows.Forms.Button buttonAddLap;
        private System.Windows.Forms.Label labelLaps;
        private System.Windows.Forms.Button buttonEndOfDay;
        private System.Windows.Forms.Label labelEstimatedSteps;
        private System.Windows.Forms.Label labelEstimatedDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelTotalElapsedTime;
        private System.Windows.Forms.Label labelSessionElapsedTime;
        private System.Windows.Forms.Button buttonEndSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEstimatedSpeed;
    }
}

