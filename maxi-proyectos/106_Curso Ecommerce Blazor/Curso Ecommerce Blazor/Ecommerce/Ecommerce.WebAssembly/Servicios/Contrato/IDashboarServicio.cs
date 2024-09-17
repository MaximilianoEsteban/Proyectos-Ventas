using Ecommerce.DTO;

namespace Ecommerce.WebAssembly.Servicios.Contrato
{
    public interface IDashboarServicio
    {
        Task<ResponseDTO<DashboardDTO>> Resumen();
    }
}
