using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup1 : MonoBehaviour
{
    public AudioSource coinmusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            coinmusic.Play();
        }

        if (collision.gameObject.tag == "danger")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        
    }
}
