using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motion : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
       if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }
       if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
       if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
       if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }
}
