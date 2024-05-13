using UnityEngine;
using UnityEngine.UI;

public class MostrarImagen1 : MonoBehaviour
{
    // Variable para la imagen
    public Image imagen;

    private void OnCollisionEnter(Collision collision)
    {
        // Mostrar la imagen cuando se produce una colisión
        imagen.enabled = true;
    }
}