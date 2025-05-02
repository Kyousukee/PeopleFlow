using System;
using System.Runtime.Loader;
using System.Reflection;

public class CustomAssemblyLoadContext : AssemblyLoadContext
{
    protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
    {
        string dllPath = Path.Combine(AppContext.BaseDirectory, "libwkhtmltox.dll"); // asegúrate de tenerlo aquí
        return LoadUnmanagedDllFromPath(dllPath);
    }

    protected override Assembly Load(AssemblyName assemblyName) => null;
}
