using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField]
    private GameObject pos1;
    [SerializeField]
    private GameObject pos2;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveAtoB(pos1, pos2 ,speed));
    }
    IEnumerator MoveAtoB(GameObject gameobjectA , GameObject gameobjectB , float speedTranslation)
    {
        while(gameobjectA.transform.position!= gameobjectB.transform.position)
        {
            gameobjectA.transform.position = Vector3.MoveTowards(gameobjectA.transform.position ,gameobjectB.transform.position, speedTranslation *Time.deltaTime);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
