using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{

    public float width;
    public float height;

    public override float CalculateArea()
    {
        return width * height * 0.5f;
    }
}
