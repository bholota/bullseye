using UnityEngine;
using System.Collections;

public class ShowTargetScript : MonoBehaviour {

    public enum Direction
    {
        FRONT,
        BACK,
        LEFT,
        RIGHT,
        UP,
        DOWN
    }

    public int angleInDeg;
    public Direction direction;

    private bool hasStarted = false;
    private Transform rotationPoint;
    private Transform model;

	// Use this for initialization
	void Start () {
        rotationPoint = transform.Find("RotationPoint");
        model = transform.Find("Bullseye");
	}
	
	// Update is called once per frame
	void Update () {
        model.transform.RotateAround(rotationPoint.transform.position, Vector3.forward, Time.deltaTime * 20);
	}
}
