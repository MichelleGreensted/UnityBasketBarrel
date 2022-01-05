using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstLevelScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstLevel", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LoadFirstLevel()
    {
        Debug.Log("First level would load");
        SceneManager.LoadScene("BasketballScene");
    }
}
