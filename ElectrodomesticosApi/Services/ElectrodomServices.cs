using ElectrodomesticosApi.Data;
using ElectrodomesticosApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ElectrodomesticosApi.Services
{
    public class ElectrodomServices : IElectrodomServices
    {
        private readonly ElectrodoDbContext _dbContext;

        public ElectrodomServices(ElectrodoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<ElectrodomesticosModels> GetAll()
        {
            return _dbContext.Electrodomesticos.ToList();
        }
        public ElectrodomesticosModels GetById(int id)
        {
            return _dbContext.Electrodomesticos.Find(id);
        }
        public ElectrodomesticosModels Save(ElectrodomesticosModels electrodomesticosModels)
        {
            _dbContext.Electrodomesticos.Add(electrodomesticosModels);
            _dbContextSaveChanges();
            return electrodomesticosModels;
        }

        private void _dbContextSaveChanges()
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var electrodomestico = _dbContext.Electrodomesticos.Find(id);
            if (electrodomestico == null)
                return false;
            _dbContext.Electrodomesticos.Remove(electrodomestico);
            _dbContextSaveChanges();
            return true;

        }
    }

    public interface IElectrodomServices
    {
    }
}
