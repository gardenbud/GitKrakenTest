using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private CharacterData _data;

    [SerializeField]
    private int _health;

    public CharacterData Data => _data;
    private void Awake()
    {
        Debug.Log("Damage: " + _data.Damage);
        Debug.Log("Damage: " + _data.Damage);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, _data.RangeOfAwareness);
        Gizmos.color = Color.cyan;
        Vector3 ray = transform.forward * _data.RangeOfAwareness;
        Gizmos.DrawRay(transform.position, ray);
    }
}
