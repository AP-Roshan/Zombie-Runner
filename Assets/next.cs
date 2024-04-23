using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    [SerializeField] private AudioSource end;
    void Start()
    {
        end.Play();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            SceneManager.LoadScene("level_1 1");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("level_1");
        }
    }
}
