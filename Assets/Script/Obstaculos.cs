using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    private Rigidbody2D obsRB; 
    // Start is called before the first frame update
    void Start()
    {
        obsRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        obsRB.velocity = new Vector2(-5f, 0f);
    }
}
