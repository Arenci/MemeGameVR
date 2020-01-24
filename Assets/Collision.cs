using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    AudioSource limiMiss;
    AudioSource limiHit;
    AudioSource estebanMiss;
    AudioSource estebanHit;
    AudioSource carlosMiss;
    AudioSource carlosHit;
    AudioSource victorMiss;
    AudioSource victorHit;
    int count;
    public Camera camera;
    void Start()
    {
        AudioSource[] audios = camera.GetComponents<AudioSource>();
        limiMiss = audios[0];
        limiHit = audios[1];
        estebanMiss = audios[2];
        estebanHit = audios[3];
        carlosMiss = audios[4];
        carlosHit = audios[5];
        victorMiss = audios[6];
        victorHit = audios[7];
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 8)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }


    private void OnCollisionEnter(UnityEngine.Collision other)
    {
        
        if (other.gameObject.CompareTag("Limi"))
        {
            limiHit.volume = 0.5f;
            limiHit.Play();
            Destroy(other.gameObject);
            count++;
        }
        if (other.gameObject.CompareTag("Carlos"))
        {
            carlosHit.volume = 0.5f;
            carlosHit.Play();
            Destroy(other.gameObject);
            count++;
        }
        if (other.gameObject.CompareTag("Víctor"))
        {
            victorHit.volume = 0.5f;
            victorHit.Play();
            Destroy(other.gameObject);
            count++;
        }
        if (other.gameObject.CompareTag("Esteban"))
        {
            estebanHit.volume = 0.5f;
            estebanHit.Play();
            Destroy(other.gameObject);
            count++;
        }
        if (other.gameObject.CompareTag("LimiWall"))
        {
            limiMiss.volume = 0.5f;
            limiMiss.Play();
        }
        if (other.gameObject.CompareTag("VictorWall"))
        {
            victorMiss.volume = 0.5f;
            victorMiss.Play();
        }
        if (other.gameObject.CompareTag("EstebanWall"))
        {
            estebanMiss.volume = 0.5f;
            estebanMiss.Play();
        }
        if (other.gameObject.CompareTag("CarlosWall"))
        {
            carlosMiss.volume = 0.5f;
            carlosMiss.Play();
        }
        



    }
}
