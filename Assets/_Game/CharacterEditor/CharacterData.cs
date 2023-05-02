using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData ", menuName = "UnitData/CharacterData")]
public class CharacterData : ScriptableObject 
{
    [SerializeField]
    private string _name = "default name";
   
    [SerializeField]
    private CharacterType _characterType = CharacterType.None;
    [SerializeField]
    [Range(0, 100)]
    private float _chanceToDropItem = 20;
    [SerializeField]
    [Tooltip("Radius size where character will see the player")]
    private float _rangeOfAwareness = 10;
    [SerializeField]
    private bool _canEnterDialogue = true;

    //[SerializeField]
   // private int _damage = 1;
   // [SerializeField]
   // private int _health = 1;
    [SerializeField]
    private int _speed = 1;

    [SerializeField]
    [Tooltip("Speaks dialogue when entering combat")]
    [TextArea()]
    private string _catchPhrase = "default phrase";


    [TextArea(3, 10)]
    public string[] sentences;
    public string Name => _name;
    public CharacterType CharacterType => _characterType;
    public float ChanceToDropItem => _chanceToDropItem;
    public float RangeOfAwareness => _rangeOfAwareness;

   // public int Damage => _damage;
   // public int Health => _health;
   // public int Speed => _speed;

    public string CatchPhrase => _catchPhrase;
    
}
