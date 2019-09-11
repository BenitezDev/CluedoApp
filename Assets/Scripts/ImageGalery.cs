
// +----------------------------------------------------------------------------+
// | Created by Alejandro Benitez Lopez, benitezdev@gmail.com (benitezdev.com)  |
// | On 14th of Agust 2019                                                      |
// | Copyright © 2019 Benitezdev. Creative Commons License:                     |
// | Attribution 4.0 International (CC BY 4.0)                                  |
// +----------------------------------------------------------------------------+


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageGalery : MonoBehaviour
{

    #region Singleton
    public static ImageGalery instance;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);
    }
    #endregion

    /// <summary>
    /// List of Sprites
    /// </summary>
    public List<Sprite> buttonsSprites;

}
