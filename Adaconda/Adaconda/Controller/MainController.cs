using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adaconda.Config;

namespace Adaconda.Controller
{
    
    public class MainController
    {
        public MainWindow mainWindow = null;
    

        public MainController(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void GetListModelName()
        {
            mainWindow._ListModelName.Clear();
            if (!File.Exists(Config.Config.ModelPath))
            {
                Directory.CreateDirectory(Config.Config.ModelPath);
            }
            List<string> listModelDirectory = Directory.GetDirectories(Config.Config.ModelPath).ToList();
            foreach(string name in listModelDirectory)
            {
                var _name = name.Split('\\')[name.Split('\\').Length - 1];
                mainWindow._ListModelName.Add(_name);
            }
            mainWindow._ListModelAvailable = mainWindow._ListModelName.ToList();

        }
    }
}
