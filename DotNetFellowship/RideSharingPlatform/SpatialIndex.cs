using System;
using System.Collections.Generic;
using System.Text;

namespace RideSharingPlatform
{
    public class SpatialIndex<T>
    {
        private const double CellSize = 0.01;

        private Dictionary<(int, int), List<T>> grid = new();

        private (int, int) GetCell(double lat, double lon)
        {
            return (
                (int)Math.Floor(lat / CellSize),
                (int)Math.Floor(lon / CellSize)
            );
        }

        public void Add(T item, double lat, double lon)
        {
            var cell = GetCell(lat, lon);

            if (!grid.ContainsKey(cell))
                grid[cell] = new List<T>();

            grid[cell].Add(item);
        }

        public List<T> GetNearby(double lat, double lon)
        {
            var cell = GetCell(lat, lon);
            var result = new List<T>();

            for (int x = -1; x <= 1; x++)
            {
                for (int y = -1; y <= 1; y++)
                {
                    var key = (cell.Item1 + x, cell.Item2 + y);

                    if (grid.ContainsKey(key))
                        result.AddRange(grid[key]);
                }
            }

            return result;
        }
    }
}