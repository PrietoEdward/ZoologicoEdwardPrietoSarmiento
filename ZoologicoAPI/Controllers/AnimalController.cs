using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ZoologicoDAL;
using ZoologicoBL;
using ZoologicoEntity;

namespace ZoologicoAPI.Controllers
{
    public class AnimalController : ApiController
    {
        AnimalBL AnimBL = new AnimalBL();
        // GET: api/Animal
        public List<Animal> Get()
        {
            List<Animal> respuesta = new List<Animal>();
            try
            {
                respuesta = AnimBL.ConsultarAnimal();
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        //GET: api/Animal/5
        public Animal Get(int id)
        {
            Animal respuesta = new Animal();
            try
            {
                respuesta = AnimBL.ConsultarAnimalId(id);
                return respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // POST: api/Animal
        public void Post(Animal Objeto)
        {
            try
            {
                AnimBL.IngresarAnimal(Objeto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // PUT: api/Animal/5
        public void Put(int id, Animal Objeto)
        {
            try
            {
                AnimBL.ActualizarAnimal(Objeto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        // DELETE: api/Animal/5
        public void Delete(int id)
        {
            try
            {
                AnimBL.BorrarAnimal(id);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
