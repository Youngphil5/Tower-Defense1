using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Debug.DrawLine(ray.origin, ray.direction, Color.red);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    if (hit.transform.gameObject.tag == "Enemy")
                    {
                        hit.transform.GetComponent<Enemy>().health--;
                    }
                }
            }
        }
        
    }
}
