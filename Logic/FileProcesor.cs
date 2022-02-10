using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileProcesor
    {
        public string Path { get; set; }

        public void LoadFile()
        {
            Console.WriteLine($"Načítání souboru z cesty:\n{Path}");
        }
        // Private - přístupné pouze v rámci třídy, Public - přístupný z celého Solution Inrternal - v rámci projektu
    }
}
