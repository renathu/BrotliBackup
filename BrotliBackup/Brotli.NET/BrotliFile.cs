using Brotli;
using System;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace BrotliBackup.Brotli.NET
{
    public static class BrotliFile
    {
        public static void CompressFile(string source, string destination)
        {
            var files = Directory.GetFiles(source);

            Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = (Environment.ProcessorCount > 1 ? Environment.ProcessorCount - 1 : Environment.ProcessorCount) }, item =>
            {
                int array_length = (int)Math.Pow(2, 19);
                byte[] dataArray = new byte[array_length];
                string fileNameCompress = Path.Combine(destination, Path.GetFileName(item) + ".br");

                using (FileStream fsread = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, array_length))
                {
                    using (BinaryReader bwread = new BinaryReader(fsread))
                    {
                        using (var fswrite = new BrotliStream(File.Create(fileNameCompress, array_length), CompressionMode.Compress))
                        {
                            using (BinaryWriter bwwrite = new BinaryWriter(fswrite))
                            {
                                for (; ; )
                                {
                                    int read = bwread.Read(dataArray, 0, array_length);
                                    if (0 == read)
                                        break;
                                    bwwrite.Write(dataArray, 0, read);
                                }
                            }
                        }
                    }
                }
            });
        }

        public static void DecompressFile(string source, string destination)
        {
            var files = Directory.GetFiles(source);

            Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = (Environment.ProcessorCount > 1 ? Environment.ProcessorCount - 1 : Environment.ProcessorCount) }, item =>
            {
                int array_length = (int)Math.Pow(2, 19);
                byte[] dataArray = new byte[array_length];
                string fileNameDecompress = Path.Combine(destination, Path.GetFileNameWithoutExtension(item));

                using (var fsread = new BrotliStream(new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.Read, array_length), CompressionMode.Decompress))
                {
                    using (BinaryReader bwread = new BinaryReader(fsread))
                    {
                        using (FileStream fswrite = new FileStream(fileNameDecompress, FileMode.Create, FileAccess.Write, FileShare.None, array_length))
                        {
                            using (BinaryWriter bwwrite = new BinaryWriter(fswrite))
                            {
                                for (; ; )
                                {
                                    int read = bwread.Read(dataArray, 0, array_length);
                                    if (0 == read)
                                        break;
                                    bwwrite.Write(dataArray, 0, read);
                                }
                            }
                        }
                    }
                }
            });
        }
    }
}
