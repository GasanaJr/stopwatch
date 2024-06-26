using System;
using System.Windows.Forms;
namespace StopWatch
{
    public partial class Form1 : Form
    {
        private StopwatchService stopwatchService;
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            stopwatchService = new StopwatchService();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = stopwatchService.Elapsed;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
