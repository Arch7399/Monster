using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [HideInInspector]
    public float speed;

    private Rigidbody2D myBody;
    // Start is called before the first frame update
    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision)
        {
            Destroy(collision.gameObject);
        }
    }
}
