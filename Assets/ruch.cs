using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ruch : MonoBehaviour
{
    private int souls;
    public int soulsCount;
    public TextMeshProUGUI soulText;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left *0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.1f);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * 0.1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * 0.1f);
        }
        soulText.text = soulsCount.ToString();

       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("soul"))
        {
            other.gameObject.SetActive(false);
            souls++;
        }
    }

}

