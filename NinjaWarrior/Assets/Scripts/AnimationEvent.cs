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

    public void PlayerDamage()
    {
        transform.GetComponentInParent<EnemyController>().DamagePlayer();
    }

    public void MoveSound()
    {
        LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[0], LevelManager.instance.player.position);
    }
}
