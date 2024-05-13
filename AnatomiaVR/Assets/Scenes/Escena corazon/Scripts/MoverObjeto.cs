using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverObjeto : MonoBehaviour
{
    public GameObject objetoVacio; // Referencia al objeto vacío
    public Slider slider; // Referencia al control deslizante

    // Actualiza la posición del objeto vacío cada vez que cambia el valor del control deslizante
    void Update()
    {
        float valorSlider = slider.value;
        Vector3 posicionActual = objetoVacio.transform.position;
        objetoVacio.transform.position = new Vector3(posicionActual.x, valorSlider, posicionActual.z);
    }
}
