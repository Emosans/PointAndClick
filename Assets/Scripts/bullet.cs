using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 1f;
    //public CameraShake cameraShake;
    void Awake()
    {
        Destroy(gameObject,life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //StartCoroutine(cameraShake.Shake(.14f, .2f));
            collision.gameObject.SetActive(false);
        }
    }
}
