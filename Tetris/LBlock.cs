﻿namespace Tetris
{
    public class LBlock : Block 
    {
        private readonly Postion[][] tiles = new Postion[][]
        {
            new Postion[] {new(0,2), new(1,0), new(1,1), new(1,2)},
            new Postion[] {new(0,1), new(1,1), new(2,1), new(2,2)},
            new Postion[] {new(1,0), new(1,1), new(1,2), new(2,0)},
            new Postion[] {new(0,0), new(0,1), new(1,1), new(2,1)}
        };
        public override int Id => 3;
        protected override Postion StartOffset => new Postion(0, 3);
        protected override Postion[][] Tiles => tiles;
    }
}
