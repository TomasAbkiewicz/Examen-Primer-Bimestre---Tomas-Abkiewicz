using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flotaDeTaxis : MonoBehaviour
{
    public int cantidadDeDias;
    public int cantidadDeUnidades;

    float cantidadDiaMinima = 5;
    float cantidadUnidadesMinima = 1;

    float litrosTotal;

    float descuento = 0.8f;
    float litrosDescuento = 100;
    float precioLitro = 130;

    float litrosPorDia = 6;
    // resultado de 90/15
    float precioTotal;
    // Start is called before the first frame update
    void Start()
    {
        if (cantidadDeDias < 5 || cantidadUnidadesMinima < 1)
        {
            Debug.Log("Error, Cantidades Ingresadas no Validas. Ingrese Una cantidad de dias mayor a 5 o una Cantidad de Unidades Mayor a 1");
            return;
        }
        if (cantidadDeDias > 5 && cantidadUnidadesMinima > 1)
        {
            litrosTotal = (litrosPorDia * cantidadDeDias) * cantidadDeUnidades;
            precioTotal = litrosTotal * precioLitro;
            Debug.Log("Una flota de" + cantidadDeUnidades + "unidades trabajando durante " + cantidadDeDias + " días implicará un gasto de" + precioTotal + "pesos en concepto de combustible");
        }
        else if (cantidadDeDias > 5 && cantidadUnidadesMinima > 1 && litrosTotal > litrosDescuento)
        {
            litrosTotal = (litrosPorDia * cantidadDeDias) * cantidadDeUnidades;
            precioTotal = (litrosTotal * precioLitro) * descuento;
            Debug.Log("Una flota de" + cantidadDeUnidades + "unidades trabajando durante " + cantidadDeDias + " días implicará un gasto de" + precioTotal + "pesos en concepto de combustible");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
