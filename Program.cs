using System;
using log4net;
using log4net.Config;
using System.IO;
using System.Xml;
using log4net.Repository;

namespace CreateLog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
            ILog log = LogManager.GetLogger(repository.Name, "NETCorelog4net");

            int i = 0;
            while (i < 100000)
            {
                log.Info("GetJsonData(request/keyword)给定关键字不在字典中。");
                i++;
            }

        }


    }
}
