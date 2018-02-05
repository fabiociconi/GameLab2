using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsContro : MonoBehaviour
{


    public GameObject fabioPerson;

    public Sprite changeColor;

    private SpriteRenderer sr;


    // Use this for initialization
    void Start()
    {

        sr = fabioPerson.GetComponent<SpriteRenderer>();
    }

    private void OnMouseDown()
    {

        sr.sprite = changeColor;

    }
    private void Update()
    {

    }
}
