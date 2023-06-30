using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoManager : IToDoService
    {
        IToDoDal _toDoDal;

        public ToDoManager(IToDoDal toDoDal)
        {
            _toDoDal = toDoDal;
        }

        public void TAdd(ToDo t)
        {
            _toDoDal.Insert(t);
        }

        public void TDelete(ToDo t)
        {
            _toDoDal.Delete(t);
        }

      

        public ToDo TGetById(int id)
        {
            return _toDoDal.GetByID(id);
        }

        public List<ToDo> TGetList()
        {
            return _toDoDal.GetList();
        }

        public List<ToDo> TGetListByFilter(string p)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDo t)
        {
            _toDoDal.Update(t);

        }
    }
}
