using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    public CharacterCollider characterCollider;
    public void PlayerAttack()
    {
        Debug.Log("Player Attacked!");
        characterCollider.DoAttack();
    }
}
