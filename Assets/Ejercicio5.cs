using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {

        if (num2 == 0)
        {
            Debug.Log("No se puede dividir por 0");

        }
        else
        {
            Debug.Log("La división entre " + num1 + "y" + num2 + "es de" + (num1 / num2));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
