using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

namespace LuckySpin
{
   public class AnimationEvent : MonoBehaviour
   {
      public UnityEvent Event;

      [UsedImplicitly]
      private void InvokeEvent()
      {
         Event?.Invoke();
      }
   }
}
