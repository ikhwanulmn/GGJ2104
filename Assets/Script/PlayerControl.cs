using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float mouseSen = 100f;

    public Transform PChar;

    float Xrot = 0f;

    



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSen * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSen * Time.deltaTime;

        Xrot -= MouseY;
        Xrot = Mathf.Clamp(Xrot, -90f, 90);



        transform.localRotation = Quaternion.Euler(Xrot, 0f, 0f);

        PChar.Rotate(Vector3.up * MouseX);
        
        

    }
}
