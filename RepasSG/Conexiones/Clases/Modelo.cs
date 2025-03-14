using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasSG.Clases {
    internal class Modelo {
        public class Apertura {
            public int AperturaID { get; set; }
            public DateTime Fecha { get; set; }
            public decimal Monto { get; set; }
        }

        public class Cierre {
            public int CierreID { get; set; }
            public DateTime Fecha { get; set; }
            public decimal Monto { get; set; }
            public int AperturaID { get; set; }
            public Apertura Apertura { get; set; }
        }
        
        public class Accion {
            public int AccionID { get; set; }
            public string Nombre { get; set; } // (Ej: "Ingreso", "Egreso", "Pago")
        }

        public class FormaPago {
            public int FormaPagoID { get; set; }
            public string Nombre { get; set; } // (Ej: "Efectivo", "Débito", "Transferencia")
        }

        public class Movimiento {
            public int MovimientoID { get; set; }
            public DateTime Fecha { get; set; }
            public string Detalles { get; set; }
            public decimal Cantidad { get; set; }

            public int AccionID { get; set; }
            public Accion Accion { get; set; }

            public int FormaPagoID { get; set; }
            public FormaPago FormaPago { get; set; }
        }

        public class Cliente {  //listo
            public int ClienteID { get; set; }
            public string Nombre { get; set; }
            public string Direccion { get; set; }
            public string Telefono { get; set; }
        }
        public class Seccion {
            public int SeccionID { get; set; }
            public string Nombre { get; set; }
        }

        public class Menu {
            public int MenuID { get; set; }
            public string NombreComida { get; set; }
            public string Detalles { get; set; }
            public decimal Precio { get; set; }

            public int SeccionID { get; set; }
            public Seccion Seccion { get; set; }
        }
        public class Pedido {
            public int PedidoID { get; set; }
            public DateTime Fecha { get; set; }

            public int ClienteID { get; set; }
            public Cliente Cliente { get; set; }

            public int MenuID { get; set; }
            public Menu Menu { get; set; }

            public int Cantidad { get; set; }

            public int FormaPagoID { get; set; }
            public FormaPago FormaPago { get; set; }
        }
        public class Repartidor {
            public int RepartidorID { get; set; }
            public string Nombre { get; set; }
        }
        public class TipoPago {
            public int TipoPagoID { get; set; }
            public string Nombre { get; set; } // (Ej: "Diario", "Semanal", "Mensual", "Cuenta Corriente")
        }

        public class Suscripcion {
            public int SuscripcionID { get; set; }

            public int ClienteID { get; set; }
            public Cliente Cliente { get; set; }

            public string NoDias { get; set; } // (Ej: "Lunes, Miércoles, Viernes")
            public string NoCome { get; set; } // (Ej: "Pescado, Mariscos")

            public int MenuID { get; set; }
            public Menu Menu { get; set; }

            public int TipoPagoID { get; set; }
            public TipoPago TipoPago { get; set; }

            public string Novedad { get; set; } // (Ej: "Canceló hoy")
            public decimal PrecioDiario { get; set; }
            public decimal Acumulado { get; set; }
            public string Detalles { get; set; } // (Ej: "Entrega a las 12 hs")

            public int? RepartidorID { get; set; }
            public Repartidor Repartidor { get; set; }
        }

    }
}
