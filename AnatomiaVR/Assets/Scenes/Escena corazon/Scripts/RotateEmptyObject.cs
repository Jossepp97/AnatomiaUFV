using UnityEngine;
using UnityEngine.UI;

public class RotateEmptyObject : MonoBehaviour
{
    [SerializeField] private GameObject emptyObject; // Referencia al objeto vac�o
    [SerializeField] private Slider rotationSlider; // Referencia al Slider en el inspector

    private void Update()
    {
        // Obtiene el valor del Slider (de 0 a 1)
        float rotationValue = rotationSlider.value;

        // Rota el objeto vac�o en el eje Y (puedes ajustar el eje seg�n tus necesidades)
        emptyObject.transform.rotation = Quaternion.Euler(0f, rotationValue * 360f, 0f);
    }
}
