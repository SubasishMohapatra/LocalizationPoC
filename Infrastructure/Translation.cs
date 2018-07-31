using CommonServiceLocator;
using Infrastructure.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class Translation
    {
        //static ResourceManager resourceManager = null;
        public static string GetTranslatedText(string key)
        {
            var resourceManager = ServiceLocator.Current.GetInstance<ResourceManager>();
            var translatedText= Resources.ResourceManager.GetString(key, new CultureInfo(resourceManager.CultureInfo.Name));
            return translatedText;
        }
    }
}
