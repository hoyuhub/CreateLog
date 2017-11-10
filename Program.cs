using System;
using log4net;
using log4net.Config;
using System.IO;
using System.Xml;
using log4net.Repository;
using System.Diagnostics;

namespace CreateLog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ILoggerRepository repository = LogManager.CreateRepository("NETCoreRepository");
            XmlConfigurator.Configure(repository, new FileInfo("log4net.config"));
            ILog log = LogManager.GetLogger(repository.Name, "NETCorelog4net");
            string[] strArr = new string[] { "urltest/test", "send", "test2", "user/login", "url/url", "urltest/test1", "send1", "test21", "user/login1", "url/url1", "urltest/test2", "send2", "test22", "user/login2", "url/url2" };
            int i = 0;
            while (true)
            {
                Random ran = new Random();
                int id = ran.Next(1, 30);
                string url = strArr[ran.Next(0, 14)];
                log.Info("GetJsonData(request/keyword)给定关键字不在字典中。");
                log.Info("test,内容填充");
                log.Info("test,内容填充");
                log.Info("test,内容填充");
                log.Debug("MobileAdapterApi.Controllers.BaseController - Request fa116561-5df2-4ce8-9af0-a0937437fa1e {\"sender\":\"mp.test\",\"token\":\"\",\"timestamp\":\"20171011004342\",\"request\":{\"pagesize\":null,\"uvcode\":null,\"phone\":\"phone_"+id.ToString()+"\",\"alias\":null,\"release2\":null,\"state\":null,\"areacode\":null,\"code\":null,\"level\":null,\"column7\":null,\"page\":null,\"address\":null,\"name\":null,\"release\":null,\"uvcid\":null,\"imgurl\":null,\"hospid\":\"hospid_" + id.ToString() + "\"}} " + url + "");
                i++;
            }

        }


    }
}
