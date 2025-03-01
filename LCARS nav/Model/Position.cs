using System;

namespace LCARS_nav.Model;
/// <summary>
/// Create a Galactic position.
/// </summary>
public class Position
{
    #region Attritubes and Fields   
    public char[] Grid { get; set; } // Wedge [0-9, a-z] (10 degree) and band (0-9) (Band being 5000 x 3600)
    public int Quad { get; set; } // 100 Quads in 5000 x 3600 x 10 degree (~4500) LY
    public int Block { get; set; } // 1000 Blocks in 1000 x 800 x 2 degree (~900) LY
    public int Sector { get; set; } // 100 Sectors in a 100 x 80 x ~100 (0 deg 13' 20")
    public string? System { get; set; } = null; // S02-ABC, Sol
    #endregion

    #region Constructors
    /// <summary>
    /// Default constructor
    /// </summary>
    public Position()
    {
        Grid = new char[2] { '0', '0' };
        Quad = 0;
        Block = 0;
        Sector = 0;
    }
    /// <summary>
    /// Full constructor down to a Sector.
    /// 
    /// Gives you a coordination down to a sector. A Sector is 100x80x~100 LY
    /// </summary>
    /// <param name="grid">Grid (Wedge / Band)</param>
    /// <param name="quad">Quad</param>
    /// <param name="block">Block</param>
    /// <param name="sector">Sector</param>
    public Position(char[] grid, int quad, int block, int sector)
    {
        Grid = grid;
        Quad = quad;
        Block = block;
        Sector = sector;
    }
    /// <summary>
    /// Full constructor down to a System.
    /// 
    /// Gives you a coordination down to a sector. A Sector is 100x80x~100 LY
    /// A sector can potentially hold several solar systems. Ex. Sol system and Alpha Centauri is in the same Sector (4.37 LY apart)
    /// </summary>
    /// <param name="grid">Grid (Wedge / Band)</param>
    /// <param name="quad">Quad</param>
    /// <param name="block">Block</param>
    /// <param name="sector">Sector</param>
    /// <param name="system">System, solar system</param>
    public Position(char[] grid, int quad, int block, int sector, string system) : this(grid, quad, block, sector)
    {
        System = system;
    }
    #endregion

    #region Computation
    /// <summary>
    /// Radial distance. Between Band(grid), Quad, Block, and Sector
    /// </summary>
    /// <param name="grid">Grid (15)</param>
    /// <param name="quad">Quad (072)</param>
    /// <param name="block">Block (76)</param>
    /// <param name="sector">Sector (02)</param>
    /// <returns>Radial Distance</returns>
    public int Radial(char[] grid, int quad, int block, int sector)
    {
        return Band(grid) * 5000 + quad * 900 + block * 500 + sector * 100;
    }
    /// <summary>
    /// Returns radiance out of Grid (0-9, a-z)
    /// </summary>
    /// <param name="grid">Grid 15</param>
    /// <returns>Radians</returns>
    public decimal Radians(char[] grid)
    {
        int wedgeNo;
        if (int.TryParse(grid[0].ToString(), out wedgeNo))
        {
            // If the first character is a number (0-9), use it directly.
        }
        else
        {
            int number = char.ToLower(grid[0]) - 'a' + 11;
            wedgeNo = number;
        }

        // Convert wedge number to radians (10° per wedge)
        return (decimal)(wedgeNo * 10 * (Math.PI / 180));
    }
    /// <summary>
    /// Calculates the Z-Height out of Band and Block
    /// </summary>
    /// <param name="band">Band (of Grid)</param>
    /// <param name="block">Block number</param>
    /// <returns>Z Height (LY)</returns>
    public double ZHeight(int band, int block)
    {
        return band * 3600 + block / 100 * 800;
    }
    #endregion

    #region Helpers
    /// <summary>
    /// Extracting the band value out of the Grid.
    /// </summary>
    /// <param name="grid">Wedge and Band</param>
    /// <returns>Band number</returns>
    public int Band(char[] grid)
    {
        return int.Parse(grid[1].ToString());
    }
    /// <summary>
    /// Returning string format of Position "15 02 076 12"
    /// </summary>
    /// <returns>String</returns>
    public override string ToString()
    {
        return $"{Grid} {Quad:D2} {Block:D3} {Sector:D2}";
    }

    internal int X()
    {
        throw new NotImplementedException();
    }

    internal int Y()
    {
        throw new NotImplementedException();
    }

    internal int Z()
    {
        throw new NotImplementedException();
    }
    #endregion
}
