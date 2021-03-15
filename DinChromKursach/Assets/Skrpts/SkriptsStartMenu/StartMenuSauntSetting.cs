using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenuSauntSetting : MonoBehaviour
{
    public GameObject ScrollBur;
    public AudioSource audio;
    void Start()
    {
        ScrollBur.GetComponent<Scrollbar>().value = PlayerPrefs.GetFloat("StartVolLavel");
    }
    void Update()
    {
        PlayerPrefs.SetFloat("StartVolLavel",ScrollBur.gameObject.GetComponent<Scrollbar>().value);
        audio.volume = PlayerPrefs.GetFloat("StartVolLavel");
    }
}
