using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class RecordSpeedTimer : MonoBehaviour
{
    public GameObject text;

    static int timer;
    static float GlobalSpeed;
    static bool _chekTimer = false;
    void Start()
    {
        timer = 0;
        PlayerPrefs.SetFloat("Speed", 5f);
        GlobalSpeed = PlayerPrefs.GetFloat("Speed");
        StartCoroutine("Timer");
    }
    private void Update()
    {
        PlayerPrefs.SetFloat("Record", timer);

        text.gameObject.GetComponent<Text>().text = "Record: " + timer + " Speed: " + GlobalSpeed;
        if (_chekTimer)
        {
            _chekTimer = false;
            GlobalSpeed = PlayerPrefs.GetFloat("Speed");
            GlobalSpeed++;
            PlayerPrefs.SetFloat("Speed", GlobalSpeed);
        }
    }
    IEnumerator Timer()
    {
        while (true)
        {
            timer++;
            if (timer % 50 == 0)
                _chekTimer = true;
            yield return new WaitForSeconds(1f);
        }
    }
}
