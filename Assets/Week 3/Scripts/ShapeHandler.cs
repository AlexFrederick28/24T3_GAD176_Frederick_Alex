using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IShape circle = new Circle();
        circle.Draw();
        
        Debug.Log("Area of our 8 radius circle is " + circle.CalculateArea());

        IShape square = new Square();
        square.Draw();
        
        Debug.Log("Area of our 8 radius circle is " + square.CalculateArea());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
