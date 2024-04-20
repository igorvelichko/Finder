using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class successfulpurchase : MonoBehaviour
{
    
    public void PurchesingComplete(Product product)
    {
        
        switch (product.definition.id)
        {
            case ".com.serbull.finder.10seconds":
                Add10sec();
                
                break;
        }
    }

    private void Add10sec()
    {
        Timer.sec += 10;
        
    }
}
