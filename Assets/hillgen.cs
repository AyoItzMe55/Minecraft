using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hillGen : MonoBehaviour
{
    [SerializeField] GameObject hillPrefab;
    //public GameObject hillPrefab; // hill prefab to this in the inspector
    public int width = 32;
    public int length = 32;
    public int placementHeight = 0; // y axis (i think)

    // Start is called before the first frame update
    void Start()
    {
        PlaceAndRotateHill();
    }

    void PlaceAndRotateHill()
    {
        // random position in chunk
        int x = Random.Range(0, length);
        int z = Random.Range(0, width);
        Vector3 position = new Vector3(x, placementHeight, z);

        // random rotation using Quaternion.Euler
        Quaternion rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

        Instantiate(hillPrefab, position, rotation);
    }
}
