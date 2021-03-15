using System;
using UnityEngine;
using UnityEngine.UI;

public class List : MonoBehaviour
{
    public GameObject textlist;
    void Start()
    {
        textlist.gameObject.GetComponent<Text>().text = "";
        string templist = PlayerPrefs.GetString("RecordList");
        string[] tempmass = templist.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int temp;
        for (int i = 0; i < tempmass.Length - 1; i++)
        {
            for (int j = i + 1; j < tempmass.Length; j++)
            {
                if (int.Parse(tempmass[i]) < int.Parse(tempmass[j]))
                {
                    temp = int.Parse(tempmass[i]);
                    tempmass[i] = tempmass[j];
                    tempmass[j] = Convert.ToString(temp);
                }
            }
        }
        for (int i = 0; i < 10; i++)
        {
            textlist.gameObject.GetComponent<Text>().text = textlist.gameObject.GetComponent<Text>().text + tempmass[i] + " sec." + "\n";
        }
    }
}
