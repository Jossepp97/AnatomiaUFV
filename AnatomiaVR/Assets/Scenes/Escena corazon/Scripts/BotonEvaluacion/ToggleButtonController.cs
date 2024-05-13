using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonController : MonoBehaviour
{
    public Toggle toggleButton; // Aseg�rate de asignar tu bot�n Toggle en el inspector de Unity
    public GameObject image; // Aseg�rate de asignar tu imagen en el inspector de Unity

    void Start()
    {
        // Aseg�rate de que la imagen est� oculta al inicio
        image.SetActive(false);

        // Agrega un listener al bot�n Toggle para mostrar u ocultar la imagen cuando se presione
        toggleButton.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggleButton);
        });
    }

    void ToggleValueChanged(Toggle change)
    {
        // Si el bot�n Toggle est� activo, muestra la imagen. Si no, oculta la imagen.
        image.SetActive(toggleButton.isOn);
    }
}
