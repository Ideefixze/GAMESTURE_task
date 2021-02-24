using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script providing "set active to false after chosen time" functionality.
/// </summary>
public class TimedLife : MonoBehaviour
{
    /// <summary>
    /// Starts a Coroutine that makes object disabled after choosen interval of time.
    /// </summary>
    /// <param name="time">Time in seconds to wait before disabling</param>
    public void StartTimedLife(float time)
    {
        gameObject.SetActive(true);
        StopAllCoroutines(); //Stops previous Coroutines for maintaining time of TimedLife
        StartCoroutine(Disappear(time));
    }

    /// <summary>
    /// Coroutine that makes object disabled after choosen interval of time.
    /// </summary>
    /// <param name="time">Time in seconds to wait before disabling</param>
    /// <returns></returns>
    private IEnumerator Disappear(float time)
    {
        yield return new WaitForSeconds(time);
        gameObject.SetActive(false);
        yield return null;
    }
}
