using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeCor : MonoBehaviour
{
    [SerializeField] private Renderer rend;
    [SerializeField] private float WaitTime = 1.0f;
    [SerializeField] private float fadeSpeed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Fade());
        }
    }

    IEnumerator Fade()
    {
        for (float ft = 1f; ft >= 0; ft -= fadeSpeed)
        {
            Color c = rend.material.color;
            c.a = ft;
            rend.material.color = c;
            yield return null;
        }
    }
}
