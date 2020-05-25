using Battleship_ahf27_ymf04.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_ahf27_ymf04.Objects.Boards
{
    /// <summary>
    /// Represents a collection of Panels to show where the player has fired shots, and whether those shots are hits or misses.
    /// </summary>
    public class FiringBoard : GameBoard
    {
        public List<Coordinates> getPanels()
        {
            return Panels.Where(x => x.Coordinates.Row >= 0 
                                 && x.Coordinates.Column >= 0 
                                 && x.Coordinates.Row <= 100 
                                 && x.Coordinates.Column <= 100).Select(x=>x.Coordinates).ToList();
        }
    }
}
//.Where(x => x.OccupationType == OccupationType.Empty || x.IsOccupied).Select(x=>x.Coordinates).ToList()