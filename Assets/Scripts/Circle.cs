using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public Transform ball;

    private GameManager gm;

    void Start()
    {
       gm = GameObject.FindObjectOfType<GameManager>();
    }


    void Update()
    {
        if(transform.position.y + 10f >= ball.position.y) {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}
