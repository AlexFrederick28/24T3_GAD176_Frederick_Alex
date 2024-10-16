using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Circle : IShape
{

    [SerializeField] private float radius;

    

    public double CalculateArea()
    {
        //implementation of calculating the area of a circle
        radius = 8;
        //convert our radius float to a daouble (because pi has many digits and we want to be as accurate as possible)
        double radiusDouble = Convert.ToDouble(radius);
        //calculate the area (PI r Squared)
        double area = Math.PI * radius * radius;

        return area;
    }

    public void Draw()
    {
        //implementation of drawing a circle
        //instead of drawing a circle due to being a lot of maths, draw a wire frame sphere in unity.
        Debug.Log("Drawing a circle");
    }

   
}
