﻿using System.Linq;

namespace Hawk
{
    public class HawkMultiball : HawkCollectable
    {
        private HawkBallsManager ballManager;

        private void Start()
        {
            ballManager = HawkBallsManager.Instance;
        }

        protected override void applyEffect()
        {
            // #ToList fixes the issue of trying to add to a collection
            // while using it. Can't add to a list as you are iterating over it.
            // Need a copy of the list to iterate over then we can add to original list
            foreach (HawkBall ball in ballManager.balls.ToList())
            {
                ballManager.spawnBalls(ball.gameObject.transform.position, 2);
            }
        }
    }
}
