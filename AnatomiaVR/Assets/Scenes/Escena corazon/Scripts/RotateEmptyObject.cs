using UnityEngine;
using UnityEngine.UI;

public class RotateEmptyObject : MonoBehaviour
{
    [SerializeField] private GameObject emptyObject; // Referencia al objeto vacío
    [SerializeField] private Slider rotationSlider; // Referencia al Slider en el inspector

    private void Update()
    {
        // Obtiene el valor del Slider (de 0 a 1)
        float rotationValue = rotationSlider.value;

        // Rota el objeto vacío en el eje Y (puedes ajustar el eje según tus necesidades)
        emptyObject.transform.rotation = Quaternion.Euler(0f, rotationValue * 360f, 0f);
    }
}
