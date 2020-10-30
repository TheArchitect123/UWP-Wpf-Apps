using System.Collections.Generic;
using Windows.Storage;

namespace IMDBConsumer.Uwp.Services.Security
{
    public static class WindowsClientStorage
    {
        public static ApplicationDataContainer GetLocalSettingsContainer() => ApplicationData.Current.LocalSettings;

        public static void SaveSettingsToLocalContainer(KeyValuePair<string, string> item)
        {
            if (!GetLocalSettingsContainer().Values.TryAdd(item.Key, item.Value)) //If it fails to add a new key/value pair it means it exists already, simply run an override
                GetLocalSettingsContainer().Values[item.Key] = item.Value;
        }

        public static string GetSavedSettingsValueFromLocalContainer(string key)
        {
            object valueRetrieved = null;
            GetLocalSettingsContainer().Values.TryGetValue(key, out valueRetrieved);

            if (valueRetrieved != null)
                return valueRetrieved as string;
            else
                return null;
        }
    }
}
