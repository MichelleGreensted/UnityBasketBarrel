using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Destroy(gameObject);
        Instantiate(gameObject, Random.insideUnitSphere * 5, Quaternion.identity);
    }
}
