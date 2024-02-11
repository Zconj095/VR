using UnityEngine;

public class SimulateVRActivation : MonoBehaviour
{
    void Start()
    {
        SetupCameraForVR();
        Debug.Log("Simulated HP Reverb G2 Activation: Camera configured for VR.");
    }

    void SetupCameraForVR()
    {
        Camera.main.fieldOfView = 100; // Set FOV to simulate VR
        Camera.main.aspect = 16f / 9f; // Set aspect ratio to common VR aspect ratio
        // Additional configurations as necessary
    }
}
