using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : IShape
{
    [SerializeField] private float length;
    
    

    public double CalculateArea()
    {
        //implementation of calculating the area of a circle
        length = 8;
        //calculate the area (Length * height)
        double area = length * length;

        return area;
    }

    public void Draw()
    {
        Debug.Log("Drawing a Square");
    }
}
