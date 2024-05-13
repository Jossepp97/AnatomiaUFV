using UnityEngine;

public class ObjectAppearDisappear : MonoBehaviour
{
    [SerializeField] private GameObject emptyObject; // Referencia al objeto vacío

    private bool isVisible = true;

    private void Start()
    {
        // Asegúrate de que el objeto esté inicialmente visible
        emptyObject.SetActive(isVisible);
    }

    public void ToggleVisibility()
    {
        // Cambia la visibilidad del objeto
        isVisible = !isVisible;
        emptyObject.SetActive(isVisible);
    }
}
