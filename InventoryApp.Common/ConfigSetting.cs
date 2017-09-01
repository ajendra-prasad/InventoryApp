using System.Configuration;

namespace InventoryApp.Common
{
    public static class ConfigSetting
    {
        public static string DBConnectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
    }
}
