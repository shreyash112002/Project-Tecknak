using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform target;
    public Transform bg1;
    public Transform bg2;
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        size = bg1.GetComponent<BoxCollider2D>().size.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetPos = new Vector3(target.position.x ,target.position.y,target.position.z);
        transform.position = Vector3.Lerp(transform.position, targetPos, 0.2f);
        if(transform.position.y >= bg2.position.y)
        {
            bg1.position = new Vector3(bg1.position.x , bg2.position.y + size, bg1.position.z);
            SwitchBg();
        }
    }

    public void  SwitchBg()
    {
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;
    }
}
