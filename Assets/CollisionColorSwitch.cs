using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionColorSwitch : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

        //Get the Renderer component from the new cube
        var cubeRenderer = gameObject.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to white
        cubeRenderer.material.SetColor("_Color", Color.white);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter()
    {
        //Get the Renderer component from the new cube
        var cubeRenderer = gameObject.GetComponent<Renderer>();

        cubeRenderer.material.SetColor("_Color", Color.red);
    }
}
