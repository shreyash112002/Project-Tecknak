using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;
//using Prototype.NetworkLobby;


public class Spawners : MonoBehaviour
{
    [SerializeField] GameObject[] Blocksprefab;
    [SerializeField] float secondSpawn=0.5f;
    [SerializeField] float minTras;
   [SerializeField] float maxTras;
    void Start()
    {
        StartCoroutine(BlockSpawn());
    }
     IEnumerator BlockSpawn()
     {
         while (true)
         {
              var wanted= Random.Range(minTras,maxTras);
              var position = new Vector3(wanted,transform.position.x);
              GameObject gameObject = Instantiate(Blocksprefab[Random.Range(0,Blocksprefab.Length)],position,Quaternion.identity);
              yield return new WaitForSeconds(secondSpawn);
              Destroy(gameObject,5f);
         }
     }

   
}
