using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRAAdvancedUIInteractionDemo : MonoBehaviour
{
    [SerializeField] private PrimitiveType[] primitiveTypes = { PrimitiveType.Cube, PrimitiveType.Sphere, PrimitiveType.Cylinder, PrimitiveType.Capsule };
    [SerializeField] private Vector3 spawnPosition = new Vector3(1, 1.5f, 2);
    [SerializeField] private Vector3 spawnRotation = new Vector3(45, 45, 0);
    [SerializeField] private Vector3 spawnScale = new Vector3(0.35f, 0.35f, 0.35f);
    private List<GameObject> objs = new List<GameObject>();
    private int currentIndex = 0;

    // Agrega un campo p�blico para asignar los prefabs de los objetos vac�os en el Inspector
    public GameObject[] emptyObjectPrefabs;

    void Start()
    {
        GenerateObjs();
    }

    void GenerateObjs()
    {
        GameObject container = new GameObject("ObjectsContainer");
        for (int i = 0; i < primitiveTypes.Length; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(primitiveTypes[i]);
            obj.transform.parent = container.transform;
            obj.transform.position = spawnPosition;
            obj.transform.rotation = Quaternion.Euler(spawnRotation);
            obj.transform.localScale = spawnScale;
            obj.SetActive(false);
            objs.Add(obj);
        }
    }

    public void DisplayObj(bool state)
    {
        if (state)
        {
            objs[currentIndex].SetActive(false);
            currentIndex = (currentIndex + 1) % objs.Count;
            objs[currentIndex].SetActive(true);
        }
        else
        {
            objs[currentIndex].SetActive(false);
        }
    }

    // M�todo para instanciar el objeto vac�o correspondiente al bot�n
    public void InstantiateEmptyObject(int prefabIndex)
    {
        if (prefabIndex >= 0 && prefabIndex < emptyObjectPrefabs.Length)
        {
            // Calcula la posici�n ligeramente por encima de la posici�n original
            Vector3 spawnPos = spawnPosition + Vector3.up * 0.5f;
            Instantiate(emptyObjectPrefabs[prefabIndex], spawnPos, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("�Prefab del objeto vac�o no v�lido!");
        }
    }
}
