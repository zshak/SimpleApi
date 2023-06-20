using simpleApi.Models;

namespace simpleApi.Services
{
    public interface IToDoService
    {
        List<ToDo> GetList();
        void CreateToDo(ToDo todo);
        ToDo GetById(int id);
        void DeleteById(int id);
        void UpdateById(int id);
    }
}
