using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotation : MonoBehaviour
{
    void Update()
    {
      //Vector rotación solo en horizontal
      Vector3 rotate = new Vector3(0f, Input.GetAxis("Mouse X"), 0f);
      transform.eulerAngles += rotate;
    }
}
