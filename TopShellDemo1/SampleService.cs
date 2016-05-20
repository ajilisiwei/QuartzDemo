using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TopShellDemo1
{
    public class SampleService
    {
        private Timer _timer = null;
        readonly ILog _log = LogManager.GetLogger(typeof(SampleService));

        public SampleService()
        {
            double interval = 5000;
            _timer = new Timer(interval);
            _timer.Elapsed += new ElapsedEventHandler(OnTick);
        }

        protected virtual void OnTick(object sender, ElapsedEventArgs e)
        {
            _log.Debug("Tick:" + DateTime.Now.ToLongTimeString());
        }

        public void Start()
        {
            _log.Info("SampleService is Started");

            _timer.AutoReset = true;
            _timer.Enabled = true;
            _timer.Start();
        }

        public void Stop()
        {
            _log.Info("SampleService is Stopped");

            _timer.AutoReset = false;
            _timer.Enabled = false;
        }
    }
}
