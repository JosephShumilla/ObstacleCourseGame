using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xTurn = 0;
    [SerializeField] float yTurn = 0;
    [SerializeField] float zTurn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xTurn, yTurn, zTurn);
    }
}
