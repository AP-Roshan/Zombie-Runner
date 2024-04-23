using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boy : MonoBehaviour
{
    public bool ij;
    [SerializeField] private AudioSource jump;
    [SerializeField] private AudioSource bgm;

    void Start()
    {
        ij = false;
        bgm.Play();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && ij == false)
        {
            jump.Play();
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 8, 0);
            ij = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            ij = false;
        }
        if (collision.gameObject.tag == "Respawn")
        {

            SceneManager.LoadScene("Defeat");
        }
    }
}
