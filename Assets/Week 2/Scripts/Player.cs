using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Encapsulation
{
    public class Player : MonoBehaviour
    {
        // For a variable we need 3 things;
        // access modifier.. type.. name
        [SerializeField] private Car car;

        // Start is called before the first frame update
        private void Start()
        {
            // Find out the cars model and year
            car.GetModel();
            Debug.Log(car.GetModel() + " " + car.GetYear());

        }


    }
}

