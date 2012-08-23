using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loudbit.WebHerdrNS
{
    /// <summary>
    /// This class is a data structure representing  a protocol/application combination. 
    /// It contains a list of urls specific to the application, and whether or not the 
    /// application should be considered the default for URLs not defined by an rules in 
    /// any application.
    /// </summary>
    public class ProtocolAppData
    {
        private String protocol;
        private String application;
        private List<String> urls;
        private Boolean isDefault;

        public ProtocolAppData()
        {
           
        }

        public ProtocolAppData(String protocol, String application)
        {
            this.protocol = protocol;
            this.application = application;
        }

        public String Protocol
        {
            get
            {
                return protocol;
            }
            set
            {
                protocol = value;
            }
        }

        public String Application
        {
            get
            {
                return application;
            }
            set
            {
                application = value;
            }
        }

        public Boolean IsDefault
        {
            get
            {
                return isDefault;
            }
            set
            {
                isDefault = value;
            }
        }

        public List<String> URLS
        {
            get
            {
                return urls;
            }
            set
            {
                urls = value;
            }
        }

        public void addURL(String URL)
        {
            urls.Add(URL);
        }

    }
}
