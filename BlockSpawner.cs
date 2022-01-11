using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject block_Prefab;
     
  
    public void SpawnBlock()
    {
        GameObject block_obj =Instantiate(block_Prefab);
        block_obj.transform.position=transform.position;
    }
    
}
