using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    public enum Direction
    { NONE, RIGHT, LEFT, FORWARD, BACKWARD, DOWN, UP };

    public bool Enabled = false;

    public GameObject kiub;

    [System.Serializable]
    public class Rotation
    {

        public bool RotateEnabled = false;
        public Direction RotateDirection;
        public float RotateSpeed = 10;
        public float Angle;
    }
    public Rotation ObjectRotation;

    [System.Serializable]
    public class Movement
    {
        public bool MovementEnabled = false;
        public Vector3 MovementAxis;
        public float MovementUnit = 0.0001f;
    }
    public Movement ObjectMovement;

    void Update()
    {

        if (Enabled)
        {
            if (ObjectRotation.RotateEnabled)
            {
                if (ObjectRotation.RotateDirection == Direction.UP)
                {
                    if (kiub.transform.rotation.eulerAngles.y <= ObjectRotation.Angle)
                    {
                        transform.Rotate(Vector3.up * (-Time.deltaTime) * ObjectRotation.RotateSpeed);
                    }
                    if (kiub.transform.rotation.eulerAngles.y >= (ObjectRotation.Angle + 0.001))
                    {
                        transform.Rotate(Vector3.up * (-Time.deltaTime) * ObjectRotation.RotateSpeed);
                    }
                }
            }
        }
    }
}

