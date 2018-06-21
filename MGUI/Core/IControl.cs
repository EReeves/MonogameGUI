﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MGUI.Core
{
    public interface IControl
    {
        List<IControl> Children { get; set; }
        IControl Parent { get; set; }
        Rectangle Bounds { get; set; }
        Rectangle CanvasBounds { get; }
        Point Offset { get; set; }
        
        //Weight
        int Weight { get; set; }
        
        //Layout
        void Layout();
        
        //Invalidate
        void Invalidate();
       
        //Add/Remove      
        void Add(IControl control);
        void Remove(IControl control);
        
        //Update/Draw
        void Update(GameTime gameTime);
        void Draw(SpriteBatch batcher);
    }
}