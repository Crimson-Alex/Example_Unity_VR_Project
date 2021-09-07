using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundObject : MonoBehaviour
{

    public GameObject target;
    private int direction;


    // Start is called before the first frame update
    void Start()
    {
        direction = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, Vector3.up, direction*60 * Time.deltaTime);
    }

    void OnCollisionEnter()
    {
        direction *= -1;
    }
}
