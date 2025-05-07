using Core.Entities;
using Core.Interfaces;
namespace Application.Services;

public class ClienteService
{
    private readonly IClienteRepository _repository;

    public ClienteService(IClienteRepository repository)
    {
        _repository = repository;
    }

    public void AgregarCliente(Cliente cliente)
    {
        _repository.Insert(cliente);
    }

    public Cliente? ObtenerClientePorId(int id)
    {
        return _repository.GetById(id);
    }

    public void ActualizarCliente(Cliente cliente)
    {
        _repository.Update(cliente);
    }

    public void EliminarCliente(int id)
    {
        _repository.Delete(id);
    }
}
