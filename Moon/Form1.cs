using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Http;
using System.Windows.Forms.DataVisualization.Charting;

namespace Moon
{
    public partial class Form1 : Form
    {
        public HashSet<DateTime> sunriseHash = new HashSet<DateTime>();
        public HashSet<DateTime> sunsetHash = new HashSet<DateTime>();
        public HashSet<DateTime> moonriseHash = new HashSet<DateTime>();
        public HashSet<DateTime> moonsetHash = new HashSet<DateTime>();



        public Form1()
        {
            InitializeComponent();


        }

        public void DrawChart()
        {
            

            List<DateTime> sunrise = SortAscending(sunriseHash.ToList());
            List<DateTime> sunset = SortAscending(sunsetHash.ToList());
            List<DateTime> moonrise = SortAscending(moonriseHash.ToList());
            List<DateTime> moonset = SortAscending(moonsetHash.ToList());

            List<DateTime> moonover = new List<DateTime>();
            List<DateTime> moonunder = new List<DateTime>();

            List<DateTime> allmoon = new List<DateTime>();
            allmoon.AddRange(moonrise);
            allmoon.AddRange(moonset);

            allmoon = SortAscending(allmoon);

            bool riseFirst = false;
            bool setFirst = false;
            if (moonrise.Contains(allmoon[0]))
                riseFirst = true;
            if (moonset.Contains(allmoon[0]))
                setFirst = true;

            for (int i = 1; i < allmoon.Count-1; i++ )
            {

                if (riseFirst)
                {
                    TimeSpan ts = allmoon[i] - allmoon[i - 1];
                    double halfHours = ts.TotalHours / 2;
                    moonover.Add(allmoon[i - 1].AddHours(halfHours));

                    i++;

                    ts = allmoon[i] - allmoon[i - 1];
                    halfHours = ts.TotalHours / 2;
                    moonunder.Add(allmoon[i - 1].AddHours(halfHours));
                }

                if (setFirst)
                {
                    TimeSpan ts = allmoon[i] - allmoon[i - 1];
                    double halfHours = ts.TotalHours / 2;
                    moonunder.Add(allmoon[i - 1].AddHours(halfHours));

                    i++;

                    ts = allmoon[i] - allmoon[i - 1];
                    halfHours = ts.TotalHours / 2;
                    moonover.Add(allmoon[i - 1].AddHours(halfHours));
                }

            }

            chart1.Series.Clear();
            ChartArea area = chart1.ChartAreas[0];
            area.AxisX.LabelStyle.Format = "MM/dd/yyyy";
            area.AxisX.LabelStyle.Angle = -90;
            area.AxisX.IntervalType = DateTimeIntervalType.Months;
            //chart1.ChartAreas.Add(area);

            chart1.Series.Add(GetSeries(sunrise, "Sunrise", Color.Orange, true));
            chart1.Series.Add(GetSeries(sunset, "Sunset", Color.DarkOrange, true));
            //chart1.Series.Add(GetSeries(moonrise, "Moonrise", Color.Blue, true));
            //chart1.Series.Add(GetSeries(moonset, "Moonset", Color.LightBlue, true));
            chart1.Series.Add(GetSeries(moonover, "MoonOverHead", Color.Green, false));
            chart1.Series.Add(GetSeries(moonunder, "MoonUnderFoot", Color.LightGreen, false));


        }

        public Series GetSeries(List<DateTime> data, string name, Color col, bool solid)
        {
            Series s = new Series(name);
            s.ChartType = SeriesChartType.Line;
            s.Color = col;
            s.ChartArea = "ChartArea1";
            s.BorderWidth = 3;
            s.XValueType = ChartValueType.DateTime;
            if (solid)
                s.BorderDashStyle = ChartDashStyle.Solid;
            else
                s.BorderDashStyle = ChartDashStyle.Dash;

            for (int i = 0; i < data.Count; i++)
            {
                DateTime date = data[i];
                DateTime xDate = date.Date;
                float hour = (float)date.Hour + (float)date.Minute / 60 + (float)date.Second / 60 / 60;
                s.Points.AddXY(xDate, hour);
            }
            return s;
        }
        public void ProcessDay(DateTime dt)
        {
            string url = String.Format("http://api.usno.navy.mil/rstt/oneday?date={0}&loc=St.%20Louis,%20MO", dt.ToShortDateString());

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    //For IP-API
                    client.BaseAddress = new Uri(url);
                    HttpResponseMessage response = client.GetAsync(url).GetAwaiter().GetResult();
                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsAsync<MoonJson>().GetAwaiter().GetResult();
                        Console.WriteLine("Received, " + url);
                        ProcessData(data);
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
        public void ProcessData(MoonJson json)
        {
            DateTime day = new DateTime(json.year, json.month, json.day);

            //Moon
            foreach (var type in json.moondata)
            {
                if (type.phen.Equals("R"))
                {
                    lock (moonriseHash)
                        moonriseHash.Add(Convert2DateTime(day, type.time));
                }
                if (type.phen.Equals("S"))
                {
                    lock (moonsetHash)
                        moonsetHash.Add(Convert2DateTime(day, type.time));
                }
            }

            //Sun
            foreach (var type in json.sundata)
            {
                if (type.phen.Equals("R"))
                {
                    lock (sunriseHash)
                        sunriseHash.Add(Convert2DateTime(day, type.time));
                }
                if (type.phen.Equals("S"))
                {
                    lock (sunsetHash)
                        sunsetHash.Add(Convert2DateTime(day, type.time));
                }
            }
        }

        public static void StartAndWaitAllThrottled(IEnumerable<Task> tasksToRun, int maxActionsToRunInParallel, int timeoutInMilliseconds, CancellationToken cancellationToken = new CancellationToken())
        {
            // Convert to a list of tasks so that we don't enumerate over it multiple times needlessly.
            var tasks = tasksToRun.ToList();

            using (var throttler = new SemaphoreSlim(maxActionsToRunInParallel))
            {
                var postTaskTasks = new List<Task>();

                // Have each task notify the throttler when it completes so that it decrements the number of tasks currently running.
                tasks.ForEach(t => postTaskTasks.Add(t.ContinueWith(tsk => throttler.Release())));

                // Start running each task.
                foreach (var task in tasks)
                {
                    // Increment the number of tasks currently running and wait if too many are running.
                    throttler.Wait(timeoutInMilliseconds, cancellationToken);

                    cancellationToken.ThrowIfCancellationRequested();
                    task.Start();
                }

                // Wait for all of the provided tasks to complete.
                // We wait on the list of "post" tasks instead of the original tasks, otherwise there is a potential race condition where the throttler&#39;s using block is exited before some Tasks have had their "post" action completed, which references the throttler, resulting in an exception due to accessing a disposed object.
                Task.WaitAll(postTaskTasks.ToArray(), cancellationToken);
            }
        }

        public static DateTime Convert2DateTime(DateTime day, string time)
        {
            
            string s = day.ToShortDateString() + " " + time;
            s = s.Replace("a.m.", "AM");
            s = s.Replace("p.m.", "PM");
            s = s.Replace(" DT", "");
            s = s.Replace(" ST", "");
            return Convert.ToDateTime(s);
        }

        public static DateTime String2DateTime(DateTime day, string time)
        {
            string[] ti = time.Split(' ');

            string[] hm = ti[0].Split(':');

            int h = Int16.Parse(hm[0]);
            int m = Int16.Parse(hm[1]);

            DateTime dt;
            if (ti[1].StartsWith("a"))
            {
                //am
                dt = new DateTime(day.Year, day.Month, day.Day, h, m, 0);
            }
            else
            {
                dt = new DateTime(day.Year, day.Month, day.Day, h,m,0);//pm
                if (h<12)
                    dt = dt.AddHours(12);
            }

            Console.WriteLine(dt.ToString() + "------" + day.ToShortDateString() + "," + time);
            return dt;
        }
        public static List<DateTime> SortAscending(List<DateTime> list)
        {
            list.Sort((a, b) => a.CompareTo(b));
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(2018, 9, 21);
            DateTime end = new DateTime(2018, 11, 1);

            int totDays = end.Subtract(start).Days;
            List<Task> tasks = new List<Task>();
            for (int i = 0; i < totDays; i++)
            {
                DateTime day = start.AddDays(i);
                var t = new Task(() => ProcessDay(day));
                tasks.Add(t);
            }

            StartAndWaitAllThrottled(tasks, 6, 20000000);

            DrawChart();
        }

    }
}
