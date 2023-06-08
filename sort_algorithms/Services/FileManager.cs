using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_algorithms.Services
{
    public static class FileManager
    {
        public static void Write(string filePath, string conteudo)
        {
            if (!File.Exists(filePath))
            {
                using (var writer = File.CreateText(filePath))
                {
                    writer.Write(conteudo);
                }
            }
            else
            {
                using (var writer = File.AppendText(filePath))
                {
                    writer.Write(conteudo);
                }
            }
        }
    }
}
