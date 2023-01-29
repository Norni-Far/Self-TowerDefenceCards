using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRender : MonoBehaviour
{
    private LineRenderer line;
    private void OnEnable()
    {
        line = GetComponent<LineRenderer>();
        line.enabled = true;
        Vector3 posMouse = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
        posMouse.y = 9;
        line.SetPosition(0, posMouse);
        line.SetPosition(1, posMouse);
    }
    private void Update()
    {
        Vector3 posMouse = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, 0, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
        posMouse.y = 9;
        line.SetPosition(1, posMouse);
        if (Input.GetMouseButtonDown(0))
            this.enabled = false;
    }
    private void OnDisable()
    {
        line.enabled = false;
    }
}
