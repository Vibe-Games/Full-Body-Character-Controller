using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;

namespace FullBodyAwarenessController
{
    public class PlayerAnimationEvents : MonoBehaviour
    {
        private FullBodyAwarenessController _fullBodyAwarenessController;

        private void Awake()
        {
            _fullBodyAwarenessController = GetComponentInParent<FullBodyAwarenessController>();
        }

        private void OnFootstep(AnimationEvent animationEvent)
        {
            _fullBodyAwarenessController.OnFootstep(animationEvent);
        }

        void OnLand(AnimationEvent animationEvent)
        {
            _fullBodyAwarenessController.OnLand(animationEvent);
        }
    }
}
