using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SpawnObjects : MonoBehaviour
{
    public GameObject emptyObjectPrefab; // Prefab para el objeto vacío
    public Transform spawnPoint; // Transform para la posición de generación
    public Dropdown dropdown; // Referencia al Dropdown en la UI
    public Button spawnButton; // Referencia al botón para generar objetos

    private void Start()
    {
        // Inicializa las opciones del Dropdown
        dropdown.ClearOptions();
        dropdown.AddOptions(new List<string> { "Opción 1", "Opción 2", "Opción 3", "Opción 4", "Opción 5", "Opción 6" });

        // Agrega un listener al botón de generación
        spawnButton.onClick.AddListener(SpawnEmptyObject);
    }

    private void SpawnEmptyObject()
    {
        // Obtiene la opción seleccionada del Dropdown
        int selectedIndex = dropdown.value;

        // Instancia un objeto vacío en la posición de generación
        GameObject emptyObject = Instantiate(emptyObjectPrefab, spawnPoint.position, Quaternion.identity);

        // Asigna un nombre al objeto vacío basado en la opción seleccionada
        emptyObject.name = $"ObjetoVacio_{selectedIndex + 1}";
    }
}
