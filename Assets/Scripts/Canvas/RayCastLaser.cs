using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RayCastLaser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        //��� ���, ���������� �� ������� ����� ������� � ��������� � ������� ����
        Ray ray = new Ray(transform.position, transform.forward);
        //������� ���
        Physics.Raycast(ray, out hit);

        //���� ��� � ���-�� ��������, ��..
        if (hit.collider != null)
        {
            //   if (hit.collider.gameObject != target.gameObject)
            // {
            Debug.Log("���� � ����� ����������� ������: " + hit.collider.name);
            //}
        }
    }
}
