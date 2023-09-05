using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus_move : MonoBehaviour
{
    // Gets the local scale of a game object
    Vector3 objectScale;
    float scale_add = 1.1f;
    int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        objectScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(scale_add>6)
        {
            flag = 1;
        }
        else if(scale_add<1.1)
        {
            flag = 0;
        }

        if(flag == 0)
        {
            transform.localScale = new Vector3(objectScale.x*scale_add,  objectScale.y*scale_add, objectScale.z*scale_add);
            scale_add += 0.1f;
            Debug.Log("scale:" + transform.localScale);
        }
        else
        {
            // Sets the local scale of game object
            transform.localScale = new Vector3(objectScale.x*scale_add,  objectScale.y*scale_add, objectScale.z*scale_add);
            scale_add -= 0.1f;
            Debug.Log("scale:" + transform.localScale);
        }
    }
}
