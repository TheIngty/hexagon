using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour {

    public Rigidbody2D rb;
    public float shrink = 3f;

    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);
        transform.localScale = Vector3.one * 10f;
    }
    void Update () {
        transform.localScale -= Vector3.one * shrink * Time.deltaTime;
        if(transform.localScale.x <= 0.5f)
        {
            Destroy(gameObject);
            GameObject.Find("Player").GetComponent<Player>().score += 100;
            GameObject.Find("Player").GetComponent<Player>().SetScoreText();
        }
	}
}
