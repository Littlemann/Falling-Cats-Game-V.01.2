using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public event System.Action OnCollecting;
    public event System.Action OnCompleteLevel;
    public static GameManager Instance;
    public virtual bool IsDontDestroyOnLoad => true;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            if (IsDontDestroyOnLoad)
            {
                DontDestroyOnLoad(this.gameObject);
            }
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this as GameManager)
        {
            Instance = null;
        }
    }


    public void Collecting()
    {
        OnCollecting?.Invoke();
    }
    public void LevelDone()
    {
        OnCompleteLevel?.Invoke();
        
    }


 }

