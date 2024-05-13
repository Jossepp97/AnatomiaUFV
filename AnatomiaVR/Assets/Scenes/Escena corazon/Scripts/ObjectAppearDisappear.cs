using UnityEngine;

public class ObjectAppearDisappear : MonoBehaviour
{
    [SerializeField] private GameObject emptyObject; // Referencia al objeto vac�o

    private bool isVisible = true;

    private void Start()
    {
        // Aseg�rate de que el objeto est� inicialmente visible
        emptyObject.SetActive(isVisible);
    }

    public void ToggleVisibility()
    {
        // Cambia la visibilidad del objeto
        isVisible = !isVisible;
        emptyObject.SetActive(isVisible);
    }
}
