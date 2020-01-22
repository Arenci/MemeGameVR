using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 up = new Vector3(transform.position.x + 0.2f, transform.position.y + 0.2f, transform.position.z);
        Vector3 down = new Vector3(transform.position.x - 0.2f, transform.position.y - 0.2f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y + 0.2f, transform.position.z);

       

        

    }


}
