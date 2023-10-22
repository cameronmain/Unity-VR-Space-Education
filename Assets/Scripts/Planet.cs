using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * class to hold information about a planet
 */
public class Planet : MonoBehaviour
{
    public string planetName;
    [TextArea(10,10)]public string planetDescription;
    public AudioClip planetAudio;
}
