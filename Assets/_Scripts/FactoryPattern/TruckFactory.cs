using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckFactory : MonoBehaviour, IFactory
{
    [SerializeField] private GameObject TruckPrefab1;
    [SerializeField] private GameObject TruckPrefab2;

    private const int TRUCT_TYPE_1 = 0;
    private const int TRUCT_TYPE_2 = 1;
    public IProduct GetProduct(int productType, Vector3 position)
    {
        switch (productType)
        {
            case TRUCT_TYPE_1:
                var truck1 = Instantiate(TruckPrefab1);
                truck1.transform.position = position;
                return new Track1();
            case TRUCT_TYPE_2:
                var truck2 = Instantiate(TruckPrefab2);
                truck2.transform.position = position;
                return new Track2();

        }
        return null;
    }
}

public class Track1 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Truck 1";
    }
}

public class Track2 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Truck 2";
    }
}
