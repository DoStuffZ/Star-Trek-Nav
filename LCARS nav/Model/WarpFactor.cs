using System;
using System.Collections;

namespace Model;

public class WarpFactor
{
    #region Fields
    private IDictionary Above9Warp = new Dictionary<string, double>
    {
        {"9", 1516},
        {"9.1",1649},
        {"9.2",1823},
        {"9.3",2048},
        {"9.4",2397},
        {"9.5",7912},
        {"9.6",9951},
        {"9.7",13542},
        {"9.8",17025},
        {"9.9",21473},
        {"9.99",114770}
    };
    #endregion

    #region Constructor
    public WarpFactor()
    {
    }

    public IDictionary GetAbove9Warp()
    {
        return Above9Warp;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Translate Warp Factor to c (speed of light).
    /// </summary>
    /// <param name="warp">Warp Factor</param>
    /// <returns>c velocity (Speed of Light)</returns>
    public static double WarpToC(double warp, IDictionary above9Warp)
    {
        if (warp < 9)
        {
            return Math.Pow(warp, 10 / 3) + Math.Pow(10 - warp, -11 / 3);
        }
        else
        {
            try
            {
                if (above9Warp.Contains(warp + ""))
#pragma warning disable CS8605 // Unboxing a possibly null value.
                    return (double)above9Warp[warp + ""];
#pragma warning restore CS8605 // Unboxing a possibly null value.
                return 0;
            }
            catch (ArgumentNullException)
            {
                return 0;
            }
        }
    }
    #endregion
}
