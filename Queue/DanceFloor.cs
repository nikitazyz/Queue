using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Queue
{
    class DanceFloor
    {
        Queue<string> girls = new Queue<string>();
        Queue<string> boys = new Queue<string>();

        public DanceFloor(string file)
        {
            using(StreamReader sr = new StreamReader(file))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if(line[0] == 'Д')
                    {
                        girls.Enque(line);
                    }
                    else
                    {
                        boys.Enque(line);
                    }
                }
            }
        }

        public string Dance()
        {
            int l = girls.Size > boys.Size ? girls.Size : boys.Size;
            string output = "";
            for (int i = 0; i < l; i++)
            {
                output += string.Format("{0} и {1}", girls.Deque., boys.Deque)
            }
        }
    }
}
