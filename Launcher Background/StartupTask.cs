﻿using MakerDen;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;


// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace Launcher_Background
{
    public sealed class StartupTask : IBackgroundTask {
        BackgroundTaskDeferral _deferral;
        MakerDen.Experiments md = new MakerDen.Experiments();
     
        public void Run(IBackgroundTaskInstance taskInstance) {
            _deferral = taskInstance.GetDeferral();

            Task.Run(() => md.Main()).Wait();
        }
    }
}
