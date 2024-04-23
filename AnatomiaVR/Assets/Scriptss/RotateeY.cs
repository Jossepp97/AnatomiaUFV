using UnityEngine;

public class RotacionInfinitaY : MonoBehaviour {

    void Update()
    {
        // Rotar el objeto en torno al eje X
        transform.Rotate(new Vector3(0f, 30f, 0f)* Time.deltaTime);
    }
}