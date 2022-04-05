using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("La suma entre " + num1 + " y " + num2 + " da como resultado " + (num1+num2));

        if (num2 == 0) ;
        Debug.Log("No se puede dividir por 0"); 

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
