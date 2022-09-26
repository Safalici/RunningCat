using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake2 : MonoBehaviour
{
    public Camera Camera2;

    float shakeAmount = 0;

    
    public void Shake(float amt, float length)
    {
        shakeAmount = amt;
        InvokeRepeating("BeginShake", 0, 0.01f);
        Invoke("StopShake", length);

    }
    

    void BeginShake()
    {
        if (shakeAmount > 0)
        {
            Vector3 camPos = Camera2.transform.position;
            float offsetx = Random.value * shakeAmount * 2 - shakeAmount;
            float offsetY = Random.value * shakeAmount * 2 - shakeAmount;
            camPos.x += offsetx;
            camPos.y += offsetY;

            Camera2.transform.position = camPos;
        }
    }
    void StopShake()
    {
        CancelInvoke("BeginShake");
        Camera2.transform.localPosition = Vector3.zero;
    }
}
