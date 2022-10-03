using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
   public CharacterDataBase _characterDB;

   public SpriteRenderer _sprite;

   private int selectedoption;


   void Start()
   {
    if(!PlayerPrefs.HasKey("selectedoption"))
    {
      selectedoption=0;
    }
    else
    {
      Load();
    }
    
    UpdateCharacter(selectedoption);
   }
   
   
   public void NextOption()
   {
      selectedoption++;

      if(selectedoption > _characterDB.CharacterCount)
      {
        selectedoption=0;
      }
      UpdateCharacter(selectedoption);
      Save();
   }
   
   public void BackOption()
   {
     selectedoption--;
     if(selectedoption == 0)
     {
      selectedoption = -_characterDB.CharacterCount - 1;
     }
     UpdateCharacter(selectedoption);
     Save();
   }

   
   private void UpdateCharacter(int selectedoption)
   {
    Character _character = _characterDB.GetCharacter(selectedoption);
    _sprite.sprite = _character._charactersprite;
   }

   private void Load()
   {
    selectedoption = PlayerPrefs.GetInt("selectedoption");
   }

   private void Save()
   {
     PlayerPrefs.SetInt("selectedoption",selectedoption);
   }
}
