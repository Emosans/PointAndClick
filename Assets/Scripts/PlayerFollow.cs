using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject Player;
    public CameraShake cameraShake;
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, Player.transform.position, 10f * Time.deltaTime);
    }

    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collided");
            StartCoroutine(cameraShake.Shake(.14f, .5f));
        }
    }

}
