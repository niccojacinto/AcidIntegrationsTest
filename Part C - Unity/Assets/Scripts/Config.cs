﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config : MonoBehaviour {

    void Start() {
        // Switch to 640 x 480 full-screen
        Screen.SetResolution(480,360, false);
    }
}
