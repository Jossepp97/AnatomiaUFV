using UnityEngine;
using UnityEngine.UI;

public class GestionarImagenes : MonoBehaviour
{
    // Variables para las im�genes
    public Image imagenADestruir;
    public Image imagenAMantener;

    private void OnCollisionEnter(Collision collision)
    {
        // Destruir la imagen y mantener la otra cuando se produce una colisi�n
        Destroy(imagenADestruir.gameObject);
        imagenAMantener.enabled = true;
    }
}
