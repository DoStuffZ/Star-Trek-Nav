using System;
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

    public int Distance(Position posA, Position posB)
    {

    }
}
