using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class RepoService
    {
        private List<Spin> spinRepository = new List<Spin>();
        public IEnumerable<Spin> SpinRepository
        {
            get
            {
                return spinRepository;
            }
        }
        public void AddSpins(Spin spin)
        {
            spinRepository.Add(spin);
        }
    }
}
