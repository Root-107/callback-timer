using System;
using UnityEngine;

namespace Packages.callback_timer
{
    public class CallbackTimerBehaviour : MonoBehaviour
    {
        private float duration;
        private Action callback;
        private float currentTime;
        
        private bool paused = true;

        public void Configure(Action callback, float duration)
        {
            this.callback = callback;
            this.duration = duration;
            
            currentTime = duration;
        }

        private void Update()
        {
            if (paused) return;
            
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                callback?.Invoke();
                Stop();
            }
        }

        public void Begin()
        {
            paused = false;
        }

        public void Stop()
        {
            paused = true;
            Destroy(this.gameObject);
        }
        
        public void Pause()
        {
            paused = true;
        }
    }
}