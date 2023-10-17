using System.Diagnostics;
using System.Windows.Forms;

namespace _0104SP
{

    public partial class Form1 : Form
    {
        Process[] processes = Process.GetProcesses();
        int selectedID = 0;

        public Form1()
        {
            InitializeComponent();
            processListView.Columns.Add("Process Name", 230, HorizontalAlignment.Center);
            processListView.Columns.Add("ID", 100, HorizontalAlignment.Center);
            processListView.Columns.Add("CPU Usage (%)", 150, HorizontalAlignment.Center);
            processListView.Columns.Add("Memory Usage (MB)", 200, HorizontalAlignment.Center);
            processListView.Columns.Add("Start Time", 100, HorizontalAlignment.Center);
            processListView.Columns.Add("Thread Count", 145, HorizontalAlignment.Center);
            processListView.Font = new Font(processListView.Font, FontStyle.Bold);

            update();

            startButton.Enabled = false;
            stopButton.Select();
        }

        public void update()
        {
            this.processListView.Items.Clear();

            this.timeLabel.Text = DateTime.Now.ToLongTimeString();
            processes = Process.GetProcesses();
            this.countLabel.Text = processes.Length.ToString();

            foreach (var process in processes)
            {
                ListViewItem item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());

                try { item.SubItems.Add(process.TotalProcessorTime.TotalSeconds.ToString("0.00")); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                try { item.SubItems.Add((process.WorkingSet64 / (1024 * 1024)).ToString("0.00")); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                try { item.SubItems.Add(process.StartTime.ToShortTimeString()); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                try { item.SubItems.Add(process.Threads.Count.ToString()); }
                catch (Exception) { item.SubItems.Add("N/A"); }

                processListView.Items.Add(item);

            }

            if (processListView.Items.Count > 0)
            {
                defineSelectedProcess();
            }
        }

        private void defineSelectedProcess()
        {
            for (int i = 0; i < processListView.Items.Count; i++)
            {
                if (processListView.Items[i].Selected == true)
                {
                    selectedID = i;

                    selectedProcessName.Text = processListView.Items[i].SubItems[0].Text;
                    selectedProcessID.Text = processListView.Items[i].SubItems[1].Text;
                    selectedProcessCpuUsage.Text = processListView.Items[i].SubItems[2].Text + (processListView.Items[i].SubItems[2].Text != "N/A" ? "%" : "");
                    selectedProcessMemoryUsage.Text = processListView.Items[i].SubItems[3].Text + "MB";
                    selectedProcessThreadCount.Text = processListView.Items[i].SubItems[5].Text;

                    try { selectedProcessFullStartTime.Text = processes[i].StartTime.ToShortDateString() + "   -   " + processes[i].StartTime.ToLongTimeString(); }
                    catch (Exception) { selectedProcessFullStartTime.Text = "N/A"; }

                    return;
                }
            }

            if (processListView.Items.Count > 0)
            {

                if (selectedID >= processListView.Items.Count)
                {
                    selectedID = processListView.Items.Count - 1;
                }

                processListView.Items[selectedID].Selected = true;
                defineSelectedProcess();
            }
            
        }

        private void timerTick(object sender, EventArgs e)
        {
            update();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.timer.Interval = Convert.ToInt16(numericUpDown1.Value) * 1000;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            programmState.Text = "stopped";
            programmState.ForeColor = Color.DarkRed;
            programmState.BackColor = Color.HotPink;

            stopButton.Enabled = false;
            startButton.Enabled = true;

            startButton.Select();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            programmState.Text = "running";
            programmState.ForeColor = Color.Blue;
            programmState.BackColor = Color.Aqua;

            timer.Stop();
            timer.Start();

            update();

            startButton.Enabled = false;
            stopButton.Enabled = true;

            stopButton.Select();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Are you sure to exit application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (q.Equals(DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void processListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            defineSelectedProcess();
        }

        private void closeProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                processes[selectedID].Kill();

                timer.Stop();
                timer.Start();

                update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error! (Closing Process)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}