using System;
using System.Threading;
using System.Threading.Tasks;

namespace TEZ_Project.Common.Data
{
    public static class ApplicationHelper
    {
        public static void DoEvents()
        {
            // Stub implementation for Application.DoEvents
            // In real WPF, this would process pending messages
            Thread.Sleep(1);
        }
    }
}
