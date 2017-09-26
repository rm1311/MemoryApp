using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryApp.Classes
{
    public class MemTable
    {
        private int[] memTable;
        public int[] _memTable { get { return memTable; } set { memTable = value; } }
        public bool cont(int[] table, int number)
        {
            for (int i = 0; i < table.Length; i++)
                if (table[i] == number) return true;
            return false;
        }
        public MemTable()
        {
            int[] tmpTable = new int[16];
            for (int i = 0; i < tmpTable.Length; i++)
            {
                if (i % 2 > 0)
                {
                    tmpTable[i] = (i - 1) / 2;
                }
                else tmpTable[i] = i / 2;

            }

            int[] randTable = new int[16];
            Random rnd = new Random();
            for (int i = 0; i < randTable.Length; i++) randTable[i] = 20;
            for (int i = 0; i < 16; i++)
            {
                int tmp = rnd.Next(16);
                while (this.cont(randTable, tmp))
                {
                    tmp = rnd.Next(16);

                }
                randTable[i] = tmp;
            }

            this.memTable = new int[16];
            for (int i = 0; i < randTable.Length; i++)
            {
                int iterator = randTable[i];
                memTable[i] = tmpTable[iterator];
            }
        }
    }
}

