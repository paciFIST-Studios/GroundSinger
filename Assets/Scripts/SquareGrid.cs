using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareGrid
{
    public static readonly int MAX_SIDE = 30000;

    private int width;
    private int height;

    private int[,] gridArray;


    public int Width  { get { return this.width; } }
    public int Height { get { return this.height; } }


    private int ClampToValidRange(int value)
    {
        if (value > MAX_SIDE)
        {
            return MAX_SIDE;
        }
        else if (value < 0)
        {
            return 0;
        }

        return value;
    }


    public SquareGrid(int width, int height)
    {
        this.width  = ClampToValidRange(width);
        this.height = ClampToValidRange(height);


        gridArray = new int[this.width, this.height];
    }

}
