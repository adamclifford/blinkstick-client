﻿using System;
using System.Collections.Generic;

namespace BlinkStickClient.DataModel
{
    public class Pattern
    {
        public string Name
        {
            get;
            set;
        }

        public List<Animation> Animations = new List<Animation>();

        public Pattern()
        {
            this.Name = "";
        }

        public Pattern(String name)
        {
            this.Name = name;
        }

        public override String ToString()
        {
            return this.Name;
        }

        public void Assign(Pattern pattern)
        {
            foreach (Animation animation in pattern.Animations)
            {
                Animation newAnimation = new Animation();
                newAnimation.Assign(animation);
                this.Animations.Add(newAnimation);
            }
        }
    }
}

