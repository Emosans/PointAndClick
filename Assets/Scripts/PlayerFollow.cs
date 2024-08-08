using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform Player;
    public CameraShake cameraShake;

    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
        cameraShake = Camera.main.GetComponent<CameraShake>();
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 10f * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("collided");
            StartCoroutine(cameraShake.Shake(.14f, .5f));


            collision.gameObject.SetActive(false);
        }
    }

}
