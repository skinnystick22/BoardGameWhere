using Ardalis.Result;

namespace BoardGameWhere.Core.Interfaces;
public interface IDeleteContributorService
{
  public Task<Result> DeleteContributor(int contributorId);
}
