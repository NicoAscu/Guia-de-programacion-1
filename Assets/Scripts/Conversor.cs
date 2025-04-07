using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversor : MonoBehaviour
{

    //declaracion de variables
    public float montoAConvertir;
    public string codigoMoneda;

    float cotizacionDolar = 1350.22f;
    float cotizacionEuro = 1633.12f;
    float cotizacionReal = 367.54f;

    float montoConvertido;
    float montoMinimo = 1000;

    // Start is called before the first frame update
    void Start()
    {
        //ingreso y validacion de datos
        if (montoAConvertir < montoMinimo)
        {
            Debug.Log("El monto minimo es $1000");
            return;
        }

        if (codigoMoneda == "D" || codigoMoneda == "d")
        {
            montoConvertido = cotizacionDolar / montoAConvertir;
        }
        else if (codigoMoneda == "E" || codigoMoneda == "e")
        {
            montoConvertido = cotizacionEuro / montoAConvertir;
        }
        else if (codigoMoneda == "R" || codigoMoneda == "r")
        {
            montoConvertido = cotizacionReal / montoAConvertir;
        }
        else
        {
            Debug.Log("Codigo no valido");
            return;
        }
        //salida
        Debug.Log("El monto ingresado equivale a " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
