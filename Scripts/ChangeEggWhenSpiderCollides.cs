using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEggWhenSpiderCollides : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Cambia de color los huevos al colisionar con la araña
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "spiders_group_1" ||
            collision.gameObject.tag == "spiders_group_2")
        {
            Debug.Log("Collision detected with spider");

            for (int i = 0; i < transform.childCount; i++)
            {
                Transform child = transform.GetChild(i);
                if (child.CompareTag("egg"))
                {
                    Material nuevoMaterial = new Material(child.GetComponent<Renderer>().material);

                    int position = Random.Range(0, 3);
                    Vector4 actual_color = nuevoMaterial.color;
                    actual_color[position] = Random.value;
                    nuevoMaterial.color = actual_color;

                    child.GetComponent<Renderer>().material = nuevoMaterial;
                }
            }
        }
    }

    // // Cambia de color las arañas al colisionar con el huevo
    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "spiders_group_1" ||
    //         collision.gameObject.tag == "spiders_group_2")
    //     {
    //         Debug.Log("Collision detected with spider");

    //         for (int i = 0; i < collision.gameObject.transform.childCount; i++)
    //         {
    //             Transform child = collision.gameObject.transform.GetChild(i);
    //             if (child.CompareTag("spider"))
    //             {
    //                 Material nuevoMaterial = new Material(child.GetComponent<Renderer>().material);

    //                 int position = Random.Range(0, 3);
    //                 Vector4 actual_color = nuevoMaterial.color;
    //                 actual_color[position] = Random.value;
    //                 nuevoMaterial.color = actual_color;
                    
    //                 child.GetComponent<Renderer>().material = nuevoMaterial;
    //             }
    //         }
    //     }
    // }
}
