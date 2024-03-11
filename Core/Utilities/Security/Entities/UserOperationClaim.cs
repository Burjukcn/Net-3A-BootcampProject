using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Entities
{
    public class UserOperationClaim : BaseEntity<int>
    {
        public int UserId { get; set; }   //1
        public int OperationClaimId { get; set; } // 1=>developer
        public virtual User User { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }

        public UserOperationClaim()
        {

        }

        public UserOperationClaim(int id, int userId, int operationClaimId) : this()
        {
            Id = id;
            UserId = userId;
            OperationClaimId = operationClaimId;
        }
    }
}
