//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BlockDictionaryGenerator : MonoBehaviour
//{
    
//    public int width = 32;
//    public int length = 32;
//    public int height = 0; 

//    Dictionary<Vector3, string> worldDictionary = new Dictionary<Vector3, string>();

//    // Start is called before the first frame update
//    void Start()
//    {
//        GenerateBlocks();
//    }

//    void GenerateBlocks()
//    {
//        for (int x = 0; x < width; x++)
//        {
//            for (int z = 0; z < length; z++)
//            {

//                for (int y = 0; y < height; y++)
//                {
//                    Vector3 position = new Vector3(x, y, z);
//                    string blockName = DetermineBlockName(x, y, z);
//                    worldDictionary.Add(position, blockName);
//                }
              
//            }
//        }

//        foreach (KeyValuePair<Vector3, string> entry in worldDictionary)
//        {
//            if(KeyValuePair.Value == "dirt")
//            {
//                Instantiate(dirtPrefab, KeyValuePair.key, Quaternion.identity);
//            }
//            //Debug.Log($"Position: {entry.Key} - Block: {entry.Value}");
//        }
//    }

//    string DetermineBlockName(int x, int y, int z)
//    {
//        // Example logic to determine block name based on position
//        if (y == 0)
//        {
//            return "Bedrock";
//        }
//        else if (y < 2)
//        {
//            return "Stone";
//        }
//        else
//        {
//            return "Dirt";
//        }
//    }
//}
