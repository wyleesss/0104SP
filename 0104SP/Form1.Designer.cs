using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _0104SP
{
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
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            processListView = new ListView();
            label3 = new Label();
            countLabel = new Label();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            stopButton = new Button();
            startButton = new Button();
            label8 = new Label();
            programmState = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            exitButton = new Button();
            label7 = new Label();
            button6 = new Button();
            button7 = new Button();
            selectedProcessName = new Label();
            button8 = new Button();
            label9 = new Label();
            button111 = new Button();
            button9 = new Button();
            selectedProcessID = new Label();
            label10 = new Label();
            selectedProcessCpuUsage = new Label();
            button10 = new Button();
            label11 = new Label();
            selectedProcessMemoryUsage = new Label();
            button11 = new Button();
            label2 = new Label();
            selectedProcessThreadCount = new Label();
            button12 = new Button();
            label12 = new Label();
            selectedProcessFullStartTime = new Label();
            closeProcessButton = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BackColor = Color.White;
            timeLabel.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            timeLabel.Location = new Point(981, 77);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(98, 26);
            timeLabel.TabIndex = 2;
            timeLabel.Text = "00:00:00";
            timeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 20000;
            timer.Tick += timerTick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(996, 57);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "data for:";
            // 
            // processListView
            // 
            processListView.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            processListView.Location = new Point(5, 5);
            processListView.Name = "processListView";
            processListView.Size = new Size(950, 588);
            processListView.TabIndex = 5;
            processListView.UseCompatibleStateImageBehavior = false;
            processListView.View = View.Details;
            processListView.SelectedIndexChanged += processListView_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(1097, 57);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 6;
            label3.Text = "process count:";
            // 
            // countLabel
            // 
            countLabel.BackColor = Color.White;
            countLabel.Font = new Font("Yu Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            countLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            countLabel.Location = new Point(1097, 77);
            countLabel.Name = "countLabel";
            countLabel.RightToLeft = RightToLeft.Yes;
            countLabel.Size = new Size(107, 26);
            countLabel.TabIndex = 8;
            countLabel.Text = "     0     ";
            countLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(986, 117);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 9;
            label6.Text = "update for:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.White;
            numericUpDown1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(998, 143);
            numericUpDown1.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(60, 34);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(995, 177);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 12;
            label5.Text = "seconds";
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.LightGray;
            stopButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stopButton.Location = new Point(973, 214);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(111, 46);
            stopButton.TabIndex = 13;
            stopButton.Text = "STOP";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.LightGray;
            startButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(1095, 214);
            startButton.Name = "startButton";
            startButton.Size = new Size(111, 46);
            startButton.TabIndex = 14;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(1096, 117);
            label8.Name = "label8";
            label8.Size = new Size(109, 20);
            label8.TabIndex = 15;
            label8.Text = "program state:";
            // 
            // programmState
            // 
            programmState.BackColor = Color.Aqua;
            programmState.Font = new Font("Yu Gothic UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            programmState.ForeColor = Color.Blue;
            programmState.Location = new Point(1102, 146);
            programmState.Name = "programmState";
            programmState.Size = new Size(100, 46);
            programmState.TabIndex = 17;
            programmState.Text = "running";
            programmState.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Enabled = false;
            button1.Location = new Point(966, 49);
            button1.Name = "button1";
            button1.Size = new Size(125, 64);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Enabled = false;
            button2.Location = new Point(1089, 49);
            button2.Name = "button2";
            button2.Size = new Size(125, 64);
            button2.TabIndex = 19;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Enabled = false;
            button3.Location = new Point(966, 111);
            button3.Name = "button3";
            button3.Size = new Size(125, 98);
            button3.TabIndex = 20;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Enabled = false;
            button4.Location = new Point(1089, 111);
            button4.Name = "button4";
            button4.Size = new Size(125, 98);
            button4.TabIndex = 21;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Enabled = false;
            button5.Location = new Point(1097, 141);
            button5.Name = "button5";
            button5.Size = new Size(110, 56);
            button5.TabIndex = 22;
            button5.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlDark;
            label4.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(1009, 12);
            label4.Name = "label4";
            label4.Size = new Size(168, 31);
            label4.TabIndex = 23;
            label4.Text = "Info / Settings:";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.LightCoral;
            exitButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(966, 265);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(248, 38);
            exitButton.TabIndex = 24;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ControlLight;
            label7.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(996, 317);
            label7.Name = "label7";
            label7.Size = new Size(193, 33);
            label7.TabIndex = 25;
            label7.Text = "Selected Process:";
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlDark;
            button6.Enabled = false;
            button6.Location = new Point(958, 5);
            button6.Name = "button6";
            button6.Size = new Size(267, 308);
            button6.TabIndex = 26;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLight;
            button7.Enabled = false;
            button7.Location = new Point(958, 313);
            button7.Name = "button7";
            button7.Size = new Size(267, 280);
            button7.TabIndex = 27;
            button7.UseVisualStyleBackColor = false;
            // 
            // selectedProcessName
            // 
            selectedProcessName.BackColor = Color.White;
            selectedProcessName.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProcessName.Location = new Point(970, 356);
            selectedProcessName.Name = "selectedProcessName";
            selectedProcessName.Size = new Size(240, 29);
            selectedProcessName.TabIndex = 28;
            selectedProcessName.Text = "Name";
            selectedProcessName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Enabled = false;
            button8.Location = new Point(966, 349);
            button8.Name = "button8";
            button8.Size = new Size(248, 42);
            button8.TabIndex = 30;
            button8.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.BackColor = Color.White;
            label9.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(973, 396);
            label9.Name = "label9";
            label9.Size = new Size(110, 19);
            label9.TabIndex = 31;
            label9.Text = "ID:";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button111
            // 
            button111.BackColor = Color.White;
            button111.Enabled = false;
            button111.Location = new Point(966, 389);
            button111.Name = "button111";
            button111.Size = new Size(125, 51);
            button111.TabIndex = 32;
            button111.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Enabled = false;
            button9.Location = new Point(1089, 389);
            button9.Name = "button9";
            button9.Size = new Size(125, 51);
            button9.TabIndex = 33;
            button9.UseVisualStyleBackColor = false;
            // 
            // selectedProcessID
            // 
            selectedProcessID.BackColor = Color.White;
            selectedProcessID.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProcessID.Location = new Point(973, 411);
            selectedProcessID.Name = "selectedProcessID";
            selectedProcessID.Size = new Size(111, 18);
            selectedProcessID.TabIndex = 35;
            selectedProcessID.Text = "000000";
            selectedProcessID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(1095, 396);
            label10.Name = "label10";
            label10.Size = new Size(115, 19);
            label10.TabIndex = 36;
            label10.Text = "CPU Usage:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectedProcessCpuUsage
            // 
            selectedProcessCpuUsage.BackColor = Color.White;
            selectedProcessCpuUsage.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProcessCpuUsage.Location = new Point(1096, 411);
            selectedProcessCpuUsage.Name = "selectedProcessCpuUsage";
            selectedProcessCpuUsage.Size = new Size(111, 18);
            selectedProcessCpuUsage.TabIndex = 37;
            selectedProcessCpuUsage.Text = "0,00%";
            selectedProcessCpuUsage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button10
            // 
            button10.BackColor = Color.White;
            button10.Enabled = false;
            button10.Location = new Point(966, 438);
            button10.Name = "button10";
            button10.Size = new Size(125, 51);
            button10.TabIndex = 38;
            button10.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(970, 443);
            label11.Name = "label11";
            label11.Size = new Size(117, 19);
            label11.TabIndex = 39;
            label11.Text = "Memory Usage:";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectedProcessMemoryUsage
            // 
            selectedProcessMemoryUsage.BackColor = Color.White;
            selectedProcessMemoryUsage.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProcessMemoryUsage.Location = new Point(973, 462);
            selectedProcessMemoryUsage.Name = "selectedProcessMemoryUsage";
            selectedProcessMemoryUsage.Size = new Size(111, 18);
            selectedProcessMemoryUsage.TabIndex = 40;
            selectedProcessMemoryUsage.Text = "0,00MB";
            selectedProcessMemoryUsage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Enabled = false;
            button11.Location = new Point(1089, 438);
            button11.Name = "button11";
            button11.Size = new Size(125, 51);
            button11.TabIndex = 41;
            button11.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = Color.White;
            label2.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(1093, 443);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 42;
            label2.Text = "Thread Count:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectedProcessThreadCount
            // 
            selectedProcessThreadCount.BackColor = Color.White;
            selectedProcessThreadCount.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProcessThreadCount.Location = new Point(1096, 462);
            selectedProcessThreadCount.Name = "selectedProcessThreadCount";
            selectedProcessThreadCount.Size = new Size(111, 18);
            selectedProcessThreadCount.TabIndex = 43;
            selectedProcessThreadCount.Text = "0";
            selectedProcessThreadCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Enabled = false;
            button12.Location = new Point(966, 487);
            button12.Name = "button12";
            button12.Size = new Size(248, 51);
            button12.TabIndex = 44;
            button12.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(1032, 492);
            label12.Name = "label12";
            label12.Size = new Size(117, 19);
            label12.TabIndex = 45;
            label12.Text = "Full Start Time:";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // selectedProcessFullStartTime
            // 
            selectedProcessFullStartTime.BackColor = Color.White;
            selectedProcessFullStartTime.Font = new Font("Yu Gothic UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            selectedProcessFullStartTime.Location = new Point(973, 511);
            selectedProcessFullStartTime.Name = "selectedProcessFullStartTime";
            selectedProcessFullStartTime.Size = new Size(237, 18);
            selectedProcessFullStartTime.TabIndex = 46;
            selectedProcessFullStartTime.Text = "00/00/00  -  00:00:00";
            selectedProcessFullStartTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeProcessButton
            // 
            closeProcessButton.BackColor = Color.LightCoral;
            closeProcessButton.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeProcessButton.Location = new Point(966, 536);
            closeProcessButton.Name = "closeProcessButton";
            closeProcessButton.Size = new Size(248, 49);
            closeProcessButton.TabIndex = 47;
            closeProcessButton.Text = "CLOSE PROCESS";
            closeProcessButton.UseVisualStyleBackColor = false;
            closeProcessButton.Click += closeProcessButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 598);
            Controls.Add(closeProcessButton);
            Controls.Add(selectedProcessFullStartTime);
            Controls.Add(label12);
            Controls.Add(button12);
            Controls.Add(label2);
            Controls.Add(selectedProcessThreadCount);
            Controls.Add(button11);
            Controls.Add(label11);
            Controls.Add(selectedProcessMemoryUsage);
            Controls.Add(button10);
            Controls.Add(label10);
            Controls.Add(selectedProcessCpuUsage);
            Controls.Add(label9);
            Controls.Add(selectedProcessID);
            Controls.Add(button111);
            Controls.Add(button9);
            Controls.Add(label7);
            Controls.Add(selectedProcessName);
            Controls.Add(exitButton);
            Controls.Add(label4);
            Controls.Add(programmState);
            Controls.Add(button5);
            Controls.Add(label8);
            Controls.Add(startButton);
            Controls.Add(stopButton);
            Controls.Add(numericUpDown1);
            Controls.Add(countLabel);
            Controls.Add(label1);
            Controls.Add(timeLabel);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(processListView);
            MaximizeBox = false;
            MinimumSize = new Size(1248, 610);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Systems Programming";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private Label selectedProcessCpuUsage;
        private ListView processListView;
        private Label label3;
        private Label countLabel;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private Button stopButton;
        private Button startButton;
        private Label label8;
        private Label programmState;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private Button exitButton;
        private Label label7;
        private Button button6;
        private Button button7;
        private Label selectedProcessName;
        private Button button8;
        private Label label9;
        private Button button111;
        private Button button9;
        private Label selectedProcessID;
        private Label label10;
        private Button button10;
        private Label label11;
        private Label selectedProcessMemoryUsage;
        private Button button11;
        private Label label2;
        private Label selectedProcessThreadCount;
        private Button button12;
        private Label label12;
        private Label selectedProcessFullStartTime;
        private Button closeProcessButton;
    }
}