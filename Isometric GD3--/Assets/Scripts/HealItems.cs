using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " New HealItem", menuName = "HealItems")]
public class HealItems : ScriptableObject
{
   
   public new string name;
   public string description;
   
   public int healPoints;
   public int timePoints;
}

    

