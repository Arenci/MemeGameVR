using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision00 : MonoBehaviour
{
    // Start is called before the first frame update
    int count;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Diana"))
        {
            Destroy(other.gameObject);
            count++;

            if (count == 4)
            {
                SceneManager.LoadScene("01");
            }
        }
    }
}
