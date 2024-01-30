using ElectrodomesticosApi.Model;

namespace ElectrodomesticosApi.Services.Interfaces
{
    public interface IElectrodomInterface
    {
        IEnumerable<ElectrodomesticosModels>GetAll();
        ElectrodomesticosModels GetById(int id);
        ElectrodomesticosModels Save(ElectrodomesticosModels electrodomesticosModels);
        bool Update(int id, ElectrodomesticosModels electrodomesticosModels);
        bool Delete(int id);
    }
}
