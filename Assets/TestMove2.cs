﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMove2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }

    }
}
