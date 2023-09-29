using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarFactory : MonoBehaviour,IFactory
{

    [SerializeField] private GameObject CarPrefab1;
    [SerializeField] private GameObject CarPrefab2;
    [SerializeField] private GameObject CarPrefab3;

    public const int CAR_TYPE_1 = 0;
    public const int CAR_TYPE_2 = 1;
    public const int CAR_TYPE_3 = 2;
    public IProduct GetProduct(int productType, Vector3 position)
    {
        switch(productType)
        {
            case CAR_TYPE_1:
                var car1 = Instantiate(CarPrefab1); 
                car1.transform.position = position;
                return new Car1();
            case CAR_TYPE_2:
                var car2 = Instantiate(CarPrefab2);
                car2.transform.position = position;
                return new Car2();
            case CAR_TYPE_3:
                var car3 = Instantiate(CarPrefab3);
                car3.transform.position = position;
                return new Car3();
        }
        return null;
    }
}

public class Car1 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Car 1";
    }
}

public class Car2 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Car 2";
    }
}

public class Car3 : IProduct
{
    private string productName;
    public string ProductName => productName;

    public void Initialize()
    {
        productName = "Car 3";
    }
}
