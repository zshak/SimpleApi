using simpleApi.Models;

namespace simpleApi.Services
{
    public class ToDoService : IToDoService
    {
        private static List<ToDo> _toDoList = new List<ToDo>();

        public void CreateToDo(ToDo todo)
        {
            _toDoList.Add(todo);
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ToDo GetById(int id)
        {
            if(id < 0 || id >= _toDoList.Count) throw new ArgumentOutOfRangeException();

            return _toDoList[id];
        }

        public List<ToDo> GetList()
        {
            return _toDoList;
        }

        public void UpdateById(int id)
        {
            if (id < 0 || id >= _toDoList.Count) throw new ArgumentOutOfRangeException();
            _toDoList.RemoveAt(id);
        }
    }
}
