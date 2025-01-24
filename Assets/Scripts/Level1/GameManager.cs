using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject BallObject;
    int Score = 0;
    int TurnCounter = 0;
    GameObject[] Pins;
    [SerializeField] TextMeshProUGUI ScoreUI;
    Vector3[] Positions;
    [SerializeField] HighScore highScore;
    [SerializeField] GameObject menu;
    void Start()
    {
        Pins = GameObject.FindGameObjectsWithTag("Pin");
        Positions = new Vector3[Pins.Length];

        for(int i = 0; i < Pins.Length; i++)
        {
            Positions[i] = Pins[i].transform.position;
        }
    }
    void Update()
    {
        MoveBall();

        if(Input.GetKeyDown(KeyCode.Space) || BallObject.transform.position.z >= 18)
        {
            CountPinsDown();
            TurnCounter++;
            ResetPins();

            if(TurnCounter == 3)
            {
                menu.SetActive(true);
            }
        }
    }

    void MoveBall()
    {
        Vector3 BallPosition = BallObject.transform.position;
        BallPosition += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
        BallPosition.x = Mathf.Clamp(BallPosition.x, 10.3f, 11f);
        BallObject.transform.position = BallPosition;
    }

    void CountPinsDown()
    {
        for(int i = 0; i < Pins.Length; i++)
        {
            if ((Pins[i].transform.eulerAngles.x < 250 || Pins[i].transform.eulerAngles.x > 290) && (Pins[i].transform.eulerAngles.x < -110 || Pins[i].transform.eulerAngles.x > -70) && Pins[i].activeSelf)

            {
                Score++;
                Pins[i].SetActive(false);
            }
        }
        ScoreUI.text = Score.ToString();

        if(Score > highScore.highScore)
        {
            highScore.highScore = Score;
        }

        Debug.Log(highScore.highScore);
    }

     void ResetPins()
    {
        for(int i = 0; i < Pins.Length; i++)
        {
            Pins[i].SetActive(true);
            Pins[i].transform.position = Positions[i];
            Pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            Pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            Pins[i].transform.rotation = Quaternion.Euler(-90f, 0, 0);
        }

        BallObject.transform.position = new Vector3(10.65f, -0.92f, 7.5f);
        BallObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        BallObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        BallObject.transform.rotation = Quaternion.identity;
    } 
}