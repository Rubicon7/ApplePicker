/***
 * Created By: Logan Patrick
 * Date Created: 1/31/2022
 * 
 * Last Edited: N/A
 * Last Edited By: N/A
 * 
 * Description: Apple despawn logic
 * 
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{

    public static float bottomY = -20f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);
        }
    }
}
