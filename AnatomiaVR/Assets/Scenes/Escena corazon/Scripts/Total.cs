using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour
{
    public GameObject objetoVacio; // Referencia al objeto vacío
    public Slider sliderEscala; // Referencia al control deslizante para la escala
    public Slider sliderRotacionY; // Referencia al control deslizante para la rotación en el eje Y
    public Slider sliderRotacionX; // Referencia al control deslizante para la rotación en el eje X
    public Slider sliderTraslacionVertical; // Referencia al control deslizante para la traslación vertical
    public Slider sliderTraslacionHorizontal; // Referencia al control deslizante para la traslación horizontal

    // Actualiza la escala, rotación y traslación del objeto vacío cada vez que cambian los valores de los controles deslizantes
    void Update()
    {
        float valorEscala = sliderEscala.value;
        float valorRotacionY = sliderRotacionY.value;
        float valorRotacionX = sliderRotacionX.value;
        float valorTraslacionVertical = sliderTraslacionVertical.value;
        float valorTraslacionHorizontal = sliderTraslacionHorizontal.value;

        objetoVacio.transform.localScale = new Vector3(valorEscala, valorEscala, valorEscala);
        objetoVacio.transform.rotation = Quaternion.Euler(valorRotacionX, valorRotacionY, 0);
        objetoVacio.transform.position = new Vector3(valorTraslacionHorizontal, valorTraslacionVertical, objetoVacio.transform.position.z);
    }
}
