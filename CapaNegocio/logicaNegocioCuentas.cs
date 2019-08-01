using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaDatos;

namespace CapaNegocio
{
    public class logicaNegocioCuentas
    {
        AccesoClaseCuentas ac = new AccesoClaseCuentas();

        public int insertarcuentas(Cuentas ct)
        {
            return ac.insertarcuentas(ct);
        }

        public List<Cuentas> listarCuentas()
        {
            return ac.listarCuentas();
        }

        public int EliminarCuentas(int idcuent)
        {
            return ac.EliminarCuentas(idcuent);
        }

        public int EditarCuentas(Cuentas ct)
        {
            return ac.EditarCuentas(ct);
        }

        public List<Cuentas> BuscarCuentas(String dato)
        {
            return ac.BuscarCuentas(dato);
        }

    }
}
