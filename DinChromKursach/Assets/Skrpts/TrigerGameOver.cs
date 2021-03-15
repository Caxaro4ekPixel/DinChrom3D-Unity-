using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerGameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.IndexOf('o') > 0)
        {
            string s = PlayerPrefs.GetString("RecordList");
            s = s + " " + Convert.ToString(PlayerPrefs.GetFloat("Record"));
            PlayerPrefs.SetString("RecordList",s);

            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
