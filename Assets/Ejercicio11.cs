//Realizá un programa que resuelva el siguiente problema:  
//Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:  YYYYMMDD), un nombre de 
//comprador, un nombre de producto y una cantidad y precio del producto comprado.Mostrá a modo de ticket, la 
//información ingresada y el monto a pagar.Modelo de Ticket:  
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio11 : MonoBehaviour
{
    public string fecha;
    public string nom;
    public string prod;
    public float cant;
    public float precio;
    float precioTotal;
    // Start is called before the first frame update
    void Start()
    {
        precioTotal = cant * precio;
        Debug.Log("Fecha de Compra: " + fecha + "\nNombre del Comprador: " + nom + "\nProducto Solicitado: " + prod +
            " \nCantidad Solicitada: " + cant + "\nPrecio Unitario: " + precio + "\nTotal a pagar: " + precioTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
