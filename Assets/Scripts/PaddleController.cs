using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] float minX = -7f;
    [SerializeField] float maxX = 7f;
    [SerializeField] float screenWidthInUnits = 16;

    GameSession gameSession;
    Ball ball;
    

    // Start is called before the first frame update
    void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = GetXPos();
        transform.position = new Vector2(Mathf.Clamp(xPos, minX, maxX) , transform.position.y);
    }

    private float GetXPos()
    {
        if (gameSession.IsAutoPlay())
        {
            return ball.transform.position.x;
        }
        else
        {
            return (Input.mousePosition.x / Screen.width * screenWidthInUnits) - screenWidthInUnits / 2;
        }
    }

}
