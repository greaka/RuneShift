﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML;
using SFML.Graphics;
using SFML.Window;

namespace RuneShift
{
    public class Particle
    {
        public Vector2 Position;
        Vector2 Direction;
        float Speed;

        public Particle(Vector2 position, Vector2 direction, float speed)
        {
            this.Position = position;
            this.Direction = direction.normalized;
            this.Speed = speed;
        }

        public void Update(Vector2 target)
        {
            float rotationDirection = -1*(Vector2.isToTheRight(Position, Direction, target) ? 1F : -1F);

            Direction.rotate(Rand.Value(0.01F, 0.03F) * rotationDirection);
            
            Position += Direction.normalized * Speed;
        }
    }
}