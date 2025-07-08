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

namespace System.Windows
{
    public static class Application
    {
        public static void DoEvents()
        {
            // Stub implementation for Application.DoEvents
            // In real WPF, this would process pending messages
            Thread.Sleep(1);
        }
    }
}
