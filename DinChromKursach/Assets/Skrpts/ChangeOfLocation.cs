using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOfLocation : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine("chengeLocation");
    }
    IEnumerator chengeLocation()
    {
        while (true)
        {
            int i = Random.Range(1, 3);
            switch (i)
            {
                case 1:
                    PlayerPrefs.SetInt("Location", 1);
                    break;
                case 2:
                    PlayerPrefs.SetInt("Location", 2);
                    break;
            }
            Debug.Log(i);
            yield return new WaitForSeconds(Random.Range(50, 100));
        }
    }
}
