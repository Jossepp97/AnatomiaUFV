using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    // Variable para el nombre de la escena
    public string nombreDeLaEscena;

    // Método para cambiar la escena
    public void CambiarALaEscena()
    {
        // Cargar la escena con el nombre especificado
        SceneManager.LoadScene(nombreDeLaEscena);
    }
}
