using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {

    public float timeLeft = 500;
    public int playerScore = 0;
    public float energy = 100;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    public GameObject energyUI;
    public AudioClip Chirp;
    public AudioClip Pick;
    public AudioClip Eat;
    public AudioClip injured;

    void Start () {
        //Just for testing
        //Data_Management.dataManagement.LoadData();
    }

	void Update () {
        timeLeft -= Time.deltaTime;
        energy -= Time.deltaTime * 0.5f;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time Left: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        energyUI.gameObject.GetComponent<Text>().text = ("energy:" + energy);
        if (energy <= 0)
        {
            SceneManager.LoadScene("my game-sheep");
        }
        if (timeLeft < 0.1f) {
            SceneManager.LoadScene ("my game-sheep");
        } 
    }

    void OnTriggerEnter2D (Collider2D trig) {
        if (trig.gameObject.name == "End_Level") {
            CountScore();
        }
        if (trig.gameObject.name == "spike")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike1")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike2")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike3")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike4")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike5")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike6")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike7")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike8")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike9")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike10")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike11")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike12")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "spike13")
        {
            energy -= 10;
            AudioSource.PlayClipAtPoint(injured, transform.position);
        }
        if (trig.gameObject.name == "CMG_Star")
        {
            playerScore += 20;
            AudioSource.PlayClipAtPoint(Chirp, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "star1")
        {
            playerScore += 20;
            AudioSource.PlayClipAtPoint(Chirp, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "star2")
        {
            playerScore += 20;
            AudioSource.PlayClipAtPoint(Chirp, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "star3")
        {
            playerScore += 20;
            AudioSource.PlayClipAtPoint(Chirp, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "star4")
        {
            playerScore += 20;
            AudioSource.PlayClipAtPoint(Chirp, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "green") {
            playerScore += 10;
            AudioSource.PlayClipAtPoint(Pick, transform.position);
            Destroy(trig.gameObject);
     
        }
        if (trig.gameObject.name == "yellow")
        {
            playerScore += 10;
            AudioSource.PlayClipAtPoint(Pick, transform.position);
            Destroy(trig.gameObject);

        }
        if (trig.gameObject.name == "red") {
            playerScore += 10;
            AudioSource.PlayClipAtPoint(Pick, transform.position);
            Destroy(trig.gameObject);

        }
        if (trig.gameObject.name == "gd")
        {
            energy += 20;
            AudioSource.PlayClipAtPoint(Eat, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "pd")
        {
            energy += 20;
            AudioSource.PlayClipAtPoint(Eat, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "gp")
        {
            energy += 10;
            AudioSource.PlayClipAtPoint(Eat, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.name == "wbp")
        {
            energy += 10;
            AudioSource.PlayClipAtPoint(Eat, transform.position);
            Destroy(trig.gameObject);
        }
    }

    void CountScore () {
        Debug.Log("Data says high score is currently" + Data_Management.dataManagement.highScore);
        playerScore = playerScore + (int)(timeLeft * 10);
        Data_Management.dataManagement.highScore = playerScore + (int)(timeLeft * 10);
        Data_Management.dataManagement.SaveData();
        Debug.Log(message: "Now that we have added the score to Data_Management, data says high score is currently" + Data_Management.dataManagement.highScore);
    }
}
