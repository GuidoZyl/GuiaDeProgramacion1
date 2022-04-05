//Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio09 : MonoBehaviour
{
    public string nom1;
    public string nom2;
    public string nom3;

    public float cap1;
    public float cap2;
    public float cap3;

    float por1;
    float por2;
    float por3;

    float monto;
    // Start is called before the first frame update
    void Start()
    {
        monto = cap1 + cap2 + cap3;
        por1 = cap1 / monto * 100;
        por2 = cap2 / monto * 100;
        por3 = cap3 / monto * 100;

        Debug.Log("Nombre: " + nom1 + ", Capital aportado: $" + cap1 + ", Porcentaje del capital: %" + por1 + ", Monto total aportado: $" + monto + "\n" +
            "Nombre: " + nom2 + ", Capital aportado: $" + cap2 + ", Porcentaje del capital: %" + por2 + ", Monto total aportado: $" + monto + "\n" +
            "Nombre: " + nom3 + ", Capital aportado: $" + cap3 + ", Porcentaje del capital: %" + por3 + ", Monto total aportado: $" + monto);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
