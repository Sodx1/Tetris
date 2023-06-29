namespace Tetris
{
    public class TBlock : Block
    {
       private readonly Postion[][] tiles = new Postion[][]
       {
            new Postion[] {new(0,1), new(1,0), new(1,1), new(1,2)},
            new Postion[] {new(0,1), new(1,1), new(1,2), new(2,1)},
            new Postion[] {new(1,0), new(1,1), new(1,2), new(2,1)},
            new Postion[] {new(0,1), new(1,0), new(1,1), new(2,1)}
       };
        public override int Id => 6;
        protected override Postion StartOffset => new Postion(0, 3);
        protected override Postion[][] Tiles => tiles;
    }
}
