using Domain.Model;
using Data;
using DTOs;

namespace Application.Services
{
    public class ProductoService
    {
        public ProductoDTO Add(ProductoDTO dto)
        {
            var productoRepository = new ProductoRepository();


            Producto producto = new Producto(dto.Id, dto.Nombre, dto.Descripcion, dto.Precio);

            productoRepository.Add(producto);

            dto.Id = producto.Id;

            return dto;
        }

        public bool Delete(int id)
        {
            var productoRepository = new ProductoRepository();
            return productoRepository.Delete(id);
        }

        public ProductoDTO Get(int id)
        {
            var productoRepository = new ProductoRepository();
            Producto? producto = productoRepository.Get(id);

            if (producto == null)
                return null;

            return new ProductoDTO
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio,
                
            };
        }

        public IEnumerable<ProductoDTO> GetAll()
        {
            var productoRepository = new ProductoRepository();
            var productos = productoRepository.GetAll();

            return productos.Select(producto => new ProductoDTO
            {
                Id = producto.Id,
                Nombre = producto.Nombre,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio,

            }).ToList();
        }

        public bool Update(ProductoDTO dto)
        {
            var productoRepository = new ProductoRepository();

            Producto producto = new Producto(dto.Id,dto.Nombre, dto.Descripcion, dto.Precio);
            return productoRepository.Update(producto);
        }



        }
    }
