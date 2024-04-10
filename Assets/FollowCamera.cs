using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject Maincharacter;
    // Update is called once per frame
    void Update()
    {
        transform.position = Maincharacter.transform.position + new Vector3(0, 0, -20);
    }
}
