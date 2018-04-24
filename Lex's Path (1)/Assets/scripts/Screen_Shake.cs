using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen_Shake : MonoBehaviour
{
    public static float shakeTimer;
    float shakeAmount = 0.2f;
    public static Vector3 originalCameraPos = new Vector3(0f, 0f, -10f);
    Vector3 originalCameraRot = new Vector3(0f, 0f, 0f);
    public static bool shakeScreen = false;
    public static bool playOnce = false;

    // Use this for initialization
    void Start()
    {
        originalCameraPos = new Vector3(0, 0, -10);

    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (playOnce)
        {
            // swallowSound.Play();
            playOnce = false;
        }
        if (shakeScreen)
        {
            //shake the screen
            //Camera.main.transform.localPosition  = new Vector3(gameObject.transform.position.x + Random.value * shakeTimer * shakeAmount, 
            //	gameObject.transform.position.y + Random.value * shakeTimer * shakeAmount, 
            //	gameObject.transform.position.z + Random.value * shakeTimer * shakeAmount);

            transform.localPosition = originalCameraPos + new Vector3(Random.value * shakeTimer * shakeAmount,
                Random.value * shakeTimer * shakeAmount,
                -10);
        }
        else
        {
            transform.localPosition = originalCameraPos; // new Vector3(0,0,-20f);
                                                         // transform.localPosition  = new Vector3(transform.localPosition.x,transform.localPosition.y,-20f);
        }

        if (shakeTimer > 0)
        {
            shakeTimer -= Time.unscaledDeltaTime;
            if (shakeTimer < 0) shakeTimer = 0;
        }


    }
}



