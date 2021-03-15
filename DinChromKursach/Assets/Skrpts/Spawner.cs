using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject platform;
    public void Start()
    {
        Instantiate(platform, new Vector3(0f, -5f, -1f), Quaternion.identity);
        Instantiate(platform, new Vector3(39f, -5f, -1f), Quaternion.identity);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "End")
        {
            Instantiate(platform, new Vector3(38f, -5f, -1f), Quaternion.identity);
        }
    }
}
