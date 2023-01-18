using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeManager
{
    public class Progress
    {
        public int CompletionPercentage { get; private set; }

        public Progress()
        {
            CompletionPercentage = 0;
        }

        public void UpdateProgress(int percentage)
        {
            CompletionPercentage = percentage;
        }

        public int GetProgress()
        {
            return CompletionPercentage;
        }
    }

}
