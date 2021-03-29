using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerGameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Animator DieDinAnim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.IndexOf('o') > 0)
        {
            string s = PlayerPrefs.GetString("RecordList");
            s = s + " " + Convert.ToString(PlayerPrefs.GetFloat("Record"));
            PlayerPrefs.SetString("RecordList",s);

            PlayerPrefs.SetFloat("Speed", 0f);
            this.gameObject.GetComponent<JampRex>().enabled = false;
            DieDinAnim.speed = 1f;
            DieDinAnim.SetBool("Die1", true);
            gameOverPanel.SetActive(true);
            //Time.timeScale = 0;
        }
    }
}
