using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WorkingExperience
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> monthEnds = new Dictionary<string, int>();
            monthEnds.Add("Jan", 31);
            monthEnds.Add("Feb", 28);
            monthEnds.Add("Mar", 31);
            monthEnds.Add("Apr", 30);
            monthEnds.Add("May", 31);
            monthEnds.Add("Jun", 30);
            monthEnds.Add("Jul", 31);
            monthEnds.Add("Aug", 31);
            monthEnds.Add("Sep", 30);
            monthEnds.Add("Oct", 31);
            monthEnds.Add("Nov", 30);
            monthEnds.Add("Dec", 31);
            Dictionary<string, int> monthD = new Dictionary<string, int>();
            monthD.Add("Jan", 1);
            monthD.Add("Feb", 2);
            monthD.Add("Mar", 3);
            monthD.Add("Apr", 4);
            monthD.Add("May", 5);
            monthD.Add("Jun", 6);
            monthD.Add("Jul", 7);
            monthD.Add("Aug", 8);
            monthD.Add("Sep", 9);
            monthD.Add("Oct", 10);
            monthD.Add("Nov", 11);
            monthD.Add("Dec", 12);
            using (StreamReader reader = File.OpenText(args[0]))
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        continue;
                    //Console.WriteLine(line);
                    string[] times = line.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
                    List<TimeFrame> timeFrames = new List<TimeFrame>();
                    for (int i = 0; i < times.Length; i++)
                    {
                        string[] dates = times[i].Split('-');
                        string[] beginDateElements = dates[0].Split(' ');
                        DateTime beginDate = new DateTime(Convert.ToInt32(beginDateElements[1]), monthD[beginDateElements[0]], 1);
                        string[] endDateElements = dates[1].Split(' ');
                        DateTime endDate;
                        if (DateTime.IsLeapYear(Convert.ToInt32(endDateElements[1])) && (monthD[endDateElements[0]] == 2))
                            endDate = new DateTime(Convert.ToInt32(endDateElements[1]), monthD[endDateElements[0]], 29, 23, 59, 59);
                        else
                            endDate = new DateTime(Convert.ToInt32(endDateElements[1]), monthD[endDateElements[0]], monthEnds[endDateElements[0]], 23, 59, 59);
                        timeFrames.Add(new TimeFrame(beginDate, endDate));
                    }
                    Console.WriteLine(process(timeFrames));
                }
            Console.ReadLine();
        }

        private static int process(List<TimeFrame> timeFrames)
        {
            TimeFrameComparer tfc = new TimeFrameComparer();
            timeFrames.Sort(tfc);
            int k = 0;
            do
            {
                // we know timeframes are sorted by begintime
                //   and then by endtime if begintime is equal
                // if k+1 begins after k ends increment k (don't do anything)
                if (timeFrames[k + 1].beginTime > timeFrames[k].endTime)
                    k++;
                // if k ends before or same as k+1
                // get rid of k+1
                else if (timeFrames[k].endTime >= timeFrames[k + 1].endTime)
                    timeFrames.RemoveAt(k + 1);
                // if k ends after k+1 begins merge them
                //   create new timeframe with k begin and k+1 end
                //   then get rid of k+1
                else if (timeFrames[k].endTime > timeFrames[k + 1].beginTime)
                {
                    timeFrames[k] = new TimeFrame(timeFrames[k].beginTime, timeFrames[k + 1].endTime);
                    timeFrames.RemoveAt(k + 1);
                }
            } while (k < (timeFrames.Count - 1));
            //TimeFrame[] timeFramesA = timeFrames.ToArray();
            TimeSpan[] spans = new TimeSpan[timeFrames.Count];
            for (int i = 0; i < spans.Length; i++)
            {
                //timeFramesA[i].endTime = timeFramesA[i].endTime.AddSeconds(1);
                //TimeFrame element = timeFrames[i];
                //element.endTime = element.endTime.AddSeconds(1);
                //timeFrames.RemoveAt(i);
                //timeFrames.Insert(i, element);
                //timeFrames[i].endTime = timeFrames[i].endTime.AddSeconds(1);
                spans[i] = timeFrames[i].endTime.AddSeconds(1) - timeFrames[i].beginTime;
            }
            int days = 0;
            for (int i = 0; i < spans.Length; i++)
            {
                days += spans[i].Days;
            }
            return days / 365;
        }
    }

    struct TimeFrame
    {
        public DateTime beginTime;
        public DateTime endTime;

        public TimeFrame(DateTime beginTime, DateTime endTime)
        {
            this.beginTime = beginTime;
            this.endTime = endTime;
        }
    }

    class TimeFrameComparer : IComparer<TimeFrame>
    {
        public int Compare(TimeFrame x, TimeFrame y)
        {
            const int ticsInASec = 10000000;
            long i = (x.beginTime.Ticks / ticsInASec) - (y.beginTime.Ticks / ticsInASec);
            if (i == 0)
                return (int)((x.endTime.Ticks / ticsInASec) - (y.endTime.Ticks / ticsInASec));
            else
                return (int)i;
        }
    }
}
