using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToCreate : MonoBehaviour
{
    [SerializeField] private IFactory[] factory;
    private void Update()
    {
        GetProductAtClick();
    }

    private void GetProductAtClick()
    {
        if(Input.GetMouseButtonDown(0))
        {

        }    
    }    
}
