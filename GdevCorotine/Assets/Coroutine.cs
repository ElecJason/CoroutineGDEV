using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Ik start nu de coroutine");
        StartCoroutine(Wait());
    }
    
    IEnumerator Wait()
    {
        for(int i = 0; i<10; i++)
        {
            Debug.Log("Coroutine update");
            yield return new WaitForSeconds(.5f);
        }
        Debug.Log("Coroutine einde");
    }
}
