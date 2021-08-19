using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb; //ball rigidbody

    public GameObject splashPreFab;
    
    public float jumpForce; //ball jump 

    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) { //at the time of impact 
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPreFab, transform.position + new  Vector3(0f, -0.2f, 0), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);

        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name; //recognizing where it hit
        Debug.Log("Materyal Adı: " + materialName);

        if(materialName == "Safe Colour (Instance)") { // will score points

        }

        else if (materialName == "Enemy Colour (Instance)") { //will restart

               Debug.Log("Game Over!");
               gm.RestartGame();
        }

        else if(materialName == "Last Circle (Instance)") { //level complate
                Debug.Log("Next Level");

        }
    }
}
