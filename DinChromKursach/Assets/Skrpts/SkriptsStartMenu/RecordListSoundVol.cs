using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordListSoundVol : MonoBehaviour
{
    public GameObject ScrollBar;
    public AudioSource audio;
    void Start()
    {
        ScrollBar.GetComponent<Scrollbar>().value = PlayerPrefs.GetFloat("RecordListVolLavel");
    }
    void Update()
    {
        PlayerPrefs.SetFloat("RecordListVolLavel", ScrollBar.gameObject.GetComponent<Scrollbar>().value);
        audio.volume = PlayerPrefs.GetFloat("RecordListVolLavel");
    }
}
