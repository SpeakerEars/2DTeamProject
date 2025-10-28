using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IteamDeathAnim : MonoBehaviour
{
    public float delay = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delay); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
