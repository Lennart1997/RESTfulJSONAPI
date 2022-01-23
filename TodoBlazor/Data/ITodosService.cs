using System.Collections.Generic;
using System.Threading.Tasks;
using TodoBlazor.Models;

namespace TodoBlazor.Data {
public interface ITodosService {
    Task<IList<Todo>> GetTodosAsync();
    Task   AddTodoAsync(Todo todo);
    Task   RemoveTodoAsync(int todoId);
    Task   UpdateAsync(Todo todo);
}
}