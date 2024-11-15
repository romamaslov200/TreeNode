using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeNode.Core
{
    public static class ClassSwich
    {
        static TaskCommand taskCommand = new TaskCommand();
        public static void Vibor(int i) 
        {
            switch (i)
            {
                case 1:
                    taskCommand.add();
                    break;
                case 2:
                    taskCommand.remuve();
                    break;
                case 3:
                    taskCommand.show();
                    break;
                case 4:
                    taskCommand.showI();
                    break;
                case 5:
                    taskCommand.showToName();
                    break;
                default:
                    break;
            }
        }
    }
}
