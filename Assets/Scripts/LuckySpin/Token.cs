using System;
using UnityEngine;

public class Token : MonoBehaviour
{
   public event Action<int> CountChanged;
   
   [SerializeField] private int _count;

   private void Start()
   {
      CountChanged?.Invoke(_count);
   }

   public void GetToken()
   {
      _count--;
      
      CountChanged?.Invoke(_count);
   }
}
