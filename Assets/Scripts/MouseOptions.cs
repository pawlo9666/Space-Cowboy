﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOptions : MonoBehaviour
{
    // Start is called before the first frame update
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    void Awake()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

}
