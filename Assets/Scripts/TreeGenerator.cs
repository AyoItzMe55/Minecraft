using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    [SerializeField] GameObject trunkPrefab;
    [SerializeField] GameObject leafPrefab;

    // Start is called before the first frame update
    void Start()
    {

        int x, y, z;
        x = Random.Range(-40, 40);
        y = 0;
        z= Random.Range(-40, 40);

        for (int i = 0; i < 30; i++)
        {
            GrowTree(new Vector3Int(x, y, z));
        }


        Vector3Int growPos = new Vector3Int(9, 0, -2);
        GameObject tree = new GameObject("Tree");
        tree.transform.position = growPos;

        int height = Random.Range(5, 15);
        Vector3Int[] branchDirections = { Vector3Int.forward, Vector3Int.right, Vector3Int.back, Vector3Int.left };

        for (int i = 0; i < height; i++)
        {
            Instantiate(trunkPrefab, growPos, Quaternion.identity, tree.transform);
            growPos += Vector3Int.up;
            
            // chance for branch growth
            if (Random.Range(0f, 1f) > .6f)
            {
                Vector3Int branchPos = growPos;
                Debug.Log("Branching!");

                // 0 - forward, 1 - right, 2 - back, 3 - left
                Vector3Int branchDir = branchDirections[Random.Range(0, 4)];
                int branchLength = Random.Range(1, 5);

                while (branchLength > 0)
                {
                    branchPos += branchDir;
                    Instantiate(trunkPrefab, branchPos, Quaternion.identity, tree.transform);
                    branchLength--;
                }
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GrowTree(Vector3Int pos)
    {
        Vector3Int growPos = pos;
        GameObject tree = new GameObject("Tree");
        tree.transform.position = growPos;

        int height = Random.Range(5, 15);
        Vector3Int[] branchDirections = { Vector3Int.forward, Vector3Int.right, Vector3Int.back, Vector3Int.left };
    }

}
