using DevExpress.Mvvm;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.DataModel.DesignTime;
using DevExpress.Mvvm.DataModel.EF6;
using RCD_Project;
using System;
using System.Collections;
using System.Linq;

namespace RCD_Project.RCD_ConnectionDataModel {

    /// <summary>
    /// Provides methods to obtain the relevant IUnitOfWorkFactory.
    /// </summary>
    public static class UnitOfWorkSource {

		/// <summary>
        /// Returns the IUnitOfWorkFactory implementation.
        /// </summary>
        public static IUnitOfWorkFactory<IRCD_ConnectionUnitOfWork> GetUnitOfWorkFactory() {
            return new DbUnitOfWorkFactory<IRCD_ConnectionUnitOfWork>(() => new RCD_ConnectionUnitOfWork(() => new RCD_Connection()));
        }
    }
}