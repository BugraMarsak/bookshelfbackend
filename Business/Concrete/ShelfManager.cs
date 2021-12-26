using Business.Abstract;
using Core.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ShelfManager : IShelfService
    {
        IShelfDal _shelfDal;

        public ShelfManager(IShelfDal shelfDal)
        {
            _shelfDal = shelfDal;
        }

        public IResult Add(Shelf shelf)
        {
            if (!Check(shelf))
            {
                _shelfDal.Add(shelf);
                return new SuccessResult(Messages.added);
            }
            else {
                
                return new SuccessResult(Messages.notadded);
            }
            
        }

        public IResult Delete(Shelf shelf)
        {
            _shelfDal.Delete(shelf);
            return new SuccessResult(Messages.deleted);
        }

        public IDataResult<List<Shelf>> GetById(int userId)
        {
            return new SuccessDataResult<List<Shelf>>(_shelfDal.GetAll(s =>s.UserId  == userId), Messages.Listed);
        }

        private bool Check(Shelf shelf) {
            
            var result = _shelfDal.GetAll(s =>s.UserId==shelf.UserId && s.BookId== shelf.BookId).Any(); 

            return result;
        }

    }
}
