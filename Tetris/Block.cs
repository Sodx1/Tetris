using System.Collections.Generic;
using System.Data.Common;

namespace Tetris
{
    public abstract class Block
    {
        protected abstract Postion[][] Tiles { get; }
        protected abstract Postion StartOffset { get; }
        public abstract int Id { get; }

        private int rotationState;
        private Postion offset;

        public Block()
        {
            offset = new Postion(StartOffset.Row, StartOffset.Column);
        }

        /// <summary>
        /// Метод выполняет цикл по позиции плитки в текущем состония вращения
        /// </summary>
        /// <returns> Добавляет смещение строки и смещения столбца</returns>
        public IEnumerable<Postion> TilePositions()
        {
            foreach (Postion p in Tiles[rotationState])
            {
                yield return new Postion(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        //Метод Поворот по часовой стрелки 
        public void RotateCW()
        {
            if (rotationState == 0)
            {
                rotationState = (rotationState+1)% Tiles.Length;
            }
        }

        //Метод Поворот против часовой стрелки 
        public void RotateCCW()
        {
            if(rotationState == 0)
            {
                rotationState = Tiles.Length-1;
            }
            else
            {
                rotationState--;
            }
        }

        //Метод Движение плитки
        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }

        //Сброс вращения 
        public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
            offset.Column = StartOffset.Column;
        }

    }
}
