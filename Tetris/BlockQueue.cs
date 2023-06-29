using System;
namespace Tetris
{
    public class BlockQueue
    {
        //Масив доступных тетраминов
        private readonly Block[] _blocks = new Block[]
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock(),
        };

        private readonly Random random = new Random();

        public Block NextBlock { get; private set; }
        //Очередь блоков
        public BlockQueue() 
        {
            NextBlock = RandomBlock();
        }
        //Задаем рандомость блоков
        public Block RandomBlock()
        {
            return _blocks[random.Next(_blocks.Length)];    
        }

        //Обработка блоков чтобы они дважды не повторялись
        public Block GetAndUpdate()
        {
            Block block = NextBlock;

            do
            {
                NextBlock = RandomBlock();
            } 
            while (block.Id == NextBlock.Id);

            return block;
        }
    }
}
