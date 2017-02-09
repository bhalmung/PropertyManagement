using Models;
using System.Collections.Generic;

namespace DomainLogic.Serivce
{
    public interface IRestaurentService
    {
        IEnumerable<Restaurent> GetAllRestaurent();
    }
}