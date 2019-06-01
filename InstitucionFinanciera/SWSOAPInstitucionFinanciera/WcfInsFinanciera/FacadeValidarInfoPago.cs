using InstitucionFinanciera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfInsFinanciera;

namespace InstitucionFinanciera.Controllers
{
    public class FacadeValidarInfoPago
    {

        private BDInsFinancieraEntities db = new BDInsFinancieraEntities();

        public Comprobante validar(InfoPago infoPago)
        {
            InfoPago result = (from p in db.InfoPago
                                    where p.tipoDocumento == infoPago.tipoDocumento &&
                                    p.numDocumento == infoPago.numDocumento &&
                                    p.contraseña == infoPago.contraseña &&
                                    p.monto >= infoPago.monto
                                    select p).SingleOrDefault();

            if (result != default(InfoPago))
            {
                result.monto -= infoPago.monto;
                db.SaveChanges();
                return new Comprobante();
            }
            return null;
        }

        public IQueryable<InfoPago> GetInfoPago()
        {
            return db.InfoPago;
        }
    }
}