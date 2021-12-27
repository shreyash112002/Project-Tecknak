using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
       /* Debug.Log(Input.GetAxisRaw("Vertical"));
        Vector3 moveposition = new Vector3(0f,Input.GetAxisRaw("Vertical"),0f);
        transform.position += moveposition * MoveSpeed* Time.deltaTime; */ 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
