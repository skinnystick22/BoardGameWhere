using Ardalis.Specification;

namespace BoardGameWhere.Core.ContributorAggregate.Specifications;
public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification
{
  public ContributorByIdSpec(int contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
