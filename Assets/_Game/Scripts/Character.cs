using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private string _name = "...";

    [SerializeField]
    private CharacterType _characterType = CharacterType.None;
    [SerializeField]
    [Range(0, 100)]
    private float _chanceToDropItem; //= 20;
    [SerializeField]
    [Tooltip("Radius size where character will see the player")]
    private float _rangeOfAwareness; //= 10;
    //[SerializeField]
    //private bool _canEnterDialogue = true;

    [SerializeField]
    private int _damage;// = 1;
    [SerializeField]
    private int _health; //= 1;
    [SerializeField]
    private int _speed; //= 1;

    [SerializeField]
    [Tooltip("Speaks dialogue when entering combat")]
    [TextArea()]
    private string _catchPhrase; //= "...";

    // [SerializeField]
    //private CharacterDialogue[] _dialogue;}
}
