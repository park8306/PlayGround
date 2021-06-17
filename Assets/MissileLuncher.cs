using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLuncher : MonoBehaviour
{
    public GameObject Shell;
    public Transform startPosition;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(Shell, startPosition.position, transform.rotation);
        }
    }
}
