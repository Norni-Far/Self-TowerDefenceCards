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
        //сам луч, начинается от позиции этого объекта и направлен в сторону цели
        Ray ray = new Ray(transform.position, transform.forward);
        //пускаем луч
        Physics.Raycast(ray, out hit);

        //если луч с чем-то пересёкся, то..
        if (hit.collider != null)
        {
            //   if (hit.collider.gameObject != target.gameObject)
            // {
            Debug.Log("Путь к врагу преграждает объект: " + hit.collider.name);
            //}
        }
    }
}
