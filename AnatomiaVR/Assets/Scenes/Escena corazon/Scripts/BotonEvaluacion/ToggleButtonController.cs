using UnityEngine;
using UnityEngine.UI;

public class ToggleButtonController : MonoBehaviour
{
    public Toggle toggleButton; // Asegúrate de asignar tu botón Toggle en el inspector de Unity
    public GameObject image; // Asegúrate de asignar tu imagen en el inspector de Unity

    void Start()
    {
        // Asegúrate de que la imagen esté oculta al inicio
        image.SetActive(false);

        // Agrega un listener al botón Toggle para mostrar u ocultar la imagen cuando se presione
        toggleButton.onValueChanged.AddListener(delegate {
            ToggleValueChanged(toggleButton);
        });
    }

    void ToggleValueChanged(Toggle change)
    {
        // Si el botón Toggle está activo, muestra la imagen. Si no, oculta la imagen.
        image.SetActive(toggleButton.isOn);
    }
}
