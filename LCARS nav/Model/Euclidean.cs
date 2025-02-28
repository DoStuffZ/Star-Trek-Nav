using System;

namespace Model;
/// <summary>
/// Calculation a Euclidean distance between 2 points of a point in a 3D space.
/// </summary>
public class Euclidean
{
    #region Attributes
    public Position PositionA { get; set; }
    public Position PositionB { get; set; }
    public int Distance { get; set; }
    #endregion

    #region Constructor
    public Euclidean(Position positionA, Position positionB)
    {
        PositionA = positionA;
        PositionB = positionB;
    }
    #endregion

    public static double Distance(Position posA, Position posB)
    {
        return Math.Sqrt(Math.Pow(posA.X() - posB.X(), 2) + Math.Pow(posA.Y() - posB.Y(), 2) + Math.Pow(posA.Z() - posB.Z(), 2));
    }

    public static double Distance(UFPPosition posA, UFPPosition posB)
    {
        return Math.Sqrt(Math.Pow(posA.UFPX - posB.UFPX, 2) + Math.Pow(posA.UFPY - posB.UFPY, 2) + Math.Pow(posA.UFPZ - posB.UFPZ, 2));
    }
}
