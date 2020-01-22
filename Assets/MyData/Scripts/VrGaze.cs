using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VrGaze : MonoBehaviour
{

    public Image imgGaze;
    private float totalTime ;
    public GameObject player;
    bool gvrStatus;
    float gvrTimer;
    public Camera camera;
    private int distanceOfRay = 40;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        totalTime = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            imgGaze.fillAmount = gvrTimer / totalTime;
        }

        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));

        if (Physics.Raycast(ray, out hit, distanceOfRay))
        {

            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("Teleport"))
            {
                Debug.Log("Llego");
                hit.transform.gameObject.GetComponent<TP>().TeleportPlayer();
            }
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("Ball"))
            {
                hit.transform.gameObject.GetComponent<GrabBall>().GrabBall1();
            }
            if (imgGaze.fillAmount == 1 && hit.transform.CompareTag("Limi") || imgGaze.fillAmount == 1 && hit.transform.CompareTag("Carlos") || imgGaze.fillAmount == 1 && hit.transform.CompareTag("Esteban") || imgGaze.fillAmount == 1 && hit.transform.CompareTag("Víctor") || imgGaze.fillAmount == 1 && hit.transform.CompareTag("Diana"))
            {
                hit.transform.gameObject.GetComponent<Shoot>().LaunchBall();
                
            }
        }
    }

    public void GVROn()
    {
        gvrStatus = true;
    }

    public void GVROff()
    {
        gvrStatus = false;
        gvrTimer = 0;
        imgGaze.fillAmount = 0;
    }
}
