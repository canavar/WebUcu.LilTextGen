using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebUcu.LilTextGen
{
    class ConfigurationHelper
    {
        public string TemplateExtension { get; private set; }
        public string TemplateRootFolder { get; private set; }
        Configuration configuration;

        public ConfigurationHelper()
        {
            string pluginAssemblyPath = Assembly.GetExecutingAssembly().Location;
            configuration = ConfigurationManager.OpenExeConfiguration(pluginAssemblyPath);

            CheckConfigurationSettings();

            TemplateExtension = configuration.AppSettings.Settings["TemplateExtension"].Value;
            TemplateRootFolder = configuration.AppSettings.Settings["TemplateRootFolder"].Value;
        }

        private void CheckConfigurationSettings()
        {
            if (configuration.AppSettings.Settings["TemplateExtension"] == null)
            {
                throw new ConfigurationException("Can not find TemplateExtension key in configuration file.");
            }

            if (configuration.AppSettings.Settings["TemplateExtension"].Value.Trim() == string.Empty)
            {
                throw new ConfigurationException("Invalid TemplateExtension value.");
            }

            if (configuration.AppSettings.Settings["TemplateRootFolder"] == null)
            {
                throw new ConfigurationException("Can not find TemplateRootFolder key in configuration file.");
            }

            if (configuration.AppSettings.Settings["TemplateRootFolder"].Value.Trim() == string.Empty)
            {
                throw new ConfigurationException("Invalid TemplateRootFolder value.");
            }
        }
    }
}
