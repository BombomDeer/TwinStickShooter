using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utility
{
    static public bool MousePoint(ref Vector3 RC)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit = new RaycastHit();
        if (Physics.Raycast(ray, out raycastHit))
        {
            if (raycastHit.collider.tag.Contains("terrain"))
            {
                RC = raycastHit.point;
                //Debug.Log(raycastHit.point);

                return true;
            }
            else
                return false;
        }
        
        return false;
    }

    static public bool MousePick(ref Vector3 vEnd)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            if (!hit.collider.tag.Contains("Terrain"))
                return false;
            vEnd = hit.point;
            Debug.Log(hit.collider.name);
            return true;

        }

        return true;
    }
}
