using System;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace lab6
{
    public class Operations
    {
        /// <summary>
        /// methor for saving default settings
        /// </summary>
        /// <param name="set"></param>
        public static void save_default_settings(Settings set)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Settings));
            using (FileStream fs = new FileStream(@"C:\Users\stass\source\repos\lab6\lab6\default_settings.json", FileMode.OpenOrCreate))
            {
                js.WriteObject(fs, set);
            }
        }
        /// <summary>
        /// method for saving user settings
        /// </summary>
        /// <param name="set"></param>
        public static void save_user_settings(Settings set)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Settings));
            using (FileStream fs = new FileStream(@"C:\Users\stass\source\repos\lab6\lab6\user_settings.json", FileMode.OpenOrCreate))
            {
                js.WriteObject(fs, set);
            }
        }
        /// <summary>
        /// method for loading user settings
        /// </summary>
        /// <param name="set"></param>
        /// <returns></returns>
        public static bool load_user_settings(ref Settings set)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Settings));
            try
            {
                using (FileStream fs = new FileStream(@"C:\Users\stass\source\repos\lab6\lab6\user_settings.json", FileMode.Open))
                {
                    set = (Settings)js.ReadObject(fs);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// method for paint hands
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="gr"></param>
        /// <param name="set"></param>
        public static void hands_paint(PictureBox pb, Graphics gr, Settings set)
        {
            gr.TranslateTransform(pb.Width / 2, pb.Height / 2);
            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;
            Pen sec_pen = new Pen(set.sec_color, 1);
            Pen min_pen = new Pen(set.min_color, 2);
            Pen hour_pen = new Pen(set.hour_color, 3);
            double sec_angle = 2 * Math.PI * sec / 60;
            double min_angle = 2 * Math.PI * (min + sec / 60) / 60;
            double hour_angle = 2 * Math.PI * (hour + min / 60) / 12;
            Point centre = new Point(0, 0);
            int length_sec = pb.Width / 2 - 40;
            Point sec_hand = new Point((int)(length_sec * Math.Sin(sec_angle)), (int)(length_sec * -Math.Cos(sec_angle)));
            gr.DrawLine(sec_pen, centre, sec_hand);
            int length_min = pb.Width / 2 - 50;
            Point min_hand = new Point((int)(length_min * Math.Sin(min_angle)), (int)(length_min * -Math.Cos(min_angle)));
            gr.DrawLine(min_pen, centre, min_hand);
            int length_hour = pb.Width / 2 - 60;
            Point hour_hand = new Point((int)(length_hour * Math.Sin(hour_angle)), (int)(length_hour * -Math.Cos(hour_angle)));
            gr.DrawLine(hour_pen, centre, hour_hand);
            gr.ResetTransform();
        }
        /// <summary>
        /// method for paint digits
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="gr"></param>
        /// <param name="set"></param>
        public static void digits_paint(PictureBox pb, Graphics gr, Settings set)
        {
            int r = Math.Min(pb.Width, pb.Height) / 2 - 7;
            Font font = new Font("Times New Roman", 14, FontStyle.Bold);
            Point centre = new Point(pb.Width / 2, pb.Height / 2);
            int hour = 1;
            for(int minute = 5; minute <= 60; minute += 5)
            {
                Point pt = radia_point(centre, r - 20, minute);
                using (SolidBrush sb = new SolidBrush(set.digits_color))
                {
                    gr.DrawString(hour.ToString(), font, sb, pt.X - 10, pt.Y - 10);
                }
                hour++;
            }
        }
        /// <summary>
        /// method for points
        /// </summary>
        /// <param name="centre"></param>
        /// <param name="r"></param>
        /// <param name="seconds"></param>
        /// <returns></returns>
        public static Point radia_point(Point centre, int r, int seconds)
        {
            double angle = -((seconds - 15) % 60) * Math.PI / 30;
            Point p = new Point(centre.X + (int)(r * Math.Cos(angle)), centre.Y + (int)(r * -Math.Sin(angle)));
            return p;
        }
        /// <summary>
        /// method for digital watch
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="gr"></param>
        /// <param name="set"></param>
        public static void digital_watch(PictureBox pb, Graphics gr, Settings set)
        {
            DateTime dt = DateTime.Now;
            gr.DrawString(dt.ToLongTimeString(), new Font("Times New Roman", 12, FontStyle.Regular), new SolidBrush(set.digits_color), new Point(pb.Width / 2 - 29, pb.Height / 2 + 40));
        }
    }
}
