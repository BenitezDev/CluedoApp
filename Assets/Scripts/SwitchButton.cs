
// +----------------------------------------------------------------------------+
// | Created by Alejandro Benitez Lopez, benitezdev@gmail.com (benitezdev.com)  |
// | On 14th of Agust 2019                                                      |
// | Copyright © 2019 Benitezdev. Creative Commons License:                     |
// | Attribution 4.0 International (CC BY 4.0)                                  |
// +----------------------------------------------------------------------------+


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchButton : MonoBehaviour
{

    // Image component of this GameObject
    private Image image;

    // Index of the list of sprites
    private int index = 0;


    private void Awake()
    {
        image = GetComponent<Image>();
    }


    private void Start()
    {
        image.sprite = ImageGalery.instance.buttonsSprites[index];
    }

    
    public void ChangeSprite()
    {
        index++;

        if (index >= ImageGalery.instance.buttonsSprites.Count) index = 0;

        image.sprite = ImageGalery.instance.buttonsSprites[index];
    }
}
