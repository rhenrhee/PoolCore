using System;

namespace CorePool.Mining
{
    public class PoolStartupAbortException : Exception
    {
        public PoolStartupAbortException(string msg) : base(msg)
        {
        }

        public PoolStartupAbortException()
        {
        }
    }
}
