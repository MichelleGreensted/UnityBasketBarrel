using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketballScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float forceStrength;
    public GameObject thingToClone;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawn a cube 
            GameObject clone = Instantiate(thingToClone, transform.position+transform.forward*1.5f, Quaternion.identity);
            //throw the cube           
            Rigidbody rb = clone.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * forceStrength+Vector3.up*forceStrength*0.5f, ForceMode.Impulse);
        }
    }
}
