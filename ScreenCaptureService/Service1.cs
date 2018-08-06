using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ScreenCaptureService
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            CaptureScreen();
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = 30000;  //Read from configuration.
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            CaptureScreen();
        }

        protected override void OnStop()
        {
            // log service status
        }

        public void CaptureScreen()
        {
            // Write screen capture logic

        }
    }

    // InstallUtill.exe path of service and enter from cmd to install the service.
}
