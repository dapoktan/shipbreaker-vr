using System;

namespace ShipbreakerVr.Tracking;

// Presentation only: native equip/input/animation state must never depend on this gate.
internal sealed class ToolReturnVisibility
{
    private float elapsed, stable;
    private bool visible;
    internal bool Sample(bool held, bool poseSettled, float deltaTime)
    {
        if (!held) { elapsed = stable = 0; visible = false; return false; }
        if (visible) return true; // Normal tool shake must not flicker visibility.
        if (float.IsNaN(deltaTime) || float.IsInfinity(deltaTime) || deltaTime <= 0) return false;
        // A hitch is not evidence that the intervening animation was stationary.
        var dt = Math.Min(deltaTime, .05f);
        elapsed += dt;
        stable = poseSettled ? stable + dt : 0;
        visible = elapsed >= .25f && stable >= .12f;
        return visible;
    }
}
