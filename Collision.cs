using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.CompareTag("Damage"))
      {
          DoDamageToPlayer();
      }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Damage"))
      {
          DoDamageToPlayer();
      }
    }
    void DoDamageToPlayer()
    {
        Debug.Log("Hit!");
    }
}
