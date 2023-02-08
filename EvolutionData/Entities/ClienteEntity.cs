using EvolutionData.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvolutionData.Entities
{
    public class ClienteEntity : IEntity<int>
    {
        public int f_id { get; set; }
        public string f_nombre { get; set; }
        public string f_apellido { get; set; }
        public string f_telefono { get; set; }
        public double f_balance { get; set; }
        public string f_rif { get; set; }
        public DateOnly f_fecha { get; set; }
        public double f_limite_credito { get; set; }
        public string f_email { get; set; }
        public bool f_facturarcredito { get; set; }
        public double f_dias_credito { get; set; }
        public string f_celular { get; set; }
        public string f_direccion { get; set; }
        public DateOnly f_fecha_year { get; set; }
        public string f_empresa { get; set; }
        public int f_vendedor { get; set; }
        public int f_zona { get; set; }
        public int f_tipo_cliente { get; set; }
        public bool f_exento_impuestos { get; set; }
        public int f_tipo_moneda { get; set; }
        public string f_comentario { get; set; }
        public string f_contacto { get; set; }
        public int f_precio_venta { get; set; }
        public int f_cobrador { get; set; }
        public string f_fax { get; set; }
        public bool f_activo { get; set; }
        public double f_retencion { get; set; }
        public double f_descuento_maximo { get; set; }
        public int f_region { get; set; }
        public int f_estado { get; set; }
        public int f_ciudad { get; set; }
        public int f_municipio { get; set; }
        public int f_pais { get; set; }
        public int f_tipo_contribuyente { get; set; }
        public string f_cuenta_contable { get; set; }
        public int f_clasificacion { get; set; }
        public int f_forma_pago { get; set; }
        public int f_tipo_comprobante { get; set; }
        public int f_clasificacion_credito { get; set; }
        public int f_termino { get; set; }
        public bool f_facturar_costo { get; set; }
        public bool f_bloqueo_credito { get; set; }
        public DateOnly f_ultima_modificacion { get; set; }
        public int f_modificado_por { get; set; }
        public bool f_cambio_precio { get; set; }
        public int f_almacen { get; set; }


        public int GetId()
        {
            return f_id;
        }
    }
}
