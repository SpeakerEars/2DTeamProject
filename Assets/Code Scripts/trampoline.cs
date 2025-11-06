using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampoline : MonoBehaviour
{
    public float bouncingPower = 32;

    [SerializeField] private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject)
        {
            rb.velocity = new Vector2(rb.velocity.x, bouncingPower);

        }
    }
}
