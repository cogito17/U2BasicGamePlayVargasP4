using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;

    private int currentAmount = 0;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
