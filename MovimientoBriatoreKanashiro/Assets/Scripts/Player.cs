using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2;
    public float scale = 1;
    void Start()
    {
        scale = 5;
    }

    // Update is called once per frame
    void Update()
    {
        float positionX = this.transform.position.x + (speed * Time.deltaTime);
        this.transform.localScale = Vector3.one * scale;
        this.transform.position = new Vector3(positionX, 0, 0);
    }
}
