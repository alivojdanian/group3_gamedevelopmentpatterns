using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BoxEvents_Observer
    {
        public abstract float GetJumpForce();
    }


    public class JumpLittle : BoxEvents_Observer
    {
        public override float GetJumpForce()
        {
            return 30f;
        }
    }


    public class JumpMedium : BoxEvents_Observer
    {
        public override float GetJumpForce()
        {
            return 60f;
        }
    }


    public class JumpHigh : BoxEvents_Observer
    {
        public override float GetJumpForce()
        {
            return 90f;
        }
    }
