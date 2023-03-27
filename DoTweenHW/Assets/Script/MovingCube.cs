using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector3(-15, 3, -15), 5);
        transform.DOScale(new Vector3(6, 6, 6), 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
