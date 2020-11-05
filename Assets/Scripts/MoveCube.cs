using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    float speed;
    float zlimit = 27.5f;

    bool hitBorder = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(5.0f,20.0f);

        if (transform.position.z < zlimit && hitBorder)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else if (transform.position.z > 1 && !hitBorder)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * -speed);
        }
        else
        {
            hitBorder = !hitBorder;
        }
    }
}
