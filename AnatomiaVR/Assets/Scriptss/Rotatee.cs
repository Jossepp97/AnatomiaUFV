using UnityEngine;

public class RotacionInfinita : MonoBehaviour
{
    // Velocidad de rotación
    public float velocidadRotacion = 30f;

    void Update()
    {
        // Rotar el objeto en torno al eje X
        transform.Rotate(new Vector3(0f, 0f, 30f)* Time.deltaTime);
    }
}