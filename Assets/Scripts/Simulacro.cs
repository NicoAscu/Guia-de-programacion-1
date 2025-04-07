using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulacro : MonoBehaviour
{
    //1. Definicion de variables

    public int cantidadDeDias;
    public string codigoAnimal;
    int gramosComidaTotal;
    int racionGatos = 300;
    int racionPerrosPeque = 400;
    int racionPerroGrande = 700;
    int racionAnimalActual;
    float costoAlimento;
    float precioPorCienGramos = 80;


    // Start is called before the first frame update
    void Start()
    {
      //2. Ingreso de datos

        if (cantidadDeDias < 3)
        {
            Debug.Log("Cantidad de dias no valida");
        }
        else
        {

        

      if(codigoAnimal == "G" || codigoAnimal == "g"){
        racionAnimalActual = racionGatos;

      }else if(codigoAnimal == "PP" || codigoAnimal == "pp"){
        racionAnimalActual = racionPerrosPeque;


      }else if(codigoAnimal == "PG" ||codigoAnimal == "pg"){
        racionAnimalActual = racionPerroGrande;
      }else
            {
                Debug.Log("Codigo no valido");
                return;
            }

      //3. Procesamiento de los datos

      gramosComidaTotal = racionAnimalActual * cantidadDeDias;

      costoAlimento = gramosComidaTotal / 100 * precioPorCienGramos;

      //4. Mostrar resultado

      Debug.Log("Para ese periodo se necesitan " + gramosComidaTotal + " gramos de alimento");
      Debug.Log("Costo alimento: $" + costoAlimento);
        }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
