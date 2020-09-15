using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] float minX = -7f;
    [SerializeField] float maxX = 7f;
    [SerializeField] float screenWidthInUnits = 16;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xPos = (Input.mousePosition.x / Screen.width * screenWidthInUnits) - screenWidthInUnits / 2;
        transform.position = new Vector2(Mathf.Clamp(xPos, minX, maxX) , transform.position.y);
    }
}
