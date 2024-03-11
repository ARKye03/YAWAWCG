using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public GameObject allyMelee;
    public GameObject allyRanged;
    public GameObject allySiege;
    // Declare other slots...

    private Slot allyMeleeSlot;
    private Slot allyRangedSlot;
    private Slot allySiegeSlot;
    // Declare other slot variables...

    // Start is called before the first frame update
    void Start()
    {
        allyMeleeSlot = allyMelee.GetComponent<Slot>();
        allyRangedSlot = allyRanged.GetComponent<Slot>();
        allySiegeSlot = allySiege.GetComponent<Slot>();
        // Get other slot components...
    }

    // Update is called once per frame
    void Update()
    {

    }
}