using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLife : MonoBehaviour
{
    public void StartTimedLife(float time)
    {
        gameObject.SetActive(true);
        StopAllCoroutines(); //Stops previous Coroutines for maintaining time of TimedLife
        StartCoroutine(Disappear(time));
    }
    
    private IEnumerator Disappear(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
        yield return null;
    }
}
