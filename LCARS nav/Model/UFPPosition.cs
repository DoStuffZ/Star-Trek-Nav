using System;

namespace LCARS_nav.Model;
/// <summary>
/// Create an UFP (United Federation Planets) position.
/// </summary>
public class UFPPosition
{
    #region Attributes    
    /// <summary>
    /// UFP X Parsecs position
    /// </summary>
    public double UFPX { get; set; }
    /// <summary>
    /// UFP Y Parsecs position
    /// </summary>
    public double UFPY { get; set; }
    /// <summary>
    /// UFP Z Parsec Position
    /// </summary>
    public double UFPZ { get; set; }
    #endregion

    #region Fields
    private const double _ParsecLY = 3.26;
    #endregion

    #region
    /// <summary>
    /// Default Constructor, creates a UFP [0,0,0]
    /// </summary>
    public UFPPosition()
    {
        UFPX = 0;
        UFPY = 0;
        UFPZ = 0;
    }
    /// <summary>
    /// Full constructor UFP Position
    /// </summary>
    /// <param name="x">Parsec X</param>
    /// <param name="y">Parsec Y</param>
    /// <param name="z">Parsec Z</param>
    public UFPPosition(double x, double y, double z)
    {
        UFPX = x;
        UFPY = y;
        UFPZ = z;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Transfer from Parsecs to Lightyear
    /// </summary>
    /// <param name="parsec">Parsec</param>
    /// <returns>Lightyear (LY)</returns>
    public double ParsecsToLightYear(double parsec)
    {
        return (double)(parsec * _ParsecLY);
    }
    #endregion
}
