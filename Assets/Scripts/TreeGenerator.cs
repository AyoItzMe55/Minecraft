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

        int x;
        int y;
        int z;


        for (int i = 0; i < 30; i++)
        {
            x = Random.Range(-40, 40);
            y = 0;
            z = Random.Range(-40, 40);
            GrowTree(new Vector3Int(x, y, z));
        }


        Vector3Int growPos = new Vector3Int(9, 0, -2);
        Vector3Int leafGrowPos = new Vector3Int(10, 1, -1);
       // Vector3Int leafPos = leafGrowPos;
        GameObject tree = new GameObject("Tree");
        GameObject leaf = new GameObject("Leaf");
        tree.transform.position = growPos;
        leaf.transform.position = leafGrowPos;
        int amount = Random.Range(1, 3);


        int height = Random.Range(5, 10);
        Vector3Int[] branchDirections = { Vector3Int.forward, Vector3Int.right, Vector3Int.back, Vector3Int.left };
        Vector3Int[] leafDirections = { Vector3Int.forward, Vector3Int.right, Vector3Int.back, Vector3Int.left };

        

        for (int i = 0; i < height; i++)
        {
            Instantiate(trunkPrefab, growPos, Quaternion.identity, tree.transform);
            growPos += Vector3Int.up;
            
            // chance for branch growth
            if (Random.Range(0f, 1f) > .2f)
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


            if (Random.Range(0f, 1f) > 0.5f)//has a 50% chance to spawn another set of leaves
            {
                Vector3Int leafDir = GetRandomDirection();
                int leafLength = Random.Range(1, 5); // leaf length is between 1 and 5

                for (int g = 0; g < leafLength; g++) // k being used instead of "g" cuz "g" already used
                {
                    Vector3Int leafPos = growPos + leafDir * g; // Adjust position for each leaf

                    // Instantiate leafPrefab at leafPos
                    Instantiate(leafPrefab, leafPos, Quaternion.identity);
                }
            }
        }
    }

   
    Vector3Int GetRandomDirection()
    {
        Vector3Int[] directions = { Vector3Int.up, Vector3Int.forward, Vector3Int.back, Vector3Int.right, Vector3Int.left };
        return directions[Random.Range(0, 4)];
        // a list of all directions then randomly selects which directions from the list (vectors are automatically labeled 0-4
 
    }
        

            //for (int g = 0; g < 5; g++)
            //{
    
            //    Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
            //    leafPos = leafPos + Vector3Int.left*amount;
            //    Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
            //    leafPos = leafPos + Vector3Int.right*amount*2;
            //    Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
            //    leafPos = leafPos + Vector3Int.left*amount;
            //    leafPos = leafPos + Vector3Int.back*amount;
            //    Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
            //    leafPos = leafPos + Vector3Int.forward*amount*2;
            //    Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
            //    leafPos = leafPos + Vector3Int.back*amount;
            //    Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);
            //    leafPos = leafPos + Vector3Int.up * amount;


            //}
    //        if (Random.Range(0, 1) > .8f)
    //        {

    //            //      Vector3Int leafPos = leafGrowPos;

    //            Vector3Int leafDir = leafDirections[Random.Range(0, 4)];
    //            int leafLength = Random.Range(1, 5);

    //            if (leafLength > 0)
    //            {
    //                leafPos += leafDir;
    //                Instantiate(leafPrefab, leafPos, Quaternion.identity, leaf.transform);

    //                leafPos = leafPos + Vector3Int.up;
    //                leafPos = leafPos + Vector3Int.left;
    //                leafPos = leafPos + Vector3Int.right;
    //                leafPos = leafPos + Vector3Int.back;
    //                leafPos = leafPos + Vector3Int.forward;
    //                leafLength--;
    //            }
    //            //    branchPos + Vector3.up * 2; 

    //        }
    //    }
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    void GrowTree(Vector3Int pos)
    {
        Vector3Int growPos = pos;
        GameObject tree = new GameObject("Tree");
        tree.transform.position = growPos;

        int height = Random.Range(5, 15);
        Vector3Int[] branchDirections = { Vector3Int.forward, Vector3Int.right, Vector3Int.back, Vector3Int.left };
    }

    // instantiate branch pos + vector3.up (.down   .right   .left)

}

