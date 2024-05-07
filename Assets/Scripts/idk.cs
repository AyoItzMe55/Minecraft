using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidBuilder : MonoBehaviour
{
    [SerializeField]
    private GameObject stonePrefab;

    private Dictionary<Vector3Int, int> pyramidStructure = new Dictionary<Vector3Int, int>()
    {
        { new Vector3Int(0, 0, 0), 7 },
        { new Vector3Int(1, 1, 1), 5 },
        { new Vector3Int(2, 2, 2), 3 }
    };

    private void Start()
    {
        foreach (KeyValuePair<Vector3Int, int> entry in pyramidStructure)
        {
            Vector3Int startPos = entry.Key;
            int size = entry.Value;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size - y; x++)
                {
                    for (int z = 0; z < size - y; z++)
                    {
                        Vector3Int spawnPos = startPos + new Vector3Int(x, y, z);
                        Instantiate(stonePrefab, spawnPos, Quaternion.identity);
                    }
                }
            }
        }
    }
}