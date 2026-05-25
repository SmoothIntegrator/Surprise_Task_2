using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapBullet : MonoBehaviour
{
    public float speed = 15f;
    private Vector2 moveDirection;
    private Transform player;

    public void Setup(Vector2 dir)
    {
        moveDirection = dir; 
        player = GameObject.FindGameObjectWithTag("Player").transform;
 
        Destroy(gameObject, 3f);
    }

    void Update()
    { 
        transform.position += (Vector3)(moveDirection * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Swappable"))
        { 
            Vector3 tempPos = player.position;
 
            player.position = other.transform.position;
 
            other.transform.position = tempPos;
 
            Destroy(gameObject);
        }
    }
}
