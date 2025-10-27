using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerOpacity : MonoBehaviour
{
    public GameObject CircusFront;
    public SpriteRenderer CircusSprite;
    // Start is called before the first frame update
    void Start()
    {
        GameObject CircusFront = GameObject.FindGameObjectWithTag("Opacity effect");
        if (CircusFront != null)
        {
            SpriteRenderer CircusSprite = CircusFront.GetComponent<SpriteRenderer>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trigger1")
        {
            CircusSprite.enabled = false;
        }
        if (collision.gameObject.tag == "Trigger2")
        {
            CircusSprite.enabled = true;
        }
    }
}
