using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulation : MonoBehaviour
{
    float timeCounter = 0;
    float speed;
    float width;
    float height;
    bool flag = true;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
        width = 2;
        height = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag){ timeCounter -= Time.deltaTime;
        float x = Mathf.Cos(timeCounter) * width;
        float y = Mathf.Sin(timeCounter) * height;
        float z = 0f;
        transform.position = new Vector3(x, y, z);
    }
    else{  timeCounter += Time.deltaTime;
        float x = Mathf.Cos(timeCounter) * width;
    float y = Mathf.Sin(timeCounter) * height;
    float z = 0f;
    transform.position = new Vector3(x, y, z);
}
      

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            flag = false;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            flag = true;   
        }
        
    }
}
