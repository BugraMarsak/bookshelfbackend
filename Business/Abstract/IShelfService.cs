using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IShelfService
    {
        IResult Add(Shelf shelf);
        IResult Delete(Shelf shelf);
        IDataResult<List<Shelf>> GetById(int userId);
    }
}
