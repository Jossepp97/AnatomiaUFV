using UnityEngine;
using UnityEngine.UI;

public class ToggleButton1 : MonoBehaviour
{
    public Toggle toggleButton; // Referencia al botón de alternancia
    public GameObject objetoParaAparecer; // Referencia al objeto que quieres hacer aparecer
    public GameObject objetoParaDestruir; // Referencia al objeto que quieres destruir

    void Start()
    {
        // Asegúrate de que el botón de alternancia está configurado para llamar a esta función cuando se cambie
        toggleButton.onValueChanged.AddListener(delegate { ToggleValueChanged(toggleButton); });
    }

    // Esta función se llama cuando el valor del botón de alternancia cambia
    void ToggleValueChanged(Toggle change)
    {
        if (toggleButton.isOn)
        {
            objetoParaAparecer.SetActive(true); // Hacer aparecer el objeto
            Destroy(objetoParaDestruir); // Destruir el otro objeto
        }
        else
        {
            objetoParaAparecer.SetActive(false); // Hacer desaparecer el objeto si el botón de alternancia no está activado
        }
    }
}
