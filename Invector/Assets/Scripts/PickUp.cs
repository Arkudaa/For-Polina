using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public AudioSource coinmusic;
    public int score;
    public Text scoreText;
    public GameObject winText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            score++;
            scoreText.text = "Score: " + score;
            coinmusic.Play();
            
        }

        if (collision.gameObject.tag == "danger")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "finish")
        {
            winText.SetActive(true);
        }
    }


}
