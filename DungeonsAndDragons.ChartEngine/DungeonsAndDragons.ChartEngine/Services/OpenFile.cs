using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DungeonsAndDragons.ChartEngine.Services
{
    public class OpenFile
    {
        public List<string> GetDataFile(string MonetaryChartData = @"Resources\MonetaryChartData.txt")
        {
            List<string> MonetaryChartDataList = new List<string>();
            using (StreamReader sR = new StreamReader(MonetaryChartData))
            {
                while (!sR.EndOfStream)
                {
                    MonetaryChartDataList.Add(sR.ReadLine());
                }
            }
            return MonetaryChartDataList;
        }//todo So I know this is used to read the textfile. But we made some changes and I want to know - is this the basic formula for writing a stream reader? Should I memorize it?
        //There are a number of different ways to input a text doc. Memorizing it isn't a bad idea, but you dont have to. Google is a programmer's best friend.  

    }
}
