using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace Encapsulation
{
    public class Car : MonoBehaviour
    {

        [SerializeField] private string model;
        [SerializeField] private int year;

        public void SetModel(string newModel)
        {
            model = newModel;
        }

        public string GetModel()
        {
            return model;
        }

        public int GetYear()
        {
            return year;
        }
    }
}

