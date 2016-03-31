using System;
using System.Runtime.InteropServices;
using Aimp4.Api;
using RGiesecke.DllExport;

namespace Aimp4
{
    public static class EntryPoint
    {
        [DllExport("AIMPPluginGetHeader", CallingConvention.StdCall)]
        public static IntPtr AIMPPluginGetHeader([MarshalAs(UnmanagedType.Interface)] out IAIMPPlugin header)
        {
            try
            {
                header = new SamplePluginClass();
                return IntPtr.Zero;
            }
            catch (Exception exception)
            {
                header = null;
                return (IntPtr) exception.HResult;
            }
        }
    }
}