using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    // Behind Player Settings
    public Vector3 behindOffset = new Vector3(0, 8, -10);
    public float lookDownAngle = -6f;

    // Follow Settings
    public float followSpeed = 4f;
    public float rotationSpeed = 3f;

    // Controls
    public KeyCode switchTargetKey = KeyCode.Tab;

    // Zoom
    public float defaultFOV = 60f;
    public float zoomOutFOV = 75f;
    public float zoomSpeed = 3f;

    private Transform currentTarget;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
