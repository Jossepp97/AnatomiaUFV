using UnityEngine;
using UnityEngine.UI;

public class GestionarImagenes : MonoBehaviour
{
    // Variables para las imágenes
    public Image imagenADestruir;
    public Image imagenAMantener;

    private void OnCollisionEnter(Collision collision)
    {
        // Destruir la imagen y mantener la otra cuando se produce una colisión
        Destroy(imagenADestruir.gameObject);
        imagenAMantener.enabled = true;
    }
}
