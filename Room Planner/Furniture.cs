using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Room_Planner
{
    class Furniture
    {
        public System.Drawing.Image Image { get; set; }
        public List<System.Drawing.Point> Points { get; set; }
        public string Name { get; set; }
        public bool isSelected;
        public int Angle { get; set; }

        public Furniture(System.Drawing.Image image, List<System.Drawing.Point> points, string Name)
        {
            this.Image = image;
            this.Points = points;
            this.Name = Name;
            isSelected = false;
            this.Angle = 0;
        }

    }
}
