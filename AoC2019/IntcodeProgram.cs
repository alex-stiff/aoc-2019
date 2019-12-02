using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AoC2019
{
    public class IntcodeProgram
    {
        public IntcodeProgram(List<int> memory)
        {
            initialMemory = memory;
            CurrentMemory = memory;
        }

        public void Reset()
        {
            CurrentMemory = initialMemory;
        }

        public List<int> CurrentMemory { get; set; }
        public int Verb {
            get => CurrentMemory[1];
            set => CurrentMemory[1] = value;
        }
        public int Noun
        {
            get => CurrentMemory[2];
            set => CurrentMemory[2] = value;
        }

        public void Run()
        {
            for (var i = 0; i < CurrentMemory.Count; i += 4)
            {
                var opcode = CurrentMemory[i]; 
                
                if (opcode == 99)
                {
                    return;
                }
                else if (opcode == 1)
                {
                    PerformAdd(i);
                }
                else if (opcode == 2)
                {
                    PerformMultiplication(i);
                }
            }

            return;
        }

        private void PerformAdd(int index)
        {
            var indexToChange = CurrentMemory[index + 3];
            var firstIndex = CurrentMemory[index + 1];
            var secondIndex = CurrentMemory[index + 2];
            CurrentMemory[indexToChange] = CurrentMemory[firstIndex] + CurrentMemory[secondIndex];
        }

        private void PerformMultiplication(int index)
        {
            var indexToChange = CurrentMemory[index + 3];
            var firstIndex = CurrentMemory[index + 1];
            var secondIndex = CurrentMemory[index + 2];
            CurrentMemory[indexToChange] = CurrentMemory[firstIndex] * CurrentMemory[secondIndex];
        }

        private List<int> initialMemory { get; }
    }
}
