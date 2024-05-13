using UnityEngine;
using UnityEngine.UI;

public class CubeCollision : MonoBehaviour
{
    public string targetCubeName; // Nombre del cubo con el que quieres que colisione
    public Image image1; // Imagen que aparecerá cuando colisione con el cubo objetivo
    public Image image2; // Imagen que aparecerá cuando colisione con cualquier otro cubo

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == targetCubeName)
        {
            // Si el cubo colisiona con el cubo objetivo, muestra la imagen1
            image1.enabled = true;
            image2.enabled = false;
        }
        else
        {
            // Si el cubo colisiona con cualquier otro cubo, muestra la imagen2
            image1.enabled = false;
            image2.enabled = true;
        }
    }
}
