using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using Topshelf;

namespace TopShellDemo1
{
    public class TownCrier2 : ServiceControl
    {
        private Timer _timer = null;
        readonly ILog _log = LogManager.GetLogger(typeof(TownCrier2));
        public TownCrier2()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => _log.Info(DateTime.Now);

        }
        public bool Start(HostControl hostControl)
        {
            _log.Info("TopshelfDemo is Started");
            _timer.Start();
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            throw new NotImplementedException();
        }
    }
}
