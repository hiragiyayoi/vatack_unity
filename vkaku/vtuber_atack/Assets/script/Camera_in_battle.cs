using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_in_battle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coordinate();
    }

    public void coordinate() 
    {
        Vector3 tmp = GameObject.FindGameObjectWithTag("Player").transform.position;

    }
}
