using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SUVFactory : MonoBehaviour,IFactory
{
    [SerializeField] private GameObject SUVPrefab1;

    private const int SUV_TYPE_1 = 0;
    public IProduct GetProduct(int productType, Vector3 position)
    {
       switch (productType)
        {
            case SUV_TYPE_1:
                var truck1 = Instantiate(SUVPrefab1);
                truck1 .transform.position = position;
                return null;
        }
        return null;
    }
}

public class SUV1 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Suv 1";
    }
}
 