using System;
using UnityEngine;
using UnityEngine.Events;

namespace LuckySpin
{
   public class Token : MonoBehaviour
   {
      public UnityEvent TokensOut; 
      public event Action<int> CountChanged;
   
      [SerializeField] private int _count;

      private void Start()
      {
         CountChanged?.Invoke(_count);

         OnTokensDepleted();
      }

      private void OnTokensDepleted()
      {
         if (_count == 0)
         {
            TokensOut?.Invoke();
         }
      }

      public void GetToken()
      {
         if (_count > 0)
         {
            _count--;
            CountChanged?.Invoke(_count);
         }

         OnTokensDepleted();
      }
   }
}