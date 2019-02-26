using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public float moveSpeed = 600f;
    float movement = 0f;

    public double score = 0;
    public Text scoreText;
    public double highScore = 0;
    public Text highScoreText;


    void Start()
    {
        SetScoreText();
        SetHighScoreText();
    }
    void Update ()
    {
        movement = Input.GetAxisRaw("Horizontal");	
	}
    private void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (score > highScore)
        {
            highScore = score;
        }
        score = 0;
        SetScoreText();
        SetHighScoreText();
        DestroyAll();
    }
    public void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    public void SetHighScoreText()
    {
        highScoreText.text = "Highscore: " + highScore.ToString();
    }
    void DestroyAll()
    {
        GameObject[] hexagons = GameObject.FindGameObjectsWithTag("HexagonTag");
        for (int i = 0; i < hexagons.Length; i++)
        {
            Destroy(hexagons[i]);
        }
    }
}
