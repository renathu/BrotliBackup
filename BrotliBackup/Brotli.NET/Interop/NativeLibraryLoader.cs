using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace Brotli
{
    internal class NativeLibraryLoader
    {
        internal static bool IsWindows = true;

        static NativeLibraryLoader()
        {
          
        }

        // dlopen flags
        const int RtldLazy = 1;
        const int RtldGlobal = 8;

        readonly string _libraryPath;
        internal IntPtr Handle { get; private set; }

        internal NativeLibraryLoader(string libraryPath)
        {
            _libraryPath = libraryPath;
            Handle = LoadLibrary(_libraryPath, out var errorMsg);
            if (!String.IsNullOrEmpty(errorMsg))
            {
                throw new BrotliException($"unable to load library {libraryPath}");
            }
        }

        public static IntPtr GetWin32ModuleHandle(String moduleName)
        {
            IntPtr r = IntPtr.Zero;
            foreach (ProcessModule mod in Process.GetCurrentProcess().Modules)
            {
                if (mod.ModuleName == moduleName)
                {
                    r = mod.BaseAddress;
                    break;
                }
            }
            return r;
        }

        /// <summary>
        /// Loads method in the library
        /// </summary>
        /// <param name="symbolName">The methold of the library</param>
        /// <returns>method address</returns>
        private IntPtr LoadSymbol(string symbolName)
        {
            if (IsWindows)
            {
              return WindowsLoader.GetProcAddress(Handle, symbolName);
            }
            
            throw new InvalidOperationException("Unsupported platform.");
        }

        public void FillDelegate<T>(out T delegateType) where T : class
        {
            var typeName = typeof(T).Name;
            var kt = "Delegate";
            if (typeName.EndsWith(kt))
            {
                typeName = typeName.Substring(0, typeName.Length - kt.Length);
            }
            delegateType = GetNativeMethodDelegate<T>(typeName);
        }


        public T GetNativeMethodDelegate<T>(string methodName) where T : class
        {
            var ptr = LoadSymbol(methodName);
            if (ptr == IntPtr.Zero)
            {
                throw new MissingMethodException(string.Format("The native method \"{0}\" does not exist", methodName));
            }

            return Marshal.GetDelegateForFunctionPointer(ptr, typeof(T)) as T;  // generic version not available in .NET45
        }

        internal static string[] GetPossibleRuntimeDirectories()
        {
            var assemblyDirectory = Path.GetDirectoryName(typeof(LibPathBootStrapper).Assembly.Location);

            string[] paths = new[] { Path.Combine(Directory.GetParent(assemblyDirectory).FullName, "Arquivos comuns"), assemblyDirectory };
            
            return paths;
        }

        internal static bool FreeLibrary(IntPtr handle)
        {
            string errorMsg = null;
            if (IsWindows)
            {
                return WindowsLoader.FreeLibrary(handle);
            }
            
            throw new InvalidOperationException("Unsupported platform.");
        }

        /// <summary>
        /// Load library
        /// </summary>
        internal static IntPtr LoadLibrary(string libraryPath, out string errorMsg)
        {
            if (IsWindows)
            {
                errorMsg = null;
                //var handle = GetWin32ModuleHandle(libraryPath);
                //if (handle != IntPtr.Zero) return handle;
                var handle= WindowsLoader.LoadLibrary(libraryPath);
                if (handle== IntPtr.Zero)
                {
                    throw new System.ComponentModel.Win32Exception($"failed to load library {libraryPath}");
                }
                return handle;
            }
            
            throw new InvalidOperationException("Unsupported platform.");
        }

        static IntPtr LoadLibraryPosix(Func<string, int, IntPtr> dlopenFunc, Func<IntPtr> dlerrorFunc, string libraryPath, out string errorMsg)
        {
            errorMsg = null;
            IntPtr ret = dlopenFunc(libraryPath, RtldGlobal + RtldLazy);
            if (ret == IntPtr.Zero)
            {
                errorMsg = Marshal.PtrToStringAnsi(dlerrorFunc());
            }
            return ret;
        }

        static bool UnloadLibraryPosix(Func<IntPtr,int> dlcloseFunc, Func<IntPtr> dlerrorFunc, IntPtr handle,out string errorMsg)
        {
            errorMsg = null;
            var r = dlcloseFunc(handle);
            if (r!=0)
            {
                errorMsg= Marshal.PtrToStringAnsi(dlerrorFunc());
                return false;
            }
            return true;
        }
    }
}
