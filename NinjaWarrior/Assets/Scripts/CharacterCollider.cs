using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCollider : MonoBehaviour
{
    public void DoAttack()
    {
        transform.Find("Collider").GetComponent<BoxCollider>().enabled = true;
        StartCoroutine(HideCollider());
    }

    IEnumerator HideCollider()
    {
        yield return new WaitForSeconds(0.5f);
        transform.Find("Collider").GetComponent<BoxCollider>().enabled = false;
    }
}
