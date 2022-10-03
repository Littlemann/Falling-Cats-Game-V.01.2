using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDataBase : ScriptableObject
{
   public Character[] _character;

   public int CharacterCount
   {
        get
        {
            return _character.Length;
        }
   }

   public Character GetCharacter(int index)
   {
     return _character[index];
   }
}
