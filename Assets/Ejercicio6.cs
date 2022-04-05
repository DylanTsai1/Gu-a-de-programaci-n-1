using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public int num1;

    // Start is called before the first frame update
    void Start()
    {
        if (num1 % 2 == 1)
        {
            Debug.Log("El número es impar");
        }
        else
            Debug.Log("El número es par");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
