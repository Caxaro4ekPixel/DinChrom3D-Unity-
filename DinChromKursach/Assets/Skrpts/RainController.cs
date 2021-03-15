using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainController : MonoBehaviour
{
    public GameObject rainPartic;
    void Start()
    {
        StartCoroutine("rain");
    }
    IEnumerator rain()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(50, 200));
            rainPartic.SetActive(true);
            StopRain();
        }
    }
    void StopRain()
    {
        new WaitForSeconds(Random.Range(20, 40));
        rainPartic.SetActive(false);
    }
}
