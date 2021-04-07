using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20f;
    public float panBoarderThickness = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("z") || Input.mousePosition.y >= Screen.height - panBoarderThickness)
        {
            pos.z += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= panBoarderThickness)
        {
            pos.z -= panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBoarderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }

        if (Input.GetKey("q") || Input.mousePosition.x <= panBoarderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }
        
        transform.position = pos;
    }
}
