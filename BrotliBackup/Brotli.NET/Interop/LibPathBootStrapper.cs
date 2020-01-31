using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Brotli
{
    internal class LibPathBootStrapper
    {
        internal static string LibPath { get; private set; }

        static LibPathBootStrapper()
        {
            string fileName = null;
            if (NativeLibraryLoader.IsWindows)
            {
                fileName = "brolib_x86.dll";
            }
            
            if (string.IsNullOrEmpty(fileName)) throw new NotSupportedException($"OS not supported:{Environment.OSVersion.ToString()}");
            var paths = NativeLibraryLoader.GetPossibleRuntimeDirectories();
            var libFound = false;
            foreach (var path in paths)
            {
                var fullPath = Path.Combine(path, fileName);
                if (System.IO.File.Exists(fullPath))
                {
                    LibPath = fullPath;
                    libFound = true;
                    break;
                }
            }

            if (!libFound) throw new NotSupportedException($"Unable to find library {fileName}");
        }
    }
}
