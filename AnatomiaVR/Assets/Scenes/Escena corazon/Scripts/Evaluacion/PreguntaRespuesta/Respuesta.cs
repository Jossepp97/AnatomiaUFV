using UnityEngine;
using UnityEngine.UI;

public class ToggleButton1 : MonoBehaviour
{
    public Toggle toggleButton; // Referencia al bot�n de alternancia
    public GameObject objetoParaAparecer; // Referencia al objeto que quieres hacer aparecer
    public GameObject objetoParaDestruir; // Referencia al objeto que quieres destruir

    void Start()
    {
        // Aseg�rate de que el bot�n de alternancia est� configurado para llamar a esta funci�n cuando se cambie
        toggleButton.onValueChanged.AddListener(delegate { ToggleValueChanged(toggleButton); });
    }

    // Esta funci�n se llama cuando el valor del bot�n de alternancia cambia
    void ToggleValueChanged(Toggle change)
    {
        if (toggleButton.isOn)
        {
            objetoParaAparecer.SetActive(true); // Hacer aparecer el objeto
            Destroy(objetoParaDestruir); // Destruir el otro objeto
        }
        else
        {
            objetoParaAparecer.SetActive(false); // Hacer desaparecer el objeto si el bot�n de alternancia no est� activado
        }
    }
}
