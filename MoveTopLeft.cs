using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTopLeft : MonoBehaviour
{
    public float movementSpeed = 10;
 
    private Rigidbody rb;
    private Vector3 endPosition = new Vector3(-8, 0, -8);
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
 
    // Update is called once per frame
    void Update() {
        if(transform.position != endPosition) {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);
        }
    }
}
