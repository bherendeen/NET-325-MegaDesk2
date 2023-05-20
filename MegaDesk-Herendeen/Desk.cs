using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2
{
    public class Desk
    {
        // Desk variables
        public const int DESK_MIN_WIDTH = 24;
        public const int DESK_MAX_WIDTH = 96;
        public const int DESK_MIN_DEPTH = 12;
        public const int DESK_MAX_DEPTH = 48;
        public const int DRAWER_MIN = 0;
        public const int DRAWER_MAX = 7;
        public int deskDepth { get; set; }
        public int deskWidth { get; set; }
        public int deskNumDrawers { get; set; }
        public DesktopMaterial surfaceMaterial { get; set; }

        public int deskMinWidth { get { return DESK_MIN_WIDTH; } }
        public int deskMaxWidth { get { return DESK_MAX_WIDTH; } }
        public int deskMinDepth { get { return DESK_MIN_DEPTH; } }
        public int deskMaxDepth { get { return DESK_MAX_DEPTH; } }
        public int deskDrawerMin { get { return DRAWER_MIN; } }
        public int deskDrawerMax { get { return DRAWER_MAX; } }

        public Desk(int width, int depth, int numDrawers, DesktopMaterial surfaceMaterial)
        {
            this.deskWidth = width;
            this.deskDepth = depth;
            this.deskNumDrawers = deskNumDrawers;
            this.surfaceMaterial = (DesktopMaterial)surfaceMaterial;
        }

        public Desk()
        {
        }
    }


    // Create enumerated type named DesktopMaterial
    public enum DesktopMaterial
    {
        Laminate,
        Oak,
        Pine,
        Rosewood,
        Veneer
    }
}
