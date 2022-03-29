//Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y
//num3, muestre el valor del mayor de todos.
//En caso de igualdad entre los tres imprimir &quot; Los números son iguales&quot;.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio07 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;
    int res;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2 && num1 == num3)
        {
            Debug.Log("Los números son iguales");
        }

        else
        {
            if (num1 >= num2 && num1 >= num3)
            {
                res = num1;
            }

            else if (num2 >= num1 && num2 >= num3)
            {
                res = num2;
            }

            else
            {
                res = num3;
            }

            Debug.Log(res);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
