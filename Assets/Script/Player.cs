using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private Rigidbody2D plyRB;
    private bool canJump;
    public UnityEvent OnPlayerHitted;
    // Start is called before the first frame update
    void Start()
    {
        plyRB= GetComponent<Rigidbody2D>();
        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Jump();
        }

    }

    void Jump()
    {
        if (canJump) 
        {
            canJump = false;
            plyRB.velocity = new Vector2(0f, 7f);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "obstaculo") 
        {
            OnPlayerHitted.Invoke();
        }
      canJump= true;
    }
}
