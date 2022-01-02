using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePlayController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int maxPlatform=0;
     public static GamePlayController instance;
     public BlockSpawner block_Spawner;
  
    public void GameOver()
     {
         GameOverScreen.Setup(maxPlatform);
          }
   void Awake()
   {
       if(instance== null)
       instance=this;
   }
    // Start is called before the first frame update
    void Start()
    {
        block_Spawner.SpawnBlock();
       

         
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBlock()
    {
        Invoke("NewBlock",2f);
    }
    void NewBlock()
    {
        block_Spawner.SpawnBlock();
    }
}
