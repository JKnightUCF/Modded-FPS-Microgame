using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {
    public Camera MainCamera;
    public Camera Peek_Camera;

    // Call this function to disable FPS camera,
    // and enable overhead camera.
    public void ShowOverheadView() {
        MainCamera.enabled = false;
        Peek_Camera.enabled = true;
    }
    void Update() {
        // Check for key input (e.g., the "C" key)
        if (Input.GetKeyDown(KeyCode.F));
    }
    // Call this function to enable FPS camera,
    // and disable overhead camera.
    public void ShowFirstPersonView() {
        MainCamera.enabled = true;
        Peek_Camera.enabled = false;
    }
}