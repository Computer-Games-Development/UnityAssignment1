using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class Heart : MonoBehaviour
{


    float a =10F;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {if (a ==9F) { a =10F;
            Thread.Sleep(800);
        }
        else { a = 9F;
            Thread.Sleep(250);
        }
        
        transform.localScale = new Vector3(a, a, a);
        
       
       
    }
}
