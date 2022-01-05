using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionSensorScript : MonoBehaviour
{
    public float Score;
    public Text ScoreText;
    public List<Material> Materials;
    public AudioClip BasketSuccessSound;
    public AudioSource AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score:" + Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    T getRandomElement<T>(List<T> MaterialsList)
    {
        int index = Random.Range(0, MaterialsList.Count);
        return MaterialsList[index];
    }
    private void OnTriggerEnter(Collider other)
    {
        Score++;
        ScoreText.text = "Score:" + Score;
        other.gameObject.GetComponent<MeshRenderer>().material = getRandomElement(Materials);
        Debug.Log(Score);
        //Destroy(other.gameObject);
        AudioSource.PlayOneShot(BasketSuccessSound);
    }
}
