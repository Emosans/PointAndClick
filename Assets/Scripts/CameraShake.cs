using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Transform MainCamera;

    private void Start()
    {
        MainCamera = Camera.main.transform;
    }

    public IEnumerator Shake(float duration,float magnitude)
    {
        Vector3 originalPos = MainCamera.localPosition;

        float elapsedTime = 0.0f;

        while ((elapsedTime < duration))
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            MainCamera.localPosition = new Vector3(x, y, originalPos.z);

            elapsedTime += Time.deltaTime;

            yield return null;
        }
         MainCamera.localPosition = originalPos;
    }
}
