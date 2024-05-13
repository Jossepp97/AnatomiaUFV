using UnityEngine;
using UnityEngine.UI;

public class MostrarImagen : MonoBehaviour
{
    // Variables para las im�genes y el nombre del objeto
    public Image imagenEspecifica;
    public Image imagenGeneral;
    public string nombreEspecifico;

    private void OnCollisionEnter(Collision collision)
    {
        // Comprobar si el objeto con el que se ha colisionado tiene el nombre espec�fico
        if (collision.gameObject.name == nombreEspecifico)
        {
            // Mostrar la imagen espec�fica y ocultar la imagen general
            imagenEspecifica.enabled = true;
            imagenGeneral.enabled = false;
        }
        else
        {
            // Mostrar la imagen general y ocultar la imagen espec�fica
            imagenGeneral.enabled = true;
            imagenEspecifica.enabled = false;
        }
    }
}
