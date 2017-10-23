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
            while (i<100)
            {
                log.Info("GetJsonData(request/keyword)给定关键字不在字典中。");
                log.Info("2017-10-11 00:42:45,874 [7] DEBUG MobileAdapterApi.Controllers.BaseController - Request fa116561-5df2-4ce8-9af0-a0937437fa1e {\"sender\":\"mp.test\",\"token\":\"\",\"timestamp\":\"20171011004342\",\"request\":{\"pagesize\":null,\"uvcode\":null,\"phone\":null,\"alias\":null,\"release2\":null,\"state\":null,\"areacode\":null,\"code\":null,\"level\":null,\"column7\":null,\"page\":null,\"address\":null,\"name\":null,\"release\":null,\"uvcid\":null,\"imgurl\":null}} hos");
                i++;
            }

        }


    }
}
