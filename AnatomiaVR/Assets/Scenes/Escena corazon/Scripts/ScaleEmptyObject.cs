using UnityEngine;
using UnityEngine.UI;

public class ScaleEmptyObject : MonoBehaviour
{
    [SerializeField] private GameObject emptyObject; // Referencia al objeto vac�o
    [SerializeField] private Slider scaleSlider; // Referencia al Slider en el inspector

    private void Start()
    {
        // Establece la escala inicial del objeto vac�o en la mitad del Slider
        float initialScaleValue = 1.5f; // Valor de escala deseado (0.5 para la mitad)
        emptyObject.transform.localScale = Vector3.one * initialScaleValue;
    }

    private void Update()
    {
        // Obtiene el valor del Slider (de 0 a 1)
        float scaleValue = scaleSlider.value;

        // Escala el objeto vac�o en todas las dimensiones
        emptyObject.transform.localScale = Vector3.one * scaleValue;
    }
}
