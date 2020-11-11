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
            Queue<string> l = girls.Size > boys.Size ? girls : boys;
            string output = "";
            for (int i = 0; i < l.Size; i++)
            {
                output += string.Format("{0} и {1}\n", girls.Deque().Split(' ')[1], boys.Deque().Split(' ')[1]);
            }
            output += "В очереди " + l.Size;
            if (l.Size == girls.Size)
                output += " девочек. И первая из них — ";
            else
                output += " мальчиков. И первый из них — ";
            output += l.Front().Split(' ')[1];
            return output;
        }
    }
}
