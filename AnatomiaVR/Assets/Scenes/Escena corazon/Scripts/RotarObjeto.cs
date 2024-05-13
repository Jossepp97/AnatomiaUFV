using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotarObjeto : MonoBehaviour
{
    public GameObject objeto; // Referencia al objeto
    public Slider slider; // Referencia al control deslizante

    // Actualiza la rotación del objeto cada vez que cambia el valor del control deslizante
    void Update()
    {
        float valorSlider = slider.value;
        objeto.transform.rotation = Quaternion.Euler(0, valorSlider, 0);
    }
}
