using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveMouse : MonoBehaviour
{
    public GameObject Main_Cube = null;
    public Slider slider;
    private Camera goCamera = null;
    private Vector3 MousePos;
    private float MyAngle = 0F;

    void Start()
    {
        goCamera = GetComponent<Camera>();
        Main_Cube = goCamera.transform.parent.gameObject;
    }

    void Update()
    {
        MousePos = Input.mousePosition;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            MyAngle = 0;
            MyAngle = slider.value * ((MousePos.x - (Screen.width / 2)) / Screen.width);
            goCamera.transform.RotateAround(Main_Cube.transform.position, goCamera.transform.up, MyAngle);
            MyAngle = slider.value * ((MousePos.y - (Screen.height / 2)) / Screen.height);
            goCamera.transform.RotateAround(Main_Cube.transform.position, goCamera.transform.right, -MyAngle);
        }
    }
    void OnGUI()
    {
        if (GUI.Button(new Rect(1100, 10, 100, 20), "Выход"))
        {
            Application.Quit();
        }
    }
}
