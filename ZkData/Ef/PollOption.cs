using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZkData
{
    public class PollOption
    {
        
        public PollOption()
        {
            PollVotes = new HashSet<PollVote>();
        }

        [Key]
        public int OptionID { get; set; }
        public int PollID { get; set; }
        [Required]
        [StringLength(200)]
        public string OptionText { get; set; }
        public int Votes { get; set; }

        public virtual Poll Poll { get; set; }
        public virtual ICollection<PollVote> PollVotes { get; set; }
    }
}
