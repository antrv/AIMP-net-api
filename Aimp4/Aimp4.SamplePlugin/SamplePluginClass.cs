using System.Runtime.InteropServices;
using Aimp4.Api;

namespace Aimp4.SamplePlugin
{
    [Guid("635F3A94-643F-4849-B2B8-6D8A5AE49603")]
    public class SamplePluginClass: IAIMPPlugin
    {
        public string InfoGet(AIMPPluginInfo info)
        {
            switch (info)
            {
                case AIMPPluginInfo.Author:
                    return "Anton Ryzhov";
                case AIMPPluginInfo.Name:
                    return "Sample .NET plugin";
                case AIMPPluginInfo.ShortDescription:
                    return "Sample .NET plugin descr";
                case AIMPPluginInfo.FullDescription:
                    return "Sample .NET plugin description";
                default:
                    return string.Empty;
            }
        }

        public AIMPPluginCategories InfoGetCategories()
        {
            return AIMPPluginCategories.None;
        }

        public void Initialize(IAIMPCore core)
        {
        }

        public void FinalizePlugin()
        {
        }

        public void SystemNotification(AIMPSystemNotification notification, object data)
        {
        }
    }
}