using System.Collections;
using System.Globalization;

namespace Infrastructure
{
    /// <summary>
    /// Provides convenient access to culture-specific resources at run time
    /// </summary>
    public class ResourceManager : System.Resources.ResourceManager
    {
        public ResourceManager()
        { }

        public ResourceManager(CultureInfo cultureInfo)
        {
            this.CultureInfo = cultureInfo;
        }

        public CultureInfo CultureInfo { get; set; }
    }
}