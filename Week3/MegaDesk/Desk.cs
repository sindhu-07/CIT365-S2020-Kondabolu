﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
      
    class Desk
    {
        #region Member Vars

        //Desk Description
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public Material DeskMaterial { get; set; }
        public int Area { get; set; }

        #endregion

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        //Matrials
        //[Flags]
        public enum Material {
            Oak = 200,
            Laminate = 100,
            Pine =  50,
            Rosewood = 300,
            Veneer = 125
        }

    }

    // I think this is right, let me know if you guys think this is not how structs work...
    // The compiler didn't even sort of whine, so I have no idea.
    /*
    public struct DeskStruct
    {
        #region Member Vars

        //Desk Description
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public Material DeskMaterial { get; set; }
        public int Area { get; set; }

        #endregion

        //Desk Constraints
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        //Matrials
        //[Flags]
        public enum Material
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }
    }
    */
}
