

using Core.DataAccess;
using Core.Utilities.Security.Entities;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IUserOperationClaimRepository : IAsyncRepository<UserOperationClaim, int>
    {
    }
}
