using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BossDeathSpawnPortal : MonoBehaviour
{
    public string targetTag = "Boss";
    public GameObject Boss;
    public GameObject background;
    public GameObject prefab;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(targetTag);
        if (taggedObjects.Length <= 0)
        {
            Destroy(background);
            timer += Time.deltaTime;
            //This is going to be wonky, BUT CHANGE "transform.position" to the ACTUAL PLACE you want your portal. If you don't, It will just spawn on the player
            if (timer > 3)
            {
                Instantiate(prefab, transform.position, Quaternion.identity);
            }
        }
    }
}
