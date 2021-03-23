using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] platform;
    public void Start()
    {
        switch (PlayerPrefs.GetInt("Location"))
            {

            case 1:
                Instantiate(platform[0], new Vector3(0f, -5f, -1f), Quaternion.identity);
                Instantiate(platform[0], new Vector3(39f, -5f, -1f), Quaternion.identity);
                break;
            case 2:
                Instantiate(platform[1], new Vector3(0f, -5f, -1f), Quaternion.identity);
                Instantiate(platform[1], new Vector3(39f, -5f, -1f), Quaternion.identity);
                break;
            default:
                Instantiate(platform[0], new Vector3(0f, -5f, -1f), Quaternion.identity);
                Instantiate(platform[0], new Vector3(39f, -5f, -1f), Quaternion.identity);
                break;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "End")
        {
            switch (PlayerPrefs.GetInt("Location"))
            {
                case 1:
                    Instantiate(platform[0], new Vector3(38f, -5f, -1f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(platform[1], new Vector3(38f, -5f, -1f), Quaternion.identity);
                    break;
                default:
                    Instantiate(platform[0], new Vector3(38f, -5f, -1f), Quaternion.identity);
                    break;
            }
        }
    }
}
