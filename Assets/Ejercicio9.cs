using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string nom1;
    public string nom2;
    public string nom3;

    public float per1;
    public float per2;
    public float per3;

    float capitalTotal;
    float porc1;
    float porc2;
    float porc3;



    // Start is called before the first frame update
    void Start()
    { capitalTotal = per1 + per2 + per3;

        porc1 = per1/capitalTotal * 100;
        porc2 = per2 / capitalTotal * 100;
        porc3 = per3 / capitalTotal * 100;

        Debug.Log("Nombre: " + nom1 + " capital aportado: $ " + per1 + ", Porcentaje del capital: %" + porc1 + ", Monto  total aportado: $" + capitalTotal );
        Debug.Log("Nombre: " + nom2 + " capital aportado: $ " + per2 + ", Porcentaje del capital: %" + porc2 + ", Monto  total aportado: $" + capitalTotal);
        Debug.Log("Nombre: " + nom3 + " capital aportado: $ " + per3 + ", Porcentaje del capital: %" + porc3 + ", Monto  total aportado: $" + capitalTotal);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


