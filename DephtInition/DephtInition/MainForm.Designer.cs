﻿namespace DephtInition
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointDephtGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dephtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.updShrinkTimes = new System.Windows.Forms.NumericUpDown();
            this.grpPreprocess = new System.Windows.Forms.GroupBox();
            this.grpProcess = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.updStackInterDistance = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.updMultiResSteps = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.updCurveReliabilityTreshold = new System.Windows.Forms.NumericUpDown();
            this.grpPostprocess = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.updSpikeFilterTreshold = new System.Windows.Forms.NumericUpDown();
            this.gaugeProgressBar1 = new DephtInition.GaugeProgressBar();
            this.menuStrip1.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updShrinkTimes)).BeginInit();
            this.grpPreprocess.SuspendLayout();
            this.grpProcess.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updStackInterDistance)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updMultiResSteps)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCurveReliabilityTreshold)).BeginInit();
            this.grpPostprocess.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSpikeFilterTreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnGo
            // 
            this.btnGo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGo.Location = new System.Drawing.Point(0, 0);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 27);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rGBToolStripMenuItem,
            this.contrastToolStripMenuItem,
            this.pointDephtGraphToolStripMenuItem,
            this.dephtToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // rGBToolStripMenuItem
            // 
            this.rGBToolStripMenuItem.Name = "rGBToolStripMenuItem";
            this.rGBToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.rGBToolStripMenuItem.Text = "RGB";
            this.rGBToolStripMenuItem.Click += new System.EventHandler(this.rGBToolStripMenuItem_Click);
            // 
            // contrastToolStripMenuItem
            // 
            this.contrastToolStripMenuItem.Name = "contrastToolStripMenuItem";
            this.contrastToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.contrastToolStripMenuItem.Text = "Contrast";
            this.contrastToolStripMenuItem.Click += new System.EventHandler(this.contrastToolStripMenuItem_Click);
            // 
            // pointDephtGraphToolStripMenuItem
            // 
            this.pointDephtGraphToolStripMenuItem.Name = "pointDephtGraphToolStripMenuItem";
            this.pointDephtGraphToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pointDephtGraphToolStripMenuItem.Text = "Point Depht Graph";
            this.pointDephtGraphToolStripMenuItem.Click += new System.EventHandler(this.pointDephtGraphToolStripMenuItem_Click);
            // 
            // dephtToolStripMenuItem
            // 
            this.dephtToolStripMenuItem.Name = "dephtToolStripMenuItem";
            this.dephtToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.dephtToolStripMenuItem.Text = "Depht";
            this.dephtToolStripMenuItem.Click += new System.EventHandler(this.dephtToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.gaugeProgressBar1);
            this.pnlBottom.Controls.Add(this.btnGo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 332);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(500, 27);
            this.pnlBottom.TabIndex = 3;
            // 
            // pnlOptions
            // 
            this.pnlOptions.Controls.Add(this.grpPostprocess);
            this.pnlOptions.Controls.Add(this.grpProcess);
            this.pnlOptions.Controls.Add(this.grpPreprocess);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOptions.Location = new System.Drawing.Point(0, 24);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Padding = new System.Windows.Forms.Padding(3);
            this.pnlOptions.Size = new System.Drawing.Size(500, 308);
            this.pnlOptions.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.updShrinkTimes);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(488, 30);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "shrink input image n times";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updShrinkTimes
            // 
            this.updShrinkTimes.Dock = System.Windows.Forms.DockStyle.Right;
            this.updShrinkTimes.Location = new System.Drawing.Point(421, 3);
            this.updShrinkTimes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updShrinkTimes.Name = "updShrinkTimes";
            this.updShrinkTimes.Size = new System.Drawing.Size(64, 20);
            this.updShrinkTimes.TabIndex = 8;
            this.updShrinkTimes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpPreprocess
            // 
            this.grpPreprocess.Controls.Add(this.panel5);
            this.grpPreprocess.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPreprocess.Location = new System.Drawing.Point(3, 3);
            this.grpPreprocess.Name = "grpPreprocess";
            this.grpPreprocess.Size = new System.Drawing.Size(494, 54);
            this.grpPreprocess.TabIndex = 5;
            this.grpPreprocess.TabStop = false;
            this.grpPreprocess.Text = "Pre process";
            // 
            // grpProcess
            // 
            this.grpProcess.Controls.Add(this.panel4);
            this.grpProcess.Controls.Add(this.panel3);
            this.grpProcess.Controls.Add(this.panel1);
            this.grpProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpProcess.Location = new System.Drawing.Point(3, 57);
            this.grpProcess.Name = "grpProcess";
            this.grpProcess.Size = new System.Drawing.Size(494, 122);
            this.grpProcess.TabIndex = 6;
            this.grpProcess.TabStop = false;
            this.grpProcess.Text = "Process";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.updStackInterDistance);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(488, 30);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "distance between pictures (mm)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updStackInterDistance
            // 
            this.updStackInterDistance.DecimalPlaces = 1;
            this.updStackInterDistance.Dock = System.Windows.Forms.DockStyle.Right;
            this.updStackInterDistance.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updStackInterDistance.Location = new System.Drawing.Point(421, 3);
            this.updStackInterDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updStackInterDistance.Name = "updStackInterDistance";
            this.updStackInterDistance.Size = new System.Drawing.Size(64, 20);
            this.updStackInterDistance.TabIndex = 4;
            this.updStackInterDistance.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.updMultiResSteps);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 46);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(488, 30);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "multiresolution steps (1-10)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updMultiResSteps
            // 
            this.updMultiResSteps.Dock = System.Windows.Forms.DockStyle.Right;
            this.updMultiResSteps.Location = new System.Drawing.Point(421, 3);
            this.updMultiResSteps.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updMultiResSteps.Name = "updMultiResSteps";
            this.updMultiResSteps.Size = new System.Drawing.Size(64, 20);
            this.updMultiResSteps.TabIndex = 8;
            this.updMultiResSteps.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.updCurveReliabilityTreshold);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 76);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(488, 30);
            this.panel4.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "curve raliability treshold (0.1-10)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updCurveReliabilityTreshold
            // 
            this.updCurveReliabilityTreshold.DecimalPlaces = 1;
            this.updCurveReliabilityTreshold.Dock = System.Windows.Forms.DockStyle.Right;
            this.updCurveReliabilityTreshold.Location = new System.Drawing.Point(421, 3);
            this.updCurveReliabilityTreshold.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updCurveReliabilityTreshold.Name = "updCurveReliabilityTreshold";
            this.updCurveReliabilityTreshold.Size = new System.Drawing.Size(64, 20);
            this.updCurveReliabilityTreshold.TabIndex = 8;
            this.updCurveReliabilityTreshold.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // grpPostprocess
            // 
            this.grpPostprocess.Controls.Add(this.panel2);
            this.grpPostprocess.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPostprocess.Location = new System.Drawing.Point(3, 179);
            this.grpPostprocess.Name = "grpPostprocess";
            this.grpPostprocess.Size = new System.Drawing.Size(494, 73);
            this.grpPostprocess.TabIndex = 7;
            this.grpPostprocess.TabStop = false;
            this.grpPostprocess.Text = "Post process";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.updSpikeFilterTreshold);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(488, 30);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "spikes filter treshold (0-100)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // updSpikeFilterTreshold
            // 
            this.updSpikeFilterTreshold.DecimalPlaces = 1;
            this.updSpikeFilterTreshold.Dock = System.Windows.Forms.DockStyle.Right;
            this.updSpikeFilterTreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.updSpikeFilterTreshold.Location = new System.Drawing.Point(421, 3);
            this.updSpikeFilterTreshold.Name = "updSpikeFilterTreshold";
            this.updSpikeFilterTreshold.Size = new System.Drawing.Size(64, 20);
            this.updSpikeFilterTreshold.TabIndex = 6;
            this.updSpikeFilterTreshold.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // gaugeProgressBar1
            // 
            this.gaugeProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeProgressBar1.Label = "waiting";
            this.gaugeProgressBar1.Location = new System.Drawing.Point(75, 0);
            this.gaugeProgressBar1.Name = "gaugeProgressBar1";
            this.gaugeProgressBar1.Size = new System.Drawing.Size(425, 27);
            this.gaugeProgressBar1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 359);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(270, 176);
            this.Name = "MainForm";
            this.Text = "DephtInition";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updShrinkTimes)).EndInit();
            this.grpPreprocess.ResumeLayout(false);
            this.grpProcess.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updStackInterDistance)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updMultiResSteps)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updCurveReliabilityTreshold)).EndInit();
            this.grpPostprocess.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updSpikeFilterTreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointDephtGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dephtToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DephtInition.GaugeProgressBar gaugeProgressBar1;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.GroupBox grpPostprocess;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updSpikeFilterTreshold;
        private System.Windows.Forms.GroupBox grpProcess;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown updCurveReliabilityTreshold;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updMultiResSteps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updStackInterDistance;
        private System.Windows.Forms.GroupBox grpPreprocess;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown updShrinkTimes;
    }
}

