using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;


namespace TPO.Quiz
{
    class TPODataCenter : IDisposable
    {
        static const int CachedTPONum = 5;

        private static TPODataCenter instance = null;
        
        private Thread singleThread;
        private ReaderWriterLock readWriteLock = new ReaderWriterLock();
        private static object syncLock = new object();
        private static object writeLock = new object();
        
        private ManualResetEvent endEvent;


        private LinkedList<TPOTest> cachedTests;


        protected TPODataCenter()
        {
            // do the initialization
            this.cachedTests = new LinkedList<TPOTest>();

            this.singleThread = new Thread(this.checkStatus);
            this.singleThread.Start();
        }

        public static TPODataCenter Instance()
        {
            if (instance == null)
            {
                lock (syncLock)
                {
                    if (instance == null)
                    {
                        instance = new TPODataCenter();
                    }
                }
            }
            return instance;
        }

        private void checkStatus()
        {
            for(;;)
            {
                Thread.Sleep(500);
                readWriteLock.AcquireWriterLock(0);

                readWriteLock.ReleaseWriterLock();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            this.Dispose(true);
        }

        //所有与回收相关的工作都由该方法完成
        private void Dispose(bool disposing)
        {
            lock (this) //避免产生线程错误。
            {
                if (disposing)
                {
                    //需要程序员完成释放对象占用的资源。
                    readWriteLock.AcquireWriterLock(0);
                    this.singleThread.Abort();
                    this.cachedTests.Clear();
                    readWriteLock.ReleaseWriterLock();
                }

                //对象将被垃圾回收器终结。在这里添加其它和清除对象相关的代码。
            }
        }
    }
}
