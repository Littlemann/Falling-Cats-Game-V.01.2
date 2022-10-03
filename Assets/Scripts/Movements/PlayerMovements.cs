using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovements : MonoBehaviour
{
    

    [SerializeField] private Camera _mainCam;
    [SerializeField] private GameObject _player;
    
   public void Update()
   {
    if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            _player.transform.position = new Vector3(_mainCam.ScreenToWorldPoint(touch.position).x/2, _player.transform.position.y, _player.transform.position.z);
        }
   }
 
   
  

     

        
}
