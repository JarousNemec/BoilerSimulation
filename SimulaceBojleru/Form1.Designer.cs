namespace SimulaceBojleru;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        _chboxHeater = new CheckBox();
        _tbarSprchaTemp = new TrackBar();
        _tbarSprchaFlow = new TrackBar();
        _tbarUmyvadloTemp = new TrackBar();
        _tbarUmyvadloFlow = new TrackBar();
        label1 = new Label();
        _lblTemp = new Label();
        label3 = new Label();
        _lblLevel = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        _tbarSpeed = new TrackBar();
        label2 = new Label();
        _lblSprchaTemp = new Label();
        _lblSprchaFlow = new Label();
        _lblUmyvadloTemp = new Label();
        _lblUmyvadloFlow = new Label();
        _lblControl = new Label();
        label9 = new Label();
        _lblHeater = new Label();
        label11 = new Label();
        _lblRunningTime = new Label();
        label12 = new Label();
        ((System.ComponentModel.ISupportInitialize)_tbarSprchaTemp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_tbarSprchaFlow).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_tbarUmyvadloTemp).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_tbarUmyvadloFlow).BeginInit();
        ((System.ComponentModel.ISupportInitialize)_tbarSpeed).BeginInit();
        SuspendLayout();
        // 
        // _chboxHeater
        // 
        _chboxHeater.AutoSize = true;
        _chboxHeater.Location = new Point(900, 266);
        _chboxHeater.Name = "_chboxHeater";
        _chboxHeater.Size = new Size(99, 19);
        _chboxHeater.TabIndex = 0;
        _chboxHeater.Text = "Bojler on / off";
        _chboxHeater.UseVisualStyleBackColor = true;
        _chboxHeater.CheckStateChanged += _chboxHeater_CheckStateChanged;
        // 
        // _tbarSprchaTemp
        // 
        _tbarSprchaTemp.Location = new Point(731, 96);
        _tbarSprchaTemp.Maximum = 100;
        _tbarSprchaTemp.Name = "_tbarSprchaTemp";
        _tbarSprchaTemp.Size = new Size(217, 45);
        _tbarSprchaTemp.TabIndex = 1;
        _tbarSprchaTemp.Value = 1;
        _tbarSprchaTemp.ValueChanged += _tbarSprchaTemp_ValueChanged;
        // 
        // _tbarSprchaFlow
        // 
        _tbarSprchaFlow.Location = new Point(731, 147);
        _tbarSprchaFlow.Maximum = 3000;
        _tbarSprchaFlow.Name = "_tbarSprchaFlow";
        _tbarSprchaFlow.Size = new Size(217, 45);
        _tbarSprchaFlow.TabIndex = 2;
        _tbarSprchaFlow.ValueChanged += _tbarSprchaFlow_ValueChanged;
        // 
        // _tbarUmyvadloTemp
        // 
        _tbarUmyvadloTemp.Location = new Point(1013, 96);
        _tbarUmyvadloTemp.Maximum = 100;
        _tbarUmyvadloTemp.Name = "_tbarUmyvadloTemp";
        _tbarUmyvadloTemp.Size = new Size(224, 45);
        _tbarUmyvadloTemp.TabIndex = 3;
        _tbarUmyvadloTemp.Value = 1;
        _tbarUmyvadloTemp.ValueChanged += _tbarUmyvadloTemp_ValueChanged;
        // 
        // _tbarUmyvadloFlow
        // 
        _tbarUmyvadloFlow.Location = new Point(1013, 147);
        _tbarUmyvadloFlow.Maximum = 1500;
        _tbarUmyvadloFlow.Name = "_tbarUmyvadloFlow";
        _tbarUmyvadloFlow.Size = new Size(224, 45);
        _tbarUmyvadloFlow.TabIndex = 4;
        _tbarUmyvadloFlow.ValueChanged += _tbarUmyvadloFlow_ValueChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(47, 34);
        label1.Name = "label1";
        label1.Size = new Size(48, 15);
        label1.TabIndex = 5;
        label1.Text = "Teplota:";
        // 
        // _lblTemp
        // 
        _lblTemp.AutoSize = true;
        _lblTemp.Location = new Point(101, 34);
        _lblTemp.Name = "_lblTemp";
        _lblTemp.Size = new Size(33, 15);
        _lblTemp.TabIndex = 6;
        _lblTemp.Text = "--- C";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(44, 49);
        label3.Name = "label3";
        label3.Size = new Size(51, 15);
        label3.TabIndex = 7;
        label3.Text = "Hladina:";
        // 
        // _lblLevel
        // 
        _lblLevel.AutoSize = true;
        _lblLevel.Location = new Point(101, 50);
        _lblLevel.Name = "_lblLevel";
        _lblLevel.Size = new Size(31, 15);
        _lblLevel.TabIndex = 8;
        _lblLevel.Text = "--- L";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(802, 65);
        label5.Name = "label5";
        label5.Size = new Size(91, 15);
        label5.TabIndex = 9;
        label5.Text = "Kohout ke sprše";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(1074, 65);
        label6.Name = "label6";
        label6.Size = new Size(111, 15);
        label6.TabIndex = 10;
        label6.Text = "Kohout k umyvadlu";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(621, 101);
        label7.Name = "label7";
        label7.Size = new Size(45, 15);
        label7.TabIndex = 11;
        label7.Text = "Teplota";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(621, 152);
        label8.Name = "label8";
        label8.Size = new Size(42, 15);
        label8.TabIndex = 12;
        label8.Text = "Průtok";
        // 
        // _tbarSpeed
        // 
        _tbarSpeed.Location = new Point(621, 417);
        _tbarSpeed.Maximum = 100;
        _tbarSpeed.Minimum = 1;
        _tbarSpeed.Name = "_tbarSpeed";
        _tbarSpeed.Size = new Size(616, 45);
        _tbarSpeed.TabIndex = 13;
        _tbarSpeed.Value = 1;
        _tbarSpeed.ValueChanged += _tbarSpeed_ValueChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(900, 371);
        label2.Name = "label2";
        label2.Size = new Size(98, 15);
        label2.TabIndex = 14;
        label2.Text = "Simulation speed";
        // 
        // _lblSprchaTemp
        // 
        _lblSprchaTemp.AutoSize = true;
        _lblSprchaTemp.Location = new Point(687, 101);
        _lblSprchaTemp.Name = "_lblSprchaTemp";
        _lblSprchaTemp.Size = new Size(22, 15);
        _lblSprchaTemp.TabIndex = 15;
        _lblSprchaTemp.Text = "---";
        // 
        // _lblSprchaFlow
        // 
        _lblSprchaFlow.AutoSize = true;
        _lblSprchaFlow.Location = new Point(687, 152);
        _lblSprchaFlow.Name = "_lblSprchaFlow";
        _lblSprchaFlow.Size = new Size(38, 15);
        _lblSprchaFlow.TabIndex = 16;
        _lblSprchaFlow.Text = "label4";
        // 
        // _lblUmyvadloTemp
        // 
        _lblUmyvadloTemp.AutoSize = true;
        _lblUmyvadloTemp.Location = new Point(969, 101);
        _lblUmyvadloTemp.Name = "_lblUmyvadloTemp";
        _lblUmyvadloTemp.Size = new Size(38, 15);
        _lblUmyvadloTemp.TabIndex = 17;
        _lblUmyvadloTemp.Text = "label4";
        // 
        // _lblUmyvadloFlow
        // 
        _lblUmyvadloFlow.AutoSize = true;
        _lblUmyvadloFlow.Location = new Point(969, 152);
        _lblUmyvadloFlow.Name = "_lblUmyvadloFlow";
        _lblUmyvadloFlow.Size = new Size(38, 15);
        _lblUmyvadloFlow.TabIndex = 18;
        _lblUmyvadloFlow.Text = "label4";
        // 
        // _lblControl
        // 
        _lblControl.AutoSize = true;
        _lblControl.Location = new Point(101, 65);
        _lblControl.Name = "_lblControl";
        _lblControl.Size = new Size(25, 15);
        _lblControl.TabIndex = 20;
        _lblControl.Text = "--- ";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Location = new Point(38, 65);
        label9.Name = "label9";
        label9.Size = new Size(57, 15);
        label9.TabIndex = 19;
        label9.Text = "Ovládání:";
        // 
        // _lblHeater
        // 
        _lblHeater.AutoSize = true;
        _lblHeater.Location = new Point(101, 80);
        _lblHeater.Name = "_lblHeater";
        _lblHeater.Size = new Size(25, 15);
        _lblHeater.TabIndex = 22;
        _lblHeater.Text = "--- ";
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Location = new Point(50, 80);
        label11.Name = "label11";
        label11.Size = new Size(45, 15);
        label11.TabIndex = 21;
        label11.Text = "Spirála:";
        // 
        // _lblRunningTime
        // 
        _lblRunningTime.AutoSize = true;
        _lblRunningTime.Location = new Point(101, 96);
        _lblRunningTime.Name = "_lblRunningTime";
        _lblRunningTime.Size = new Size(25, 15);
        _lblRunningTime.TabIndex = 24;
        _lblRunningTime.Text = "--- ";
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Location = new Point(16, 96);
        label12.Name = "label12";
        label12.Size = new Size(79, 15);
        label12.TabIndex = 23;
        label12.Text = "Čas simulace:";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1300, 502);
        Controls.Add(_lblRunningTime);
        Controls.Add(label12);
        Controls.Add(_lblHeater);
        Controls.Add(label11);
        Controls.Add(_lblControl);
        Controls.Add(label9);
        Controls.Add(_lblUmyvadloFlow);
        Controls.Add(_lblUmyvadloTemp);
        Controls.Add(_lblSprchaFlow);
        Controls.Add(_lblSprchaTemp);
        Controls.Add(label2);
        Controls.Add(_tbarSpeed);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(_lblLevel);
        Controls.Add(label3);
        Controls.Add(_lblTemp);
        Controls.Add(label1);
        Controls.Add(_tbarUmyvadloFlow);
        Controls.Add(_tbarUmyvadloTemp);
        Controls.Add(_tbarSprchaFlow);
        Controls.Add(_tbarSprchaTemp);
        Controls.Add(_chboxHeater);
        Name = "Form1";
        Text = "Form1";
        FormClosing += Form1_FormClosing;
        Load += Form1_Load;
        Paint += Form1_Paint;
        ((System.ComponentModel.ISupportInitialize)_tbarSprchaTemp).EndInit();
        ((System.ComponentModel.ISupportInitialize)_tbarSprchaFlow).EndInit();
        ((System.ComponentModel.ISupportInitialize)_tbarUmyvadloTemp).EndInit();
        ((System.ComponentModel.ISupportInitialize)_tbarUmyvadloFlow).EndInit();
        ((System.ComponentModel.ISupportInitialize)_tbarSpeed).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox _chboxHeater;
    private TrackBar _tbarSprchaTemp;
    private TrackBar _tbarSprchaFlow;
    private TrackBar _tbarUmyvadloTemp;
    private TrackBar _tbarUmyvadloFlow;
    private Label label1;
    private Label _lblTemp;
    private Label label3;
    private Label _lblLevel;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private TrackBar _tbarSpeed;
    private Label label2;
    private Label _lblSprchaTemp;
    private Label _lblSprchaFlow;
    private Label _lblUmyvadloTemp;
    private Label _lblUmyvadloFlow;
    private Label _lblControl;
    private Label label9;
    private Label _lblHeater;
    private Label label11;
    private Label _lblRunningTime;
    private Label label12;
}