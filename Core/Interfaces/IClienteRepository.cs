namespace Core.Interfaces;

public interface IClienteRepository
{
    Cliente GetById(int id);
    IEnumerable<Cliente> GetAll();
    void Insert(Cliente cliente);
    void Update(Cliente cliente);
    void Delete(int id);
}