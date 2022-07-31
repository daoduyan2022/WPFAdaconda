using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adaconda.Config;
using System.Windows;
using Newtonsoft.Json;

namespace Adaconda.Model
{
    public class Model
    {
        public string ModelName { get; set; }
        public List<Point> listPoint { get; set; }

        public Coordinate targetPoint { get; set; }
        public Model(string modelName)
        {
            ModelName = modelName;
            listPoint = new List<Point>();
            listPoint.Add(new Point());
        }
        public int Save()
        {
            string savePath = $"{Config.Config.ModelPath}/{this.ModelName}";
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }
            string configPath = $"{Config.Config.ModelPath}/{this.ModelName}/{this.ModelName}.json";
            string js = JsonConvert.SerializeObject(this);
            File.WriteAllText(configPath, js);
            return 0;
        }

        public  static Model LoadModel(string modelName)
        {

            string path = $"{Config.Config.ModelPath}/{modelName}/{modelName}.json";
            Model model = null;
            if (File.Exists(path))
            {
                try
                {
                    var js = File.ReadAllText(path);
                    model = JsonConvert.DeserializeObject<Model>(js);
                    return model;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    return null;
                }
            }
            else
            {
                return model;

            }

        }

    }


    public class Point
    {
        public string name { get; set; }
        public Coordinate coordinate { get; set; }
        public Point()
        {
            name = "NO NAME";
            coordinate = new Coordinate();
        }
    }
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public int R { get; set; }
        public Coordinate()
        {
            X = 0; Y = 0; Z = 0; R = 0;
        }
    }
}
