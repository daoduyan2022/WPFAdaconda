using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adaconda.Utils
{
    public class GcodeCompiler
    {
        public string[] G1(string[] lineCmd)
        {
            int numOfParam = 5;
            string[] result = new string[numOfParam];
            var llineCmd = lineCmd.ToList();
            for (int i = 0; i < llineCmd.Count; i++)
            {
                var s = llineCmd[i].Remove(0, 1);
                if (i == 1 && !llineCmd[1].Contains("X"))
                {
                    s = "-1";
                    llineCmd.Insert(i, "");
                }
                else if (i == 2 && !llineCmd[2].Contains("Y"))
                {
                    s = "-1";
                    llineCmd.Insert(i, "");

                }
                else if (i == 3 && !llineCmd[3].Contains("Z"))
                {
                    s = "-1";
                    llineCmd.Insert(i, "");

                }
                else if (i == 4 && !llineCmd[4].Contains("T"))
                {
                    s = "1";
                }
                result[i] = s;
            }
            return result;
        }   
        
        public string[] G2(string[] lineCmd)
        {
            int numOfParam = 3;

            string[] result = new string[numOfParam];
            var llineCmd = lineCmd.ToList();
            for (int i = 0; i < llineCmd.Count; i++)
            {
                var s = llineCmd[i].Remove(0, 1);
                if (i == 1 && !llineCmd[1].Contains("Z"))
                {
                    s = "-1";
                    llineCmd.Insert(i, "");
                }
                else if (i == 2 && !llineCmd[2].Contains("T"))
                {
                    s = "-1";
                }
                result[i] = s;
            }
            return result;

        }
        public string[] G3(string[] lineCmd)
        {
            int numOfParam = 3;

            string[] result = new string[numOfParam];
            var llineCmd = lineCmd.ToList();
            for (int i = 0; i < llineCmd.Count; i++)
            {
                var s = llineCmd[i].Remove(0, 1);
                if (i == 1 && !llineCmd[1].Contains("K"))
                {
                    s = "0";
                    llineCmd.Insert(i, "");
                }
                else if (i == 2 && !llineCmd[2].Contains("T"))
                {
                    s = "2000";
                }
                result[i] = s;
            }
            return result;

        }


        public string[] RemoveSpace(string[] arr)
        {
            string[] notSpace = new string[] { };   
            foreach(string e in arr)
            {
                if (!string.IsNullOrEmpty(e))
                {
                    notSpace = notSpace.Append(e).ToArray();

                }
            }
            return notSpace;
        }
        public ResultOfComplier ConvertTxtToPLC(string filePath)
        {
            
            ResultOfComplier resultOfComplier = new ResultOfComplier();
            string[] lines = File.ReadAllLines(filePath);
            int orderOfLine = 0;
            foreach (string line in lines)
            {
                orderOfLine++;
                var lineCut = line.Trim();
                string[] _line = lineCut.Split(' ');
                _line = this.RemoveSpace(_line);
                try
                {
                    if (lineCut.Contains("G"))
                    {

                        for (int code = 0; code < 256; code++)
                        {
                            var _code = Convert.ToInt32(_line[0].Remove(0, 1));

                            if (_code == code)
                            {
                                Type thisType = this.GetType();
                                var nameMethod = "G" + _code.ToString();
                                System.Reflection.MethodInfo theMethod = thisType.GetMethod(nameMethod);

                                var decode = theMethod.Invoke(this, new object[] { _line });
                                resultOfComplier.listDecode.Add((string[])decode);
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    resultOfComplier.listErrorCpl.Add(orderOfLine.ToString());
                }
                
            }
            return resultOfComplier;

        }
    }

    public class ResultOfComplier
    {
        public List<string[]> listDecode { get; set; }
        public List<string> listErrorCpl { get; set; }
        
        public ResultOfComplier()
        {
            listDecode = new List<string[]>();
            listErrorCpl = new List<string>();
        }
    }
}
