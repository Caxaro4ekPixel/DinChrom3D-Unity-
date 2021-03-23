using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject[] tree;
    void Start()
    {
        StartCoroutine("SpawnTreess");
    }
    IEnumerator SpawnTreess()
    {
        while (true)
        {
            switch (PlayerPrefs.GetInt("Location"))
            {
                case 1:
                    if (Random.Range(0, 2) == 1)
                    {
                        Instantiate(tree[Random.Range(0, 3)], new Vector3(21f, -4f, -1f), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(tree[Random.Range(0, 3)], new Vector3(21f, -4f, 5f), Quaternion.identity);
                    }
                    break;
                case 2:
                    if (Random.Range(0, 2) == 1)
                    {
                        Instantiate(tree[Random.Range(4, 9)], new Vector3(21f, -4f, -1f), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(tree[Random.Range(4, 9)], new Vector3(21f, -4f, 5f), Quaternion.identity);
                    }
                    break;

                default:
                    if (Random.Range(0, 2) == 1)
                    {
                        Instantiate(tree[Random.Range(0, 3)], new Vector3(21f, -4f, -1f), Quaternion.identity);
                    }
                    else
                    {
                        Instantiate(tree[Random.Range(0, 3)], new Vector3(21f, -4f, 5f), Quaternion.identity);
                    }
                    break;
            }
            yield return new WaitForSeconds(Random.Range(2,10));
        }
    }
}
