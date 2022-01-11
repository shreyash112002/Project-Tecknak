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
        
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveposition = new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f);
        transform.position += moveposition * MoveSpeed* Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0f,8f),ForceMode2D.Impulse);
        } 
    }
}
