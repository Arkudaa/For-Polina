using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nebo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test"); 
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 5);
    }
}
