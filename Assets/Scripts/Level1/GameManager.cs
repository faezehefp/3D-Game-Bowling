using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject BallObject;
    int Score = 0;
    GameObject[] Pins;
    [SerializeField] TextMeshProUGUI ScoreUI;
    void Start()
    {
        Pins = GameObject.FindGameObjectsWithTag("Pin");
    }
    void Update()
    {
        MoveBall();

        if(Input.GetKeyDown(KeyCode.Space) || BallObject.transform.position.z > 17)
        {
            CountPinsDown();
        }
    }

    void MoveBall()
    {
        Vector3 BallPosition = BallObject.transform.position;
        BallPosition += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
        BallPosition.x = Mathf.Clamp(BallPosition.x, 10.3f, 11f);
        BallObject.transform.position = BallPosition;
        //BallObject.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime);
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
    }
}
