using System;
using UnityEngine;

namespace Packages.callback_timer
{
    public class CallbackTimer
    {
        private readonly CallbackTimerBehaviour behaviour;

        public CallbackTimer(Action callback, float duration)
        {
            behaviour = new GameObject("CallbackTimer").AddComponent<CallbackTimerBehaviour>();
            behaviour.Configure(callback, duration);
        }

        public CallbackTimer Start()
        {
            behaviour.Begin();
            return this;
        }

        public CallbackTimer Stop()
        {
            behaviour.Stop();
            return this;
        }

        public CallbackTimer Pause()
        {
            behaviour.Pause();
            return this;
        }
    }
}