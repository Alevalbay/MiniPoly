using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegularAreaIdentities : MonoBehaviour
{
    //Identity feature
    public GameObject areaOwner;
    public float      areaPrice;
    public float      areaLienPrice;
    public float      numberOfHouse;
    public float      numberOfHotel;
    public float      housePrice;
    public float      hotelPrice;
    public float      houseRentPrice;
    public float      hotelRentPrice;
    public float      areaRentPrice;
    public float      totalRentPrice;
    public string     areaName;
    public Text       areaNameText;
    public Text       areaPriceText;
    private float totalPayment;





    // Start is called before the first frame update
    void Start()
    {
        areaNameText.text  = areaName;
        areaPriceText.text = areaPrice.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function Works for Payment
    public float CalculatePayment()
    {
        totalPayment = ((areaRentPrice) + (numberOfHouse * houseRentPrice) + (numberOfHotel * hotelPrice));
        return totalPayment;
    }
}
