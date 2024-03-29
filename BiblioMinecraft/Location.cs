﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CegepVicto.TechInfo.H21.P2.DA2033220.Minecrafting.World_System;

namespace CegepVicto.TechInfo.H21.P2.DA2033220.Minecrafting
{
    public class Location
    {
        private float x;
        private float y;
        private float z;
        private float pitch;
        private float yaw;
        private World world;

        public Location(float x, float y, float z, World world) : this(x, y, z, 0, 0, world) { }
        public Location(float x, float y, float z, float pitch, float yaw, World world)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.pitch = pitch;
            this.yaw = yaw;
            this.world = world;
        }


        public void Move(float x, float y, float z, float pitch, float yaw)
        {
            this.x += x;
            this.y += y;
            this.z += z;
            this.pitch += pitch;
            this.yaw += yaw;

            while (this.yaw < -Math.PI)
            {
                this.yaw += (float)Math.PI*2;
            }
            while (this.yaw > Math.PI)
            {
                this.yaw -= (float)Math.PI*2;
            }

            /*
            while (this.pitch > (float)Math.PI)
            {
                this.yaw += (float)Math.PI;
                this.pitch -= (float)Math.PI;
            }
            while (this.pitch < -(float)Math.PI)
            {
                this.yaw += (float)Math.PI;
                this.pitch += (float)Math.PI;
            }
            */
        }

        public virtual void TP(float x, float y, float z, float pitch, float yaw)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.pitch = pitch;
            this.yaw = yaw;
        }

        /*
        public virtual void ChangeWorld(float x, float y, float z, float pitch, float yaw, World world)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.pitch = pitch;
            this.yaw = yaw;
            this.world = world;
        }
        */

        public bool Equals(Location loc)
        {
            return X == loc.X && Y == loc.Y && Z == loc.Z && Pitch == loc.Pitch && Yaw == loc.Yaw;
        }

        public bool AbsoluteEquals(Location loc)
        {
            return X == loc.X && Y == loc.Y && Z == loc.Z && Pitch == loc.Pitch && Yaw == loc.Yaw && world.Name == loc.world.Name;
        }

        public Location Clone()
        {
            return new Location(x,y,z,pitch,yaw,world);
        }

        public float X { get => x; }
        public float Y { get => y; }
        public float Z { get => z; }
        public float Pitch { get => pitch; }
        public float Yaw { get => yaw; }
        public World World { get => world; }
    }
}
