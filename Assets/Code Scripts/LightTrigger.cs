using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightTrigger : MonoBehaviour
{
    public Light2D playerLight;
    // Start is called before the first frame update
    void Start()
    {
        playerLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Trigger1")
        {
            playerLight.enabled = true;
        }
        if (collision.gameObject.tag == "Trigger2")
        {
            playerLight.enabled = false;
        }
    }
}
