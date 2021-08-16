using System.Drawing;
using System.Runtime.Serialization;

namespace lab6
{
    [DataContract]
    public class Settings
    {
        /// <summary>
        /// type watch
        /// </summary>
        [DataMember]
        public bool clock_type { get; set; }
        /// <summary>
        /// color second hand
        /// </summary>
        [DataMember]
        public Color sec_color { get; set; }
        /// <summary>
        /// color minute hand
        /// </summary>
        [DataMember]
        public Color min_color { get; set; }
        /// <summary>
        /// color hour color
        /// </summary>
        [DataMember]
        public Color hour_color { get; set; }
        /// <summary>
        /// watch color
        /// </summary>
        [DataMember]
        public Color clock_color { get; set; }
        /// <summary>
        /// digits color
        /// </summary>
        [DataMember]
        public Color digits_color { get; set; }
        /// <summary>
        /// clock size
        /// </summary>
        [DataMember]
        public int clock_size { get; set; }
        /// <summary>
        /// default constructor
        /// </summary>
        public Settings()
        {
            clock_type = false;
            sec_color = Color.Black;
            min_color = Color.Black;
            hour_color = Color.Black;
            clock_color = Color.White;
            digits_color = Color.Black;
            clock_size = 1;
        }
    }
}
