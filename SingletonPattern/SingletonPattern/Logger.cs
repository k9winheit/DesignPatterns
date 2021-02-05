using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger logger;
        private Logger()
        {

        }

        //Provide one single object - Method 1
        //public static Logger GetInstance()
        //{
        //   return logger = (logger == null) ? new Logger() : logger;
        //}

        //Provide one single object - Method 2 getter
        public static Logger Instance
        {
            get{
               return logger = (logger == null) ? new Logger() : logger;
            }
        }
    }
}
