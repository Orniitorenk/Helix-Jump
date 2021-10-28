using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float jumpForce;
    [SerializeField] GameObject splashEffect;
    private GameManager gm;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject splash = Instantiate(splashEffect, transform.position + new Vector3(0, -0.22f ,0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);
        string material = other.gameObject.GetComponent<MeshRenderer>().material.name;
        rb.AddForce(Vector3.up * jumpForce);

        if(material == "NotSafePlatform (Instance)")
        {
            gm.RestartGame();
        }
        else
        {
            Debug.Log("Next Scene");
        }
    }
}
