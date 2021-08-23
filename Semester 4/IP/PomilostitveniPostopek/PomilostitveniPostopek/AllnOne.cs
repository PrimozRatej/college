using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PomilostitveniPostopek
{
    public class AllnOne
    {
        public enum Ustanova { Sodišče = 1, Ministerstvo = 2, Tožilec = 3, Zaključena = 4};

        
        
        public void IncializirajProšnje()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            DirectoryInfo d = new DirectoryInfo(path + "\\Prošnje");//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            foreach (FileInfo file in Files)
            {
                Prošnja prošnja = new Prošnja(file.FullName) {Ime = file.Name};
                prošnja.posodobiStanje();
                Context.prošnje.Add(prošnja);
            }
        }


        

        
    }
}
