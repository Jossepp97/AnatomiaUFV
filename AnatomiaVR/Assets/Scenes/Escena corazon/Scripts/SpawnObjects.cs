using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SpawnObjects : MonoBehaviour
{
    public GameObject emptyObjectPrefab; // Prefab para el objeto vac�o
    public Transform spawnPoint; // Transform para la posici�n de generaci�n
    public Dropdown dropdown; // Referencia al Dropdown en la UI
    public Button spawnButton; // Referencia al bot�n para generar objetos

    private void Start()
    {
        // Inicializa las opciones del Dropdown
        dropdown.ClearOptions();
        dropdown.AddOptions(new List<string> { "Opci�n 1", "Opci�n 2", "Opci�n 3", "Opci�n 4", "Opci�n 5", "Opci�n 6" });

        // Agrega un listener al bot�n de generaci�n
        spawnButton.onClick.AddListener(SpawnEmptyObject);
    }

    private void SpawnEmptyObject()
    {
        // Obtiene la opci�n seleccionada del Dropdown
        int selectedIndex = dropdown.value;

        // Instancia un objeto vac�o en la posici�n de generaci�n
        GameObject emptyObject = Instantiate(emptyObjectPrefab, spawnPoint.position, Quaternion.identity);

        // Asigna un nombre al objeto vac�o basado en la opci�n seleccionada
        emptyObject.name = $"ObjetoVacio_{selectedIndex + 1}";
    }
}
