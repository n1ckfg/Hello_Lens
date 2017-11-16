﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushInputHoloLens : MonoBehaviour {

    public LightningArtist latk;
    public HandClicker handClicker;
    public int startingFrames = 12;

    private bool firstRun = true;

    private void Awake() {
        if (latk == null) latk = GetComponent<LightningArtist>();
    }

    private void Update() {
        if (firstRun) {
            for (int i = 0; i < startingFrames-1; i++) {
                latk.inputNewFrame();
            }
            latk.inputPlay();
            firstRun = false;
        }

        latk.clicked = handClicker.handPressed;
    }

}
