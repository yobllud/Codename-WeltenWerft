using UnityEngine;
using System.Collections;
using InControl;

public class chopstick_script : MonoBehaviour {

    private Rigidbody2D rb;
    public string stickID = "L";

    public float moveSpeed = 0.25f;

    //InControll:
    ChopstickActions01 chopStickActions;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
       
        //Initialze Controll Bindings:
        chopStickActions = new ChopstickActions01();

        chopStickActions.LStickLeft.AddDefaultBinding(InputControlType.LeftStickLeft);
        chopStickActions.LStickRight.AddDefaultBinding(InputControlType.LeftStickRight);
        chopStickActions.LStickDown.AddDefaultBinding(InputControlType.LeftStickDown);
        chopStickActions.LStickUp.AddDefaultBinding(InputControlType.LeftStickUp);
        chopStickActions.LStickRotateLeft.AddDefaultBinding(InputControlType.LeftBumper);
        chopStickActions.LStickRotateRight.AddDefaultBinding(InputControlType.LeftTrigger);

        chopStickActions.RStickLeft.AddDefaultBinding(InputControlType.RightStickLeft);
        chopStickActions.RStickRight.AddDefaultBinding(InputControlType.RightStickRight);
        chopStickActions.RStickDown.AddDefaultBinding(InputControlType.RightStickDown);
        chopStickActions.RStickUp.AddDefaultBinding(InputControlType.RightStickUp);
        chopStickActions.RStickRotateLeft.AddDefaultBinding(InputControlType.RightBumper);
        chopStickActions.RStickRotateRight.AddDefaultBinding(InputControlType.RightTrigger);
    }

    // Update is called once per frame
    void Update() {
        InputManager.OnDeviceAttached += inputDevice => Debug.Log("Attached: " + inputDevice.Name);

        if (stickID == "L")
        {
            if (chopStickActions.LStickMove != Vector2.zero)
            {
                Move(chopStickActions.LStickMove);
            }
            if (chopStickActions.LStickRotate.Value != 0f)
            {
                Rotate(chopStickActions.LStickRotate.Value);
            }
        }
        else if(stickID == "R"){
            if (chopStickActions.RStickMove != Vector2.zero)
            {
                Move(chopStickActions.RStickMove);
            }
            if (chopStickActions.RStickRotate.Value != 0f)
            {
                Rotate(chopStickActions.RStickRotate.Value);
            }
        }
	}

    void Rotate(float rot)
    { 
        rb.MoveRotation(rb.rotation - rot);
    }

    void Move(Vector2 movDir)
    {
        rb.MovePosition(rb.position + movDir*moveSpeed);
    }
}
