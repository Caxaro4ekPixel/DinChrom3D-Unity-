using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameVol : MonoBehaviour
{
    public GameObject ScrollBar;
    public AudioSource audio;
    void Start()
    {
        ScrollBar.GetComponent<Scrollbar>().value = PlayerPrefs.GetFloat("GameVolLavel");
    }
    void Update()
    {
        PlayerPrefs.SetFloat("GameVolLavel", ScrollBar.gameObject.GetComponent<Scrollbar>().value);
        audio.volume = PlayerPrefs.GetFloat("GameVolLavel");
    }
}
