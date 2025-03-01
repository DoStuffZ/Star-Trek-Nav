using System;
using System.Collections;

namespace LCARS_nav.Model;

public class WarpFactor
{
    #region Fields
    /// <summary>
    /// Warp factor luminal velocities above 9.
    /// </summary>
    private IDictionary AboveWarp9 = new Dictionary<string, double>
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
    /// <summary>
    /// Would be looking for the relative transport velocities
    /// </summary>
    private IDictionary Transwarp = new Dictionary<string, double> { };
    private IDictionary QuantumSlipstream = new Dictionary<string, double> { };
    private IDictionary CoaxialWarp = new Dictionary<string, double> { };
    #endregion

    #region Constructor
   /// <summary>
   /// Default constructor
   /// </summary>
    public WarpFactor()
    {
    }
    #endregion

    #region Methods
    /// <summary>
    /// Translate Warp Factor to c (speed of light).
    /// </summary>
    /// <param name="warp">Warp Factor</param>
    /// <returns>Luminal velocity (c) (Speed of Light)</returns>
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

        // 21,473×10(W−10)×0.5
    }
    #endregion
}
