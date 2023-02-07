using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Branches
{
    internal class Branch
    {
        List<Branch> branches = new List<Branch>();

        public Branch() {
        }
        
        public void Add(Branch branch)
        {
            this.branches.Add(branch);
        }

        public int GetDepth(Branch branch)
        {
            int maxlevel = 0;
            foreach (Branch childBranch in branch.branches) {
                maxlevel = Math.Max(maxlevel, this.GetDepth(childBranch));
            }
            maxlevel += 1;
            return maxlevel;
        }

        public string Show()
        {
            return $"Depth of branches structure is {this.GetDepth(this)}";
        }
    }
}

