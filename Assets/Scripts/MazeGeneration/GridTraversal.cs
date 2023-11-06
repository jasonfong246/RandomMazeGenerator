using System.Collections.Generic;
using UnityEngine;


namespace ShareefSoftware
{
    /// Utility class to traverse a grid.
    public class GridTraversal<T>
    {

        private readonly IGridGraph<T> grid;
        //Create a list of all walls
        private List<((int Row, int Column) From, (int Row, int Column) To)> fromToCells;
        //Create a set for each cell, each containing just that one cell.
        private List<List<(int Row, int Column)>> sets;
        private List<(int Row, int Column)> fromSet;
        private List<(int Row, int Column)> toSet;

        /*
         * Replace this with your documentation
         * 
         * Define your instance variables here
         */

        public GridTraversal(IGridGraph<T> grid)
        {
            this.grid = grid;
        }

        /*
         * Replace this with your documentation
         * 
         * DO NOT change the method signature
         * Define helper methods as 'private'
         */
        public IEnumerable<((int Row, int Column) From, (int Row, int Column) To)> GenerateMaze(int startRow, int startColumn)
        {

            /*
             * Implement your maze generation algorithm here
             * Use helper methods as needed
             */

            fromToCells = new List<((int Row, int Column) From, (int Row, int Column) To)>();
            sets = new List<List<(int Row, int Column)>>();

            for (int row = 0; row < grid.NumberOfRows; row++)
            {
                for (int column = 0; column < grid.NumberOfColumns; column++)
                {
                    // Add every cell to its own set
                    sets.Add(new List<(int Row, int Column)> { (row, column) });
                    //Add every wall to the list 
                    if (row > 0)
                    {
                        fromToCells.Add(((row, column), (row -1, column)));
                    }
                    if (column > 0)
                    {
                        fromToCells.Add(((row, column), (row, column -1)));
                    }
                }
            }
 
            
            // Iterate each wall in some random order
            while (fromToCells.Count > 0)
            {
                int randomIndex = Random.Range(0, fromToCells.Count);
                //Pick a random wall with from and to cells
                ((int Row, int Column) From, (int Row, int Column) To) wall = fromToCells[randomIndex];
                // Find the set for the from and to cells
                fromSet = sets.Find(set => set.Contains(wall.From));
                toSet = sets.Find(set => set.Contains(wall.To));
                fromToCells.RemoveAt(randomIndex);
                // If the cells are in different sets then remove the wall and merge the sets
                if (fromSet != toSet)
                {
                    
                    fromSet.AddRange(toSet);
                    sets.Remove(toSet);
                    yield return wall;
                }
            }
        }
    }
}