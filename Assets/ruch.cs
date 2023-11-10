using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ruch : MonoBehaviour
{
    private int souls;
    public int soulsCount;
    public TextMeshProUGUI soulText;


    void Update()
    {
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
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("soul"))
        {
            Destroy(other.gameObject);
            souls++;
        }
    }

}

