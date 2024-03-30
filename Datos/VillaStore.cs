using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{Id = 1, Nombre = "Vista a la pisicina", Ocupantes= 6, MetrosCuadrados= 110},
            new VillaDto{Id = 2, Nombre = "Vista al mar", Ocupantes= 4, MetrosCuadrados= 80},
            new VillaDto{Id = 3, Nombre = "Vista al jardin", Ocupantes= 3, MetrosCuadrados= 50}
        };
    }
}
