using System;

namespace SKYNET
{
    public class ExceptionEventArgs : EventArgs
    {
        public ExceptionEventArgs(Exception ex)
        {
            this.Exception = ex;
        }

        public Exception Exception { get; set; }
    }
}