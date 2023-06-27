﻿using RapiPizzaGM.Data.Request;
using RapiPizzaGM.Data.Response;

namespace RapiPizzaGM.Data.Services
{
	public interface IFacturaServices
	{
		Task<Resul<List<FacturaResponse>>> Consultar(string filtro);
		Task<Resul> Crear(FacturaRequest request);
		Task<Resul> Eliminar(FacturaRequest request);
		Task<Resul> Modificar(FacturaRequest request);
	}
}