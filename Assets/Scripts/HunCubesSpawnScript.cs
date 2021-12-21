using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunCubesSpawnScript : MonoBehaviour
{
    public GameObject thingToClone;
    public Transform SpawnPoint1;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++)
        {
            Instantiate(thingToClone, SpawnPoint1.position + Random.insideUnitSphere * 5, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
