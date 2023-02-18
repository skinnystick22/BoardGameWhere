using Ardalis.Result;
using BoardGameWhere.Core.ProjectAggregate;

namespace BoardGameWhere.Core.Interfaces;
public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
